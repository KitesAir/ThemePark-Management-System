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
using QRCoder;

namespace ThemeParkUser
{
    public partial class FinalFrm : MetroForm
    {
        private String purchId="";
        public FinalFrm()
        {
            InitializeComponent();
        }

        private void FinalFrm_Load(object sender, EventArgs e)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(purchId, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(15);
            QRView.BackgroundImage = qrCodeImage;
        }

        public void setPurchasId(String id)
        {
            purchId = id;
        }
    }
}
