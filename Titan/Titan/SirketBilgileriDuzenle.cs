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
    public partial class SirketBilgileriDuzenle : Form
    {
        private Form[] GelinenTablo;
        private int SirketSayısı = 0;
        private int secilenSirketId = -1;
        private int[] sirketId = new int[500];
        private string[] sirketAdı = new string[500];
        private string[] SirketAdresi = new string[500];
        private string[] SirketTel = new string[500];
        private string[] SirketTel2 = new string[500];
        private string[] SirketTel3 = new string[500];
        private string[] SirketMail = new string[500];
        private string[] SirketMail2 = new string[500];
        private string[] Acıklama = new string[500];

        private SqlConnection myConnection = Yönlendirmeler.getTitanConnection();
        private string SirketVirileriStr = "SELECT SirketId ,SirketAdı , SirketAdresi , SirketTel, SirketTel2, SirketTel3, SirketMail, SirketMail2 , Acıklama FROM SirketBilgileri";

        public SirketBilgileriDuzenle()
        {
            InitializeComponent();
        }

        public SirketBilgileriDuzenle(Form[] gelinenTablo)
        {
            this.GelinenTablo = new Form[20];
            for (int i = 0; i < 20; i++)
            {
                this.GelinenTablo[i] = gelinenTablo[i];
            }

            InitializeComponent();

            SirketSayısı = 0;

            myConnection.Open();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand(SirketVirileriStr, myConnection);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                sirketId[SirketSayısı] = myReader["SirketId"].GetHashCode();
                sirketAdı[SirketSayısı] = myReader["SirketAdı"].ToString();
                SirketAdresi[SirketSayısı] = myReader["SirketAdresi"].ToString();
                SirketTel[SirketSayısı] = myReader["SirketTel"].ToString();
                SirketTel2[SirketSayısı] = myReader["SirketTel2"].ToString();
                SirketTel3[SirketSayısı] = myReader["SirketTel3"].ToString();
                SirketMail[SirketSayısı] = myReader["SirketMail"].ToString();
                SirketMail2[SirketSayısı] = myReader["SirketMail2"].ToString();
                Acıklama[SirketSayısı] = myReader["Acıklama"].ToString();
                CBSirket.Items.Add(sirketAdı[SirketSayısı]);
                SirketSayısı++;
            }
            myConnection.Close();

            LSirketTik.ForeColor = System.Drawing.Color.Red;
            LSirketTik.Text = "*";

        }

        private void SirketBilgileriDuzenle_Load(object sender, EventArgs e)
        {

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
            if (TBSirketTel1.Text.Length > 7)
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
            if (TBSirketAdresi.Text.Length > 19)
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

        private void BTEkle_Click(object sender, EventArgs e)
        {
            if (TBSirketAdı.Text.Length > 3 && TBSirketTel1.Text.Length > 9 && TBSirketAdresi.Text.Length > 19)
            {
                try
                {
                    string updateSirketbilgileri = ""+
                    "update SirketBilgileri set SirketAdı = '"+TBSirketAdı.Text.ToString()+"',SirketAdresi = '"+TBSirketAdresi.Text.ToString()+
                    "' ,SirketTel = '"+TBSirketTel1.Text.ToString()+"',sirketTel2 = '"+ TBSirketTel2.Text.ToString()+"' "+
                    ",sirketTel3 = '"+TBSirketTel3.Text.ToString()+"'" +
                    ",SirketMail = '"+TBSirketMail.Text.ToString()+"',SirketMail2 = '"+TBSirketMail2.Text.ToString()+"'"+
                    ",Acıklama = '" + TBSirketAcıklama.Text.ToString() + "' where SirketId = " + secilenSirketId;

                    try
                    {
                        SqlCommand myCommand2 = new SqlCommand(updateSirketbilgileri, myConnection);
                        myCommand2.CommandType = CommandType.Text;
                        myCommand2.Connection = myConnection;

                        myConnection.Open();
                        myCommand2.ExecuteNonQuery();
                        myConnection.Close();
                    }
                    catch
                    {
                        myConnection.Close();
                        MessageBox.Show("bir hata oluştu !");
                    }

                    myConnection.Close();
                    MessageBox.Show("Şirket Başarılı Şekilde Kaydedildi !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lütfen gerekli alanları doldurunuz !");
                }
            }
            else
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz !");
            }
        }

        private void CBSirket_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenSirketId = sirketId[CBSirket.SelectedIndex];
            if (CBSirket.SelectedIndex > -1)
            {

                LSirketTik.ForeColor = System.Drawing.Color.Green;
                LSirketTik.Text = ((char)0x221A).ToString();
            }
            else
            {
                LSirketAdresiTik.ForeColor = System.Drawing.Color.Red;
                LSirketAdresiTik.Text = "*";
            }

            TBSirketAdı.Text = sirketAdı[CBSirket.SelectedIndex];
            TBSirketAdresi.Text = SirketAdresi[CBSirket.SelectedIndex];
            TBSirketAcıklama.Text = Acıklama[CBSirket.SelectedIndex];
            TBSirketMail.Text = SirketMail[CBSirket.SelectedIndex];
            TBSirketMail2.Text = SirketMail2[CBSirket.SelectedIndex];
            TBSirketTel1.Text = SirketTel[CBSirket.SelectedIndex];
            TBSirketTel2.Text = SirketTel2[CBSirket.SelectedIndex];
            TBSirketTel3.Text = SirketTel3[CBSirket.SelectedIndex];

        }
    }
}
