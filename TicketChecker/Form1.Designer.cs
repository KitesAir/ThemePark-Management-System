namespace TicketChecker
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
            this.unameTxt = new MetroFramework.Controls.MetroTextBox();
            this.pwdTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.cancelBtn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // unameTxt
            // 
            // 
            // 
            // 
            this.unameTxt.CustomButton.Image = null;
            this.unameTxt.CustomButton.Location = new System.Drawing.Point(194, 2);
            this.unameTxt.CustomButton.Name = "";
            this.unameTxt.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.unameTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.unameTxt.CustomButton.TabIndex = 1;
            this.unameTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.unameTxt.CustomButton.UseSelectable = true;
            this.unameTxt.CustomButton.Visible = false;
            this.unameTxt.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.unameTxt.Lines = new string[0];
            this.unameTxt.Location = new System.Drawing.Point(168, 86);
            this.unameTxt.MaxLength = 32767;
            this.unameTxt.Name = "unameTxt";
            this.unameTxt.PasswordChar = '\0';
            this.unameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.unameTxt.SelectedText = "";
            this.unameTxt.SelectionLength = 0;
            this.unameTxt.SelectionStart = 0;
            this.unameTxt.ShortcutsEnabled = true;
            this.unameTxt.Size = new System.Drawing.Size(230, 38);
            this.unameTxt.TabIndex = 0;
            this.unameTxt.UseSelectable = true;
            this.unameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.unameTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pwdTxt
            // 
            // 
            // 
            // 
            this.pwdTxt.CustomButton.Image = null;
            this.pwdTxt.CustomButton.Location = new System.Drawing.Point(194, 2);
            this.pwdTxt.CustomButton.Name = "";
            this.pwdTxt.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.pwdTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pwdTxt.CustomButton.TabIndex = 1;
            this.pwdTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pwdTxt.CustomButton.UseSelectable = true;
            this.pwdTxt.CustomButton.Visible = false;
            this.pwdTxt.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.pwdTxt.Lines = new string[0];
            this.pwdTxt.Location = new System.Drawing.Point(168, 145);
            this.pwdTxt.MaxLength = 32767;
            this.pwdTxt.Name = "pwdTxt";
            this.pwdTxt.PasswordChar = '*';
            this.pwdTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pwdTxt.SelectedText = "";
            this.pwdTxt.SelectionLength = 0;
            this.pwdTxt.SelectionStart = 0;
            this.pwdTxt.ShortcutsEnabled = true;
            this.pwdTxt.Size = new System.Drawing.Size(230, 38);
            this.pwdTxt.TabIndex = 1;
            this.pwdTxt.UseSelectable = true;
            this.pwdTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pwdTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.Black;
            this.metroLabel1.Location = new System.Drawing.Point(74, 97);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Username";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.Black;
            this.metroLabel2.Location = new System.Drawing.Point(74, 154);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Password";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(192, 208);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(121, 47);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Login";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(319, 208);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(121, 47);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseSelectable = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 278);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pwdTxt);
            this.Controls.Add(this.unameTxt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox unameTxt;
        private MetroFramework.Controls.MetroTextBox pwdTxt;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton cancelBtn;
    }
}

