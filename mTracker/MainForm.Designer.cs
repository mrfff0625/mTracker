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
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tstNew = new System.Windows.Forms.ToolStripButton();
            this.tstOpen = new System.Windows.Forms.ToolStripButton();
            this.tstSave = new System.Windows.Forms.ToolStripButton();
            this.tstStop = new System.Windows.Forms.ToolStripButton();
            this.tstPlay = new System.Windows.Forms.ToolStripButton();
            this.tstPause = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mstMenu.SuspendLayout();
            this.tstStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstMenu
            // 
            this.mstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstFile,
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
            this.toolStripSeparator3});
            resources.ApplyResources(this.tstStrip, "tstStrip");
            this.tstStrip.Name = "tstStrip";
            this.tstStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.SizingGrip = false;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tstStrip);
            this.Controls.Add(this.mstMenu);
            this.MainMenuStrip = this.mstMenu;
            this.Name = "MainForm";
            this.mstMenu.ResumeLayout(false);
            this.mstMenu.PerformLayout();
            this.tstStrip.ResumeLayout(false);
            this.tstStrip.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

