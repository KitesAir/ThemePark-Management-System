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
using System.Media;

namespace AdminControls
{
    public partial class MainView : MetroForm
    {
        private SqlConnection con;
        private SqlCommand cmd;
        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            loadSales();
            loadEventDetails();
        }

        private void loadSales()
        {
            try
            {
                con = DBConnection.getConnection();

                String sql = "Select * From Purchases";

                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                salesGrid.DataSource = dt;

                salesGrid.Columns[0].HeaderText = "Ticket ID";
                salesGrid.Columns[1].HeaderText = "Purchase Time";
                salesGrid.Columns[2].HeaderText = "Purchase Data";
                salesGrid.Columns[3].HeaderText = "Total Value";

                cmd = new SqlCommand("select sum(totVal) from Purchases", con);
                var totIncome = cmd.ExecuteScalar();

                incomeLbl.Text = "$" + totIncome.ToString();

                con.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Database Error", "Error");
            }
            catch (InvalidOperationException ec)
            {
                //MessageBox.Show(ec.Message, "Error");
            }
        }

        private void loadEventDetails()
        {
            try
            {
                con = DBConnection.getConnection();
               // con.Open();
                String sql = "Select * From Events";

                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                eventsGrid.DataSource = dt;

                eventsGrid.Columns[0].HeaderText = "Event ID";
                eventsGrid.Columns[1].HeaderText = "Event Name";
                eventsGrid.Columns[2].HeaderText = "Price";
                eventsGrid.Columns[3].HeaderText = "Maintenance";

                con.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Database Error", "Error");
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LoginFrm lf = new LoginFrm();
            lf.Show();this.Hide();
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadSales();
            loadEventDetails();
            if (metroTabControl1.SelectedIndex != 0)
            {
                label1.Hide();
                label2.Hide();
                label3.Hide();
                incomeLbl.Hide();
            }else
            {
                label1.Show();
                label2.Show();
                label3.Show();
                incomeLbl.Show();
            }
        }
    }
}
