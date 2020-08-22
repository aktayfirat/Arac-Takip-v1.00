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
    public partial class KmGiris : Form
    {
        Boolean editMode = false;
        MsSQL veriTabani = new MsSQL();
        String is_ortagi;
        public KmGiris()
        {
            InitializeComponent();

        }

        private void KmGiris_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'aracTakipDBDataSet1.v_SurucuBilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.v_SurucuBilgileriTableAdapter.Fill(this.aracTakipDBDataSet1.v_SurucuBilgileri);
            // TODO: Bu kod satırı 'aracTakipDBDataSet1.v_FaturaBilgisi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.v_FaturaBilgisiTableAdapter.Fill(this.aracTakipDBDataSet1.v_FaturaBilgisi);
            // TODO: Bu kod satırı 'aracTakipDBDataSet1.Sehir_Bilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sehir_BilgileriTableAdapter.Fill(this.aracTakipDBDataSet1.Sehir_Bilgileri);
            // TODO: Bu kod satırı 'aracTakipDBDataSet1.Surucu_Bilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.surucu_BilgileriTableAdapter.Fill(this.aracTakipDBDataSet1.Surucu_Bilgileri);
            // TODO: Bu kod satırı 'aracTakipDBDataSet1.Arac_Bilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.arac_BilgileriTableAdapter.Fill(this.aracTakipDBDataSet1.Arac_Bilgileri);

            // Form yüklenirken ComboBox'lara verileri güncel olarak ekler
            ViewGüncelle();
        }

        private void checkEdit5_CheckedChanged(object sender, EventArgs e)
        {
            // İş ortağındandaki Diğer kutusunun aktif olma durumu
            diger_Textbox.Enabled = !diger_Textbox.Enabled;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // İş ortağı CheckBox ilgili düzenlemeler
            is_ortagi = "";
            if (mavi_CheckBox.Checked == true) is_ortagi += mavi_CheckBox.Text + ", ";
            if (tepe_CheckBox.Checked == true) is_ortagi += tepe_CheckBox.Text + ", ";
            if (kekova_CheckBox.Checked == true) is_ortagi += kekova_CheckBox.Text + ", ";
            if (niti_CheckBox.Checked == true) is_ortagi += niti_CheckBox.Text + ", ";
            if (diger_CheckBox.Checked == true) is_ortagi += diger_Textbox.Text + ", ";
            if(is_ortagi.Length>2) is_ortagi = is_ortagi.Substring(0, is_ortagi.Length - 2);

            // Ön koşullu kod; veritabanındaki km bilgisinin dışında km girilmesini engeller.
            if (belgeNo.Text != "" && plakaNo_f.Text != "" && donus_km.Text != "" && km_date.Text != "")
            {

                if (Convert.ToInt32(Km_gidis.Text) < Convert.ToInt32(donus_km.Text))
                {
                    veriTabani.KmGirisEkle(belgeNo.Text, plakaNo_f.Text, "" + surucuAdi_Km.SelectedValue, is_ortagi, "" + sehir_Km.SelectedValue, donus_km.Text, km_date.Text);
                    ViewGüncelle();

                }
                else
                {
                    MessageBox.Show("DÖNÜŞ GİDİŞTEN KÜÇÜK OLAMAZ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {

                    MessageBox.Show("HERHANGİ BİR ALAN BOŞ GECİLEMEZ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void plakaNo_f_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Formda olası bir farklı plaka kaydı icin KM bilgisini günceller
            Km_gidis.Text = veriTabani.SorguSonuc("SELECT Arac_Km FROM Arac_Bilgileri WHERE Arac_PlakaNo='"+plakaNo_f.Text+"'");
            donus_km.Text = Km_gidis.Text;
        }

        private void kmSil_Click(object sender, EventArgs e)
        {
            veriTabani.VeriSil(Fatura_Bilgileri.Name, "Belge_No", gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Belge_No").ToString());
            ViewGüncelle();
        }

        private void ViewGüncelle() {

            v_FaturaBilgisiTableAdapter.Fill(aracTakipDBDataSet1.v_FaturaBilgisi);
            // Bu kod satırı 'aracTakipDBDataSet1.Sehir_Bilgileri' tablosunu yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sehir_BilgileriTableAdapter.Fill(this.aracTakipDBDataSet1.Sehir_Bilgileri);
            // Bu kod satırı Aracın veri tabanımızda tuttuğumuz en son Km bilgisini görüntüler
            Km_gidis.Text = veriTabani.SorguSonuc("SELECT Arac_Km FROM Arac_Bilgileri WHERE Arac_PlakaNo='" + plakaNo_f.Text + "'");
            // Bu kod satırı textbox girişlerini sıfırlar
            donus_km.Text = Km_gidis.Text; belgeNo.Text = "";
        }

        private void EditMode_Click(object sender, EventArgs e)
        {
            
            editMode = !editMode;
            if (editMode)
            {
                // Düzenleme modu aktif ise gerekli yapılandırılmalar
                editButton.Width = 100;
                ekle_km.Visible = false;
                km_sil.Visible = false;
                belgeNo.Enabled = false;
                group_No.Height = 154;
                labelEdit.Visible = true;

                donus_km.BackColor =Color.Thistle;
                km_date.BackColor = Color.Thistle;
                Km_gidis.BackColor = Color.Thistle;
                belgeNo.BackColor = Color.Thistle;
                cancel.Visible = true;
                cancel.Location = new Point(cancel.Location.X,cancel.Location.Y+39);


            }
            else {
                // Düzenleme modu pasif ise gerekli yapılandırılmalar
                EditClose();

                if (belgeNo.Text!="")
                {
                    is_ortagi = "";
                    if (mavi_CheckBox.Checked == true) is_ortagi += mavi_CheckBox.Text + ", ";
                    if (tepe_CheckBox.Checked == true) is_ortagi += tepe_CheckBox.Text + ", ";
                    if (kekova_CheckBox.Checked == true) is_ortagi += kekova_CheckBox.Text + ", ";
                    if (niti_CheckBox.Checked == true) is_ortagi += niti_CheckBox.Text + ", ";
                    if (diger_CheckBox.Checked == true) is_ortagi += diger_Textbox.Text + ", ";
                    if (is_ortagi.Length > 2) is_ortagi = is_ortagi.Substring(0, is_ortagi.Length - 2);

                    veriTabani.FaturaGuncelle(belgeNo.Text, plakaNo_f.Text, "" + surucuAdi_Km.SelectedValue, is_ortagi, "" + sehir_Km.SelectedValue, donus_km.Text, km_date.Text);
                    ViewGüncelle();
                }

            }


        }
        private void EditClose() {

            editButton.Width = 39;
            ekle_km.Visible = true;
            km_sil.Visible = true;
            belgeNo.Enabled = true;
            group_No.Height = 134;
            labelEdit.Visible = false;

            donus_km.BackColor = Color.White;
            km_date.BackColor = Color.White;
            Km_gidis.BackColor = Color.White;
            belgeNo.BackColor = Color.White;
            cancel.Visible = false;
            cancel.Location = new Point(cancel.Location.X, cancel.Location.Y - 39);
        }

        private void Fatura_Bilgileri_DoubleClick(object sender, EventArgs e)
        {
            if (editMode)
            {
                belgeNo.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Belge_No").ToString();
                donus_km.Text= gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Donus_Km").ToString();
                surucuAdi_Km.Text= gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Surucu").ToString();
                plakaNo_f.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Plaka_No").ToString();

            }
            
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            EditClose();
            editMode = false;
        }

        private void Fatura_Bilgileri_Click(object sender, EventArgs e)
        {

        }
    }
}
