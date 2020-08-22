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
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'aracTakipDBDataSet1.v_FaturaBilgisi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.v_FaturaBilgisiTableAdapter.Fill(this.aracTakipDBDataSet1.v_FaturaBilgisi);
            // TODO: Bu kod satırı 'aracTakipDBDataSet1.Arac_Bilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.arac_BilgileriTableAdapter.Fill(this.aracTakipDBDataSet1.Arac_Bilgileri);
            // TODO: Bu kod satırı 'aracTakipDBDataSet1.v_SurucuBilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.v_SurucuBilgileriTableAdapter.Fill(this.aracTakipDBDataSet1.v_SurucuBilgileri);

        }
    }
}
