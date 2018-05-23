using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        İŞ_PLALAMA isplanlama = new İŞ_PLALAMA();  //burası merkez form ekranı iş planla burada oluşturuluyor ve bilgiler "isplanlama" dan çekiliyor 

    


        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            personelEkle p1 = new personelEkle() { PerIsim = "can", PerSifre = "1973", Perrenk = 0, PerEposta = "muhammetcancicek@gmail.com", PerAdres = "sedat özcanögrenci yurdu", PerSeviye = 100, PerTelf = "546 738 23 84" };
            yonetciEkle y1 = new yonetciEkle() { YonetEposta = "yonetici_aglayınyonetciyim@gmail.com", YonetIsım = "yonetici", YonetSifre = "1" };
            isplanlama.etkinrenk = p1.Perrenk;
            isplanlama.perlist.Add(p1);
            isplanlama.yoneticilist.Add(y1); 
            

        }

        private void kayıt_button_Click(object sender, EventArgs e)
        {
            kayit kyt = new kayit(this.isplanlama);
            kyt.Show();//kullanıcı veya yönetici ekleme
            


        }

        private void yonetici_button_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void giris_button_Click(object sender, EventArgs e)
        {
            if (yonetici_button.Checked)
            {
                foreach (var yonetici in isplanlama.yoneticilist)
                {
                    if (yonetici.YonetIsım == kul_adı_text.Text && yonetici.YonetSifre == kul_sifre_text.Text)
                    {
                        isplanlama.yoneticimi = true;
                        MessageBox.Show("yonetici girisi saglandi...");
                         İs_Akis_Tablosu isakıs = new İs_Akis_Tablosu(isplanlama);
                         isakıs.Show();

                    }//if 2

                    else MessageBox.Show("yönetici girisi sağlanamadi...");
                }//foreach
            }//if 1

            else
            {
                foreach (var Personel in isplanlama.perlist)
                {
                    if (Personel.PerIsim == kul_adı_text.Text && Personel.PerSifre == kul_sifre_text.Text)
                    {
                        isplanlama.etkinkisi = Personel.PerIsim;
                        isplanlama.yoneticimi = false;
                        isplanlama.etkinrenk = Personel.Perrenk;
                        MessageBox.Show("personel girisi saglandi...");
                        İs_Akis_Tablosu isakıs = new İs_Akis_Tablosu(isplanlama);
                        isakıs.Show();
                    }

                    else MessageBox.Show("giris saglanamadi...");
                }
            }



        }
    }
}
