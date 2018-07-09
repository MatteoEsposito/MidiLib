namespace MidiLib
{
    partial class dbForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("C:\\Users\\bbqualcosa\\Downloads\\midi_files\\T");
            this.addFolderBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pathView = new System.Windows.Forms.ListView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.importBtn = new System.Windows.Forms.Button();
            this.asyncHandler = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addFolderBtn
            // 
            this.addFolderBtn.Location = new System.Drawing.Point(15, 90);
            this.addFolderBtn.Name = "addFolderBtn";
            this.addFolderBtn.Size = new System.Drawing.Size(89, 23);
            this.addFolderBtn.TabIndex = 16;
            this.addFolderBtn.Text = "Open a folder";
            this.addFolderBtn.UseVisualStyleBackColor = true;
            this.addFolderBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "PATH:";
            // 
            // pathView
            // 
            this.pathView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5});
            this.pathView.Location = new System.Drawing.Point(12, 30);
            this.pathView.Name = "pathView";
            this.pathView.Size = new System.Drawing.Size(396, 54);
            this.pathView.TabIndex = 14;
            this.pathView.UseCompatibleStateImageBehavior = false;
            this.pathView.View = System.Windows.Forms.View.List;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 135);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(396, 23);
            this.progressBar1.TabIndex = 17;
            // 
            // importBtn
            // 
            this.importBtn.Location = new System.Drawing.Point(119, 90);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(89, 23);
            this.importBtn.TabIndex = 18;
            this.importBtn.Text = "Import Folder";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // asyncHandler
            // 
            this.asyncHandler.WorkerSupportsCancellation = true;
            this.asyncHandler.DoWork += new System.ComponentModel.DoWorkEventHandler(this.asyncHandler_DoWork);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 19;
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(8, 162);
            this.statusLbl.MinimumSize = new System.Drawing.Size(400, 0);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(400, 13);
            this.statusLbl.TabIndex = 20;
            this.statusLbl.Text = "Ready!";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(319, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Clear Database";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "STOP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 184);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.importBtn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.addFolderBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pathView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "dbForm";
            this.Text = "Database";
            this.Load += new System.EventHandler(this.dbForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
            // EasterEgg: Designed and developed by Matteo Esposito

        }

        #endregion

        private System.Windows.Forms.Button addFolderBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView pathView;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button importBtn;
        private System.ComponentModel.BackgroundWorker asyncHandler;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}