using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Takip_v1._00
{
    public partial class AracEkle : DevExpress.XtraEditors.XtraForm
    {
        MsSQL veriTabani = new MsSQL();
        public AracEkle()
        {
            InitializeComponent();
        }

        private void AracEkle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'aracTakipDBDataSet1.Arac_Bilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.arac_BilgileriTableAdapter.Fill(this.aracTakipDBDataSet1.Arac_Bilgileri);
            this.arac_BilgileriTableAdapter.Fill(this.aracTakipDBDataSet1.Arac_Bilgileri);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            veriTabani.AracEkle(arac_Plaka.Text,arac_Model.Text,arac_Km.Text);
            this.arac_BilgileriTableAdapter.Fill(this.aracTakipDBDataSet1.Arac_Bilgileri);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            veriTabani.VeriSil(Arac_Bilgileri.Name, "Arac_PlakaNo","'"+ Arac_Bilgileri.GetRowCellValue(Arac_Bilgileri.FocusedRowHandle, "Arac_PlakaNo").ToString()+"'");
            this.arac_BilgileriTableAdapter.Fill(this.aracTakipDBDataSet1.Arac_Bilgileri);

        }
    }
}
