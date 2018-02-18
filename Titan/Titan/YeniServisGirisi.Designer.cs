namespace Titan
{
    partial class YeniServisGirisi
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
            this.BTCıkıs = new System.Windows.Forms.Button();
            this.BTGeri = new System.Windows.Forms.Button();
            this.CBSirket = new System.Windows.Forms.ComboBox();
            this.CBArac = new System.Windows.Forms.ComboBox();
            this.BTYeniSirketEkle = new System.Windows.Forms.Button();
            this.BTYeniAracEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CBAracıGetirenKisi = new System.Windows.Forms.ComboBox();
            this.CBBirinciYetkiliKisi = new System.Windows.Forms.ComboBox();
            this.CBİkinciYetkiliKisi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TBAdı = new System.Windows.Forms.TextBox();
            this.TBSoyadı = new System.Windows.Forms.TextBox();
            this.TBTel1 = new System.Windows.Forms.TextBox();
            this.TBTel2 = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.BTDuzenleKaydet = new System.Windows.Forms.Button();
            this.BTYeniKisiKaydet = new System.Windows.Forms.Button();
            this.LSirketTik = new System.Windows.Forms.Label();
            this.LAracTik = new System.Windows.Forms.Label();
            this.LAracıGetirenKisiTik = new System.Windows.Forms.Label();
            this.LBirinciYetkiliKisiTik = new System.Windows.Forms.Label();
            this.LIkinciYetkiliKisiTik = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DTimePickerAracGelisTarihi = new System.Windows.Forms.DateTimePicker();
            this.DTimePickerAracTerminTarihi = new System.Windows.Forms.DateTimePicker();
            this.BTServisKaydet = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TBAcıklama = new System.Windows.Forms.TextBox();
            this.BTYeniAracGetirenKisi = new System.Windows.Forms.Button();
            this.BTYeniAracBirinciSorumlusu = new System.Windows.Forms.Button();
            this.BTYeniAracIkinciSorumlusu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTCıkıs
            // 
            this.BTCıkıs.ForeColor = System.Drawing.Color.Red;
            this.BTCıkıs.Location = new System.Drawing.Point(1104, 14);
            this.BTCıkıs.Name = "BTCıkıs";
            this.BTCıkıs.Size = new System.Drawing.Size(88, 30);
            this.BTCıkıs.TabIndex = 0;
            this.BTCıkıs.Text = "Çıkış";
            this.BTCıkıs.UseVisualStyleBackColor = true;
            this.BTCıkıs.Click += new System.EventHandler(this.BTCıkıs_Click);
            // 
            // BTGeri
            // 
            this.BTGeri.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BTGeri.Location = new System.Drawing.Point(1016, 14);
            this.BTGeri.Name = "BTGeri";
            this.BTGeri.Size = new System.Drawing.Size(82, 30);
            this.BTGeri.TabIndex = 1;
            this.BTGeri.Text = "Geri";
            this.BTGeri.UseVisualStyleBackColor = true;
            this.BTGeri.Click += new System.EventHandler(this.BTGeri_Click);
            // 
            // CBSirket
            // 
            this.CBSirket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBSirket.FormattingEnabled = true;
            this.CBSirket.Location = new System.Drawing.Point(78, 17);
            this.CBSirket.Name = "CBSirket";
            this.CBSirket.Size = new System.Drawing.Size(434, 24);
            this.CBSirket.TabIndex = 2;
            this.CBSirket.SelectedIndexChanged += new System.EventHandler(this.CBSirket_SelectedIndexChanged);
            // 
            // CBArac
            // 
            this.CBArac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBArac.FormattingEnabled = true;
            this.CBArac.Location = new System.Drawing.Point(78, 60);
            this.CBArac.Name = "CBArac";
            this.CBArac.Size = new System.Drawing.Size(434, 24);
            this.CBArac.TabIndex = 3;
            this.CBArac.SelectedIndexChanged += new System.EventHandler(this.CBArac_SelectedIndexChanged);
            // 
            // BTYeniSirketEkle
            // 
            this.BTYeniSirketEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTYeniSirketEkle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BTYeniSirketEkle.Location = new System.Drawing.Point(543, 9);
            this.BTYeniSirketEkle.Name = "BTYeniSirketEkle";
            this.BTYeniSirketEkle.Size = new System.Drawing.Size(121, 34);
            this.BTYeniSirketEkle.TabIndex = 4;
            this.BTYeniSirketEkle.Text = "Yeni Şirket Ekle";
            this.BTYeniSirketEkle.UseVisualStyleBackColor = true;
            this.BTYeniSirketEkle.Click += new System.EventHandler(this.BTYeniSirketEkle_Click);
            // 
            // BTYeniAracEkle
            // 
            this.BTYeniAracEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTYeniAracEkle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BTYeniAracEkle.Location = new System.Drawing.Point(543, 54);
            this.BTYeniAracEkle.Name = "BTYeniAracEkle";
            this.BTYeniAracEkle.Size = new System.Drawing.Size(121, 34);
            this.BTYeniAracEkle.TabIndex = 5;
            this.BTYeniAracEkle.Text = "Yeni Araç Ekle";
            this.BTYeniAracEkle.UseVisualStyleBackColor = true;
            this.BTYeniAracEkle.Click += new System.EventHandler(this.BTYeniAracEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Şirket : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Araç : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(19, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Aracı Getiren Kişi: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(18, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "1. Yetkili Kişi : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(19, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "2. Yetkili Kişi :";
            // 
            // CBAracıGetirenKisi
            // 
            this.CBAracıGetirenKisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBAracıGetirenKisi.FormattingEnabled = true;
            this.CBAracıGetirenKisi.Location = new System.Drawing.Point(150, 112);
            this.CBAracıGetirenKisi.Name = "CBAracıGetirenKisi";
            this.CBAracıGetirenKisi.Size = new System.Drawing.Size(361, 24);
            this.CBAracıGetirenKisi.TabIndex = 11;
            this.CBAracıGetirenKisi.SelectedIndexChanged += new System.EventHandler(this.CBAracıGetirenKisi_SelectedIndexChanged);
            // 
            // CBBirinciYetkiliKisi
            // 
            this.CBBirinciYetkiliKisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBBirinciYetkiliKisi.FormattingEnabled = true;
            this.CBBirinciYetkiliKisi.Location = new System.Drawing.Point(150, 156);
            this.CBBirinciYetkiliKisi.Name = "CBBirinciYetkiliKisi";
            this.CBBirinciYetkiliKisi.Size = new System.Drawing.Size(361, 24);
            this.CBBirinciYetkiliKisi.TabIndex = 12;
            this.CBBirinciYetkiliKisi.SelectedIndexChanged += new System.EventHandler(this.CBBirinciYetkiliKisi_SelectedIndexChanged);
            // 
            // CBİkinciYetkiliKisi
            // 
            this.CBİkinciYetkiliKisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBİkinciYetkiliKisi.FormattingEnabled = true;
            this.CBİkinciYetkiliKisi.Location = new System.Drawing.Point(150, 200);
            this.CBİkinciYetkiliKisi.Name = "CBİkinciYetkiliKisi";
            this.CBİkinciYetkiliKisi.Size = new System.Drawing.Size(361, 24);
            this.CBİkinciYetkiliKisi.TabIndex = 13;
            this.CBİkinciYetkiliKisi.SelectedIndexChanged += new System.EventHandler(this.CBİkinciYetkiliKisi_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(806, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Adı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(805, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Soyadı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(805, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tel 1 : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(805, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tel 2 :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(805, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "EMail : ";
            // 
            // TBAdı
            // 
            this.TBAdı.Location = new System.Drawing.Point(868, 104);
            this.TBAdı.Name = "TBAdı";
            this.TBAdı.Size = new System.Drawing.Size(265, 20);
            this.TBAdı.TabIndex = 19;
            // 
            // TBSoyadı
            // 
            this.TBSoyadı.Location = new System.Drawing.Point(868, 134);
            this.TBSoyadı.Name = "TBSoyadı";
            this.TBSoyadı.Size = new System.Drawing.Size(265, 20);
            this.TBSoyadı.TabIndex = 20;
            // 
            // TBTel1
            // 
            this.TBTel1.Location = new System.Drawing.Point(868, 164);
            this.TBTel1.Name = "TBTel1";
            this.TBTel1.Size = new System.Drawing.Size(265, 20);
            this.TBTel1.TabIndex = 21;
            // 
            // TBTel2
            // 
            this.TBTel2.Location = new System.Drawing.Point(868, 198);
            this.TBTel2.Name = "TBTel2";
            this.TBTel2.Size = new System.Drawing.Size(265, 20);
            this.TBTel2.TabIndex = 22;
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(868, 228);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(265, 20);
            this.TBEmail.TabIndex = 23;
            // 
            // BTDuzenleKaydet
            // 
            this.BTDuzenleKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTDuzenleKaydet.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BTDuzenleKaydet.Location = new System.Drawing.Point(756, 270);
            this.BTDuzenleKaydet.Name = "BTDuzenleKaydet";
            this.BTDuzenleKaydet.Size = new System.Drawing.Size(207, 36);
            this.BTDuzenleKaydet.TabIndex = 24;
            this.BTDuzenleKaydet.Text = "Düzenle, Kaydet Ve Seç";
            this.BTDuzenleKaydet.UseVisualStyleBackColor = true;
            this.BTDuzenleKaydet.Click += new System.EventHandler(this.BTDuzenleKaydet_Click);
            // 
            // BTYeniKisiKaydet
            // 
            this.BTYeniKisiKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTYeniKisiKaydet.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BTYeniKisiKaydet.Location = new System.Drawing.Point(985, 270);
            this.BTYeniKisiKaydet.Name = "BTYeniKisiKaydet";
            this.BTYeniKisiKaydet.Size = new System.Drawing.Size(207, 36);
            this.BTYeniKisiKaydet.TabIndex = 26;
            this.BTYeniKisiKaydet.Text = "Yeni Kişi Olarak Ekle Ve Seç";
            this.BTYeniKisiKaydet.UseVisualStyleBackColor = true;
            this.BTYeniKisiKaydet.Click += new System.EventHandler(this.BTYeniKisiKaydet_Click);
            // 
            // LSirketTik
            // 
            this.LSirketTik.AutoSize = true;
            this.LSirketTik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LSirketTik.ForeColor = System.Drawing.Color.Green;
            this.LSirketTik.Location = new System.Drawing.Point(517, 18);
            this.LSirketTik.Name = "LSirketTik";
            this.LSirketTik.Size = new System.Drawing.Size(20, 24);
            this.LSirketTik.TabIndex = 27;
            this.LSirketTik.Text = "L";
            // 
            // LAracTik
            // 
            this.LAracTik.AutoSize = true;
            this.LAracTik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LAracTik.ForeColor = System.Drawing.Color.Green;
            this.LAracTik.Location = new System.Drawing.Point(517, 63);
            this.LAracTik.Name = "LAracTik";
            this.LAracTik.Size = new System.Drawing.Size(20, 24);
            this.LAracTik.TabIndex = 28;
            this.LAracTik.Text = "L";
            // 
            // LAracıGetirenKisiTik
            // 
            this.LAracıGetirenKisiTik.AutoSize = true;
            this.LAracıGetirenKisiTik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LAracıGetirenKisiTik.ForeColor = System.Drawing.Color.Green;
            this.LAracıGetirenKisiTik.Location = new System.Drawing.Point(517, 115);
            this.LAracıGetirenKisiTik.Name = "LAracıGetirenKisiTik";
            this.LAracıGetirenKisiTik.Size = new System.Drawing.Size(20, 24);
            this.LAracıGetirenKisiTik.TabIndex = 29;
            this.LAracıGetirenKisiTik.Text = "L";
            // 
            // LBirinciYetkiliKisiTik
            // 
            this.LBirinciYetkiliKisiTik.AutoSize = true;
            this.LBirinciYetkiliKisiTik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBirinciYetkiliKisiTik.ForeColor = System.Drawing.Color.Green;
            this.LBirinciYetkiliKisiTik.Location = new System.Drawing.Point(517, 159);
            this.LBirinciYetkiliKisiTik.Name = "LBirinciYetkiliKisiTik";
            this.LBirinciYetkiliKisiTik.Size = new System.Drawing.Size(20, 24);
            this.LBirinciYetkiliKisiTik.TabIndex = 30;
            this.LBirinciYetkiliKisiTik.Text = "L";
            // 
            // LIkinciYetkiliKisiTik
            // 
            this.LIkinciYetkiliKisiTik.AutoSize = true;
            this.LIkinciYetkiliKisiTik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LIkinciYetkiliKisiTik.ForeColor = System.Drawing.Color.Green;
            this.LIkinciYetkiliKisiTik.Location = new System.Drawing.Point(517, 203);
            this.LIkinciYetkiliKisiTik.Name = "LIkinciYetkiliKisiTik";
            this.LIkinciYetkiliKisiTik.Size = new System.Drawing.Size(20, 24);
            this.LIkinciYetkiliKisiTik.TabIndex = 31;
            this.LIkinciYetkiliKisiTik.Text = "L";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(21, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "Geliş Tarihi : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(21, 300);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "Termin Tarihi :";
            // 
            // DTimePickerAracGelisTarihi
            // 
            this.DTimePickerAracGelisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DTimePickerAracGelisTarihi.Location = new System.Drawing.Point(155, 248);
            this.DTimePickerAracGelisTarihi.Name = "DTimePickerAracGelisTarihi";
            this.DTimePickerAracGelisTarihi.Size = new System.Drawing.Size(216, 23);
            this.DTimePickerAracGelisTarihi.TabIndex = 34;
            // 
            // DTimePickerAracTerminTarihi
            // 
            this.DTimePickerAracTerminTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DTimePickerAracTerminTarihi.Location = new System.Drawing.Point(155, 294);
            this.DTimePickerAracTerminTarihi.Name = "DTimePickerAracTerminTarihi";
            this.DTimePickerAracTerminTarihi.Size = new System.Drawing.Size(216, 23);
            this.DTimePickerAracTerminTarihi.TabIndex = 35;
            // 
            // BTServisKaydet
            // 
            this.BTServisKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTServisKaydet.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BTServisKaydet.Location = new System.Drawing.Point(868, 371);
            this.BTServisKaydet.Name = "BTServisKaydet";
            this.BTServisKaydet.Size = new System.Drawing.Size(178, 65);
            this.BTServisKaydet.TabIndex = 36;
            this.BTServisKaydet.Text = "Servisi Kaydet";
            this.BTServisKaydet.UseVisualStyleBackColor = true;
            this.BTServisKaydet.Click += new System.EventHandler(this.BTServisKaydet_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(865, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 17);
            this.label13.TabIndex = 37;
            this.label13.Text = "Secili Kişi Bilgileri";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label14.Location = new System.Drawing.Point(24, 338);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 17);
            this.label14.TabIndex = 38;
            this.label14.Text = "Açıklama : ";
            // 
            // TBAcıklama
            // 
            this.TBAcıklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBAcıklama.Location = new System.Drawing.Point(106, 338);
            this.TBAcıklama.Multiline = true;
            this.TBAcıklama.Name = "TBAcıklama";
            this.TBAcıklama.Size = new System.Drawing.Size(594, 124);
            this.TBAcıklama.TabIndex = 39;
            // 
            // BTYeniAracGetirenKisi
            // 
            this.BTYeniAracGetirenKisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTYeniAracGetirenKisi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BTYeniAracGetirenKisi.Location = new System.Drawing.Point(543, 106);
            this.BTYeniAracGetirenKisi.Name = "BTYeniAracGetirenKisi";
            this.BTYeniAracGetirenKisi.Size = new System.Drawing.Size(121, 34);
            this.BTYeniAracGetirenKisi.TabIndex = 40;
            this.BTYeniAracGetirenKisi.Text = "Yeni Kişi Ekle";
            this.BTYeniAracGetirenKisi.UseVisualStyleBackColor = true;
            this.BTYeniAracGetirenKisi.Click += new System.EventHandler(this.BTYeniAracGetirenKisi_Click);
            // 
            // BTYeniAracBirinciSorumlusu
            // 
            this.BTYeniAracBirinciSorumlusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTYeniAracBirinciSorumlusu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BTYeniAracBirinciSorumlusu.Location = new System.Drawing.Point(543, 150);
            this.BTYeniAracBirinciSorumlusu.Name = "BTYeniAracBirinciSorumlusu";
            this.BTYeniAracBirinciSorumlusu.Size = new System.Drawing.Size(121, 34);
            this.BTYeniAracBirinciSorumlusu.TabIndex = 41;
            this.BTYeniAracBirinciSorumlusu.Text = "Yeni Kişi Ekle";
            this.BTYeniAracBirinciSorumlusu.UseVisualStyleBackColor = true;
            this.BTYeniAracBirinciSorumlusu.Click += new System.EventHandler(this.BTYeniAracBirinciSorumlusu_Click);
            // 
            // BTYeniAracIkinciSorumlusu
            // 
            this.BTYeniAracIkinciSorumlusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTYeniAracIkinciSorumlusu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BTYeniAracIkinciSorumlusu.Location = new System.Drawing.Point(543, 194);
            this.BTYeniAracIkinciSorumlusu.Name = "BTYeniAracIkinciSorumlusu";
            this.BTYeniAracIkinciSorumlusu.Size = new System.Drawing.Size(121, 34);
            this.BTYeniAracIkinciSorumlusu.TabIndex = 42;
            this.BTYeniAracIkinciSorumlusu.Text = "Yeni Kişi Ekle";
            this.BTYeniAracIkinciSorumlusu.UseVisualStyleBackColor = true;
            this.BTYeniAracIkinciSorumlusu.Click += new System.EventHandler(this.BTYeniAracIkinciSorumlusu_Click);
            // 
            // YeniServisGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 490);
            this.Controls.Add(this.BTYeniAracIkinciSorumlusu);
            this.Controls.Add(this.BTYeniAracBirinciSorumlusu);
            this.Controls.Add(this.BTYeniAracGetirenKisi);
            this.Controls.Add(this.TBAcıklama);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.BTServisKaydet);
            this.Controls.Add(this.DTimePickerAracTerminTarihi);
            this.Controls.Add(this.DTimePickerAracGelisTarihi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LIkinciYetkiliKisiTik);
            this.Controls.Add(this.LBirinciYetkiliKisiTik);
            this.Controls.Add(this.LAracıGetirenKisiTik);
            this.Controls.Add(this.LAracTik);
            this.Controls.Add(this.LSirketTik);
            this.Controls.Add(this.BTYeniKisiKaydet);
            this.Controls.Add(this.BTDuzenleKaydet);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.TBTel2);
            this.Controls.Add(this.TBTel1);
            this.Controls.Add(this.TBSoyadı);
            this.Controls.Add(this.TBAdı);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CBİkinciYetkiliKisi);
            this.Controls.Add(this.CBBirinciYetkiliKisi);
            this.Controls.Add(this.CBAracıGetirenKisi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTYeniAracEkle);
            this.Controls.Add(this.BTYeniSirketEkle);
            this.Controls.Add(this.CBArac);
            this.Controls.Add(this.CBSirket);
            this.Controls.Add(this.BTGeri);
            this.Controls.Add(this.BTCıkıs);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "YeniServisGirisi";
            this.Text = "Yeni Servis Girisi";
            this.Load += new System.EventHandler(this.YeniServisGirisi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTCıkıs;
        private System.Windows.Forms.Button BTGeri;
        private System.Windows.Forms.ComboBox CBSirket;
        private System.Windows.Forms.ComboBox CBArac;
        private System.Windows.Forms.Button BTYeniSirketEkle;
        private System.Windows.Forms.Button BTYeniAracEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBAracıGetirenKisi;
        private System.Windows.Forms.ComboBox CBBirinciYetkiliKisi;
        private System.Windows.Forms.ComboBox CBİkinciYetkiliKisi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TBAdı;
        private System.Windows.Forms.TextBox TBSoyadı;
        private System.Windows.Forms.TextBox TBTel1;
        private System.Windows.Forms.TextBox TBTel2;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.Button BTDuzenleKaydet;
        private System.Windows.Forms.Button BTYeniKisiKaydet;
        private System.Windows.Forms.Label LSirketTik;
        private System.Windows.Forms.Label LAracTik;
        private System.Windows.Forms.Label LAracıGetirenKisiTik;
        private System.Windows.Forms.Label LBirinciYetkiliKisiTik;
        private System.Windows.Forms.Label LIkinciYetkiliKisiTik;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker DTimePickerAracGelisTarihi;
        private System.Windows.Forms.DateTimePicker DTimePickerAracTerminTarihi;
        private System.Windows.Forms.Button BTServisKaydet;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TBAcıklama;
        private System.Windows.Forms.Button BTYeniAracGetirenKisi;
        private System.Windows.Forms.Button BTYeniAracBirinciSorumlusu;
        private System.Windows.Forms.Button BTYeniAracIkinciSorumlusu;
    }
}