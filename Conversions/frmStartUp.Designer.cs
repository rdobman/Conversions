namespace Conversions
{
    partial class frmStartUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStartUp));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.msbNewConversion = new System.Windows.Forms.ToolStripMenuItem();
            this.msbClose = new System.Windows.Forms.ToolStripMenuItem();
            this.msbExit = new System.Windows.Forms.ToolStripMenuItem();
            this.msiTools = new System.Windows.Forms.ToolStripMenuItem();
            this.msbOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.msiWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.msbCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.msbVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.msbHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbOptions = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiFile,
            this.msiTools,
            this.msiWindow});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.msiWindow;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(943, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msiFile
            // 
            this.msiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msbNewConversion,
            this.msbClose,
            this.msbExit});
            this.msiFile.Name = "msiFile";
            this.msiFile.Size = new System.Drawing.Size(37, 20);
            this.msiFile.Text = "File";
            // 
            // msbNewConversion
            // 
            this.msbNewConversion.Name = "msbNewConversion";
            this.msbNewConversion.Size = new System.Drawing.Size(161, 22);
            this.msbNewConversion.Text = "New Conversion";
            this.msbNewConversion.Click += new System.EventHandler(this.msbNewConversion_Click);
            // 
            // msbClose
            // 
            this.msbClose.Name = "msbClose";
            this.msbClose.Size = new System.Drawing.Size(161, 22);
            this.msbClose.Text = "Close";
            this.msbClose.Click += new System.EventHandler(this.msbClose_Click);
            // 
            // msbExit
            // 
            this.msbExit.Name = "msbExit";
            this.msbExit.Size = new System.Drawing.Size(161, 22);
            this.msbExit.Text = "Exit";
            this.msbExit.Click += new System.EventHandler(this.msbExit_Click);
            // 
            // msiTools
            // 
            this.msiTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msbOptions});
            this.msiTools.Name = "msiTools";
            this.msiTools.Size = new System.Drawing.Size(47, 20);
            this.msiTools.Text = "Tools";
            // 
            // msbOptions
            // 
            this.msbOptions.Name = "msbOptions";
            this.msbOptions.Size = new System.Drawing.Size(116, 22);
            this.msbOptions.Text = "Options";
            this.msbOptions.Click += new System.EventHandler(this.msbOptions_Click);
            // 
            // msiWindow
            // 
            this.msiWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msbCascade,
            this.msbVertical,
            this.msbHorizontal});
            this.msiWindow.Name = "msiWindow";
            this.msiWindow.Size = new System.Drawing.Size(63, 20);
            this.msiWindow.Text = "Window";
            // 
            // msbCascade
            // 
            this.msbCascade.Name = "msbCascade";
            this.msbCascade.Size = new System.Drawing.Size(190, 22);
            this.msbCascade.Text = "Cascade Layout";
            this.msbCascade.Click += new System.EventHandler(this.msbCascade_Click);
            // 
            // msbVertical
            // 
            this.msbVertical.Name = "msbVertical";
            this.msbVertical.Size = new System.Drawing.Size(190, 22);
            this.msbVertical.Text = "Tile Vertical Layout";
            this.msbVertical.Click += new System.EventHandler(this.msbVertical_Click);
            // 
            // msbHorizontal
            // 
            this.msbHorizontal.Name = "msbHorizontal";
            this.msbHorizontal.Size = new System.Drawing.Size(190, 22);
            this.msbHorizontal.Text = "Tile Horizontal Layout";
            this.msbHorizontal.Click += new System.EventHandler(this.msbHorizontal_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbOptions});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(943, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNew
            // 
            this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(35, 22);
            this.tsbNew.Text = "New";
            this.tsbNew.Click += new System.EventHandler(this.msbNewConversion_Click);
            // 
            // tsbOptions
            // 
            this.tsbOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbOptions.Image = ((System.Drawing.Image)(resources.GetObject("tsbOptions.Image")));
            this.tsbOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOptions.Name = "tsbOptions";
            this.tsbOptions.Size = new System.Drawing.Size(53, 22);
            this.tsbOptions.Text = "Options";
            this.tsbOptions.Click += new System.EventHandler(this.msbOptions_Click);
            // 
            // frmStartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 610);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmStartUp";
            this.Text = "Unit Conversions";
            this.Load += new System.EventHandler(this.frmStartUp_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msiFile;
        private System.Windows.Forms.ToolStripMenuItem msbExit;
        private System.Windows.Forms.ToolStripMenuItem msiTools;
        private System.Windows.Forms.ToolStripMenuItem msiWindow;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbOptions;
        private System.Windows.Forms.ToolStripMenuItem msbNewConversion;
        private System.Windows.Forms.ToolStripMenuItem msbClose;
        private System.Windows.Forms.ToolStripMenuItem msbCascade;
        private System.Windows.Forms.ToolStripMenuItem msbVertical;
        private System.Windows.Forms.ToolStripMenuItem msbHorizontal;
        private System.Windows.Forms.ToolStripMenuItem msbOptions;
    }
}

