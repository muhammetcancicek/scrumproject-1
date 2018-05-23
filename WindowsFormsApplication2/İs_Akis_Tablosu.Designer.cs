namespace WindowsFormsApplication2
{
    partial class İs_Akis_Tablosu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(İs_Akis_Tablosu));
            this.flowPanelNotStared = new System.Windows.Forms.FlowLayoutPanel();
            this.flowPanelDONE = new System.Windows.Forms.FlowLayoutPanel();
            this.TaskEkleBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.StoryTxt = new System.Windows.Forms.TextBox();
            this.GorevTxt = new System.Windows.Forms.TextBox();
            this.PuanTxt = new System.Windows.Forms.TextBox();
            this.flowPanelINPROGRES = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxTaskSorgu = new System.Windows.Forms.GroupBox();
            this.yoneticiDuzenleBTN = new System.Windows.Forms.Button();
            this.btnGorevAl = new System.Windows.Forms.Button();
            this.btnTaskBitir = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.puangosterTXT = new System.Windows.Forms.TextBox();
            this.persgosterTXT = new System.Windows.Forms.TextBox();
            this.durumgosterTXT = new System.Windows.Forms.TextBox();
            this.taskgosterTXT = new System.Windows.Forms.TextBox();
            this.storygosterTXT = new System.Windows.Forms.TextBox();
            this.storyaraTXT = new System.Windows.Forms.TextBox();
            this.taskaraTXT = new System.Windows.Forms.TextBox();
            this.perssorguTXT = new System.Windows.Forms.TextBox();
            this.TaskSorguBTN = new System.Windows.Forms.Button();
            this.PersSorguBTN = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cikisBTN = new System.Windows.Forms.Button();
            this.grupboxTaskEkle = new System.Windows.Forms.GroupBox();
            this.groupBoxPrsnSorgula = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxTaskSorgu.SuspendLayout();
            this.grupboxTaskEkle.SuspendLayout();
            this.groupBoxPrsnSorgula.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowPanelNotStared
            // 
            this.flowPanelNotStared.BackColor = System.Drawing.Color.Transparent;
            this.flowPanelNotStared.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowPanelNotStared.Location = new System.Drawing.Point(48, 51);
            this.flowPanelNotStared.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowPanelNotStared.Name = "flowPanelNotStared";
            this.flowPanelNotStared.Size = new System.Drawing.Size(256, 429);
            this.flowPanelNotStared.TabIndex = 0;
            this.flowPanelNotStared.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // flowPanelDONE
            // 
            this.flowPanelDONE.BackColor = System.Drawing.Color.Transparent;
            this.flowPanelDONE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowPanelDONE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.flowPanelDONE.Location = new System.Drawing.Point(636, 51);
            this.flowPanelDONE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowPanelDONE.Name = "flowPanelDONE";
            this.flowPanelDONE.Size = new System.Drawing.Size(257, 429);
            this.flowPanelDONE.TabIndex = 2;
            this.flowPanelDONE.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel3_Paint);
            // 
            // TaskEkleBTN
            // 
            this.TaskEkleBTN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TaskEkleBTN.Location = new System.Drawing.Point(619, 121);
            this.TaskEkleBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TaskEkleBTN.Name = "TaskEkleBTN";
            this.TaskEkleBTN.Size = new System.Drawing.Size(112, 52);
            this.TaskEkleBTN.TabIndex = 3;
            this.TaskEkleBTN.Text = "GOREV EKLE";
            this.TaskEkleBTN.UseVisualStyleBackColor = true;
            this.TaskEkleBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(85, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "STORY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(386, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "TASK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(572, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "TASK PUANI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(96, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "NOT STARTED";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(398, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "IN PROGRESS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(724, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "DONE";
            // 
            // StoryTxt
            // 
            this.StoryTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StoryTxt.Location = new System.Drawing.Point(20, 63);
            this.StoryTxt.Multiline = true;
            this.StoryTxt.Name = "StoryTxt";
            this.StoryTxt.Size = new System.Drawing.Size(256, 166);
            this.StoryTxt.TabIndex = 10;
            this.StoryTxt.TextChanged += new System.EventHandler(this.StoryTxt_TextChanged);
            // 
            // GorevTxt
            // 
            this.GorevTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GorevTxt.Location = new System.Drawing.Point(304, 63);
            this.GorevTxt.Multiline = true;
            this.GorevTxt.Name = "GorevTxt";
            this.GorevTxt.Size = new System.Drawing.Size(257, 166);
            this.GorevTxt.TabIndex = 11;
            this.GorevTxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // PuanTxt
            // 
            this.PuanTxt.BackColor = System.Drawing.Color.White;
            this.PuanTxt.Location = new System.Drawing.Point(588, 64);
            this.PuanTxt.Multiline = true;
            this.PuanTxt.Name = "PuanTxt";
            this.PuanTxt.Size = new System.Drawing.Size(165, 30);
            this.PuanTxt.TabIndex = 12;
            this.PuanTxt.Text = "1";
            this.PuanTxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // flowPanelINPROGRES
            // 
            this.flowPanelINPROGRES.BackColor = System.Drawing.Color.Transparent;
            this.flowPanelINPROGRES.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowPanelINPROGRES.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.flowPanelINPROGRES.Location = new System.Drawing.Point(341, 51);
            this.flowPanelINPROGRES.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowPanelINPROGRES.Name = "flowPanelINPROGRES";
            this.flowPanelINPROGRES.Size = new System.Drawing.Size(257, 429);
            this.flowPanelINPROGRES.TabIndex = 3;
            this.flowPanelINPROGRES.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint_1);
            // 
            // groupBoxTaskSorgu
            // 
            this.groupBoxTaskSorgu.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTaskSorgu.Controls.Add(this.yoneticiDuzenleBTN);
            this.groupBoxTaskSorgu.Controls.Add(this.btnGorevAl);
            this.groupBoxTaskSorgu.Controls.Add(this.btnTaskBitir);
            this.groupBoxTaskSorgu.Controls.Add(this.label11);
            this.groupBoxTaskSorgu.Controls.Add(this.label10);
            this.groupBoxTaskSorgu.Controls.Add(this.label9);
            this.groupBoxTaskSorgu.Controls.Add(this.label8);
            this.groupBoxTaskSorgu.Controls.Add(this.label7);
            this.groupBoxTaskSorgu.Controls.Add(this.puangosterTXT);
            this.groupBoxTaskSorgu.Controls.Add(this.persgosterTXT);
            this.groupBoxTaskSorgu.Controls.Add(this.durumgosterTXT);
            this.groupBoxTaskSorgu.Controls.Add(this.taskgosterTXT);
            this.groupBoxTaskSorgu.Controls.Add(this.storygosterTXT);
            this.groupBoxTaskSorgu.ForeColor = System.Drawing.Color.Yellow;
            this.groupBoxTaskSorgu.Location = new System.Drawing.Point(908, 51);
            this.groupBoxTaskSorgu.Name = "groupBoxTaskSorgu";
            this.groupBoxTaskSorgu.Size = new System.Drawing.Size(441, 429);
            this.groupBoxTaskSorgu.TabIndex = 13;
            this.groupBoxTaskSorgu.TabStop = false;
            // 
            // yoneticiDuzenleBTN
            // 
            this.yoneticiDuzenleBTN.BackColor = System.Drawing.Color.Purple;
            this.yoneticiDuzenleBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yoneticiDuzenleBTN.BackgroundImage")));
            this.yoneticiDuzenleBTN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.yoneticiDuzenleBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yoneticiDuzenleBTN.ForeColor = System.Drawing.Color.Purple;
            this.yoneticiDuzenleBTN.Location = new System.Drawing.Point(201, 355);
            this.yoneticiDuzenleBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.yoneticiDuzenleBTN.Name = "yoneticiDuzenleBTN";
            this.yoneticiDuzenleBTN.Size = new System.Drawing.Size(52, 54);
            this.yoneticiDuzenleBTN.TabIndex = 20;
            this.yoneticiDuzenleBTN.Text = "O";
            this.yoneticiDuzenleBTN.UseVisualStyleBackColor = false;
            this.yoneticiDuzenleBTN.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnGorevAl
            // 
            this.btnGorevAl.BackColor = System.Drawing.Color.Purple;
            this.btnGorevAl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGorevAl.BackgroundImage")));
            this.btnGorevAl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGorevAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGorevAl.ForeColor = System.Drawing.Color.Purple;
            this.btnGorevAl.Location = new System.Drawing.Point(31, 353);
            this.btnGorevAl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGorevAl.Name = "btnGorevAl";
            this.btnGorevAl.Size = new System.Drawing.Size(128, 56);
            this.btnGorevAl.TabIndex = 18;
            this.btnGorevAl.Text = "GOREVI AL";
            this.btnGorevAl.UseVisualStyleBackColor = false;
            this.btnGorevAl.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnTaskBitir
            // 
            this.btnTaskBitir.BackColor = System.Drawing.Color.Purple;
            this.btnTaskBitir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTaskBitir.BackgroundImage")));
            this.btnTaskBitir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTaskBitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTaskBitir.ForeColor = System.Drawing.Color.Purple;
            this.btnTaskBitir.Location = new System.Drawing.Point(286, 355);
            this.btnTaskBitir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTaskBitir.Name = "btnTaskBitir";
            this.btnTaskBitir.Size = new System.Drawing.Size(128, 56);
            this.btnTaskBitir.TabIndex = 19;
            this.btnTaskBitir.Text = "BITIRILDI";
            this.btnTaskBitir.UseVisualStyleBackColor = false;
            this.btnTaskBitir.Click += new System.EventHandler(this.button5_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Yellow;
            this.label11.Location = new System.Drawing.Point(26, 293);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 25);
            this.label11.TabIndex = 9;
            this.label11.Text = "PUAN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(26, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "PERSONEL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(26, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "TASK DURUMU";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(26, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "TASK";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(26, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "STORY";
            // 
            // puangosterTXT
            // 
            this.puangosterTXT.Location = new System.Drawing.Point(194, 290);
            this.puangosterTXT.Multiline = true;
            this.puangosterTXT.Name = "puangosterTXT";
            this.puangosterTXT.Size = new System.Drawing.Size(241, 45);
            this.puangosterTXT.TabIndex = 4;
            this.puangosterTXT.TextChanged += new System.EventHandler(this.puangosterTXT_TextChanged);
            // 
            // persgosterTXT
            // 
            this.persgosterTXT.Location = new System.Drawing.Point(194, 226);
            this.persgosterTXT.Multiline = true;
            this.persgosterTXT.Name = "persgosterTXT";
            this.persgosterTXT.Size = new System.Drawing.Size(241, 43);
            this.persgosterTXT.TabIndex = 3;
            this.persgosterTXT.TextChanged += new System.EventHandler(this.persgosterTXT_TextChanged);
            // 
            // durumgosterTXT
            // 
            this.durumgosterTXT.Location = new System.Drawing.Point(194, 153);
            this.durumgosterTXT.Multiline = true;
            this.durumgosterTXT.Name = "durumgosterTXT";
            this.durumgosterTXT.Size = new System.Drawing.Size(241, 42);
            this.durumgosterTXT.TabIndex = 2;
            // 
            // taskgosterTXT
            // 
            this.taskgosterTXT.Location = new System.Drawing.Point(194, 86);
            this.taskgosterTXT.Multiline = true;
            this.taskgosterTXT.Name = "taskgosterTXT";
            this.taskgosterTXT.Size = new System.Drawing.Size(241, 44);
            this.taskgosterTXT.TabIndex = 1;
            // 
            // storygosterTXT
            // 
            this.storygosterTXT.Location = new System.Drawing.Point(194, 12);
            this.storygosterTXT.Multiline = true;
            this.storygosterTXT.Name = "storygosterTXT";
            this.storygosterTXT.Size = new System.Drawing.Size(241, 45);
            this.storygosterTXT.TabIndex = 0;
            // 
            // storyaraTXT
            // 
            this.storyaraTXT.BackColor = System.Drawing.Color.White;
            this.storyaraTXT.Location = new System.Drawing.Point(939, 495);
            this.storyaraTXT.Name = "storyaraTXT";
            this.storyaraTXT.Size = new System.Drawing.Size(153, 30);
            this.storyaraTXT.TabIndex = 0;
            this.storyaraTXT.Text = "STORY";
            // 
            // taskaraTXT
            // 
            this.taskaraTXT.BackColor = System.Drawing.Color.White;
            this.taskaraTXT.Location = new System.Drawing.Point(1149, 495);
            this.taskaraTXT.Name = "taskaraTXT";
            this.taskaraTXT.Size = new System.Drawing.Size(153, 30);
            this.taskaraTXT.TabIndex = 14;
            this.taskaraTXT.Text = "TASK";
            // 
            // perssorguTXT
            // 
            this.perssorguTXT.Location = new System.Drawing.Point(12, 33);
            this.perssorguTXT.Name = "perssorguTXT";
            this.perssorguTXT.Size = new System.Drawing.Size(153, 30);
            this.perssorguTXT.TabIndex = 15;
            this.perssorguTXT.Text = "PERSONEL ADI";
            this.perssorguTXT.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // TaskSorguBTN
            // 
            this.TaskSorguBTN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TaskSorguBTN.Location = new System.Drawing.Point(1149, 546);
            this.TaskSorguBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TaskSorguBTN.Name = "TaskSorguBTN";
            this.TaskSorguBTN.Size = new System.Drawing.Size(128, 56);
            this.TaskSorguBTN.TabIndex = 16;
            this.TaskSorguBTN.Text = "GOREV ARA";
            this.TaskSorguBTN.UseVisualStyleBackColor = true;
            this.TaskSorguBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // PersSorguBTN
            // 
            this.PersSorguBTN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PersSorguBTN.Location = new System.Drawing.Point(213, 23);
            this.PersSorguBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PersSorguBTN.Name = "PersSorguBTN";
            this.PersSorguBTN.Size = new System.Drawing.Size(128, 56);
            this.PersSorguBTN.TabIndex = 17;
            this.PersSorguBTN.Text = "PERSONEL SORGULA";
            this.PersSorguBTN.UseVisualStyleBackColor = true;
            this.PersSorguBTN.Click += new System.EventHandler(this.button3_Click);
            // 
            // cikisBTN
            // 
            this.cikisBTN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cikisBTN.Location = new System.Drawing.Point(1301, 700);
            this.cikisBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cikisBTN.Name = "cikisBTN";
            this.cikisBTN.Size = new System.Drawing.Size(88, 44);
            this.cikisBTN.TabIndex = 18;
            this.cikisBTN.Text = "CIKIS";
            this.cikisBTN.UseVisualStyleBackColor = true;
            this.cikisBTN.Click += new System.EventHandler(this.cikisBTN_Click);
            // 
            // grupboxTaskEkle
            // 
            this.grupboxTaskEkle.BackColor = System.Drawing.Color.Transparent;
            this.grupboxTaskEkle.Controls.Add(this.label1);
            this.grupboxTaskEkle.Controls.Add(this.TaskEkleBTN);
            this.grupboxTaskEkle.Controls.Add(this.label2);
            this.grupboxTaskEkle.Controls.Add(this.label3);
            this.grupboxTaskEkle.Controls.Add(this.StoryTxt);
            this.grupboxTaskEkle.Controls.Add(this.GorevTxt);
            this.grupboxTaskEkle.Controls.Add(this.PuanTxt);
            this.grupboxTaskEkle.Location = new System.Drawing.Point(48, 495);
            this.grupboxTaskEkle.Name = "grupboxTaskEkle";
            this.grupboxTaskEkle.Size = new System.Drawing.Size(826, 249);
            this.grupboxTaskEkle.TabIndex = 19;
            this.grupboxTaskEkle.TabStop = false;
            // 
            // groupBoxPrsnSorgula
            // 
            this.groupBoxPrsnSorgula.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxPrsnSorgula.Controls.Add(this.perssorguTXT);
            this.groupBoxPrsnSorgula.Controls.Add(this.PersSorguBTN);
            this.groupBoxPrsnSorgula.Location = new System.Drawing.Point(936, 605);
            this.groupBoxPrsnSorgula.Name = "groupBoxPrsnSorgula";
            this.groupBoxPrsnSorgula.Size = new System.Drawing.Size(386, 87);
            this.groupBoxPrsnSorgula.TabIndex = 13;
            this.groupBoxPrsnSorgula.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(252, 174);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 0);
            this.textBox1.TabIndex = 20;
            // 
            // İs_Akis_Tablosu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.depositphotos_19457151_stock_photo_textile_background_old_rustic_homespun;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1402, 749);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBoxPrsnSorgula);
            this.Controls.Add(this.grupboxTaskEkle);
            this.Controls.Add(this.cikisBTN);
            this.Controls.Add(this.TaskSorguBTN);
            this.Controls.Add(this.taskaraTXT);
            this.Controls.Add(this.storyaraTXT);
            this.Controls.Add(this.groupBoxTaskSorgu);
            this.Controls.Add(this.flowPanelINPROGRES);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.flowPanelDONE);
            this.Controls.Add(this.flowPanelNotStared);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "İs_Akis_Tablosu";
            this.Text = "İs_Akis_Tablosu";
            this.Load += new System.EventHandler(this.İs_Akis_Tablosu_Load);
            this.groupBoxTaskSorgu.ResumeLayout(false);
            this.groupBoxTaskSorgu.PerformLayout();
            this.grupboxTaskEkle.ResumeLayout(false);
            this.grupboxTaskEkle.PerformLayout();
            this.groupBoxPrsnSorgula.ResumeLayout(false);
            this.groupBoxPrsnSorgula.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowPanelNotStared;
        private System.Windows.Forms.FlowLayoutPanel flowPanelDONE;
        private System.Windows.Forms.Button TaskEkleBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox StoryTxt;
        private System.Windows.Forms.TextBox GorevTxt;
        private System.Windows.Forms.TextBox PuanTxt;
        private System.Windows.Forms.FlowLayoutPanel flowPanelINPROGRES;
        private System.Windows.Forms.GroupBox groupBoxTaskSorgu;
        private System.Windows.Forms.TextBox persgosterTXT;
        private System.Windows.Forms.TextBox durumgosterTXT;
        private System.Windows.Forms.TextBox taskgosterTXT;
        private System.Windows.Forms.TextBox storygosterTXT;
        private System.Windows.Forms.Button btnGorevAl;
        private System.Windows.Forms.Button btnTaskBitir;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox puangosterTXT;
        private System.Windows.Forms.TextBox storyaraTXT;
        private System.Windows.Forms.TextBox taskaraTXT;
        private System.Windows.Forms.TextBox perssorguTXT;
        private System.Windows.Forms.Button TaskSorguBTN;
        private System.Windows.Forms.Button PersSorguBTN;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button yoneticiDuzenleBTN;
        private System.Windows.Forms.Button cikisBTN;
        private System.Windows.Forms.GroupBox grupboxTaskEkle;
        private System.Windows.Forms.GroupBox groupBoxPrsnSorgula;
        private System.Windows.Forms.TextBox textBox1;
    }
}