namespace PhotoGallery
{
    partial class Form1
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.CurrentDirectoryLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CurrentDirectory = new System.Windows.Forms.ToolStripStatusLabel();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.explorer1 = new PhotoGallery.Controls.Explorer();
            this.StatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurrentDirectoryLabel,
            this.CurrentDirectory});
            this.StatusStrip.Location = new System.Drawing.Point(0, 425);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(800, 25);
            this.StatusStrip.TabIndex = 1;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // CurrentDirectoryLabel
            // 
            this.CurrentDirectoryLabel.Name = "CurrentDirectoryLabel";
            this.CurrentDirectoryLabel.Size = new System.Drawing.Size(86, 20);
            this.CurrentDirectoryLabel.Text = "Current Folder:";
            // 
            // CurrentDirectory
            // 
            this.CurrentDirectory.AutoSize = false;
            this.CurrentDirectory.Name = "CurrentDirectory";
            this.CurrentDirectory.Size = new System.Drawing.Size(700, 20);
            // 
            // SplitContainer
            // 
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.Location = new System.Drawing.Point(0, 24);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.explorer1);
            this.SplitContainer.Size = new System.Drawing.Size(800, 401);
            this.SplitContainer.SplitterDistance = 222;
            this.SplitContainer.TabIndex = 2;
            // 
            // explorer1
            // 
            this.explorer1.Location = new System.Drawing.Point(1, 0);
            this.explorer1.Name = "explorer1";
            this.explorer1.Size = new System.Drawing.Size(219, 401);
            this.explorer1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SplitContainer);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Form1";
            this.Text = "Photo Gallery";
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.SplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel CurrentDirectoryLabel;
        private System.Windows.Forms.ToolStripStatusLabel CurrentDirectory;
        private System.Windows.Forms.SplitContainer SplitContainer;
        private Controls.Explorer explorer1;
    }
}

