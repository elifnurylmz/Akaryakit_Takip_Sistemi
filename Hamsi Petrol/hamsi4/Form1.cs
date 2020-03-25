using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hamsi4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*                                                                         SAKARYA ÜNİVERSİTESİ
                                                                          BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
                                                                            BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
                                                                               NESNEYE DAYALI PROGRAMLAMA DERSİ
                                                                                   2019-2020 BAHAR DÖNEMİ
                                                  ÖDEV NUMARASI..........: 
                                                  ÖĞRENCİ ADI............: Elif Nur Yılmaz
                                                  ÖĞRENCİ NUMARASI.......: B191200010
                                                  DERSİN ALINDIĞI GRUP...: 
*/


        //Data Source=LAPTOP-4QR1NNEL\SQLEXPRESS;Initial Catalog="Akaryakıt Takip";Integrated Security=True
  
        private readonly SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-4QR1NNEL\SQLEXPRESS;Initial Catalog=Akaryakıt Takip;Integrated Security=True");
        public SqlConnection Baglanti => baglanti;
        
        
        void listele() {
            
            //KURŞUNSUZ 95 İÇİN SQLDEN VERİLERİ ALIYORUZ
            
            Baglanti.Open(); //SQL Command sql ile c# geliştirirken kullandığımız komut kodudur.
            SqlCommand komut = new SqlCommand("Select * From TBLBENZIN where petroltur='MaxKursun95' ", Baglanti); /*Petrol türü max kurşunsuza eşit olduğunda tblbenzin
            tablosundan seç.*/
            SqlDataReader dr = komut.ExecuteReader(); /*data reader ile verileri okuyoruz - komut.executereader ise veritabanınde seleks orbisiyle çektiğimiz kayıtların 
            veri akışını sağlıyoruz */
            while (dr.Read())
            {
                lblkursunsuz95.Text = dr[3].ToString();//Kurşunsuzun satış fiyatını 3.parametreden string cinsinden alıyoruz.
                prgkursunsuz95.Value = int.Parse(dr[4].ToString());//progressbarın stoğunu SQLdeki 4.parametreden alıyoruz.
                lblmaxkurşunsuz95lt.Text = dr[4].ToString();//Depodaki benzin miktarını SQLdeki 4.parametredeki stoktan alıyoruz.Ve progressbarın yanına yazıyoruz.
            }
            Baglanti.Close();
            //Diğer benzin türleri içinde aynı kodlamaları benzin türlerine göre düzenleyip tekrar yazıyoruz.
           
            
            
            //MAX EURO DİESEL İÇİN SQLDEN VERİLERİ ALIYORUZ

            Baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select * From TBLBENZIN where petroltur='MaxEuroDiesel' ", Baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblmaxeurodiesel.Text = dr2[3].ToString();
                prgmaxeurodiesel.Value = int.Parse(dr2[4].ToString());
                lblmaxeurodiesellt.Text = dr2[4].ToString();
            }
            Baglanti.Close();


            //PRO EURO DİESEL İÇİN SQLDEN VERİLERİ ALIYORUZ
            Baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select * From TBLBENZIN where petroltur='ProEuroDiesel' ", Baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblproeurodiesel.Text = dr3[3].ToString();
                prgproeurodiesel.Value = int.Parse(dr3[4].ToString());
                lblproeurodiesellt.Text = dr3[4].ToString();
            }
            Baglanti.Close();

            //GAZ İÇİN SQLDEN VERİLERİ ALIYORUZ
            Baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select * From TBLBENZIN where petroltur='Gaz' ", Baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblgaz.Text = dr4[3].ToString();
                prggaz.Value = int.Parse(dr4[4].ToString());
                lblgazlt.Text = dr4[4].ToString();
            }
            Baglanti.Close();

            Baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select *from TBLKASA", Baglanti); // SQLdeki TBLKASA tablosundan seçiyoruz 
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblkasa.Text = dr6[0].ToString(); //Kasaya tablodaki değer giriliyor
            }

            Baglanti.Close();

        }
        private void Form1_Load(object sender, EventArgs e) //Voidle yaptığımız fonksiyonu form 1 yüklendiğinde kullanıyoruz.
        {
            listele();
        }

        // Litre başına tutar hesabını yapıyoruz. Müşteri kaç litre alırsa ona göre tutar belirliyoruz.Bunu her petrol türü için tek tek yazıyoruz.
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz95, litre, tutar; //Double cinsinden değişkenler atıyoruz.Bunları litre başına tutar hesaplamak için kullanacağz.
            kursunsuz95 = Convert.ToDouble(lblkursunsuz95.Text);//Kurşunsuz95 in litre fiyatını alıp kursunsuz95 değişkenimize atıyoruz.
            litre = Convert.ToDouble(nmrkursunsuzlt.Value);//Kaç litre olucağını formdaki litre kısmımızdan alıyoruz. 
            tutar = kursunsuz95 * litre; // Litre başına olan fiyatla kaç litre olduğunu çarpıp tutarımızı hesaplıyoruz.
            txtkurşunsuz.Text = tutar.ToString();// Tutarımızı gereken bölüme yazdırıyoruz.
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            double maxeurodiesel, litre, tutar;
            maxeurodiesel = Convert.ToDouble(lblmaxeurodiesel.Text);
            litre = Convert.ToDouble(nmrmaxeurolt.Value);
            tutar = maxeurodiesel * litre;
            txtmaxeuro.Text = tutar.ToString();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            double proeurodiesel, litre, tutar;
            proeurodiesel = Convert.ToDouble(lblproeurodiesel.Text);
            litre = Convert.ToDouble(nmrproeurolt.Value);
            tutar = proeurodiesel * litre;
            txtproeuro.Text = tutar.ToString();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            double gaz, litre, tutar;
            gaz = Convert.ToDouble(lblgaz.Text);
            litre = Convert.ToDouble(nmrgazlt.Value);
            tutar = gaz * litre;
            txtgaz.Text = tutar.ToString();
        }
        // Depo doldur butonuna tıkladığımızda müşterinin plakasını, aldığı benzin türünü ,litre ve tutarını SQL veritabanımıza yazdırıyoruz. 
        private void btndepodoldur_Click(object sender, EventArgs e)
        {
            if(nmrkursunsuzlt.Value != 0) //Eğer MaxKurşunsuzun alınan litresi 0'a eşit değilse (Bunu diğer petrol türleri için ayrı ayarı if döngüsüyle yazdıracağız)
            {
                Baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBLHAREKET (PLAKA,PETROLTURU,LITRE,FIYAT) values (@p1, @p2, @p3 ,@p4)", Baglanti); /*TBL HAREKET in içine yerleştir
                plaka p1(parametre1) ,petrol türü p2 , litre p3 ve fiyat p4 */
                komut.Parameters.AddWithValue("@p1", txtplaka.Text); //Plakayı SQLdeki p1 parametresine yaz.
                komut.Parameters.AddWithValue("@p2", "MaxKursunsuz95");// SQLdeki p2 parametresine maxkurşunsuz95 yazdır.
                komut.Parameters.AddWithValue("@p3", nmrkursunsuzlt.Value); //Alınan litreyi SQLdeki p3 paremetresine gir.
                komut.Parameters.AddWithValue("@p4", decimal.Parse(txtkurşunsuz.Text)); /* Ödenmesi gereken tutarı yukarıda hesaplatmıştık.Şimdi hesapladığımız tutarı
                SQLdeki p4 paremetremize yazdırıyoruz.*/
                komut.ExecuteNonQuery();
                Baglanti.Close();
                

                Baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update TBLKASA set mıktar = mıktar + @p1", Baglanti); /*Kasadaki miktarımızı her seferinde güncelleyip SQLdeki
                TBLKASA daki p1 parametresine yazdırıyoruz.*/
                komut2.Parameters.AddWithValue("@p1", decimal.Parse(txtkurşunsuz.Text));
                komut2.ExecuteNonQuery();
                Baglanti.Close();
                

                Baglanti.Open();
                SqlCommand komut3 = new SqlCommand("update TBLBENZIN set stok=stok-@p1 where PETROLTUR='MaxKursun95'",Baglanti); /* Stoktaki petrol miktarımızı her
                seferinde güncelleyip stoktan harcanan p1 parametresini azaltıyoruz*/
                komut3.Parameters.AddWithValue("@p1", nmrkursunsuzlt.Value);
                komut3.ExecuteNonQuery();
                Baglanti.Close();
                MessageBox.Show("Satış Yapıldı.");
                listele();
         
            }

            //Diğerleri için aynı adımları tekrarlıyoruz.
            if (nmrmaxeurolt.Value != 0)
            {
                Baglanti.Open();
                SqlCommand komut4 = new SqlCommand("insert into TBLHAREKET (PLAKA,PETROLTURU,LITRE,FIYAT) values (@p1, @p2, @p3 ,@p4)", Baglanti);
                komut4.Parameters.AddWithValue("@p1", txtplaka.Text);
                komut4.Parameters.AddWithValue("@p2", "MaxEuroDiesel");
                komut4.Parameters.AddWithValue("@p3", nmrmaxeurolt.Value);
                komut4.Parameters.AddWithValue("@p4", decimal.Parse(txtmaxeuro.Text));
                komut4.ExecuteNonQuery();
                Baglanti.Close();


                Baglanti.Open();
                SqlCommand komut5 = new SqlCommand("update TBLKASA set mıktar = mıktar + @p1", Baglanti);
                komut5.Parameters.AddWithValue("@p1", decimal.Parse(txtmaxeuro.Text));
                komut5.ExecuteNonQuery();
                Baglanti.Close();


                Baglanti.Open();
                SqlCommand komut6 = new SqlCommand("update TBLBENZIN set stok=stok-@p1 where PETROLTUR='MaxEuroDiesel'", Baglanti);
                komut6.Parameters.AddWithValue("@p1", nmrmaxeurolt.Value);
                komut6.ExecuteNonQuery();
                Baglanti.Close();
                MessageBox.Show("Satış Yapıldı.");
                listele();


            }

            if (nmrproeurolt.Value != 0)
            {
                Baglanti.Open();
                SqlCommand komut7 = new SqlCommand("insert into TBLHAREKET (PLAKA,PETROLTURU,LITRE,FIYAT) values (@p1, @p2, @p3 ,@p4)", Baglanti);
                komut7.Parameters.AddWithValue("@p1", txtplaka.Text);
                komut7.Parameters.AddWithValue("@p2", "ProEuroDiesel");
                komut7.Parameters.AddWithValue("@p3", nmrproeurolt.Value);
                komut7.Parameters.AddWithValue("@p4", decimal.Parse(txtproeuro.Text));
                komut7.ExecuteNonQuery();
                Baglanti.Close();


                Baglanti.Open();
                SqlCommand komut8 = new SqlCommand("update TBLKASA set mıktar = mıktar + @p1", Baglanti);
                komut8.Parameters.AddWithValue("@p1", decimal.Parse(txtproeuro.Text));
                komut8.ExecuteNonQuery();
                Baglanti.Close();


                Baglanti.Open();
                SqlCommand komut9 = new SqlCommand("update TBLBENZIN set stok=stok-@p1 where PETROLTUR='ProEuroDiesel'", Baglanti);
                komut9.Parameters.AddWithValue("@p1", nmrproeurolt.Value);
                komut9.ExecuteNonQuery();
                Baglanti.Close();
                MessageBox.Show("Satış Yapıldı.");
                listele();


            }

            if (nmrgazlt.Value != 0)
            {
                Baglanti.Open();
                SqlCommand komut10 = new SqlCommand("insert into TBLHAREKET (PLAKA,PETROLTURU,LITRE,FIYAT) values (@p1, @p2, @p3 ,@p4)", Baglanti);
                komut10.Parameters.AddWithValue("@p1", txtplaka.Text);
                komut10.Parameters.AddWithValue("@p2", "Gaz");
                komut10.Parameters.AddWithValue("@p3", nmrgazlt.Value);
                komut10.Parameters.AddWithValue("@p4", decimal.Parse(txtgaz.Text));
                komut10.ExecuteNonQuery();
                Baglanti.Close();


                Baglanti.Open();
                SqlCommand komut11 = new SqlCommand("update TBLKASA set mıktar = mıktar + @p1", Baglanti);
                komut11.Parameters.AddWithValue("@p1", decimal.Parse(txtgaz.Text));
                komut11.ExecuteNonQuery();
                Baglanti.Close();


                Baglanti.Open();
                SqlCommand komut12 = new SqlCommand("update TBLBENZIN set stok=stok-@p1 where PETROLTUR='Gaz'", Baglanti);
                komut12.Parameters.AddWithValue("@p1", nmrgazlt.Value);
                komut12.ExecuteNonQuery();
                Baglanti.Close();
                MessageBox.Show("Satış Yapıldı.");
                listele();


            }


        }
    }
}