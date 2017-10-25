using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ThemeParkUser
{
    public partial class PaymentView : Form
    {
        private String purchId = "";
        public PaymentView()
        {
            InitializeComponent();
        }

        int count=0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            count = count + 1;
            if (count == 2)
            {
                panel1.Visible = true;
            }
            if (count == 3)
            {
                this.Hide();
                count = 0;
                FinalFrm ff = new FinalFrm();
                ff.setPurchasId(purchId);
                ff.Show();
                timer1.Stop();
            }
        }

        private void PaymentView_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        public void setPurchasId(String id)
        {
            purchId = id;
        }
    }
}
