namespace WindowsFormsControlLibrary1
{
    partial class GroupControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GroupLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GroupLabel
            // 
            this.GroupLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupLabel.Font = new System.Drawing.Font("Minion Pro Cond", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.GroupLabel.Location = new System.Drawing.Point(0, 0);
            this.GroupLabel.Name = "GroupLabel";
            this.GroupLabel.Size = new System.Drawing.Size(309, 83);
            this.GroupLabel.TabIndex = 0;
            this.GroupLabel.Text = "Group 4  - Antonio Riverol, Jorge Cura, Michael Quiros, Taufiq Islam, Franco Hern" +
    "andez";
            this.GroupLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // GroupControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.GroupLabel);
            this.Name = "GroupControl";
            this.Size = new System.Drawing.Size(309, 75);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label GroupLabel;
    }
}
