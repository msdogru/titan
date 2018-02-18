namespace Titan
{
    partial class AracServisDurumu
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LBServisParcaListesi = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTGeri = new System.Windows.Forms.Button();
            this.BTYenile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelAracModel = new System.Windows.Forms.Label();
            this.LabelAracSeriNo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBParcaStokKod = new System.Windows.Forms.TextBox();
            this.BTParcaBul = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.LBParcaBilgileri = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TBParcaAdedi = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.LBParcaAdı = new System.Windows.Forms.ListBox();
            this.LBParcaAdetMiktarı = new System.Windows.Forms.ListBox();
            this.LBParcaAdetFiyatı = new System.Windows.Forms.ListBox();
            this.LB = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TBParcaAcıklama = new System.Windows.Forms.TextBox();
            this.betterListBox1 = new BetterListBox.BetterListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BTServisKapat = new System.Windows.Forms.Button();
            this.BtSorumluKisiBilgileri = new System.Windows.Forms.Button();
            this.BTParçaÇıkart = new System.Windows.Forms.Button();
            this.CBAracServisgecmisi = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(942, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arac Servis Geçmişi";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(1026, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LBServisParcaListesi
            // 
            this.LBServisParcaListesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBServisParcaListesi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LBServisParcaListesi.FormattingEnabled = true;
            this.LBServisParcaListesi.ItemHeight = 16;
            this.LBServisParcaListesi.Location = new System.Drawing.Point(434, 93);
            this.LBServisParcaListesi.Name = "LBServisParcaListesi";
            this.LBServisParcaListesi.Size = new System.Drawing.Size(98, 324);
            this.LBServisParcaListesi.TabIndex = 4;
            this.LBServisParcaListesi.SelectedIndexChanged += new System.EventHandler(this.LBServisParcaListesi_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(588, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Değişen Parça Listesi";
            // 
            // BTGeri
            // 
            this.BTGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTGeri.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BTGeri.Location = new System.Drawing.Point(915, 42);
            this.BTGeri.Name = "BTGeri";
            this.BTGeri.Size = new System.Drawing.Size(105, 35);
            this.BTGeri.TabIndex = 6;
            this.BTGeri.Text = "Geri";
            this.BTGeri.UseVisualStyleBackColor = true;
            this.BTGeri.Click += new System.EventHandler(this.BTGeri_Click);
            // 
            // BTYenile
            // 
            this.BTYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTYenile.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BTYenile.Location = new System.Drawing.Point(12, 464);
            this.BTYenile.Name = "BTYenile";
            this.BTYenile.Size = new System.Drawing.Size(158, 33);
            this.BTYenile.TabIndex = 7;
            this.BTYenile.Text = "Listeyi Yenile";
            this.BTYenile.UseVisualStyleBackColor = true;
            this.BTYenile.Visible = false;
            this.BTYenile.Click += new System.EventHandler(this.BTYenile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Arac Model :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(12, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Arac Seri No :";
            // 
            // LabelAracModel
            // 
            this.LabelAracModel.AutoSize = true;
            this.LabelAracModel.ForeColor = System.Drawing.Color.Red;
            this.LabelAracModel.Location = new System.Drawing.Point(105, 44);
            this.LabelAracModel.Name = "LabelAracModel";
            this.LabelAracModel.Size = new System.Drawing.Size(31, 13);
            this.LabelAracModel.TabIndex = 10;
            this.LabelAracModel.Text = "........";
            // 
            // LabelAracSeriNo
            // 
            this.LabelAracSeriNo.AutoSize = true;
            this.LabelAracSeriNo.ForeColor = System.Drawing.Color.Red;
            this.LabelAracSeriNo.Location = new System.Drawing.Point(114, 73);
            this.LabelAracSeriNo.Name = "LabelAracSeriNo";
            this.LabelAracSeriNo.Size = new System.Drawing.Size(28, 13);
            this.LabelAracSeriNo.TabIndex = 11;
            this.LabelAracSeriNo.Text = ".......";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(12, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Parça Stok Kod İle parça bul ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(10, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Stok Kod :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // TBParcaStokKod
            // 
            this.TBParcaStokKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBParcaStokKod.Location = new System.Drawing.Point(89, 137);
            this.TBParcaStokKod.Name = "TBParcaStokKod";
            this.TBParcaStokKod.Size = new System.Drawing.Size(147, 23);
            this.TBParcaStokKod.TabIndex = 14;
            // 
            // BTParcaBul
            // 
            this.BTParcaBul.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BTParcaBul.Location = new System.Drawing.Point(247, 137);
            this.BTParcaBul.Name = "BTParcaBul";
            this.BTParcaBul.Size = new System.Drawing.Size(100, 23);
            this.BTParcaBul.TabIndex = 15;
            this.BTParcaBul.Text = "Parçayı Bul";
            this.BTParcaBul.UseVisualStyleBackColor = true;
            this.BTParcaBul.Click += new System.EventHandler(this.BTParcaBul_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(10, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Parça Bilgileri";
            // 
            // LBParcaBilgileri
            // 
            this.LBParcaBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBParcaBilgileri.ForeColor = System.Drawing.Color.Red;
            this.LBParcaBilgileri.FormattingEnabled = true;
            this.LBParcaBilgileri.ItemHeight = 20;
            this.LBParcaBilgileri.Location = new System.Drawing.Point(15, 191);
            this.LBParcaBilgileri.Name = "LBParcaBilgileri";
            this.LBParcaBilgileri.Size = new System.Drawing.Size(332, 64);
            this.LBParcaBilgileri.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(9, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Parça Adedi :";
            // 
            // TBParcaAdedi
            // 
            this.TBParcaAdedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBParcaAdedi.Location = new System.Drawing.Point(108, 359);
            this.TBParcaAdedi.Name = "TBParcaAdedi";
            this.TBParcaAdedi.Size = new System.Drawing.Size(63, 26);
            this.TBParcaAdedi.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(201, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 37);
            this.button3.TabIndex = 21;
            this.button3.Text = "Yeni Parçayı Ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LBParcaAdı
            // 
            this.LBParcaAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBParcaAdı.FormattingEnabled = true;
            this.LBParcaAdı.ItemHeight = 16;
            this.LBParcaAdı.Location = new System.Drawing.Point(538, 93);
            this.LBParcaAdı.Name = "LBParcaAdı";
            this.LBParcaAdı.Size = new System.Drawing.Size(192, 324);
            this.LBParcaAdı.TabIndex = 23;
            // 
            // LBParcaAdetMiktarı
            // 
            this.LBParcaAdetMiktarı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBParcaAdetMiktarı.FormattingEnabled = true;
            this.LBParcaAdetMiktarı.ItemHeight = 16;
            this.LBParcaAdetMiktarı.Location = new System.Drawing.Point(736, 93);
            this.LBParcaAdetMiktarı.Name = "LBParcaAdetMiktarı";
            this.LBParcaAdetMiktarı.Size = new System.Drawing.Size(71, 324);
            this.LBParcaAdetMiktarı.TabIndex = 24;
            // 
            // LBParcaAdetFiyatı
            // 
            this.LBParcaAdetFiyatı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBParcaAdetFiyatı.FormattingEnabled = true;
            this.LBParcaAdetFiyatı.ItemHeight = 16;
            this.LBParcaAdetFiyatı.Location = new System.Drawing.Point(813, 93);
            this.LBParcaAdetFiyatı.Name = "LBParcaAdetFiyatı";
            this.LBParcaAdetFiyatı.Size = new System.Drawing.Size(82, 324);
            this.LBParcaAdetFiyatı.TabIndex = 25;
            // 
            // LB
            // 
            this.LB.AutoSize = true;
            this.LB.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LB.Location = new System.Drawing.Point(535, 75);
            this.LB.Name = "LB";
            this.LB.Size = new System.Drawing.Size(22, 13);
            this.LB.TabIndex = 26;
            this.LB.Text = "Adı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(733, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Adet Miktarı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(810, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Adet Fiyatı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(431, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Stok Kod";
            // 
            // TBParcaAcıklama
            // 
            this.TBParcaAcıklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBParcaAcıklama.ForeColor = System.Drawing.Color.Red;
            this.TBParcaAcıklama.Location = new System.Drawing.Point(15, 261);
            this.TBParcaAcıklama.Multiline = true;
            this.TBParcaAcıklama.Name = "TBParcaAcıklama";
            this.TBParcaAcıklama.Size = new System.Drawing.Size(332, 89);
            this.TBParcaAcıklama.TabIndex = 30;
            // 
            // betterListBox1
            // 
            this.betterListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.betterListBox1.FormattingEnabled = true;
            this.betterListBox1.ItemHeight = 16;
            this.betterListBox1.Location = new System.Drawing.Point(394, 93);
            this.betterListBox1.Name = "betterListBox1";
            this.betterListBox1.Size = new System.Drawing.Size(34, 324);
            this.betterListBox1.TabIndex = 31;
            this.betterListBox1.Scroll += new BetterListBox.BetterListBox.BetterListBoxScrollDelegate(this.scroll);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(391, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Sıra";
            // 
            // BTServisKapat
            // 
            this.BTServisKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTServisKapat.ForeColor = System.Drawing.Color.Red;
            this.BTServisKapat.Location = new System.Drawing.Point(927, 378);
            this.BTServisKapat.Name = "BTServisKapat";
            this.BTServisKapat.Size = new System.Drawing.Size(191, 39);
            this.BTServisKapat.TabIndex = 33;
            this.BTServisKapat.Text = "Servisi Kapat";
            this.BTServisKapat.UseVisualStyleBackColor = true;
            this.BTServisKapat.Click += new System.EventHandler(this.BTServisKapat_Click);
            // 
            // BtSorumluKisiBilgileri
            // 
            this.BtSorumluKisiBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtSorumluKisiBilgileri.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtSorumluKisiBilgileri.Location = new System.Drawing.Point(15, 13);
            this.BtSorumluKisiBilgileri.Name = "BtSorumluKisiBilgileri";
            this.BtSorumluKisiBilgileri.Size = new System.Drawing.Size(221, 23);
            this.BtSorumluKisiBilgileri.TabIndex = 34;
            this.BtSorumluKisiBilgileri.Text = "Sorumlu kişi Bilgilerini Görüntüle";
            this.BtSorumluKisiBilgileri.UseVisualStyleBackColor = true;
            this.BtSorumluKisiBilgileri.Click += new System.EventHandler(this.BtSorumluKisiBilgileri_Click);
            // 
            // BTParçaÇıkart
            // 
            this.BTParçaÇıkart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTParçaÇıkart.ForeColor = System.Drawing.Color.Red;
            this.BTParçaÇıkart.Location = new System.Drawing.Point(247, 398);
            this.BTParçaÇıkart.Name = "BTParçaÇıkart";
            this.BTParçaÇıkart.Size = new System.Drawing.Size(100, 31);
            this.BTParçaÇıkart.TabIndex = 35;
            this.BTParçaÇıkart.Text = "ParçaÇıkart";
            this.BTParçaÇıkart.UseVisualStyleBackColor = true;
            this.BTParçaÇıkart.Click += new System.EventHandler(this.BTParçaÇıkart_Click);
            // 
            // CBAracServisgecmisi
            // 
            this.CBAracServisgecmisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBAracServisgecmisi.FormattingEnabled = true;
            this.CBAracServisgecmisi.Location = new System.Drawing.Point(915, 107);
            this.CBAracServisgecmisi.Name = "CBAracServisgecmisi";
            this.CBAracServisgecmisi.Size = new System.Drawing.Size(203, 256);
            this.CBAracServisgecmisi.TabIndex = 3;
            this.CBAracServisgecmisi.SelectedIndexChanged += new System.EventHandler(this.CBAracServisgecmisi_SelectedIndexChanged);
            // 
            // AracServisDurumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 489);
            this.Controls.Add(this.BTParçaÇıkart);
            this.Controls.Add(this.BtSorumluKisiBilgileri);
            this.Controls.Add(this.BTServisKapat);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.betterListBox1);
            this.Controls.Add(this.TBParcaAcıklama);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LB);
            this.Controls.Add(this.LBParcaAdetFiyatı);
            this.Controls.Add(this.LBParcaAdetMiktarı);
            this.Controls.Add(this.LBParcaAdı);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TBParcaAdedi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LBParcaBilgileri);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BTParcaBul);
            this.Controls.Add(this.TBParcaStokKod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LabelAracSeriNo);
            this.Controls.Add(this.LabelAracModel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTYenile);
            this.Controls.Add(this.BTGeri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBServisParcaListesi);
            this.Controls.Add(this.CBAracServisgecmisi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "AracServisDurumu";
            this.Text = "Arac Servis Durumu";
            this.Load += new System.EventHandler(this.AracServisDurumu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox LBServisParcaListesi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTGeri;
        private System.Windows.Forms.Button BTYenile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelAracModel;
        private System.Windows.Forms.Label LabelAracSeriNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBParcaStokKod;
        private System.Windows.Forms.Button BTParcaBul;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox LBParcaBilgileri;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TBParcaAdedi;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox LBParcaAdı;
        private System.Windows.Forms.ListBox LBParcaAdetMiktarı;
        private System.Windows.Forms.ListBox LBParcaAdetFiyatı;
        private System.Windows.Forms.Label LB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TBParcaAcıklama;
        private global::BetterListBox.BetterListBox betterListBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BTServisKapat;
        private System.Windows.Forms.Button BtSorumluKisiBilgileri;
        private System.Windows.Forms.Button BTParçaÇıkart;
        private System.Windows.Forms.CheckedListBox CBAracServisgecmisi;
    }
}