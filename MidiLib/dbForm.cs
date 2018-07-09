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
using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidiLib
{
    public partial class dbForm : Form
    {
        // Global Vars
        string cwd;
        LiteDatabase db = new LiteDatabase("./songs.db");                                               // Create an instance of the Database
        LiteCollection<song> col = new LiteDatabase("./songs.db").GetCollection<song>("songs");         // Create a direct instance of the desired Collection
        ListView.ListViewItemCollection dump;
        int j;
        Stopwatch watch;



        public dbForm()
        {
            InitializeComponent();
        }

        private void dbForm_Load(object sender, EventArgs e)
        {
            asyncHandler.RunWorkerCompleted += BackgroundWorker1_RunWorkerCompleted;                    // Resgitering hanlder for the Run_Worker_Completed Events
        }

        private void btn()
        {
           watch = Stopwatch.StartNew();
            if (pathView.Items.Count != 0) {
            j = 0;
            dump = pathView.Items;                                                                      // Create a copy of the pathView Items Collection to use as a FIFO
            progressBar1.Style = ProgressBarStyle.Marquee;                                              // Starting the undefined progress bar
            cwd = dump[0].Text;                                                                         // We Start to get the first "Root" path
            dump.RemoveAt(0);                                                                           // We Remove it from the queue
            asyncHandler.RunWorkerAsync();                                                              // Let's run it in a separate Threads 
            }
            else
            {
                statusLbl.Text = "Nothing to Import";
            }

        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            string selectedpath = folderBrowserDialog1.SelectedPath.ToString();
            pathView.Items.Add(selectedpath);
        }
        
        private void dumpToDB(string root)
        {
           
            if (Directory.GetDirectories(root).Length == 0)
            {
                foreach (string file in Directory.GetFiles(root))
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        if (Path.GetExtension(file) == ".kar" || Path.GetExtension(file) == ".mid" || Path.GetExtension(file) == ".midi")
                        {

                            
                            var db = new LiteDatabase(@"./songs.db");                                                               
                            var col = db.GetCollection<song>("songs");
                            // Create your new customer instance
                            var customer = new song
                            {
                                Name = Path.GetFileNameWithoutExtension(file),
                                Path = file,
                                searchString = Path.GetFileNameWithoutExtension(file).ToLower()

                            };

                            // Insert new customer document (Id will be auto-incremented)
                            col.Insert(customer);
                            statusLbl.Text = "Adding:\t" + Path.GetFileNameWithoutExtension(file).ToLower();
                            j++;
                        }
                    });
                }
            }

            foreach (string dir in Directory.GetDirectories(root))
            {
                dumpToDB(dir);
            }

            this.Invoke((MethodInvoker)delegate
            {
                if (j != 0)
                {
                    statusLbl.Text = j.ToString() + " Songs Imported";
                }
                else
                {
                    statusLbl.Text = "Nothing Imported!";
                }

            });
        }

   
        private void asyncHandler_DoWork(object sender, DoWorkEventArgs e)
        {
            dumpToDB(cwd);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.DropCollection("songs");
            statusLbl.Text = "Database Claered";
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {

            //  mtx.ReleaseMutex();
            
            // the code that you want to measure comes here
           
            if (dump.Count != 0)
            {
                cwd = dump[0].Text;
                dump.RemoveAt(0);
                asyncHandler.RunWorkerAsync();
            }
            else
            {
                //    progressBar1.
                progressBar1.Style = ProgressBarStyle.Blocks;
                watch.Stop();
                var elapsed = watch.Elapsed;

                statusLbl.Text = statusLbl.Text + " in " + elapsed.ToString("mm\\:ss\\.ff") +" m";
                //    Debug.WriteLine("Ended");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            asyncHandler.CancelAsync();
        }
    }
}
