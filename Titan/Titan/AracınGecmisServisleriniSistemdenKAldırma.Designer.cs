namespace Titan
{
    partial class AracınGecmisServisleriniSistemdenKAldırma
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
            this.BTGeri = new System.Windows.Forms.Button();
            this.LAracTik = new System.Windows.Forms.Label();
            this.LSirketTik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBArac = new System.Windows.Forms.ComboBox();
            this.CBSirket = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DTPBitis = new System.Windows.Forms.DateTimePicker();
            this.BTServisSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTGeri
            // 
            this.BTGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTGeri.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BTGeri.Location = new System.Drawing.Point(611, 12);
            this.BTGeri.Name = "BTGeri";
            this.BTGeri.Size = new System.Drawing.Size(80, 27);
            this.BTGeri.TabIndex = 14;
            this.BTGeri.Text = "Geri";
            this.BTGeri.UseVisualStyleBackColor = true;
            this.BTGeri.Click += new System.EventHandler(this.BTGeri_Click);
            // 
            // LAracTik
            // 
            this.LAracTik.AutoSize = true;
            this.LAracTik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LAracTik.ForeColor = System.Drawing.Color.Green;
            this.LAracTik.Location = new System.Drawing.Point(517, 87);
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
            this.LSirketTik.Location = new System.Drawing.Point(517, 42);
            this.LSirketTik.Name = "LSirketTik";
            this.LSirketTik.Size = new System.Drawing.Size(20, 24);
            this.LSirketTik.TabIndex = 33;
            this.LSirketTik.Text = "L";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(16, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Araç : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(16, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Şirket : ";
            // 
            // CBArac
            // 
            this.CBArac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBArac.FormattingEnabled = true;
            this.CBArac.Location = new System.Drawing.Point(78, 84);
            this.CBArac.Name = "CBArac";
            this.CBArac.Size = new System.Drawing.Size(434, 24);
            this.CBArac.TabIndex = 30;
            this.CBArac.SelectedIndexChanged += new System.EventHandler(this.CBArac_SelectedIndexChanged);
            // 
            // CBSirket
            // 
            this.CBSirket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBSirket.FormattingEnabled = true;
            this.CBSirket.Location = new System.Drawing.Point(78, 41);
            this.CBSirket.Name = "CBSirket";
            this.CBSirket.Size = new System.Drawing.Size(434, 24);
            this.CBSirket.TabIndex = 29;
            this.CBSirket.SelectedIndexChanged += new System.EventHandler(this.CBSirket_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(16, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Tarihinden Önceki Servisleri sil : ";
            // 
            // DTPBitis
            // 
            this.DTPBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DTPBitis.Location = new System.Drawing.Point(19, 167);
            this.DTPBitis.Name = "DTPBitis";
            this.DTPBitis.Size = new System.Drawing.Size(319, 29);
            this.DTPBitis.TabIndex = 36;
            // 
            // BTServisSil
            // 
            this.BTServisSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTServisSil.ForeColor = System.Drawing.Color.Red;
            this.BTServisSil.Location = new System.Drawing.Point(545, 167);
            this.BTServisSil.Name = "BTServisSil";
            this.BTServisSil.Size = new System.Drawing.Size(146, 61);
            this.BTServisSil.TabIndex = 37;
            this.BTServisSil.Text = "Servisleri Sil";
            this.BTServisSil.UseVisualStyleBackColor = true;
            this.BTServisSil.Click += new System.EventHandler(this.BTServisSil_Click);
            // 
            // AracınGecmisServisleriniSistemdenKAldırma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 266);
            this.Controls.Add(this.BTServisSil);
            this.Controls.Add(this.DTPBitis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LAracTik);
            this.Controls.Add(this.LSirketTik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBArac);
            this.Controls.Add(this.CBSirket);
            this.Controls.Add(this.BTGeri);
            this.Name = "AracınGecmisServisleriniSistemdenKAldırma";
            this.Text = "AracınGecmisServisleriniSistemdenKAldırma";
            this.Load += new System.EventHandler(this.AracınGecmisServisleriniSistemdenKAldırma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTGeri;
        private System.Windows.Forms.Label LAracTik;
        private System.Windows.Forms.Label LSirketTik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBArac;
        private System.Windows.Forms.ComboBox CBSirket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTPBitis;
        private System.Windows.Forms.Button BTServisSil;
    }
}