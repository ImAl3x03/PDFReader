namespace PDFReader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.Panel = new System.Windows.Forms.Panel();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.ButtonFile = new System.Windows.Forms.Button();
            this.ButtonPdf = new System.Windows.Forms.Button();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.ButtonPdf);
            this.Panel.Controls.Add(this.TextBox);
            this.Panel.Controls.Add(this.ButtonFile);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(218, 112);
            this.Panel.TabIndex = 0;
            // 
            // TextBox
            // 
            this.TextBox.AllowDrop = true;
            this.TextBox.Location = new System.Drawing.Point(12, 12);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(194, 20);
            this.TextBox.TabIndex = 1;
            this.TextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.InsertFile);
            this.TextBox.DragOver += new System.Windows.Forms.DragEventHandler(this.Effect);
            // 
            // ButtonFile
            // 
            this.ButtonFile.Location = new System.Drawing.Point(12, 64);
            this.ButtonFile.Name = "ButtonFile";
            this.ButtonFile.Size = new System.Drawing.Size(75, 23);
            this.ButtonFile.TabIndex = 0;
            this.ButtonFile.Text = "Insert file";
            this.ButtonFile.UseVisualStyleBackColor = true;
            this.ButtonFile.Click += new System.EventHandler(this.OpenFile);
            // 
            // ButtonPdf
            // 
            this.ButtonPdf.Location = new System.Drawing.Point(131, 64);
            this.ButtonPdf.Name = "ButtonPdf";
            this.ButtonPdf.Size = new System.Drawing.Size(75, 23);
            this.ButtonPdf.TabIndex = 2;
            this.ButtonPdf.Text = "Open file";
            this.ButtonPdf.UseVisualStyleBackColor = true;
            this.ButtonPdf.Click += new System.EventHandler(this.OpenPdf);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 112);
            this.Controls.Add(this.Panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button ButtonPdf;

        private System.Windows.Forms.Button ButtonFile;
        private System.Windows.Forms.TextBox TextBox;

        private System.Windows.Forms.Panel Panel;

        #endregion
    }
}