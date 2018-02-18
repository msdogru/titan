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

namespace Titan
{
    public partial class YeniSirketEkle : Form
    {
        private SqlConnection myConnection = Yönlendirmeler.getTitanConnection();
        private string MevcutTabloismi = "YenisirketEkle";
        private Form[] GelinenTablo = new Form[20];

        private string KullanıcıYetkiSeviyesi = "";


        public YeniSirketEkle()
        {
            InitializeComponent();
        }

        public YeniSirketEkle(Form[] GelinenTablo, string KullanıcıYetkiSeviyesi)
        {
            this.GelinenTablo = GelinenTablo;

            this.KullanıcıYetkiSeviyesi = KullanıcıYetkiSeviyesi;
            for (int i = 0; i < 20; i++)
            {
                this.GelinenTablo[i] = GelinenTablo[i];
            }
            InitializeComponent();

        }

        private void BTEkle_Click(object sender, EventArgs e)
        {
            if(TBSirketAdı.Text.Length > 3 && TBSirketTel1.Text.Length > 9 && TBSirketAdresi.Text.Length > 20)
            {
               try
                {
                    SqlCommand myCommand = new SqlCommand("" +
                    "INSERT INTO SirketBilgileri (SirketAdı,SirketAdresi,SirketTel,sirketTel2,sirketTel3" +
                    ",SirketMail,SirketMail2,Acıklama) VALUES('" + TBSirketAdı.Text.ToString() +
                    "','" + TBSirketAdresi.Text.ToString() + "','" + TBSirketTel1.Text.ToString() +
                    "','" + TBSirketTel2.Text.ToString() + "','" + TBSirketTel3.Text.ToString() +
                    "','" + TBSirketMail.Text.ToString() + "','" + TBSirketMail2.Text.ToString() +
                    "','" + TBSirketAcıklama.Text.ToString() + "')");

                    myCommand.CommandType = CommandType.Text;
                    myCommand.Connection = myConnection;

                    myCommand.Parameters.AddWithValue("@SirketAdı", TBSirketAdı.Text);
                    myCommand.Parameters.AddWithValue("@SirketAdresi", TBSirketAdresi.Text);
                    myCommand.Parameters.AddWithValue("@SirketTel", TBSirketTel1.Text);
                    myCommand.Parameters.AddWithValue("@sirketTel2", TBSirketTel2.Text);
                    myCommand.Parameters.AddWithValue("@sirketTel3", TBSirketTel3.Text);
                    myCommand.Parameters.AddWithValue("@SirketMail", TBSirketMail.Text);
                    myCommand.Parameters.AddWithValue("@SirketMail2", TBSirketMail2.Text);
                    myCommand.Parameters.AddWithValue("@Acıklama", TBSirketAcıklama.Text);

                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                   
                    myConnection.Close();
                    MessageBox.Show("Şirket Başarılı Şekilde Kaydedildi !");
            }
            catch(Exception ex)
                {
                    MessageBox.Show("Lütfen gerekli alanları doldurunuz !");
                }
            }
            else
            {
                 MessageBox.Show("Lütfen gerekli alanları doldurunuz !");
            }
        }

        private void BTCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void YeniSirketEkle_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            LSirketAdiTik.ForeColor = System.Drawing.Color.Red;
            LSirketAdiTik.Text = "*";
            LSirketTelTik.ForeColor = System.Drawing.Color.Red;
            LSirketTelTik.Text = "*";
            LSirketAdresiTik.ForeColor = System.Drawing.Color.Red;
            LSirketAdresiTik.Text = "*";
        }

        private void BTGeri_Click(object sender, EventArgs e)
        {
            Yönlendirmeler.setgirilenTabloSayısı(Yönlendirmeler.getgirilenTabloSayısı() - 1);
            GelinenTablo[Yönlendirmeler.getgirilenTabloSayısı()].Show();
            this.SetVisibleCore(false);
        }

        private void TBSirketAdı_TextChanged(object sender, EventArgs e)
        {
            if (TBSirketAdı.Text.Length > 3)
            {
                LSirketAdiTik.ForeColor = System.Drawing.Color.Green;
                LSirketAdiTik.Text = ((char)0x221A).ToString();
            }
            else
            {
                LSirketAdiTik.ForeColor = System.Drawing.Color.Red;
                LSirketAdiTik.Text = "*";
            }
        }

        private void TBSirketTel1_TextChanged(object sender, EventArgs e)
        {
            if (TBSirketTel1.Text.Length > 10)
            {
                LSirketTelTik.ForeColor = System.Drawing.Color.Green;
                LSirketTelTik.Text = ((char)0x221A).ToString();
            }
            else
            {
                LSirketTelTik.ForeColor = System.Drawing.Color.Red;
                LSirketTelTik.Text = "*";
            }
        }

        private void TBSirketAdresi_TextChanged(object sender, EventArgs e)
        {
            if (TBSirketAdresi.Text.Length > 20)
            {
                LSirketAdresiTik.ForeColor = System.Drawing.Color.Green;
                LSirketAdresiTik.Text = ((char)0x221A).ToString();
            }
            else
            {
                LSirketAdresiTik.ForeColor = System.Drawing.Color.Red;
                LSirketAdresiTik.Text = "*";
            }
        }
    }
}
