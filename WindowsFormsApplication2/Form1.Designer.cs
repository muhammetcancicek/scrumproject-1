namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.giris_button = new System.Windows.Forms.Button();
            this.kul_adı_text = new System.Windows.Forms.TextBox();
            this.kul_sifre_text = new System.Windows.Forms.TextBox();
            this.yonetici_button = new System.Windows.Forms.CheckBox();
            this.kayıt_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // giris_button
            // 
            this.giris_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.giris_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.giris_button.Location = new System.Drawing.Point(833, 184);
            this.giris_button.Name = "giris_button";
            this.giris_button.Size = new System.Drawing.Size(237, 73);
            this.giris_button.TabIndex = 0;
            this.giris_button.Text = "GİRİŞ YAP";
            this.giris_button.UseVisualStyleBackColor = false;
            this.giris_button.Click += new System.EventHandler(this.giris_button_Click);
            // 
            // kul_adı_text
            // 
            this.kul_adı_text.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kul_adı_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kul_adı_text.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kul_adı_text.Location = new System.Drawing.Point(831, 44);
            this.kul_adı_text.Name = "kul_adı_text";
            this.kul_adı_text.Size = new System.Drawing.Size(239, 24);
            this.kul_adı_text.TabIndex = 1;
            this.kul_adı_text.Text = "can";
            // 
            // kul_sifre_text
            // 
            this.kul_sifre_text.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kul_sifre_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kul_sifre_text.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kul_sifre_text.Location = new System.Drawing.Point(833, 114);
            this.kul_sifre_text.Name = "kul_sifre_text";
            this.kul_sifre_text.Size = new System.Drawing.Size(237, 24);
            this.kul_sifre_text.TabIndex = 2;
            this.kul_sifre_text.Text = "1973";
            // 
            // yonetici_button
            // 
            this.yonetici_button.AutoSize = true;
            this.yonetici_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yonetici_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yonetici_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.yonetici_button.Location = new System.Drawing.Point(833, 290);
            this.yonetici_button.Name = "yonetici_button";
            this.yonetici_button.Size = new System.Drawing.Size(129, 22);
            this.yonetici_button.TabIndex = 3;
            this.yonetici_button.Text = "yönetici girişi";
            this.yonetici_button.UseVisualStyleBackColor = false;
            this.yonetici_button.CheckedChanged += new System.EventHandler(this.yonetici_button_CheckedChanged);
            // 
            // kayıt_button
            // 
            this.kayıt_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kayıt_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayıt_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kayıt_button.Location = new System.Drawing.Point(968, 284);
            this.kayıt_button.Name = "kayıt_button";
            this.kayıt_button.Size = new System.Drawing.Size(102, 32);
            this.kayıt_button.TabIndex = 4;
            this.kayıt_button.Text = "KAYDOL";
            this.kayıt_button.UseVisualStyleBackColor = false;
            this.kayıt_button.Click += new System.EventHandler(this.kayıt_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources._39506059_office_wallpapers;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1130, 710);
            this.Controls.Add(this.giris_button);
            this.Controls.Add(this.kayıt_button);
            this.Controls.Add(this.kul_adı_text);
            this.Controls.Add(this.kul_sifre_text);
            this.Controls.Add(this.yonetici_button);
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button giris_button;
        private System.Windows.Forms.TextBox kul_adı_text;
        private System.Windows.Forms.TextBox kul_sifre_text;
        private System.Windows.Forms.CheckBox yonetici_button;
        private System.Windows.Forms.Button kayıt_button;
    }
}