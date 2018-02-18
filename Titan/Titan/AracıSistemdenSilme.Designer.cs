namespace Titan
{
    partial class AracıSistemdenSilme
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
            this.LAracTik = new System.Windows.Forms.Label();
            this.LSirketTik = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBArac = new System.Windows.Forms.ComboBox();
            this.CBSirket = new System.Windows.Forms.ComboBox();
            this.BTGeri = new System.Windows.Forms.Button();
            this.BTEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LAracTik
            // 
            this.LAracTik.AutoSize = true;
            this.LAracTik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LAracTik.ForeColor = System.Drawing.Color.Green;
            this.LAracTik.Location = new System.Drawing.Point(514, 84);
            this.LAracTik.Name = "LAracTik";
            this.LAracTik.Size = new System.Drawing.Size(20, 24);
            this.LAracTik.TabIndex = 34;
            this.LAracTik.Text = "L";
            // 
            // LSirketTik
            // 
            this.LSirketTik.AutoSize = true;
            this.LSirketTik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LSirketTik.ForeColor = System.Drawing.Color.Green;
            this.LSirketTik.Location = new System.Drawing.Point(514, 39);
            this.LSirketTik.Name = "LSirketTik";
            this.LSirketTik.Size = new System.Drawing.Size(20, 24);
            this.LSirketTik.TabIndex = 33;
            this.LSirketTik.Text = "L";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Araç : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Şirket : ";
            // 
            // CBArac
            // 
            this.CBArac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBArac.FormattingEnabled = true;
            this.CBArac.Location = new System.Drawing.Point(75, 81);
            this.CBArac.Name = "CBArac";
            this.CBArac.Size = new System.Drawing.Size(434, 24);
            this.CBArac.TabIndex = 30;
            this.CBArac.SelectedIndexChanged += new System.EventHandler(this.CBArac_SelectedIndexChanged);
            // 
            // CBSirket
            // 
            this.CBSirket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBSirket.FormattingEnabled = true;
            this.CBSirket.Location = new System.Drawing.Point(75, 38);
            this.CBSirket.Name = "CBSirket";
            this.CBSirket.Size = new System.Drawing.Size(434, 24);
            this.CBSirket.TabIndex = 29;
            this.CBSirket.SelectedIndexChanged += new System.EventHandler(this.CBSirket_SelectedIndexChanged);
            // 
            // BTGeri
            // 
            this.BTGeri.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BTGeri.Location = new System.Drawing.Point(700, 11);
            this.BTGeri.Name = "BTGeri";
            this.BTGeri.Size = new System.Drawing.Size(86, 31);
            this.BTGeri.TabIndex = 51;
            this.BTGeri.Text = "Geri";
            this.BTGeri.UseVisualStyleBackColor = true;
            this.BTGeri.Click += new System.EventHandler(this.BTGeri_Click);
            // 
            // BTEkle
            // 
            this.BTEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTEkle.ForeColor = System.Drawing.Color.Red;
            this.BTEkle.Location = new System.Drawing.Point(579, 84);
            this.BTEkle.Name = "BTEkle";
            this.BTEkle.Size = new System.Drawing.Size(207, 71);
            this.BTEkle.TabIndex = 50;
            this.BTEkle.Text = "Aracı Sil";
            this.BTEkle.UseVisualStyleBackColor = true;
            this.BTEkle.Click += new System.EventHandler(this.BTEkle_Click);
            // 
            // AracıSistemdenSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 215);
            this.Controls.Add(this.BTGeri);
            this.Controls.Add(this.BTEkle);
            this.Controls.Add(this.LAracTik);
            this.Controls.Add(this.LSirketTik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBArac);
            this.Controls.Add(this.CBSirket);
            this.Name = "AracıSistemdenSilme";
            this.Text = "AracıSistemdenSilme";
            this.Load += new System.EventHandler(this.AracıSistemdenSilme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LAracTik;
        private System.Windows.Forms.Label LSirketTik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBArac;
        private System.Windows.Forms.ComboBox CBSirket;
        private System.Windows.Forms.Button BTGeri;
        private System.Windows.Forms.Button BTEkle;
    }
}