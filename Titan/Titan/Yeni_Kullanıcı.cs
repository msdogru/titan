using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Collections.Generic;




namespace Titan
{
    public partial class Yeni_Kullanıcı : Form
    {
        private SqlConnection myConnection = Yönlendirmeler.getTitanConnection();
        private string MevcutTabloismi = "YeniKullanıcı";
        private Form[] GelinenTablo = new Form[20];
        private string KullanıcıYetkiSeviyesi = "";
        private string seciliKullanıcıSeviyesi = "";

        public Yeni_Kullanıcı()
        {
            InitializeComponent();
        }

        public Yeni_Kullanıcı(Form[] GelinenTablo, string KullanıcıYetkiSeviyesi)
        {
            InitializeComponent();
            this.GelinenTablo = GelinenTablo;
            this.KullanıcıYetkiSeviyesi = KullanıcıYetkiSeviyesi;
            for (int i = 0; i < 20; i++)
            {
                this.GelinenTablo[i] = GelinenTablo[i];
            }
        }


        //private void BtCıkıs_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}

        private void BtKullanıcıEkle_Click(object sender, EventArgs e)
        {
            if (TBAdı.Text.Count() > 1 && TBSoyadı.Text.Count() > 1 && TBKullanıcıAdı.Text.Count() > 2)
            {
                if (TBSifre.Text.ToString() == TBSifreTekrar.Text.ToString())
                {
                    try
                    {
                        SqlCommand myCommand = new SqlCommand("insert into YetkiliKisi (Adı , Soyadı , " +
                            "KullanıcıAdı , Sifre ,Tel,Tel2,Email,YetkiDüzeyi) values(@Adı,@Soyadı,@KullanıcıAdı" +
                            ",@Sifre,@Tel,@Tel2,@Email,@YetkiDüzeyi)", myConnection);
                        myCommand.CommandType = CommandType.Text;
                        myCommand.Connection = myConnection;

                        myCommand.Parameters.AddWithValue("@Adı", TBAdı.Text);
                        myCommand.Parameters.AddWithValue("@Soyadı", TBSoyadı.Text);
                        myCommand.Parameters.AddWithValue("@KullanıcıAdı", TBKullanıcıAdı.Text);
                        myCommand.Parameters.AddWithValue("@Sifre", TBSifre.Text);
                        myCommand.Parameters.AddWithValue("@Tel", TBTel.Text);
                        myCommand.Parameters.AddWithValue("@Tel2", TBTel2.Text);
                        myCommand.Parameters.AddWithValue("@Email", TBMail.Text);
                        myCommand.Parameters.AddWithValue("@YetkiDüzeyi", seciliKullanıcıSeviyesi);
                        myConnection.Open();
                        myCommand.ExecuteNonQuery();
                        MessageBox.Show("kullanıcı başarılı şekilde eklendi !");
                        myConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        myConnection.Close();
                        MessageBox.Show("Bir hata oluştu yada girilen kullanıcı adı zaten kullanılmakta ! lütfen gerekli alanları doldurunuz !");
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler Eşleşmedi Lütfen tekrar deneyiniz !");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Gerekli alanları doldurunuz !");
            }
        }

        private void Yeni_Kullanıcı_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            LAdıTik.ForeColor = System.Drawing.Color.Red;
            LAdıTik.Text = "*";
            LSoyadıTik.ForeColor = System.Drawing.Color.Red;
            LSoyadıTik.Text = "*";
            LTelTik.ForeColor = System.Drawing.Color.Red;
            LTelTik.Text = "*";
            LKullanıcıAdıTik.ForeColor = System.Drawing.Color.Red;
            LKullanıcıAdıTik.Text = "*";
            LSifreTik.ForeColor = System.Drawing.Color.Red;
            LSifreTik.Text = "*";
            LSifreKontrolTik.ForeColor = System.Drawing.Color.Red;
            LSifreKontrolTik.Text = "*";
            LYetkiDuzeyiTik.ForeColor = System.Drawing.Color.Red;
            LYetkiDuzeyiTik.Text = "*";

        }

        private void BTGeri_Click(object sender, EventArgs e)
        {

            Yönlendirmeler.setgirilenTabloSayısı(Yönlendirmeler.getgirilenTabloSayısı() - 1);
            GelinenTablo[Yönlendirmeler.getgirilenTabloSayısı()].Show();
            this.SetVisibleCore(false);
        }

        private void TBAdı_TextChanged(object sender, EventArgs e)
        {
            if (TBAdı.Text.Length > 1)
            {
                LAdıTik.ForeColor = System.Drawing.Color.Green;
                LAdıTik.Text = ((char)0x221A).ToString();
            }
            else
            {
                LAdıTik.ForeColor = System.Drawing.Color.Red;
                LAdıTik.Text = "*";
            }
        }

        private void TBSoyadı_TextChanged(object sender, EventArgs e)
        {
            if (TBSoyadı.Text.Length > 1)
            { 
                LSoyadıTik.ForeColor = System.Drawing.Color.Green;
                LSoyadıTik.Text = ((char)0x221A).ToString();
            }
            else
            {
                LSoyadıTik.ForeColor = System.Drawing.Color.Red;
                LSoyadıTik.Text = "*";
            }
        }

        private void TBTel_TextChanged(object sender, EventArgs e)
        {
            if (TBTel.Text.Length > 9)
            {
                LTelTik.ForeColor = System.Drawing.Color.Green;
                LTelTik.Text = ((char)0x221A).ToString();
            }
            else
            {
                LTelTik.ForeColor = System.Drawing.Color.Red;
                LTelTik.Text = "*";
            }
        }

        private void TBKullanıcıAdı_TextChanged(object sender, EventArgs e)
        {
            if (TBKullanıcıAdı.Text.Length > 1)
            {
                LKullanıcıAdıTik.ForeColor = System.Drawing.Color.Green;
                LKullanıcıAdıTik.Text = ((char)0x221A).ToString();
            }
            else
            {
                LKullanıcıAdıTik.ForeColor = System.Drawing.Color.Red;
                LKullanıcıAdıTik.Text = "*";
            }
        }

        private void TBSifre_TextChanged(object sender, EventArgs e)
        {
            if (TBSifre.Text.Length > 1)
            {
                LSifreTik.ForeColor = System.Drawing.Color.Green;
                LSifreTik.Text = ((char)0x221A).ToString();
            }
            else
            {
                LSifreTik.ForeColor = System.Drawing.Color.Red;
                LSifreTik.Text = "*";
            }
        }

        private void TBSifreTekrar_TextChanged(object sender, EventArgs e)
        {
            if (TBSifreTekrar.Text.Length > 1 && TBSifre.Text == TBSifreTekrar.Text)
            {
                LSifreKontrolTik.ForeColor = System.Drawing.Color.Green;
                LSifreKontrolTik.Text = ((char)0x221A).ToString();
            }
            else
            {
                LSifreKontrolTik.ForeColor = System.Drawing.Color.Red;
                LSifreKontrolTik.Text = "*";
            }
        }

        private void CBAdmin_CheckedChanged(object sender, EventArgs e)
        {  
            CBPersonel.Checked = false;
            CBYönetici.Checked = false;

            if (CBAdmin.Checked == true)
            {
                LYetkiDuzeyiTik.ForeColor = System.Drawing.Color.Green;
                LYetkiDuzeyiTik.Text = ((char)0x221A).ToString();
                seciliKullanıcıSeviyesi = "1";
            }
            else
            {
                LYetkiDuzeyiTik.ForeColor = System.Drawing.Color.Red;
                LYetkiDuzeyiTik.Text = "*";
                seciliKullanıcıSeviyesi = "";
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
                seciliKullanıcıSeviyesi = "2";
            }
            else
            {
                LYetkiDuzeyiTik.ForeColor = System.Drawing.Color.Red;
                LYetkiDuzeyiTik.Text = "*";
                seciliKullanıcıSeviyesi = "";
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
                seciliKullanıcıSeviyesi = "3";
            }
            else
            {
                LYetkiDuzeyiTik.ForeColor = System.Drawing.Color.Red;
                LYetkiDuzeyiTik.Text = "*";
                seciliKullanıcıSeviyesi = "";
            }
        }
    }
}
