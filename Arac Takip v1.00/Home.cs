using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Arac_Takip_v1._00
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KmGiris form_Home = new KmGiris();
            form_Home.MdiParent = this;
            form_Home.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KmGiris form_Home = new KmGiris();
            form_Home.MdiParent = this;
            form_Home.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Yakit_Giris form_Home = new Yakit_Giris();
            form_Home.MdiParent = this;
            form_Home.Show();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AracEkle form_Home = new AracEkle();
            form_Home.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SoforEkle form_Home = new SoforEkle();
            form_Home.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Rapor form = new Rapor();
            form.MdiParent = this;
            form.Show();
        }
    }
}
