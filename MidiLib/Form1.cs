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
using System.Windows.Forms;
using System.Diagnostics;
using System.DirectoryServices;
using System.IO;
using System.Threading;

namespace MidiLib
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public class song
        {
            public int Id { get; set; }
            public string Name { get; set; }
         //   public string[] path { get; set; }
         public string Path { get; set; }
        }
        private void connectDB()
        {
            // Create your POCO class entity


        // Open database (or create if doesn't exist)
    using(var db = new LiteDatabase(@"songs.db"))
    {
        // Get a collection (or create, if doesn't exist)
        var col = db.GetCollection<song>("songs");

        // Create your new customer instance
        var song = new song
        {
            Name = "John Doe",
            Path = "8000-0000",// new string[] { "8000-0000", "9000-0000" },

        };

        // Insert new customer document (Id will be auto-incremented)
        col.Insert(song);

                // Update a document inside a collection
         //       song.Name = "Joana Doe";
	
      //  col.Update(song);
	
        // Index document using document Name property
     /*   col.EnsureIndex(x => x.Name);
	
        // Use LINQ to query documents
        var results = col.Find(x => x.Name.Contains(""));

        // Let's create an index in phone numbers (using expression). It's a multikey index
        col.EnsureIndex(x => x.Phones, "$.Phones[*]"); 

        // and now we can query phones
        var r = col.FindOne(x => x.Phones.Contains("8888-5555"));*/

    }
        }
        private void search()
        {

        }

        void testPath()
        {
            
        }
        private void openWithIt(string path)
        {
            Process.Start(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var db = new LiteDatabase(@"./songs.db");
            var col = db.GetCollection<song>("songs");

            // Create your new customer instance
            var song = new song
            {
                Name = "John Doe",
                Path = "8000-0000",// new string[] { "8000-0000", "9000-0000" },

            };

           col.Insert(song);

        //    btn();
           // openWithIt(textBox1.Text);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            string selectedpath = folderBrowserDialog1.SelectedPath.ToString();
            listView1.Items.Add(selectedpath);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btn();
        }

        string cwd;
        Mutex mtx = new Mutex();

        void releaseIt(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            mtx.ReleaseMutex();

        }
        ListView.ListViewItemCollection dump;
        private void btn()
        {
            dump = listView1.Items;
            backgroundWorker1.RunWorkerCompleted += BackgroundWorker1_RunWorkerCompleted;

            cwd = dump[0].Text;
            backgroundWorker1.RunWorkerAsync();

        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            dump.RemoveAt(0);
            //  mtx.ReleaseMutex();
            if (dump.Count != 0) { 
                cwd = dump[0].Text;
             backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                Debug.WriteLine("Ended");
            }
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
       
            string sel = listView1.Items[0].Text;
            //  directoryEntry1.Path = sel;
            foreach (string file in Directory.GetFiles(sel))
            {
                Debug.WriteLine(file);
            }

            foreach (string file in Directory.GetDirectories(sel))
            {
                Debug.WriteLine(file);
            }

            //  enumFiles("C:\\Users\\bbqualcosa\\Desktop\\inizializzatore");
            //  Debug.WriteLine("Now we are gong to do it Asynhronusly ");

            backgroundWorker1.RunWorkerAsync();
            Debug.WriteLine("Result: %i", i);
            /*
             Debug.WriteLine(directoryEntry1.Path);

                 directorySearcher1.SearchRoot = directoryEntry1;
                 directoryEntry1.AuthenticationType = AuthenticationTypes.None;
             // (objectClass=*)
             directorySearcher1.Filter = "(objectClass=directory)";
             string res = directorySearcher1.SearchRoot.Path;
             directorySearcher1.InitializeLifetimeService();
             SearchResult result = directorySearcher1.FindOne();
             Debug.WriteLine(res);
             Console.WriteLine("Found Text");
             */

        }
        String[] arr;
        int i = 0;
        // Get a collection (or create, if doesn't exist)
     
        private void enumFiles(string root)
        {
         
            if(Directory.GetDirectories(root).Length == 0)
            {
                foreach (string file in Directory.GetFiles(root))
                {
                    this.Invoke((MethodInvoker)delegate {   // Open database (or create if doesn't exist)
                        var db = new LiteDatabase(@"./songs.db");
                        listView2.Items.Add(file);

                        var col = db.GetCollection<song>("songs");
                        // Create your new customer instance
                        var customer = new song
                        {
                            Name = Path.GetFileNameWithoutExtension(file),
                            Path = file

                        };

                        // Insert new customer document (Id will be auto-incremented)
                        col.Insert(customer);
                    });
                }
            }

            foreach( string dir in Directory.GetDirectories(root))
            {
                enumFiles(dir); i++;
                foreach (string file in Directory.GetFiles(dir))
                {
                    this.Invoke((MethodInvoker)delegate {
                        // Open database (or create if doesn't exist)
                        var db = new LiteDatabase(@"./songs.db");
                            listView2.Items.Add(file);

                        var col = db.GetCollection<song>("songs");
                        // Create your new customer instance
                        var customer = new song
                        {
                            Name = Path.GetFileNameWithoutExtension(file),
                            Path = file

                        };

                        // Insert new customer document (Id will be auto-incremented)
                        col.Insert(customer);


                    });
                    Debug.WriteLine(file);
                    
                }
                
            }
                       


        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            //  string rootDir;
            //   this.Invoke((MethodInvoker)delegate { rootDir = listView1.Items[0].Text; });
            //  enumFiles(cwd);
            
            enumFiles(cwd);
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView3.Clear();
            var db = new LiteDatabase(@"./songs.db");
        
                // Get a collection (or create, if doesn't exist)
                var col = db.GetCollection<song>("songs");

                // Index document using document Name property
                col.EnsureIndex(x => x.Name);

            // Use LINQ to query documents

            foreach (song s in col.Find(x => x.Name.Contains(textBox1.Text)))
            {
                Debug.WriteLine("From Database: \n Name: " + s.Name + "\t Path: " + s.Path);
                listView3.Items.Add(s.Name, s.Path);
            }

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count > 0)
            {

                openWithIt(listView3.SelectedItems[0].ImageKey);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dbForm dbForm = new dbForm();
            dbForm.ShowDialog();
        }
    }


     
}
