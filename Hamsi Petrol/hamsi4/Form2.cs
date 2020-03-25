using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hamsi4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void girişbutton1_Click(object sender, EventArgs e)
        {
            if (txtkullanıcıadı.Text == "petrolpersonel" && txtşifre.Text == "12345") // Eğer kullanıcı adı: petrolpersonel ve şifre:12345 ise
            {
                Form1 yeni = new Form1(); //Yeni formu aç.
                yeni.Show(); //Yeni formu göster.
                this.Hide(); //Bu formu gizle.
            }
            else
            {
                MessageBox.Show("Yanlış Kullanıcı Adı veya Şifre Girdiniz."); //Değilse mesaj kutusunu aç " Yanlış Kullanıcı Adı veya Şifre Giriniz " yazdır.
            }
        }
    }
}
