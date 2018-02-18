using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Titan
{
    public partial class KullanıcıBilgisiDuzenle : Form
    {
        private Form[] GelinenTablo;
        private string[] KullanıcıAdı = new string[1000];

        private string[] KulAdı = new string[1000];
        private string[] KulSoyadı = new string[1000];
        private string[] KulTel = new string[1000];
        private string[] KulTel2 = new string[1000];
        private string[] KulMail = new string[1000];
        private string[] KulSifre = new string[1000];
        private char seciliKullanıcıSeviyesi = '-';

        private char[] YetkiDüzeyi = new char[1000];

        private string secilenKullanıcıAdı = "-";

        private SqlConnection myConnection = Yönlendirmeler.getTitanConnection();
        private string KullanıcıBilgileriAlstr = "SELECT Adı ,Soyadı , KullanıcıAdı , Sifre , Tel , Tel2 , Email , YetkiDüzeyi FROM YetkiliKisi";


        public KullanıcıBilgisiDuzenle()
        {
            InitializeComponent();
        }

        public KullanıcıBilgisiDuzenle(Form[] GelinenTablo)
        {
            
            this.GelinenTablo = GelinenTablo;
            for (int i = 0; i < 20; i++)
            {
                this.GelinenTablo[i] = GelinenTablo[i];
            }
            InitializeComponent();

            int kullanıcıSayısı = 0;

            myConnection.Open();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand(KullanıcıBilgileriAlstr, myConnection);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                KulAdı[kullanıcıSayısı] = myReader["Adı"].ToString();
                KulSoyadı[kullanıcıSayısı] = myReader["Soyadı"].ToString();
                KullanıcıAdı[kullanıcıSayısı] = myReader["KullanıcıAdı"].ToString();
                KulSifre[kullanıcıSayısı] = myReader["Sifre"].ToString();
                KulTel[kullanıcıSayısı] = myReader["Tel"].ToString();
                KulTel2[kullanıcıSayısı] = myReader["Tel2"].ToString();
                KulMail[kullanıcıSayısı] = myReader["Email"].ToString();
                YetkiDüzeyi[kullanıcıSayısı] = myReader["YetkiDüzeyi"].ToString().ToCharArray()[0];

                CBKullanıcıAdı.Items.Add(KullanıcıAdı[kullanıcıSayısı]);
                kullanıcıSayısı++;
            }
            myConnection.Close();
        }

        private void KullanıcıBilgisiDuzenle_Load(object sender, EventArgs e)
        {
            LAdıTik.ForeColor = System.Drawing.Color.Red;
            LAdıTik.Text = "*";
            LSoyadıTik.ForeColor = System.Drawing.Color.Red;
            LSoyadıTik.Text = "*";
            LTelTik.ForeColor = System.Drawing.Color.Red;
            LTelTik.Text = "*";
            KulAdıTik.ForeColor = System.Drawing.Color.Red;
            KulAdıTik.Text = "*";
            LYetkiDuzeyiTik.ForeColor = System.Drawing.Color.Red;
            LYetkiDuzeyiTik.Text = "*";
        }

        private void CBKullanıcıAdı_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenKullanıcıAdı = KullanıcıAdı[CBKullanıcıAdı.SelectedIndex];

            TBAdı.Text = KulAdı[CBKullanıcıAdı.SelectedIndex];

            TBSoyadı.Text = KulSoyadı[CBKullanıcıAdı.SelectedIndex];

            TBSifre.Text = KulSifre[CBKullanıcıAdı.SelectedIndex];

            TBTel.Text = KulTel[CBKullanıcıAdı.SelectedIndex];

            TBTel2.Text = KulTel2[CBKullanıcıAdı.SelectedIndex];

            TBMail.Text = KulMail[CBKullanıcıAdı.SelectedIndex];

            if (YetkiDüzeyi[CBKullanıcıAdı.SelectedIndex] == 1)
            {
                
            }

            KulAdıTik.ForeColor = System.Drawing.Color.Green;
            KulAdıTik.Text = ((char)0x221A).ToString();
            LAdıTik.ForeColor = System.Drawing.Color.Green;
            LAdıTik.Text = ((char)0x221A).ToString();

            LSoyadıTik.ForeColor = System.Drawing.Color.Green;
            LSoyadıTik.Text = ((char)0x221A).ToString();

            LTelTik.ForeColor = System.Drawing.Color.Green;
            LTelTik.Text = ((char)0x221A).ToString();     
        }

        private void CBAdmin_CheckedChanged(object sender, EventArgs e)
        {
            CBPersonel.Checked = false;
            CBYönetici.Checked = false;

            if (CBAdmin.Checked == true)
            {
                LYetkiDuzeyiTik.ForeColor = System.Drawing.Color.Green;
                LYetkiDuzeyiTik.Text = ((char)0x221A).ToString();
                seciliKullanıcıSeviyesi = '1';
            }
            else
            {
                LYetkiDuzeyiTik.ForeColor = System.Drawing.Color.Red;
                LYetkiDuzeyiTik.Text = "*";
                seciliKullanıcıSeviyesi = '-';
            }
        }

        private void CBPersonel_CheckedChanged(object sender, EventArgs e)
        {
            CBAdmin.Checked = false;
            CBYönetici.Checked = false;

            if (CBPersonel.Checked == true)
            {
                LYetkiDuzeyiTik.ForeColor = System.Drawing.Color.Green;
                LYetkiDuzeyiTik.Text = ((char)0x221A).ToString();
                seciliKullanıcıSeviyesi = '2';
            }
            else
            {
                LYetkiDuzeyiTik.ForeColor = System.Drawing.Color.Red;
                LYetkiDuzeyiTik.Text = "*";
                seciliKullanıcıSeviyesi = '-';
            }
        }

        private void CBYönetici_CheckedChanged(object sender, EventArgs e)
        {
            CBAdmin.Checked = false;
            CBPersonel.Checked = false;

            if (CBYönetici.Checked == true)
            {
                LYetkiDuzeyiTik.ForeColor = System.Drawing.Color.Green;
                LYetkiDuzeyiTik.Text = ((char)0x221A).ToString();
                seciliKullanıcıSeviyesi = '3';
            }
            else
            {
                LYetkiDuzeyiTik.ForeColor = System.Drawing.Color.Red;
                LYetkiDuzeyiTik.Text = "*";
                seciliKullanıcıSeviyesi = '-';
            }
        }

        private void BtKullanıcıEkle_Click(object sender, EventArgs e)
        {
            if (TBAdı.Text.Count() > 1 && TBSoyadı.Text.Count() > 1)
            {
                string kullanıcıDuzenle = "UPDATE YetkiliKisi SET Adı = '" + TBAdı.Text.ToString()+
                "' , Soyadı= '"+ TBSoyadı.Text.ToString()+"' ,Sifre = '"+ TBSifre.Text.ToString()+
                "' ,Tel = '" +TBTel.Text.ToString()+"' ,Tel2 = '"+TBTel2.Text.ToString()+
                "' ,Email = '"+TBMail.Text.ToString()+"' ,YetkiDüzeyi = '" +seciliKullanıcıSeviyesi+
                "'  WHERE KullanıcıAdı = '"+secilenKullanıcıAdı+"'";
                try
                {
                    SqlCommand myCommand2 = new SqlCommand(kullanıcıDuzenle, myConnection);
                    myCommand2.CommandType = CommandType.Text;
                    myCommand2.Connection = myConnection;

                    myConnection.Open();
                    myCommand2.ExecuteNonQuery();
                    myConnection.Close();
                    MessageBox.Show("Kullanıcı Bilgileri Başarılı şekilde güncellendi !");
                }
                catch
                {
                    myConnection.Close();
                    MessageBox.Show("bir hata oluştu !");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Gerekli alanları doldurunuz !");
            }
        }

        private void BTGeri_Click(object sender, EventArgs e)
        {
            Yönlendirmeler.setgirilenTabloSayısı(Yönlendirmeler.getgirilenTabloSayısı() - 1);
            GelinenTablo[Yönlendirmeler.getgirilenTabloSayısı()].Show();
            this.SetVisibleCore(false);
        }
    }
}
