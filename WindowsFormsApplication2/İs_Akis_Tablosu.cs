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
    public partial class İs_Akis_Tablosu : Form
    {


        İŞ_PLALAMA isplanlama;


        public İs_Akis_Tablosu(İŞ_PLALAMA isplanla)
        {
            InitializeComponent();
            isplanlama = isplanla;
        }
        public İs_Akis_Tablosu()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }



        private void İs_Akis_Tablosu_Load(object sender, EventArgs e)
        {
            if(isplanlama.yoneticimi==false)
            {
                yoneticiDuzenleBTN.Visible = false;
                grupboxTaskEkle.Visible = false;
                groupBoxPrsnSorgula.Visible = false;

                storygosterTXT.Enabled = false;
                taskgosterTXT.Enabled = false;
                persgosterTXT.Enabled = false;
                puangosterTXT.Enabled = false;
                durumgosterTXT.Enabled = false;





            }






            flowPanelNotStared.AllowDrop = true;
            flowPanelNotStared.DragOver += new DragEventHandler(panel_DragOver);
            flowPanelNotStared.DragDrop += new DragEventHandler(panel_DragDrop);
            flowPanelINPROGRES.AllowDrop = true;
            flowPanelINPROGRES.DragOver += new DragEventHandler(panel_DragOver);
            flowPanelINPROGRES.DragDrop += new DragEventHandler(panel_DragDrop);
            flowPanelDONE.AllowDrop = true;
            flowPanelDONE.DragOver += new DragEventHandler(panel_DragOver);
            flowPanelDONE.DragDrop += new DragEventHandler(panel_DragDrop);
            System.Windows.Forms.Panel PanelNew = new Panel();
            PanelNew.BackColor = Color.White;
            PanelNew.Size = new Size(265, 125);
            PanelNew.MouseDown += c_MouseDown;

            System.Windows.Forms.TextBox txbGorev = new TextBox();
            txbGorev.Text = "STORY = Sifre olusturma "  + Environment.NewLine + "TASK =Criptolama algoritması " ;
            txbGorev.Enabled = false;
            txbGorev.BackColor = TransparencyKey;
            txbGorev.Multiline = true;
            txbGorev.Size = new Size(220, 125);
            PanelNew.Controls.Add(txbGorev);

            Gorev_ekle gorev1 = new Gorev_ekle();
            gorev1.GorevPuani = 6;//puan boş kalırsa hata veriyor
            gorev1.GorevStory = "Sifre olusturma";
            gorev1.GorevIcerigi = "Criptolama algoritması";
            isplanlama.GorevList.Add(gorev1);
            isplanlama.countGorev++;


            System.Windows.Forms.Panel PanelNew1 = new Panel();
            PanelNew1.BackColor = Color.White;
            PanelNew1.Size = new Size(265, 125);
            PanelNew1.MouseDown += c_MouseDown;
            flowPanelNotStared.Controls.Add(PanelNew);

            System.Windows.Forms.TextBox txbGorev1 = new TextBox();
            txbGorev1.Text = "STORY = Ürun listeleri " + Environment.NewLine + "TASK =Urun silme ";
            txbGorev1.Enabled = false;
            txbGorev1.BackColor = TransparencyKey;
            txbGorev1.Multiline = true;
            txbGorev1.Size = new Size(220, 125);

            Gorev_ekle gorev2 = new Gorev_ekle();
            gorev2.GorevPuani = 9;//puan boş kalırsa hata veriyor
            gorev2.GorevStory = "Ürun listeleri";
            gorev2.GorevIcerigi = "Urun silme";
            isplanlama.GorevList.Add(gorev2);
            isplanlama.countGorev++;

            int i;
            
            for(i=0; i<=isplanlama.countGorev ;i++)
            { 

            }
                
            PanelNew1.Controls.Add(txbGorev1);
            flowPanelNotStared.Controls.Add(PanelNew1);



        }


        void c_MouseDown(object sender, MouseEventArgs e)
        {
            Control currentControl = sender as Control;
            if (e.Button == MouseButtons.Left)
            {
                currentControl.DoDragDrop(currentControl, DragDropEffects.Move);
            }
        }

        //flowlayout panellerin içine atmayı kabul ettirme
        void panel_DragDrop(object sender, DragEventArgs e)
        {
            Control c = e.Data.GetData(e.Data.GetFormats()[0]) as Control;
            FlowLayoutPanel destination = sender as FlowLayoutPanel;
            FlowLayoutPanel source = (FlowLayoutPanel)c.Parent;
            if (c != null)
            {
                c.Location = destination.PointToClient(new Point(e.X, e.Y));//buradaki c senin tutup sürüklemekte olduğun label oluyor
                if (isplanlama.etkinrenk == 0)
                    c.BackColor = Color.Red;
                else if (isplanlama.etkinrenk == 1)
                    c.BackColor = Color.Blue;
                else if (isplanlama.etkinrenk == 2)
                    c.BackColor = Color.Pink;
                else if (isplanlama.etkinrenk == 3)
                    c.BackColor = Color.Yellow;
                else if (isplanlama.etkinrenk == 4)
                    c.BackColor = Color.Green;
                else c.BackColor = Color.White;


                destination.Controls.Add(c);//destination dediği şey sürükleyince bıraktığın stun oluyor
                                            // destination.BackColor = Color.Blue;

                //koşul yaz,buraya koşullar eklenebilir sürükleyip bıraktığın anda koşulu dener
            }
        }


        void panel_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gorev_ekle grv = new Gorev_ekle();
            grv.GorevPuani = Convert.ToInt16(PuanTxt.Text);//puan boş kalırsa hata veriyor
            grv.GorevStory = StoryTxt.Text;
            grv.GorevIcerigi = GorevTxt.Text;
            isplanlama.GorevList.Add(grv);
            isplanlama.countGorev++;


            System.Windows.Forms.Panel PanelNew = new Panel();
            PanelNew.BackColor = Color.White;
            PanelNew.Size = new Size(265, 125);
            PanelNew.MouseDown += c_MouseDown;


            System.Windows.Forms.TextBox txbGorev = new TextBox();
            txbGorev.Text ="STORY = "+StoryTxt.Text+ Environment.NewLine+ Environment.NewLine + "TASK =" +GorevTxt.Text;
            txbGorev.Enabled = false;
            txbGorev.BackColor = Color.Azure;
            txbGorev.Multiline = true;
            txbGorev.Size= new Size (220, 125);
            

            PanelNew.Controls.Add(txbGorev);


            System.Windows.Forms.TextBox txbstory = new TextBox();
            txbstory.Text = StoryTxt.Text;
            txbstory.Enabled = false;
            txbstory.BackColor = TransparencyKey;
            PanelNew.Controls.Add(txbstory);

            System.Windows.Forms.TextBox txbpuan = new TextBox();
            txbpuan.Text = PuanTxt.Text;
            txbpuan.Enabled = false;
            txbpuan.BackColor = TransparencyKey;
            PanelNew.Controls.Add(txbpuan);




            //System.Windows.Forms.Label lblStory = new Label();
            //lblStory.Font = new Font(lblStory.Font.Name, 15, lblStory.Font.Style, lblStory.Font.Unit);
            //lblStory.Text = StoryTxt.Text;
            //PanelNew.Controls.Add(lblStory); 236; 131


            flowPanelNotStared.Controls.Add(PanelNew);//panel içine panel atıyoruz,küçük paneli hangi flowLayoutPanel e atacağını gösteriyor


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void StoryTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var task in isplanlama.GorevList)
            {
                if (task.GorevStory == storyaraTXT.Text && task.GorevIcerigi == taskaraTXT.Text)
                {
                    storygosterTXT.Text = task.GorevStory;
                    taskgosterTXT.Text = task.GorevIcerigi;
                    durumgosterTXT.Text = task.GorevDurumu;
                    persgosterTXT.Text = task.GorevAlanPers;
                    puangosterTXT.Text = Convert.ToString(task.GorevPuani);

                }
                else continue;
            }

        }

        private void persgosterTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (var task in isplanlama.GorevList)
            {
                if (storyaraTXT.Text == task.GorevStory && taskaraTXT.Text == task.GorevIcerigi)
                {
                    task.GorevStory = storygosterTXT.Text;
                    task.GorevIcerigi = taskgosterTXT.Text;
                    task.GorevDurumu = durumgosterTXT.Text;
                    task.GorevAlanPers = persgosterTXT.Text;
                    task.GorevPuani = Convert.ToInt32(puangosterTXT.Text);
                }
                else MessageBox.Show("HATA!!! BILGILERI KONTROL EDIN...");
                MessageBox.Show("düzenlendi...");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (var task in isplanlama.GorevList)
            {
                if (storyaraTXT.Text == task.GorevStory && taskaraTXT.Text == task.GorevIcerigi)
                {
                    foreach (var pers in isplanlama.perlist)
                    {
                        if (isplanlama.etkinkisi == pers.PerIsim)
                        {
                            pers.gorevler += storygosterTXT + Environment.NewLine ;
                            task.GorevDurumu = "yapılıyor...";
                            task.GorevAlanPers = isplanlama.etkinkisi;
                            task.GorevBaslangiçTarihi = DateTime.Now;
                            MessageBox.Show(isplanlama.etkinkisi +  "  alındı");
                        }
                        
                    }

                }
                
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (var task in isplanlama.GorevList)
            {
                if (storyaraTXT.Text == task.GorevStory && taskaraTXT.Text == task.GorevIcerigi)
                {
                    foreach (var pers in isplanlama.perlist)
                    {
                        if (isplanlama.etkinkisi == pers.PerIsim)
                        {
                            pers.PerSeviye += task.GorevPuani;
                            task.GorevDurumu = "tamamlandi...";
                            task.GorevBitisTarihi = DateTime.Now;
                        }
                        
                    }
                }
                
                MessageBox.Show("MISSON COMPLATED (GOZLUK+SİGARA POZU... :D   )");
                
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var pers in isplanlama.perlist)
            {
                if (pers.PerIsim==perssorguTXT.Text)
                {
                    MessageBox.Show("personel adi  =" + pers.PerIsim + Environment.NewLine +" personel performansı  " + pers.PerSeviye + Environment.NewLine + "personelin yaptigi projeler ; " + pers.gorevler);
                }
            }
        }

        private void puangosterTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void cikisBTN_Click(object sender, EventArgs e)
        {
            isplanlama.etkinkisi = null;
            this.Close();

        }
    }
}

