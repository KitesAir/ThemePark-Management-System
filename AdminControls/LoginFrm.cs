using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;

namespace AdminControls
{
    public partial class LoginFrm : MetroForm
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private MainView mv;
        public LoginFrm()
        {
            InitializeComponent();
            conn = DBConnection.getConnection();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (unameTxt.Text.Length > 0 && pwdTxt.Text.Length > 0)
                {

                    conn.Open();
                    String un = unameTxt.Text.Trim();
                    String pw = pwdTxt.Text.Trim();
                    String sql = "select username from Users where username='" + un + "' AND pwd='" + pw + "' AND user_type=1";
                    cmd = new SqlCommand(sql, conn);
                    String getVal = (String)cmd.ExecuteScalar();
                    cmd.Dispose();

                    if (unameTxt.Text.Equals(getVal))
                    {
                        mv = new MainView();
                        mv.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password OR Username. Try Again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Enter BOTH username and password.", "Login Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter Only the Characters. NO SYMBOLS ALLOWED.", "Login Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SqlException)
            {
                MessageBox.Show("Cant connect to the Database. Try Again Later.", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            unameTxt.Text = "";
            pwdTxt.Text = "";
        }

    }
}

