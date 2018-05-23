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
    public partial class kayit : Form
    {
        İŞ_PLALAMA isplanla;


       
    public kayit (İŞ_PLALAMA isplanla)
        {
            InitializeComponent();
            this.isplanla = isplanla;
        }
       
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(yonetici_check.Checked))
            {
                personelEkle pers = new personelEkle();
                kişiKayit(pers);
                isplanla.renkkodu++;
            }
            else
            {
                yonetciEkle yonet = new yonetciEkle();
                yoneticikayit(yonet);
            }

            MessageBox.Show("sayın" + isim_text.Text + "   iş listesine kendinizi eklediniz...");
            this.Close();

        }
        public void yoneticikayit(yonetciEkle yonet)
        {
            yonet.YonetEposta = eposta_text.Text;
            yonet.YonetIsım = isim_text.Text;
            yonet.YonetSifre = sifre_text.Text;
            isplanla.yoneticilist.Add(yonet);
        }

         public void kişiKayit(personelEkle pers)
        {
            pers.PerSifre = sifre_text.Text;
            pers.PerAdres = adres_text.Text;
            pers.PerIsim = isim_text.Text;
            pers.PerTelf = telefon_text.Text;
            pers.PerEposta = eposta_text.Text;
            isplanla.perlist.Add(pers);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void personel_groupbox_Enter(object sender, EventArgs e)
        {
            
        }

        private void yonetici_check_CheckedChanged(object sender, EventArgs e)
        {
            if (yonetici_check.Checked)
                personel_groupbox.Visible = false;
            else personel_groupbox.Visible = true;
        }

        private void kayit_Load(object sender, EventArgs e)
        {

        }
    }
}
