namespace WindowsFormsControlLibrary1
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.BaseFormMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.BaseMenuStrip = new System.Windows.Forms.MenuStrip();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BaseFormMenuStrip.SuspendLayout();
            this.BaseMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseFormMenuStrip
            // 
            this.BaseFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.fileToolStripMenuItem});
            this.BaseFormMenuStrip.Name = "contextMenuStrip1";
            resources.ApplyResources(this.BaseFormMenuStrip, "BaseFormMenuStrip");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorsToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            resources.ApplyResources(this.colorsToolStripMenuItem, "colorsToolStripMenuItem");
            this.colorsToolStripMenuItem.Click += new System.EventHandler(this.OpenColorDialog);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            resources.ApplyResources(this.closeToolStripMenuItem, "closeToolStripMenuItem");
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseDialog);
            // 
            // BaseMenuStrip
            // 
            this.BaseMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.fileToolStripMenuItem1});
            resources.ApplyResources(this.BaseMenuStrip, "BaseMenuStrip");
            this.BaseMenuStrip.Name = "BaseMenuStrip";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorsToolStripMenuItem1});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            resources.ApplyResources(this.preferencesToolStripMenuItem, "preferencesToolStripMenuItem");
            // 
            // colorsToolStripMenuItem1
            // 
            this.colorsToolStripMenuItem1.Name = "colorsToolStripMenuItem1";
            resources.ApplyResources(this.colorsToolStripMenuItem1, "colorsToolStripMenuItem1");
            this.colorsToolStripMenuItem1.Click += new System.EventHandler(this.OpenColorDialog);
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeChildToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            resources.ApplyResources(this.fileToolStripMenuItem1, "fileToolStripMenuItem1");
            // 
            // closeChildToolStripMenuItem
            // 
            this.closeChildToolStripMenuItem.Name = "closeChildToolStripMenuItem";
            resources.ApplyResources(this.closeChildToolStripMenuItem, "closeChildToolStripMenuItem");
            this.closeChildToolStripMenuItem.Click += new System.EventHandler(this.CloseDialog);
            // 
            // BaseForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.BaseFormMenuStrip;
            this.Controls.Add(this.BaseMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.BaseMenuStrip;
            this.Name = "BaseForm";
            this.Activated += new System.EventHandler(this.BaseForm_Activated);
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
            this.BaseFormMenuStrip.ResumeLayout(false);
            this.BaseMenuStrip.ResumeLayout(false);
            this.BaseMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip BaseFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip BaseMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeChildToolStripMenuItem;
    }
}