using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZXing;
using System.Collections;
using ZXing.QrCode;

namespace InQRCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();            
            dt.Columns.Add("AnhQR", typeof(Byte[]));

            BarcodeWriter writer = new BarcodeWriter { Format = BarcodeFormat.QR_CODE };
            var newhint = new System.Collections.Generic.KeyValuePair<EncodeHintType, object>(EncodeHintType.CHARACTER_SET, "UTF-8");
            writer.Options.Hints.Add(newhint);
            var result = writer.Write(@"Đặng Quang Thành");
            var barcodeBitmap = new Bitmap(result);
            ImageConverter converter = new ImageConverter();

            DataRow r = dt.NewRow();
            r["AnhQR"] = (byte[])converter.ConvertTo(barcodeBitmap, typeof(byte[]));
            dt.Rows.Add(r);
            
            CrystalReport1 crt = new CrystalReport1();
            crt.SetDataSource(dt);
            crt.SetParameterValue("DuLieu", "Đặng Quang Thành");
            crystalReportViewer1.ReportSource = crt;
            crystalReportViewer1.Show();
        }
    }
}
