namespace Titan
{
    partial class SirketSilme
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
            this.LSirketTik = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CBSirket = new System.Windows.Forms.ComboBox();
            this.LSirketAdiTik = new System.Windows.Forms.Label();
            this.TBSirketAdı = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTGeri = new System.Windows.Forms.Button();
            this.BTEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LSirketTik
            // 
            this.LSirketTik.AutoSize = true;
            this.LSirketTik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LSirketTik.ForeColor = System.Drawing.Color.Green;
            this.LSirketTik.Location = new System.Drawing.Point(519, 14);
            this.LSirketTik.Name = "LSirketTik";
            this.LSirketTik.Size = new System.Drawing.Size(20, 24);
            this.LSirketTik.TabIndex = 71;
            this.LSirketTik.Text = "L";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(18, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 70;
            this.label9.Text = "Şirket : ";
            // 
            // CBSirket
            // 
            this.CBSirket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBSirket.FormattingEnabled = true;
            this.CBSirket.Location = new System.Drawing.Point(80, 13);
            this.CBSirket.Name = "CBSirket";
            this.CBSirket.Size = new System.Drawing.Size(434, 24);
            this.CBSirket.TabIndex = 69;
            this.CBSirket.SelectedIndexChanged += new System.EventHandler(this.CBSirket_SelectedIndexChanged);
            // 
            // LSirketAdiTik
            // 
            this.LSirketAdiTik.AutoSize = true;
            this.LSirketAdiTik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LSirketAdiTik.ForeColor = System.Drawing.Color.Red;
            this.LSirketAdiTik.Location = new System.Drawing.Point(315, 59);
            this.LSirketAdiTik.Name = "LSirketAdiTik";
            this.LSirketAdiTik.Size = new System.Drawing.Size(23, 25);
            this.LSirketAdiTik.TabIndex = 66;
            this.LSirketAdiTik.Text = "L";
            // 
            // TBSirketAdı
            // 
            this.TBSirketAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBSirketAdı.Location = new System.Drawing.Point(113, 61);
            this.TBSirketAdı.Name = "TBSirketAdı";
            this.TBSirketAdı.Size = new System.Drawing.Size(196, 23);
            this.TBSirketAdı.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(15, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "Şirket Adı : ";
            // 
            // BTGeri
            // 
            this.BTGeri.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BTGeri.Location = new System.Drawing.Point(640, 9);
            this.BTGeri.Name = "BTGeri";
            this.BTGeri.Size = new System.Drawing.Size(86, 31);
            this.BTGeri.TabIndex = 49;
            this.BTGeri.Text = "Geri";
            this.BTGeri.UseVisualStyleBackColor = true;
            this.BTGeri.Click += new System.EventHandler(this.BTGeri_Click);
            // 
            // BTEkle
            // 
            this.BTEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTEkle.ForeColor = System.Drawing.Color.Red;
            this.BTEkle.Location = new System.Drawing.Point(523, 61);
            this.BTEkle.Name = "BTEkle";
            this.BTEkle.Size = new System.Drawing.Size(207, 71);
            this.BTEkle.TabIndex = 48;
            this.BTEkle.Text = "Şirketi Sil";
            this.BTEkle.UseVisualStyleBackColor = true;
            this.BTEkle.Click += new System.EventHandler(this.BTEkle_Click);
            // 
            // SirketSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 167);
            this.Controls.Add(this.LSirketTik);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CBSirket);
            this.Controls.Add(this.LSirketAdiTik);
            this.Controls.Add(this.TBSirketAdı);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTGeri);
            this.Controls.Add(this.BTEkle);
            this.Name = "SirketSilme";
            this.Text = "SirketSilme";
            this.Load += new System.EventHandler(this.SirketSilme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LSirketTik;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CBSirket;
        private System.Windows.Forms.Label LSirketAdiTik;
        private System.Windows.Forms.TextBox TBSirketAdı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTGeri;
        private System.Windows.Forms.Button BTEkle;

    }
}