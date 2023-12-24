namespace mTracker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mstMenu = new System.Windows.Forms.MenuStrip();
            this.mstFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mstNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mstOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mstSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mstSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mstExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mstHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mstAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mstPage = new System.Windows.Forms.ToolStripMenuItem();
            this.tstStrip = new System.Windows.Forms.ToolStrip();
            this.tstNew = new System.Windows.Forms.ToolStripButton();
            this.tstOpen = new System.Windows.Forms.ToolStripButton();
            this.tstSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tstStop = new System.Windows.Forms.ToolStripButton();
            this.tstPlay = new System.Windows.Forms.ToolStripButton();
            this.tstPause = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tstOctaveTxt = new System.Windows.Forms.ToolStripLabel();
            this.tstOctave = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tstTempoTxt = new System.Windows.Forms.ToolStripLabel();
            this.tstTempo = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.sstStatus = new System.Windows.Forms.StatusStrip();
            this.pnlFiles = new System.Windows.Forms.Panel();
            this.trvTree = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.playerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playPatternToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playFromStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mstMenu.SuspendLayout();
            this.tstStrip.SuspendLayout();
            this.pnlFiles.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mstMenu
            // 
            this.mstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstFile,
            this.playerToolStripMenuItem,
            this.mstHelp});
            resources.ApplyResources(this.mstMenu, "mstMenu");
            this.mstMenu.Name = "mstMenu";
            this.mstMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // mstFile
            // 
            this.mstFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstNew,
            this.mstOpen,
            this.mstSave,
            this.mstSaveAs,
            this.toolStripSeparator1,
            this.mstExit});
            this.mstFile.Name = "mstFile";
            resources.ApplyResources(this.mstFile, "mstFile");
            // 
            // mstNew
            // 
            this.mstNew.Name = "mstNew";
            resources.ApplyResources(this.mstNew, "mstNew");
            // 
            // mstOpen
            // 
            this.mstOpen.Name = "mstOpen";
            resources.ApplyResources(this.mstOpen, "mstOpen");
            // 
            // mstSave
            // 
            this.mstSave.Name = "mstSave";
            resources.ApplyResources(this.mstSave, "mstSave");
            // 
            // mstSaveAs
            // 
            this.mstSaveAs.Name = "mstSaveAs";
            resources.ApplyResources(this.mstSaveAs, "mstSaveAs");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // mstExit
            // 
            this.mstExit.Name = "mstExit";
            resources.ApplyResources(this.mstExit, "mstExit");
            // 
            // mstHelp
            // 
            this.mstHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstAbout,
            this.mstPage});
            this.mstHelp.Name = "mstHelp";
            resources.ApplyResources(this.mstHelp, "mstHelp");
            // 
            // mstAbout
            // 
            this.mstAbout.Name = "mstAbout";
            resources.ApplyResources(this.mstAbout, "mstAbout");
            // 
            // mstPage
            // 
            this.mstPage.Name = "mstPage";
            resources.ApplyResources(this.mstPage, "mstPage");
            // 
            // tstStrip
            // 
            this.tstStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tstStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstNew,
            this.tstOpen,
            this.tstSave,
            this.toolStripSeparator2,
            this.tstStop,
            this.tstPlay,
            this.tstPause,
            this.toolStripSeparator3,
            this.tstOctaveTxt,
            this.tstOctave,
            this.toolStripSeparator4,
            this.tstTempoTxt,
            this.tstTempo,
            this.toolStripSeparator5});
            resources.ApplyResources(this.tstStrip, "tstStrip");
            this.tstStrip.Name = "tstStrip";
            this.tstStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // tstNew
            // 
            this.tstNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstNew.Image = global::mTracker.Properties.Resources.file_new;
            resources.ApplyResources(this.tstNew, "tstNew");
            this.tstNew.Name = "tstNew";
            // 
            // tstOpen
            // 
            this.tstOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstOpen.Image = global::mTracker.Properties.Resources.file_open;
            resources.ApplyResources(this.tstOpen, "tstOpen");
            this.tstOpen.Name = "tstOpen";
            // 
            // tstSave
            // 
            this.tstSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstSave.Image = global::mTracker.Properties.Resources.file_save;
            resources.ApplyResources(this.tstSave, "tstSave");
            this.tstSave.Name = "tstSave";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // tstStop
            // 
            this.tstStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tstStop, "tstStop");
            this.tstStop.Name = "tstStop";
            // 
            // tstPlay
            // 
            this.tstPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstPlay.Image = global::mTracker.Properties.Resources.play;
            resources.ApplyResources(this.tstPlay, "tstPlay");
            this.tstPlay.Name = "tstPlay";
            // 
            // tstPause
            // 
            this.tstPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstPause.Image = global::mTracker.Properties.Resources.pause;
            resources.ApplyResources(this.tstPause, "tstPause");
            this.tstPause.Name = "tstPause";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // tstOctaveTxt
            // 
            this.tstOctaveTxt.Name = "tstOctaveTxt";
            resources.ApplyResources(this.tstOctaveTxt, "tstOctaveTxt");
            // 
            // tstOctave
            // 
            this.tstOctave.Name = "tstOctave";
            resources.ApplyResources(this.tstOctave, "tstOctave");
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // tstTempoTxt
            // 
            this.tstTempoTxt.Name = "tstTempoTxt";
            resources.ApplyResources(this.tstTempoTxt, "tstTempoTxt");
            // 
            // tstTempo
            // 
            this.tstTempo.Name = "tstTempo";
            resources.ApplyResources(this.tstTempo, "tstTempo");
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // sstStatus
            // 
            resources.ApplyResources(this.sstStatus, "sstStatus");
            this.sstStatus.Name = "sstStatus";
            // 
            // pnlFiles
            // 
            this.pnlFiles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFiles.Controls.Add(this.trvTree);
            resources.ApplyResources(this.pnlFiles, "pnlFiles");
            this.pnlFiles.Name = "pnlFiles";
            // 
            // trvTree
            // 
            this.trvTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.trvTree, "trvTree");
            this.trvTree.Name = "trvTree";
            // 
            // splitter1
            // 
            resources.ApplyResources(this.splitter1, "splitter1");
            this.splitter1.Name = "splitter1";
            this.splitter1.TabStop = false;
            // 
            // pnlControls
            // 
            this.pnlControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlControls.Controls.Add(this.groupBox3);
            this.pnlControls.Controls.Add(this.groupBox2);
            this.pnlControls.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.pnlControls, "pnlControls");
            this.pnlControls.Name = "pnlControls";
            // 
            // splitter2
            // 
            resources.ApplyResources(this.splitter2, "splitter2");
            this.splitter2.Name = "splitter2";
            this.splitter2.TabStop = false;
            // 
            // pnlGrid
            // 
            this.pnlGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGrid.Controls.Add(this.dataGridView1);
            resources.ApplyResources(this.pnlGrid, "pnlGrid");
            this.pnlGrid.Name = "pnlGrid";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.comboBox2);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.Name = "comboBox2";
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.trackBar1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.comboBox3);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox3, "comboBox3");
            this.comboBox3.Name = "comboBox3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 10;
            resources.ApplyResources(this.trackBar1, "trackBar1");
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.TickFrequency = 16;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Value = 255;
            // 
            // playerToolStripMenuItem
            // 
            this.playerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.playFromStartToolStripMenuItem,
            this.playPatternToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            resources.ApplyResources(this.playerToolStripMenuItem, "playerToolStripMenuItem");
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            resources.ApplyResources(this.playToolStripMenuItem, "playToolStripMenuItem");
            // 
            // playPatternToolStripMenuItem
            // 
            this.playPatternToolStripMenuItem.Name = "playPatternToolStripMenuItem";
            resources.ApplyResources(this.playPatternToolStripMenuItem, "playPatternToolStripMenuItem");
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            resources.ApplyResources(this.stopToolStripMenuItem, "stopToolStripMenuItem");
            // 
            // playFromStartToolStripMenuItem
            // 
            this.playFromStartToolStripMenuItem.Name = "playFromStartToolStripMenuItem";
            resources.ApplyResources(this.playFromStartToolStripMenuItem, "playFromStartToolStripMenuItem");
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlFiles);
            this.Controls.Add(this.sstStatus);
            this.Controls.Add(this.tstStrip);
            this.Controls.Add(this.mstMenu);
            this.MainMenuStrip = this.mstMenu;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mstMenu.ResumeLayout(false);
            this.mstMenu.PerformLayout();
            this.tstStrip.ResumeLayout(false);
            this.tstStrip.PerformLayout();
            this.pnlFiles.ResumeLayout(false);
            this.pnlControls.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstMenu;
        private System.Windows.Forms.ToolStripMenuItem mstFile;
        private System.Windows.Forms.ToolStripMenuItem mstHelp;
        private System.Windows.Forms.ToolStripMenuItem mstNew;
        private System.Windows.Forms.ToolStripMenuItem mstOpen;
        private System.Windows.Forms.ToolStripMenuItem mstSave;
        private System.Windows.Forms.ToolStripMenuItem mstSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mstExit;
        private System.Windows.Forms.ToolStripMenuItem mstAbout;
        private System.Windows.Forms.ToolStripMenuItem mstPage;
        private System.Windows.Forms.ToolStrip tstStrip;
        private System.Windows.Forms.ToolStripButton tstNew;
        private System.Windows.Forms.ToolStripButton tstOpen;
        private System.Windows.Forms.ToolStripButton tstSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tstStop;
        private System.Windows.Forms.ToolStripButton tstPlay;
        private System.Windows.Forms.ToolStripButton tstPause;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.StatusStrip sstStatus;
        private System.Windows.Forms.ToolStripLabel tstOctaveTxt;
        private System.Windows.Forms.ToolStripTextBox tstOctave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel tstTempoTxt;
        private System.Windows.Forms.ToolStripTextBox tstTempo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Panel pnlFiles;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.TreeView trvTree;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playPatternToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playFromStartToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

