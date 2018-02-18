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
    public partial class KullanıcıSilme : Form
    {
        private Form[] GelinenTablo;
        private string[] KullanıcıAdı = new string[1000];

        private string[] KulAdı = new string[1000];
        private string[] KulSoyadı = new string[1000];
        private string[] KulTel = new string[1000];

        private string secilenKullanıcıAdı = "-";

        private SqlConnection myConnection = Yönlendirmeler.getTitanConnection();
        private string KullanıcıBilgileriAlstr = "SELECT Adı ,Soyadı , KullanıcıAdı , Tel FROM YetkiliKisi";

        public KullanıcıSilme()
        {
            InitializeComponent();
        }

        public KullanıcıSilme(Form[] gelinentablo)
        {
            this.GelinenTablo = new Form[20];
            for (int i = 0; i < 20; i++)
            {
                this.GelinenTablo[i] = gelinentablo[i];
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
                KulTel[kullanıcıSayısı] = myReader["Tel"].ToString();

                CBKullanıcıAdı.Items.Add(KullanıcıAdı[kullanıcıSayısı]);
                kullanıcıSayısı++;
            }
            myConnection.Close();

            KulAdıTik.ForeColor = System.Drawing.Color.Red;
            KulAdıTik.Text = "*";

            LAdıTik.ForeColor = System.Drawing.Color.Red;
            LAdıTik.Text = "*";

            LTelTik.ForeColor = System.Drawing.Color.Red;
            LTelTik.Text = "*";

            LSoyadıTik.ForeColor = System.Drawing.Color.Red;
            LSoyadıTik.Text = "*";
        }

        private void KullanıcıSilme_Load(object sender, EventArgs e)
        {

        }

        private void BTGeri_Click(object sender, EventArgs e)
        {
            Yönlendirmeler.setgirilenTabloSayısı(Yönlendirmeler.getgirilenTabloSayısı() - 1);
            GelinenTablo[Yönlendirmeler.getgirilenTabloSayısı()].Show();
            this.SetVisibleCore(false);
        }

        private void CBKullanıcıAdı_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenKullanıcıAdı = KullanıcıAdı[CBKullanıcıAdı.SelectedIndex];

            TBAdı.Text = KulAdı[CBKullanıcıAdı.SelectedIndex];

            TBSoyadı.Text = KulSoyadı[CBKullanıcıAdı.SelectedIndex];

            TBTel.Text = KulTel[CBKullanıcıAdı.SelectedIndex];

            KulAdıTik.ForeColor = System.Drawing.Color.Green;
            KulAdıTik.Text = ((char)0x221A).ToString();
            LAdıTik.ForeColor = System.Drawing.Color.Green;
            LAdıTik.Text = ((char)0x221A).ToString();

            LSoyadıTik.ForeColor = System.Drawing.Color.Green;
            LSoyadıTik.Text = ((char)0x221A).ToString();

            LTelTik.ForeColor = System.Drawing.Color.Green;
            LTelTik.Text = ((char)0x221A).ToString();     

        }

        private void BTServisSil_Click(object sender, EventArgs e)
        {
            if (secilenKullanıcıAdı != "-")
            {
                DialogResult result1 = MessageBox.Show("Kullanıcıyı Silmek istediğinizden eminmisiniz ! ", "Kapatma İşlemi Onayı", MessageBoxButtons.YesNo);
                if (result1.ToString() == "Yes")
                {
                    string KullanıcıVirileriSilStr = "DELETE FROM YetkiliKisi where KullanıcıAdı = '" + secilenKullanıcıAdı + "'";
                    try
                    {
                        SqlCommand myCommand2 = new SqlCommand(KullanıcıVirileriSilStr, myConnection);
                        myCommand2.CommandType = CommandType.Text;
                        myCommand2.Connection = myConnection;

                        myConnection.Open();
                        myCommand2.ExecuteNonQuery();
                        myConnection.Close();
                        MessageBox.Show("Kullanıcı başarılı şekilde silinmiştir !");
                    }
                    catch
                    {
                        myConnection.Close();
                        MessageBox.Show("bir hata oluştu");
                    }

                }
            }
        }
    }
}
