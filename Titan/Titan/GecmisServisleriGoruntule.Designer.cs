namespace Titan
{
    partial class GecmisServisleriGoruntule
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
            this.DTPBaslangıc = new System.Windows.Forms.DateTimePicker();
            this.DTPBitis = new System.Windows.Forms.DateTimePicker();
            this.BTServisleriGoruntule = new System.Windows.Forms.Button();
            this.CLBServisler = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DTPBaslangıc
            // 
            this.DTPBaslangıc.Location = new System.Drawing.Point(152, 21);
            this.DTPBaslangıc.Name = "DTPBaslangıc";
            this.DTPBaslangıc.Size = new System.Drawing.Size(200, 20);
            this.DTPBaslangıc.TabIndex = 0;
            // 
            // DTPBitis
            // 
            this.DTPBitis.Location = new System.Drawing.Point(152, 55);
            this.DTPBitis.Name = "DTPBitis";
            this.DTPBitis.Size = new System.Drawing.Size(200, 20);
            this.DTPBitis.TabIndex = 1;
            // 
            // BTServisleriGoruntule
            // 
            this.BTServisleriGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTServisleriGoruntule.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BTServisleriGoruntule.Location = new System.Drawing.Point(417, 21);
            this.BTServisleriGoruntule.Name = "BTServisleriGoruntule";
            this.BTServisleriGoruntule.Size = new System.Drawing.Size(167, 54);
            this.BTServisleriGoruntule.TabIndex = 2;
            this.BTServisleriGoruntule.Text = "Servisleri Görüntüle";
            this.BTServisleriGoruntule.UseVisualStyleBackColor = true;
            this.BTServisleriGoruntule.Click += new System.EventHandler(this.BTServisleriGoruntule_Click);
            // 
            // CLBServisler
            // 
            this.CLBServisler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CLBServisler.FormattingEnabled = true;
            this.CLBServisler.Location = new System.Drawing.Point(28, 148);
            this.CLBServisler.Name = "CLBServisler";
            this.CLBServisler.Size = new System.Drawing.Size(819, 274);
            this.CLBServisler.TabIndex = 3;
            this.CLBServisler.SelectedIndexChanged += new System.EventHandler(this.CLBServisler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Başlangıç Tarihi : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(25, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bitiş Tarihi : ";
            // 
            // BTGeri
            // 
            this.BTGeri.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BTGeri.Location = new System.Drawing.Point(814, 11);
            this.BTGeri.Name = "BTGeri";
            this.BTGeri.Size = new System.Drawing.Size(82, 30);
            this.BTGeri.TabIndex = 7;
            this.BTGeri.Text = "Geri";
            this.BTGeri.UseVisualStyleBackColor = true;
            this.BTGeri.Click += new System.EventHandler(this.BTGeri_Click);
            // 
            // GecmisServisleriGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 455);
            this.Controls.Add(this.BTGeri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CLBServisler);
            this.Controls.Add(this.BTServisleriGoruntule);
            this.Controls.Add(this.DTPBitis);
            this.Controls.Add(this.DTPBaslangıc);
            this.Name = "GecmisServisleriGoruntule";
            this.Text = "GecmisServisleriGoruntule";
            this.Load += new System.EventHandler(this.GecmisServisleriGoruntule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTPBaslangıc;
        private System.Windows.Forms.DateTimePicker DTPBitis;
        private System.Windows.Forms.Button BTServisleriGoruntule;
        private System.Windows.Forms.CheckedListBox CLBServisler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTGeri;
    }
}