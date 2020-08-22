using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Arac_Takip_v1._00
{
    class MsSQL
    {
        public SqlConnection baglanti;
        DataTable SorguTablo = new DataTable();
        public MsSQL()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-21VHGPU\\SQLEXPRESS; Initial Catalog=AracTakipDB;Integrated Security=True");
            
        }
     
        public Boolean Baglan() {
            try
            {
                baglanti.Open();
                return true;

            }
            catch (Exception)
            {
                return false;
            }

        }
        public Boolean Sorgu(String sorgu) {
            Boolean sonuc = true;
            if (Baglan())
            {
                //MessageBox.Show(sorgu);
                SqlDataAdapter SDA = new SqlDataAdapter(sorgu, baglanti);
                try
                {
                    
                    SDA.SelectCommand.ExecuteNonQuery();
                   // SorguSonucu = "" + SDA.SelectCommand.ExecuteScalar();                    
                   // SDA.Fill(SorguTablo);

                }
                catch (Exception e)
                {
                    MessageBox.Show("Sorguda Hata; "+e);
                    sonuc = false;
                }
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Veri Tabanına bağlanılamadı.! ");
                sonuc = false;
            }

            return sonuc;
        }

        public String SorguSonuc(String sorgu)
        {
            // Veri tabanımızdan olası bir durumda tek sonuç isteyecegimiz kod bloğu
            String sonuc = "";
            if (Baglan())
            {
                SqlDataAdapter SDA = new SqlDataAdapter(sorgu, baglanti);
                try
                {
                  sonuc=""+  SDA.SelectCommand.ExecuteScalar();
                }
                catch (Exception e)
                {
                    MessageBox.Show("HATA; "+e,"Bilgilendirme", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                baglanti.Close();
            }

            return sonuc;
        }

        public void KmGirisEkle(String Belge_No, String Plaka_No, String Surucu_Tc,String Is_Ortagi,String Sehir_Kodu,String Donus_Km,String Tarih)
        {
            if (Sorgu("INSERT INTO Fatura_Bilgileri VALUES (" + Belge_No + ",'" + Plaka_No + "',"+Surucu_Tc+ ",'" + Is_Ortagi + "'," + Sehir_Kodu + "," + Donus_Km + ",'" + TarihFormat(Tarih) + "')"))
            {
                //Arac Km bilgisini güncellediğimiz kod satırı
                Sorgu("UPDATE Arac_Bilgileri SET Arac_Km='" + Donus_Km + "' WHERE Arac_PlakaNo='" + Plaka_No + "'");
                MessageBox.Show("Kayıt İşlemi Başarıyla Gerçekleşti ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ekleme İşlemi Başarısız .! ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void VeriSil(String TabloAdi, String SutunAdi, String Veri)
        {
            DialogResult dialogResult = MessageBox.Show(SutunAdi + "=" + Veri + " Veri'yi silmek istediğinize, Emin misiniz ? ", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (dialogResult== DialogResult.Yes) { 
            if (Sorgu("DELETE FROM " + TabloAdi + " WHERE " + SutunAdi + " =" + Veri))
                {
                    MessageBox.Show(SutunAdi + "=" + Veri + " Veri Silindi ! ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {
                    MessageBox.Show("Silinecek Veri Yok ! ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        }
        public void YakitGirisi(String BelgeNo,String PlakaNo,String AlinanLitre,String ToplamTutar,String SurucuTc,String Tarih)
        {
            if (Sorgu("INSERT INTO Yakit_Bilgileri VALUES(" + BelgeNo + ",'" + PlakaNo + "'," + AlinanLitre.Replace(',','.') + "," + ToplamTutar.Replace(',','.') +","+SurucuTc+",'"+TarihFormat(Tarih)+"')"))
            {
                MessageBox.Show("Yakıt Girişi Basarılı","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Basarısız !","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void AracEkle(String PlakaNo,String Model,String Km)
        {
            if (Sorgu("INSERT INTO Arac_Bilgileri VALUES('" + PlakaNo + "','" + Model + "'," + Km + ")"))
            {
                MessageBox.Show("Arac Ekleme Basarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Basarısız !", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public  void SurucuEkle(String Tc,String Ad,String Soyad,String Telefon)
        {
            if (Sorgu("INSERT INTO Surucu_Bilgileri VALUES('" + Tc + "','" + Ad + "','" + Soyad + "','"+Telefon+"')"))
            {
                MessageBox.Show("Surucu Ekleme Basarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Basarısız !", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void FaturaGuncelle(String Belge_No, String Plaka_No, String Surucu_Tc, String Is_Ortagi, String Sehir_Kodu, String Donus_Km, String Tarih)
        {
            if (Sorgu("UPDATE Fatura_Bilgileri SET Arac_PlakaNo='" + Plaka_No + "',Surucu_TC=" + Surucu_Tc + ",Is_Ortagı='" + Is_Ortagi + "',Gidilen_Sehir=" + Sehir_Kodu + ",Donus_Km=" + Donus_Km + ",Tarih='"+TarihFormat(Tarih)+"' WHERE Belge_No=" + Belge_No))
            {
                //Arac Km bilgisini güncellediğimiz kod satırı
                Sorgu("UPDATE Arac_Bilgileri SET Arac_Km='" + Donus_Km + "' WHERE Arac_PlakaNo='" + Plaka_No + "'");
                MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşti ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Güncelleme İşlemi Başarısız .! ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public String TarihFormat(String s) {

            String gun = s.Substring(0, s.IndexOf('.'));
            s = s.Substring(gun.Length+1);
            String ay = s.Substring(0,s.IndexOf('.'));
            String yil = s.Substring(ay.Length+1);

            return yil + "-" + ay + "-" + gun;
        }
    }
}
