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
using Emgu.CV;
using Emgu.Util;
using ZXing;
using System.IO;
using ZXing.Common;
using System.Data.SqlClient;
using System.Media;

namespace TicketChecker
{
    
    public partial class MainView : MetroForm
    {
        private SqlConnection con;
        private SqlCommand cmd;
        
        public MainView()
        {
            InitializeComponent();
        }

        private Capture _capture=null;

        private void timer1_Tick(object sender, EventArgs e)
        {
            imgCamUser.Image = _capture.QueryFrame();
            decode(new Bitmap(_capture.QueryFrame().Bitmap));
        }

        public void decode(Bitmap img)
        {
            Bitmap image=img;
            
            using (image)
            {
                LuminanceSource source;
                source = new BitmapLuminanceSource(image);
                BinaryBitmap bitmap = new BinaryBitmap(new HybridBinarizer(source));
                Result result = new MultiFormatReader().decode(bitmap);
                if (result != null)
                {
                    retrieveRides(result.Text.ToString());
                    timer1.Stop();
                    _capture.Dispose();
                    _capture = new Emgu.CV.Capture();
                    timer1.Start();
                }
            }
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            _capture = new Emgu.CV.Capture();
            timer1.Start();
        }

        private void retrieveRides(String index)
        {
            try
            {
                con = DBConnection.getConnection();
                String sql = "Select eventID,eventName From Events";

                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                ridesList.DataSource = dt;

                ridesList.Columns[0].HeaderText = "Event ID";
                ridesList.Columns[1].HeaderText = "Event Name";

                SystemSounds.Beep.Play();
            }
            catch (SqlException)
            {
                MessageBox.Show("Database Error","Error");
            }
        }

        private void MainView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
