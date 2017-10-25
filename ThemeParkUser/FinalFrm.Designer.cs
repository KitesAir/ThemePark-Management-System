namespace ThemeParkUser
{
    partial class FinalFrm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.QRView = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.QRView)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.Black;
            this.metroLabel1.Location = new System.Drawing.Point(465, 161);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(285, 175);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Thanks For Purchasing :) \r\nGet Your Tickets from the Counter.\r\n\r\nFor Easiness You" +
    " can take a photo\r\nof this QR Code and use it.\r\n\r\nHave a Nice Day !";
            // 
            // QRView
            // 
            this.QRView.Location = new System.Drawing.Point(65, 80);
            this.QRView.Name = "QRView";
            this.QRView.Size = new System.Drawing.Size(380, 380);
            this.QRView.TabIndex = 0;
            this.QRView.TabStop = false;
            // 
            // FinalFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 548);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.QRView);
            this.Name = "FinalFrm";
            this.Text = "Scan the QR code or Print the Ticket";
            this.Load += new System.EventHandler(this.FinalFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QRView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox QRView;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}