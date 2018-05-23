namespace WindowsFormsApplication2
{
    partial class kayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.isim_text = new System.Windows.Forms.TextBox();
            this.sifre_text = new System.Windows.Forms.TextBox();
            this.eposta_text = new System.Windows.Forms.TextBox();
            this.telefon_text = new System.Windows.Forms.TextBox();
            this.adres_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BTNkayit = new System.Windows.Forms.Button();
            this.yonetici_check = new System.Windows.Forms.CheckBox();
            this.personel_groupbox = new System.Windows.Forms.GroupBox();
            this.personel_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // isim_text
            // 
            this.isim_text.BackColor = System.Drawing.Color.Silver;
            this.isim_text.Location = new System.Drawing.Point(185, 22);
            this.isim_text.Name = "isim_text";
            this.isim_text.Size = new System.Drawing.Size(100, 22);
            this.isim_text.TabIndex = 0;
            this.isim_text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sifre_text
            // 
            this.sifre_text.BackColor = System.Drawing.Color.Silver;
            this.sifre_text.Location = new System.Drawing.Point(181, 79);
            this.sifre_text.Name = "sifre_text";
            this.sifre_text.Size = new System.Drawing.Size(100, 22);
            this.sifre_text.TabIndex = 1;
            this.sifre_text.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // eposta_text
            // 
            this.eposta_text.BackColor = System.Drawing.Color.Silver;
            this.eposta_text.Location = new System.Drawing.Point(181, 171);
            this.eposta_text.Name = "eposta_text";
            this.eposta_text.Size = new System.Drawing.Size(100, 22);
            this.eposta_text.TabIndex = 2;
            this.eposta_text.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // telefon_text
            // 
            this.telefon_text.Location = new System.Drawing.Point(159, 15);
            this.telefon_text.Name = "telefon_text";
            this.telefon_text.Size = new System.Drawing.Size(100, 22);
            this.telefon_text.TabIndex = 3;
            // 
            // adres_text
            // 
            this.adres_text.Location = new System.Drawing.Point(159, 56);
            this.adres_text.Name = "adres_text";
            this.adres_text.Size = new System.Drawing.Size(100, 22);
            this.adres_text.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "KULLANICI ADI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(28, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "SIFRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(28, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "E POSTA";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "TELEFON";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(6, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "ADRES";
            // 
            // BTNkayit
            // 
            this.BTNkayit.BackColor = System.Drawing.Color.Black;
            this.BTNkayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTNkayit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNkayit.Location = new System.Drawing.Point(185, 349);
            this.BTNkayit.Name = "BTNkayit";
            this.BTNkayit.Size = new System.Drawing.Size(103, 30);
            this.BTNkayit.TabIndex = 10;
            this.BTNkayit.Text = "KAYIT OL";
            this.BTNkayit.UseVisualStyleBackColor = false;
            this.BTNkayit.Click += new System.EventHandler(this.button1_Click);
            // 
            // yonetici_check
            // 
            this.yonetici_check.AutoSize = true;
            this.yonetici_check.BackColor = System.Drawing.Color.Black;
            this.yonetici_check.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.yonetici_check.Location = new System.Drawing.Point(31, 358);
            this.yonetici_check.Name = "yonetici_check";
            this.yonetici_check.Size = new System.Drawing.Size(136, 21);
            this.yonetici_check.TabIndex = 11;
            this.yonetici_check.Text = "YONETICI KAYIT";
            this.yonetici_check.UseVisualStyleBackColor = false;
            this.yonetici_check.CheckedChanged += new System.EventHandler(this.yonetici_check_CheckedChanged);
            // 
            // personel_groupbox
            // 
            this.personel_groupbox.BackColor = System.Drawing.Color.Transparent;
            this.personel_groupbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.personel_groupbox.Controls.Add(this.label4);
            this.personel_groupbox.Controls.Add(this.label5);
            this.personel_groupbox.Controls.Add(this.telefon_text);
            this.personel_groupbox.Controls.Add(this.adres_text);
            this.personel_groupbox.Location = new System.Drawing.Point(22, 231);
            this.personel_groupbox.Name = "personel_groupbox";
            this.personel_groupbox.Size = new System.Drawing.Size(358, 101);
            this.personel_groupbox.TabIndex = 12;
            this.personel_groupbox.TabStop = false;
            this.personel_groupbox.Enter += new System.EventHandler(this.personel_groupbox_Enter);
            // 
            // kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources._39506059_office_wallpapers;
            this.ClientSize = new System.Drawing.Size(447, 459);
            this.Controls.Add(this.personel_groupbox);
            this.Controls.Add(this.yonetici_check);
            this.Controls.Add(this.BTNkayit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eposta_text);
            this.Controls.Add(this.sifre_text);
            this.Controls.Add(this.isim_text);
            this.Name = "kayit";
            this.Text = "kayit";
            this.Load += new System.EventHandler(this.kayit_Load);
            this.personel_groupbox.ResumeLayout(false);
            this.personel_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox isim_text;
        private System.Windows.Forms.TextBox sifre_text;
        private System.Windows.Forms.TextBox eposta_text;
        private System.Windows.Forms.TextBox telefon_text;
        private System.Windows.Forms.TextBox adres_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTNkayit;
        private System.Windows.Forms.CheckBox yonetici_check;
        private System.Windows.Forms.GroupBox personel_groupbox;
    }
}