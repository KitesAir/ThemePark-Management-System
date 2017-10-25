using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ThemeParkUser
{
    public partial class MainView : MetroForm
    {
        private double orderTot=0;
        private int row1, row2, row3, row4, row5, row6, row7, row8, row9;
        private SqlConnection con;
        private SqlCommand cmd;
        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            SelectionTabs.Font = new Font("Sugarpunch DEMO", 16, FontStyle.Regular);
            checkBox1.Font = new Font("Sugarpunch DEMO", 25);
            checkBox2.Font = new Font("Sugarpunch DEMO", 25);
            checkBox3.Font = new Font("Sugarpunch DEMO", 25);
            textBox1.Font = new Font("Sugarpunch DEMO", 14);
            textBox2.Font = new Font("Sugarpunch DEMO", 14);
            textBox3.Font = new Font("Sugarpunch DEMO", 14);
            SasemDetail1.Height = SesameStreet.Size.Height - 50;
            SasemDetail1.Width = SasemDetail1.Height;
            SasemDetail2.Left = SasemDetail1.Left + SasemDetail1.Size.Width + 16;
            SasemDetail2.Size = SasemDetail1.Size;
            SasemDetail3.Left= SasemDetail2.Left + SasemDetail2.Size.Width + 16;
            SasemDetail3.Size = SasemDetail1.Size;
            SeS1Wmp.uiMode = "none";

            hScrollBar1.Minimum = -( SasemDetail1.Width + 100);
            hScrollBar1.Maximum = ( SasemDetail1.Width -50 );
            hScrollBar1.Value = hScrollBar1.Minimum;

            hScrollBar2.Minimum = -(SasemDetail1.Width + 100);
            hScrollBar2.Maximum = (SasemDetail1.Width - 50);
            hScrollBar2.Value = hScrollBar2.Minimum;

            hScrollBar3.Minimum = -(SasemDetail1.Width + 100);
            hScrollBar3.Maximum = (SasemDetail1.Width - 50);
            hScrollBar3.Value = hScrollBar3.Minimum;

            purchaseList.Height = buyBtn.Top - (purchaseList.Top + 2);
        }

        private void playControl1(int val,int min,int max)
        {
            int length = (0 - min) + max;

            if (val < (min / 1.8) - 10)
            {
                SeS1Wmp.Ctlcontrols.play();
            }else
            {
                SeS1Wmp.Ctlcontrols.pause();
            }

            if (val > (min / 1.8) - 10 && val < (max / 1.5) - 200)
            {
                SeS2Wmp.Ctlcontrols.play();
            }
            else
            {
                SeS2Wmp.Ctlcontrols.pause();
            }

            if (val > (max / 1.5) - 200)
            {
                SeS3Wmp.Ctlcontrols.play();
            }
            else
            {
                SeS3Wmp.Ctlcontrols.pause();
            }
        }
            
        private void playControl2(int val, int min, int max)
        {
            int length = (0 - min) + max;

            if (val < (min / 1.8) - 10)
            {
                SciWmp1.Ctlcontrols.play();
            }
            else
            {
                SciWmp1.Ctlcontrols.pause();
            }

            if (val > (min / 1.8) - 10 && val < (max / 1.5) - 200)
            {
                SciWmp2.Ctlcontrols.play();
            }
            else
            {
                SciWmp2.Ctlcontrols.pause();
            }

            if (val > (max / 1.5) - 200)
            {
                SciWmp3.Ctlcontrols.play();
            }
            else
            {
                SciWmp3.Ctlcontrols.pause();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                row1 = purchaseList.Rows.Count;
                purchaseList.Rows.Add("Ses001", "Sesam Street", "When I Grow Up", "$20");
                orderTot = orderTot + 20;

            }
            else
            {
                purchaseList.Rows.RemoveAt(row1);
                orderTot = orderTot - 20;
            }
            setPrice();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                row2 = purchaseList.Rows.Count;
                purchaseList.Rows.Add("Ses002", "Sesam Street", "Spaghetti Space Chase", "$25");
                orderTot = orderTot + 25;
            }
            else
            {
                purchaseList.Rows.RemoveAt(row2);
                orderTot = orderTot - 25;
            }
            setPrice();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                row3 = purchaseList.Rows.Count;
                purchaseList.Rows.Add("Ses003", "Sesam Street", "DriveThrough New Yoke", "$25");
                orderTot = orderTot + 25;
            }
            else
            {
                purchaseList.Rows.RemoveAt(row3);
                orderTot = orderTot - 25;
            }
            setPrice();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                row4 = purchaseList.Rows.Count;
                purchaseList.Rows.Add("Sci003", "Sci-Fi World", "TRANSFORMERS : The Ultimate 3D Battle", "$40");
                orderTot = orderTot + 40;
            }
            else
            {
                purchaseList.Rows.RemoveAt(row4);
                orderTot = orderTot - 40;
            }
            setPrice();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                row5 = purchaseList.Rows.Count;
                purchaseList.Rows.Add("Sci002", "Sci-Fi World", "BattlestarGalactica", "$30");
                orderTot = orderTot + 30;
            }
            else
            {
                purchaseList.Rows.RemoveAt(row5);
                orderTot = orderTot - 30;
            }
            setPrice();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                row6 = purchaseList.Rows.Count;
                purchaseList.Rows.Add("Sci001", "Sci-Fi World", "Lights, Camera, Action!", "$25");
                orderTot = orderTot + 25;
            }
            else
            {
                purchaseList.Rows.RemoveAt(row6);
                orderTot = orderTot - 25;
            }
            setPrice();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                row9 = purchaseList.Rows.Count;
                purchaseList.Rows.Add("Srk001", "Shrek", "Shrek 4-D Adventure ", "$25");
                orderTot = orderTot + 25;
            }
            else
            {
                purchaseList.Rows.RemoveAt(row9);
                orderTot = orderTot - 25;
            }
            setPrice();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                row8 = purchaseList.Rows.Count;
                purchaseList.Rows.Add("Srk002", "Shrek", "Puss in Boots’ Giant Journey", "$30");
                orderTot = orderTot + 30;
            }
            else
            {
                purchaseList.Rows.RemoveAt(row8);
                orderTot = orderTot - 30;
            }
            setPrice();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                row7 = purchaseList.Rows.Count;
                purchaseList.Rows.Add("Srk003", "Shrek", "Enchanted Airways", "$25");
                orderTot = orderTot + 25;
            }
            else
            {
                purchaseList.Rows.RemoveAt(row7);
                orderTot = orderTot - 25;
            }
            setPrice();
        }

        private void buyAllBtn_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            checkBox4.Checked = true;
            checkBox5.Checked = true;
            checkBox6.Checked = true;
            checkBox7.Checked = true;
            checkBox8.Checked = true;
            checkBox9.Checked = true;
        }

        private void buyShreckBtn_Click(object sender, EventArgs e)
        {
            checkBox7.Checked = true;
            checkBox8.Checked = true;
            checkBox9.Checked = true;
        }

        private void buySciBtn_Click(object sender, EventArgs e)
        {
            checkBox4.Checked = true;
            checkBox5.Checked = true;
            checkBox6.Checked = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            if (purchaseList.Rows.Count>0) {
                PaymentView py = new PaymentView();
                py.Show();
                try
                {
                    con = DBConnection.getConnection();
                    con.Open();

                    String sql = "SELECT TOP 1 ticketId FROM Purchases ORDER BY ticketId DESC";
                    cmd = new SqlCommand(sql, con);
                    String lastRow = (String)cmd.ExecuteScalar();
                    cmd.Dispose();

                    String purchaseId = "S000" + (Convert.ToInt32(lastRow.Remove(0, 1)) + 1);

                    py.setPurchasId(purchaseId);

                    sql = "Insert into Purchases values('" + purchaseId + "','" + DateTime.Now.ToString("hh:mmtt") + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "'," + totLbl.Text + ")";
                    cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();


                    foreach (DataGridViewRow row in purchaseList.Rows)
                    {
                        sql = "insert into ticketDetails values('" + purchaseId + "','" + row.Cells[0].Value.ToString() + "');";
                        cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }

                    purchaseList.Rows.Clear();
                    orderTot = 0;
                    setPrice();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL : " + ex.Message);
                } catch (FormatException ev)
                {
                    MessageBox.Show("Format : " + ev.Message);
                }
            }else
            {
                MessageBox.Show("Your Purchase List is Empty.Please Select The Rides/Shows You want and Continue..", "Select Items",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void MainView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainView_Activated(object sender, EventArgs e)
        {
            SeS2Wmp.Ctlcontrols.stop();
            SeS3Wmp.Ctlcontrols.stop();
            SeS2Wmp.Ctlcontrols.play();
            SeS3Wmp.Ctlcontrols.play();
            SeS2Wmp.Ctlcontrols.pause();
            SeS3Wmp.Ctlcontrols.pause();

            SciWmp1.Ctlcontrols.stop();
            SciWmp2.Ctlcontrols.stop();
            SciWmp3.Ctlcontrols.stop();
            SciWmp1.Ctlcontrols.play();
            SciWmp2.Ctlcontrols.play();
            SciWmp3.Ctlcontrols.play();
            SciWmp1.Ctlcontrols.pause();
            SciWmp2.Ctlcontrols.pause();
            SciWmp3.Ctlcontrols.pause();

            SrWmp1.Ctlcontrols.stop();
            SrWmp2.Ctlcontrols.stop();
            SrWmp3.Ctlcontrols.stop();
            SrWmp1.Ctlcontrols.play();
            SrWmp2.Ctlcontrols.play();
            SrWmp3.Ctlcontrols.play();
            SrWmp1.Ctlcontrols.pause();
            SrWmp2.Ctlcontrols.pause();
            SrWmp3.Ctlcontrols.pause();
        }


        private void playControl3(int val, int min, int max)
        {
            int length = (0 - min) + max;

            if (val < (min / 1.8) - 10)
            {
                SrWmp1.Ctlcontrols.play();
            }
            else
            {
                SrWmp1.Ctlcontrols.pause();
            }

            if (val > (min / 1.8) - 10 && val < (max / 1.5) - 200)
            {
                SrWmp2.Ctlcontrols.play();
            }
            else
            {
                SrWmp2.Ctlcontrols.pause();
            }

            if (val > (max / 1.5) - 200)
            {
                SrWmp3.Ctlcontrols.play();
            }
            else
            {
                SrWmp3.Ctlcontrols.pause();
            }
        }


        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            SasemDetail1.Left = -hScrollBar1.Value - SasemDetail1.Width;
            SasemDetail2.Left = SasemDetail1.Left + SasemDetail1.Size.Width + 20;
            SasemDetail3.Left = SasemDetail2.Left + SasemDetail2.Size.Width + 20;
            playControl1(hScrollBar1.Value, hScrollBar1.Minimum, hScrollBar1.Maximum);
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            SrekDetail1.Left = -hScrollBar3.Value - SrekDetail1.Width;
            SrekDetail2.Left = SrekDetail1.Left + SrekDetail1.Size.Width + 20;
            SrekDetail3.Left = SrekDetail2.Left + SrekDetail2.Size.Width + 20;
            playControl3(hScrollBar3.Value, hScrollBar3.Minimum, hScrollBar3.Maximum);
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            SciDetail1.Left = -hScrollBar2.Value - SciDetail1.Width;
            SciDetail2.Left = SciDetail1.Left + SciDetail1.Size.Width + 20;
            SciDetail3.Left = SciDetail2.Left + SciDetail2.Size.Width + 20;
            playControl2(hScrollBar2.Value, hScrollBar2.Minimum, hScrollBar2.Maximum);
        }

        private void SelectionTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            SciDetail1.Size = SasemDetail1.Size;
            SciDetail2.Size = SciDetail1.Size;
            SciDetail3.Size = SciDetail1.Size;
            SciDetail2.Left = SciDetail1.Left + SciDetail1.Size.Width + 16;
            SciDetail3.Left = SciDetail2.Left + SciDetail2.Size.Width + 16;

            SrekDetail1.Size = SasemDetail1.Size;
            SrekDetail2.Size = SasemDetail1.Size;
            SrekDetail3.Size = SasemDetail1.Size;
            SrekDetail2.Left = SrekDetail1.Left + SrekDetail1.Size.Width + 16;
            SrekDetail3.Left = SrekDetail2.Left + SrekDetail2.Size.Width + 16;

            checkBox1.Font = new Font("Sugarpunch DEMO", 25);
            checkBox2.Font = new Font("Sugarpunch DEMO", 25);
            checkBox3.Font = new Font("Sugarpunch DEMO", 25);
            checkBox4.Font = new Font("Sugarpunch DEMO", 25);
            checkBox5.Font = new Font("Sugarpunch DEMO", 25);
            checkBox6.Font = new Font("Sugarpunch DEMO", 25);
            checkBox7.Font = new Font("Sugarpunch DEMO", 25);
            checkBox8.Font = new Font("Sugarpunch DEMO", 25);
            checkBox9.Font = new Font("Sugarpunch DEMO", 25);
            textBox1.Font = new Font("Sugarpunch DEMO", 14);
            textBox2.Font = new Font("Sugarpunch DEMO", 14);
            textBox3.Font = new Font("Sugarpunch DEMO", 14);
            textBox4.Font = new Font("Sugarpunch DEMO", 14);
            textBox5.Font = new Font("Sugarpunch DEMO", 14);
            textBox6.Font = new Font("Sugarpunch DEMO", 14);
            textBox7.Font = new Font("Sugarpunch DEMO", 14);
            textBox8.Font = new Font("Sugarpunch DEMO", 14);
            textBox9.Font = new Font("Sugarpunch DEMO", 14);

            SeS1Wmp.uiMode = "none";

            hScrollBar2.Minimum = -(SciDetail1.Width + 100);
            hScrollBar2.Maximum = (SciDetail1.Width - 50);
            hScrollBar2.Value = hScrollBar2.Minimum;

            if (SelectionTabs.SelectedIndex == 0)
            {
                SeS1Wmp.Ctlcontrols.play();
                SciWmp1.Ctlcontrols.pause();
                SciWmp2.Ctlcontrols.pause();
                SciWmp3.Ctlcontrols.pause();
                SrWmp1.Ctlcontrols.pause();
                SrWmp2.Ctlcontrols.pause();
                SrWmp3.Ctlcontrols.pause();
            }
            else if (SelectionTabs.SelectedIndex == 1)
            {
                SciWmp1.Ctlcontrols.play();
                SeS1Wmp.Ctlcontrols.pause();
                SeS2Wmp.Ctlcontrols.pause();
                SeS3Wmp.Ctlcontrols.pause();
                SrWmp1.Ctlcontrols.pause();
                SrWmp2.Ctlcontrols.pause();
                SrWmp3.Ctlcontrols.pause();
            }
            else if (SelectionTabs.SelectedIndex == 2)
            {
                SrWmp1.Ctlcontrols.play();
                SeS1Wmp.Ctlcontrols.pause();
                SeS2Wmp.Ctlcontrols.pause();
                SeS3Wmp.Ctlcontrols.pause();
                SciWmp1.Ctlcontrols.pause();
                SciWmp2.Ctlcontrols.pause();
                SciWmp3.Ctlcontrols.pause();
            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            purchaseList.Rows.Clear();
            orderTot = 0;
            setPrice();
        }

        private void setPrice()
        {
            totLbl.Text = "$" + orderTot.ToString();
        }
    }
}

