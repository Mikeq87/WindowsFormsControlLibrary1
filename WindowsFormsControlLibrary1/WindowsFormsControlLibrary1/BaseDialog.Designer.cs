namespace WindowsFormsControlLibrary1
{
    partial class BaseDialog
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
            this.GroupInfo = new WindowsFormsControlLibrary1.GroupControl();
            this.ClassInfo = new WindowsFormsControlLibrary1.ClassControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // GroupInfo
            // 
            this.GroupInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GroupInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupInfo.Location = new System.Drawing.Point(0, 184);
            this.GroupInfo.Name = "GroupInfo";
            this.GroupInfo.Size = new System.Drawing.Size(299, 77);
            this.GroupInfo.TabIndex = 0;
            // 
            // ClassInfo
            // 
            this.ClassInfo.BackColor = System.Drawing.Color.Transparent;
            this.ClassInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClassInfo.Location = new System.Drawing.Point(0, 0);
            this.ClassInfo.Name = "ClassInfo";
            this.ClassInfo.Size = new System.Drawing.Size(299, 58);
            this.ClassInfo.TabIndex = 1;
            this.ClassInfo.Load += new System.EventHandler(this.classControl1_Load);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 261);
            this.panel1.TabIndex = 2;
            // 
            // BaseDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 261);
            this.Controls.Add(this.ClassInfo);
            this.Controls.Add(this.GroupInfo);
            this.Controls.Add(this.panel1);
            this.Name = "BaseDialog";
            this.Text = "BaseDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private GroupControl GroupInfo;
        private ClassControl ClassInfo;
        private System.Windows.Forms.Panel panel1;
    }
}