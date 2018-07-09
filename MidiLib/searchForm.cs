/*
MIT License

Copyright (c) 2018 Matteo Esposito

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;
using System.Diagnostics;

namespace MidiLib
{
    
    public partial class searchForm : Form
    {
        LiteDatabase db = new LiteDatabase("./songs.db");                                               // Create an instance of the Database
        LiteCollection<song> col = new LiteDatabase("./songs.db").GetCollection<song>("songs");         // Create a direct instance of the desired Collection
        
        public searchForm()
        {
            InitializeComponent();
           
        }

        public void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchBackgroundWorker.RunWorkerAsync();
            }
        }
        private void performSearch()
        {
            this.Invoke((MethodInvoker)delegate {
                resView.Clear();                                                                            // Clearing the resultView       
                pBar.Style = ProgressBarStyle.Marquee;                                                      // Starting the undefined progress bar
                searchBox.Enabled = false;
            });
            col.EnsureIndex(x => x.Name);                                                                   // Index document using document Name property
            if (searchBox.Text.Length != 0)
            {
                foreach (song s in col.Find(x => x.searchString.Contains(searchBox.Text.ToLower())))        // Use LINQ to query documents
                {
                 this.Invoke((MethodInvoker)delegate{
                     statusLbl.Text = "Found: " + s.Name + " at " + s.Path;                                 // Updating th status label accordingly to the latest found
                  // Debug.WriteLine("From Database: \n Name: " + s.Name + "\t Path: " + s.Path);           // DEBUG LINE, uncomment if you find error in the implementation ( and please if this is the case
                     resView.Items.Add(s.Name, s.Path);                                                     // report it into the pull request on the gitHub page
                    });
                }
            }
                this.Invoke((MethodInvoker)delegate {
                    pBar.Style = ProgressBarStyle.Blocks;                                                   // Stopping the undefined progress bar
                    if (resView.Items.Count == 0)
                    {
                        statusLbl.Text = "No Results Found!";
                    }
                    else
                    {
                        statusLbl.Text = "Ready! Songs Found: " + resView.Items.Count.ToString();
                    }
                    
                    searchBox.Enabled = true;
                    this.ActiveControl = searchBox;
                });
            }
        private void button2_Click(object sender, EventArgs e)
        {
            dbForm dbfrm = new dbForm();                                                                // Create an instance of the Database Form
            dbfrm.ShowDialog();                                                                         // Simple avoidance of the concurrency in the use of the serch and of the importing features
                                                                                                        // the LiteDabase suports it, i just haden't the time to be sure everythings works as inteded
                                                                                                        // giving it to be just a proof-of-concept.
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchBackgroundWorker.RunWorkerAsync();
        }

        private void dbBtn_Click(object sender, EventArgs e)
        {
            dbForm dbfrm = new dbForm();                                                                // Create an instance of the Database Form
            dbfrm.ShowDialog();                                                                         // Simple avoidance of the concurrency in the use of the serch and of the importing features
                                                                                                        // the LiteDabase suports it, i just haden't the time to be sure everythings works as inteded
                                                                                                        // giving it to be just a proof-of-concept.
        }

        private void listOption_Click(object sender, EventArgs e)
        {
            resView.View = View.List;
        }

        private void tileOption_Click(object sender, EventArgs e)
        {
            resView.View = View.Tile;
        }

        private void searchForm_Load(object sender, EventArgs e)
        {
            searchBox.KeyDown += keyDown;
            this.ActiveControl = searchBox;
        }

        private void resView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (resView.SelectedItems.Count != 0) { 
            string path = resView.SelectedItems[0].ImageKey;
            Process.Start(path);
            }
        }

        private void searchBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            performSearch();
            this.ActiveControl = searchBox;
        }
    }
}
