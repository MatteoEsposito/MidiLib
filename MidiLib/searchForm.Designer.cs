namespace MidiLib
{
    partial class searchForm
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
            this.components = new System.ComponentModel.Container();
            this.searchBtn = new System.Windows.Forms.Button();
            this.resView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.dbBtn = new System.Windows.Forms.Button();
            this.resViewContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listOption = new System.Windows.Forms.ToolStripMenuItem();
            this.tileOption = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.resViewContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.Location = new System.Drawing.Point(630, 38);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 0;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // resView
            // 
            this.resView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resView.ContextMenuStrip = this.resViewContextMenu;
            this.resView.Location = new System.Drawing.Point(-3, 64);
            this.resView.Name = "resView";
            this.resView.Size = new System.Drawing.Size(723, 343);
            this.resView.TabIndex = 1;
            this.resView.UseCompatibleStateImageBehavior = false;
            this.resView.View = System.Windows.Forms.View.List;
            this.resView.SelectedIndexChanged += new System.EventHandler(this.resView_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter song title:";
            // 
            // statusLbl
            // 
            this.statusLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(12, 416);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(41, 13);
            this.statusLbl.TabIndex = 3;
            this.statusLbl.Text = "Pronto!";
            // 
            // pBar
            // 
            this.pBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pBar.Location = new System.Drawing.Point(605, 413);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(100, 16);
            this.pBar.TabIndex = 4;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Location = new System.Drawing.Point(12, 40);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(612, 20);
            this.searchBox.TabIndex = 5;
            // 
            // dbBtn
            // 
            this.dbBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dbBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.dbBtn.Location = new System.Drawing.Point(630, 12);
            this.dbBtn.Name = "dbBtn";
            this.dbBtn.Size = new System.Drawing.Size(75, 23);
            this.dbBtn.TabIndex = 6;
            this.dbBtn.Text = "Database";
            this.dbBtn.UseVisualStyleBackColor = true;
            this.dbBtn.Click += new System.EventHandler(this.dbBtn_Click);
            // 
            // resViewContextMenu
            // 
            this.resViewContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOption,
            this.tileOption});
            this.resViewContextMenu.Name = "resViewContextMenu";
            this.resViewContextMenu.ShowImageMargin = false;
            this.resViewContextMenu.Size = new System.Drawing.Size(69, 48);
            this.resViewContextMenu.Text = "A";
            // 
            // listOption
            // 
            this.listOption.Name = "listOption";
            this.listOption.Size = new System.Drawing.Size(68, 22);
            this.listOption.Text = "List";
            this.listOption.Click += new System.EventHandler(this.listOption_Click);
            // 
            // tileOption
            // 
            this.tileOption.Name = "tileOption";
            this.tileOption.Size = new System.Drawing.Size(68, 22);
            this.tileOption.Text = "Tile";
            this.tileOption.Click += new System.EventHandler(this.tileOption_Click);
            // 
            // searchBackgroundWorker
            // 
            this.searchBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.searchBackgroundWorker_DoWork);
            // 
            // searchForm
            // 
            this.AcceptButton = this.searchBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.dbBtn;
            this.ClientSize = new System.Drawing.Size(717, 441);
            this.Controls.Add(this.dbBtn);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resView);
            this.Controls.Add(this.searchBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(630, 480);
            this.Name = "searchForm";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.searchForm_Load);
            this.resViewContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ListView resView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button dbBtn;
        private System.Windows.Forms.ContextMenuStrip resViewContextMenu;
        private System.Windows.Forms.ToolStripMenuItem listOption;
        private System.Windows.Forms.ToolStripMenuItem tileOption;
        private System.ComponentModel.BackgroundWorker searchBackgroundWorker;
    }
}