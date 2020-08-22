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
    public partial class SoforEkle : DevExpress.XtraEditors.XtraForm
    {
        MsSQL sql=new MsSQL();
        public SoforEkle()
        {
            InitializeComponent();
        }

        private void SoforEkle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'aracTakipDBDataSet1.Surucu_Bilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.surucu_BilgileriTableAdapter.Fill(this.aracTakipDBDataSet1.Surucu_Bilgileri);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (tc.Text != "" && tel.Text != "" && ad.Text != "" && soyad.Text != "")
            {
                if (tc.Text.Length == 11)
                {
                    sql.SurucuEkle(tc.Text, ad.Text, soyad.Text, tel.Text);
                    this.surucu_BilgileriTableAdapter.Fill(this.aracTakipDBDataSet1.Surucu_Bilgileri);
                }
                else
                {
                    MessageBox.Show("Tc No 11'den kücük veya büyük olamaz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Herhangi bir alan boş geçilemez", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
