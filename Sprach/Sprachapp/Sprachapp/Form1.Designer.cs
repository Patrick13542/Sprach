namespace Sprachapp
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
            this.sprachip = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // sprachip
            // 
            this.sprachip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sprachip.Location = new System.Drawing.Point(0, 0);
            this.sprachip.MaximumSize = new System.Drawing.Size(1000000, 1000000);
            this.sprachip.MinimumSize = new System.Drawing.Size(20, 20);
            this.sprachip.Name = "sprachip";
            this.sprachip.Size = new System.Drawing.Size(464, 256);
            this.sprachip.TabIndex = 0;
            this.sprachip.Url = new System.Uri("http://10.193.66.127:3000/?", System.UriKind.Absolute);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 256);
            this.Controls.Add(this.sprachip);
            this.Name = "Form1";
            this.Text = "Sprach!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser sprachip;
    }
}

