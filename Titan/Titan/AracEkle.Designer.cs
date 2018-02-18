namespace Titan
{
    partial class AracEkle
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
            this.BTAracEkle = new System.Windows.Forms.Button();
            this.BTGeri = new System.Windows.Forms.Button();
            this.BTCıkıs = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CBAracinSirketi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TBAracSeriNo = new System.Windows.Forms.TextBox();
            this.TBAracModel = new System.Windows.Forms.TextBox();
            this.TBAcıklama = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTAracEkle
            // 
            this.BTAracEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTAracEkle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BTAracEkle.Location = new System.Drawing.Point(471, 234);
            this.BTAracEkle.Name = "BTAracEkle";
            this.BTAracEkle.Size = new System.Drawing.Size(171, 46);
            this.BTAracEkle.TabIndex = 0;
            this.BTAracEkle.Text = "Aracı Ekle";
            this.BTAracEkle.UseVisualStyleBackColor = true;
            this.BTAracEkle.Click += new System.EventHandler(this.BTAracEkle_Click);
            // 
            // BTGeri
            // 
            this.BTGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTGeri.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BTGeri.Location = new System.Drawing.Point(471, 12);
            this.BTGeri.Name = "BTGeri";
            this.BTGeri.Size = new System.Drawing.Size(80, 27);
            this.BTGeri.TabIndex = 1;
            this.BTGeri.Text = "Geri";
            this.BTGeri.UseVisualStyleBackColor = true;
            this.BTGeri.Click += new System.EventHandler(this.BTGeri_Click);
            // 
            // BTCıkıs
            // 
            this.BTCıkıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTCıkıs.ForeColor = System.Drawing.Color.Red;
            this.BTCıkıs.Location = new System.Drawing.Point(557, 12);
            this.BTCıkıs.Name = "BTCıkıs";
            this.BTCıkıs.Size = new System.Drawing.Size(85, 27);
            this.BTCıkıs.TabIndex = 2;
            this.BTCıkıs.Text = "Çıkış";
            this.BTCıkıs.UseVisualStyleBackColor = true;
            this.BTCıkıs.Click += new System.EventHandler(this.BTCıkıs_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(26, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aracın Ait olduğu şirket :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(26, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Araç seri No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(26, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Araç Model :";
            // 
            // CBAracinSirketi
            // 
            this.CBAracinSirketi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBAracinSirketi.FormattingEnabled = true;
            this.CBAracinSirketi.Location = new System.Drawing.Point(29, 45);
            this.CBAracinSirketi.Name = "CBAracinSirketi";
            this.CBAracinSirketi.Size = new System.Drawing.Size(358, 24);
            this.CBAracinSirketi.TabIndex = 7;
            this.CBAracinSirketi.SelectedIndexChanged += new System.EventHandler(this.CBAracinSirketi_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(26, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Açıklama :";
            // 
            // TBAracSeriNo
            // 
            this.TBAracSeriNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBAracSeriNo.Location = new System.Drawing.Point(119, 99);
            this.TBAracSeriNo.Name = "TBAracSeriNo";
            this.TBAracSeriNo.Size = new System.Drawing.Size(268, 23);
            this.TBAracSeriNo.TabIndex = 10;
            // 
            // TBAracModel
            // 
            this.TBAracModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBAracModel.Location = new System.Drawing.Point(119, 133);
            this.TBAracModel.Name = "TBAracModel";
            this.TBAracModel.Size = new System.Drawing.Size(268, 23);
            this.TBAracModel.TabIndex = 11;
            // 
            // TBAcıklama
            // 
            this.TBAcıklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBAcıklama.Location = new System.Drawing.Point(29, 195);
            this.TBAcıklama.Multiline = true;
            this.TBAcıklama.Name = "TBAcıklama";
            this.TBAcıklama.Size = new System.Drawing.Size(358, 85);
            this.TBAcıklama.TabIndex = 12;
            // 
            // AracEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 313);
            this.Controls.Add(this.TBAcıklama);
            this.Controls.Add(this.TBAracModel);
            this.Controls.Add(this.TBAracSeriNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CBAracinSirketi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTCıkıs);
            this.Controls.Add(this.BTGeri);
            this.Controls.Add(this.BTAracEkle);
            this.Name = "AracEkle";
            this.Text = "AracEkle";
            this.Load += new System.EventHandler(this.AracEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTAracEkle;
        private System.Windows.Forms.Button BTGeri;
        private System.Windows.Forms.Button BTCıkıs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBAracinSirketi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBAracSeriNo;
        private System.Windows.Forms.TextBox TBAracModel;
        private System.Windows.Forms.TextBox TBAcıklama;
    }
}