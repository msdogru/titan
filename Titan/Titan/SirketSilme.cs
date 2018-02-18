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
    public partial class SirketSilme : Form
    {

        private Form[] GelinenTablo;
        private int SirketSayısı = 0;
        private int secilenSirketId = -1;
        private int[] sirketId = new int[500];
        private string[] sirketAdı = new string[500];

        private string[] AracModel = new string[1000];
        private string[] AracseriNo = new string[1000];

        private SqlConnection myConnection = Yönlendirmeler.getTitanConnection();
        private string SirketVirileriStr = "SELECT SirketId ,SirketAdı FROM SirketBilgileri";

        public SirketSilme()
        {
            InitializeComponent();
        }

        public SirketSilme(Form[] gelinenTablo)
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
                CBSirket.Items.Add(sirketAdı[SirketSayısı]);
                SirketSayısı++;
            }
            myConnection.Close();

            LSirketTik.ForeColor = System.Drawing.Color.Red;
            LSirketTik.Text = "*";
        }

        private void SirketSilme_Load(object sender, EventArgs e)
        {

        }

        private void CBSirket_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenSirketId = sirketId[CBSirket.SelectedIndex];

            TBSirketAdı.Text = sirketAdı[CBSirket.SelectedIndex];


            LSirketTik.ForeColor = System.Drawing.Color.Green;
            LSirketTik.Text = ((char)0x221A).ToString();
            LSirketAdiTik.ForeColor = System.Drawing.Color.Green;
            LSirketAdiTik.Text = ((char)0x221A).ToString();     
        }

        private void BTEkle_Click(object sender, EventArgs e)
        {
            string AracVirileriStr = "SELECT AracModel ,AracSeriNo FROM AracBilgileri where SirketId = '" + secilenSirketId + "'";
            string SirketVirileriStr = "DELETE FROM SirketBilgileri where SirketId = '" + secilenSirketId + "'";

            int AracSayısı = 0;

            myConnection.Open();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand(AracVirileriStr, myConnection);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                AracModel[AracSayısı] = myReader["AracModel"].ToString();
                AracseriNo[AracSayısı] = myReader["AracSeriNo"].ToString();
                AracSayısı++;
            }
            myConnection.Close();
            DialogResult result1 = MessageBox.Show("Şirkete Ait tüm bilgileri silmek istediğinizden Eminmisiniz ? \n\n Sirkete Ait " + AracSayısı.ToString() + "Aracın Bilgileri İle Sirkete Ait Tüm Bilgiler Silinicektir Silinicektir ! ", "Kapatma İşlemi Onayı", MessageBoxButtons.YesNo);
            if (result1.ToString() == "Yes")
            {
                try
                {
                    for (int i = 0; i < AracSayısı; i++)
                    {
                        AracSilme(AracModel[i], AracseriNo[i]);
                    }

                    SirketSorumlularıSilme(secilenSirketId);

                    SqlCommand myCommand2 = new SqlCommand(SirketVirileriStr, myConnection);
                    myCommand2.CommandType = CommandType.Text;
                    myCommand2.Connection = myConnection;

                    myConnection.Open();
                    myCommand2.ExecuteNonQuery();
                    myConnection.Close();
                    MessageBox.Show("Şirket Başarılı Şekilde silindi !");
                }
                catch
                {
                    myConnection.Close();
                    MessageBox.Show("bir hata oluştu");
                }
            }

        }

        private void SirketSorumlularıSilme(int SirketId)
        {
            string SirketSorumluVirileriStr = "DELETE FROM SirketYetkiliKisi where SirketId = '" + SirketId.ToString() + "'";
            try
            {
                SqlCommand myCommand2 = new SqlCommand(SirketSorumluVirileriStr, myConnection);
                myCommand2.CommandType = CommandType.Text;
                myCommand2.Connection = myConnection;

                myConnection.Open();
                myCommand2.ExecuteNonQuery();
                myConnection.Close();
            }
            catch
            {
                MessageBox.Show("bir hata oluştu");
                myConnection.Close();
            }
        }

        private void AracSilme(string SecilenAracModel, string SecilenAracseriNo)
        {

            if (CBSirket.SelectedIndex > -1)
            {
                    int[] servisId = new int[2000];

                    string selectServisId = "SELECT ServisId  FROM ServisTarihleri where AracModel = '" + SecilenAracModel + "' and AracSeriNo = '" + SecilenAracseriNo + "'";

                    int servisIdSayısı = 0;
                    try
                    {

                        myConnection.Open();
                        SqlDataReader myReader = null;
                        SqlCommand myCommand = new SqlCommand(selectServisId, myConnection);
                        myReader = myCommand.ExecuteReader();
                        while (myReader.Read())
                        {
                            servisId[servisIdSayısı] = myReader["ServisId"].GetHashCode();
                            servisIdSayısı++;
                        }
                        myConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("bir hata oluştu");
                        myConnection.Close();
                    }

                    for (int i = 0; i < servisIdSayısı; i++)
                    {
                        string servisParcaBilgisiSilme = "DELETE FROM ServisParcaBilgileri WHERE ServisId = " + servisId[i];
                        try
                        {
                            SqlCommand myCommand2 = new SqlCommand(servisParcaBilgisiSilme, myConnection);
                            myCommand2.CommandType = CommandType.Text;
                            myCommand2.Connection = myConnection;

                            myConnection.Open();
                            myCommand2.ExecuteNonQuery();
                            myConnection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("bir hata oluştu");
                            myConnection.Close();
                        }
                    }

                    for (int i = 0; i < servisIdSayısı; i++)
                    {
                        string servistarihBilgisiSilme = "DELETE FROM ServisTarihleri WHERE ServisId = " + servisId[i];
                        try
                        {
                            SqlCommand myCommand3 = new SqlCommand(servistarihBilgisiSilme, myConnection);
                            myCommand3.CommandType = CommandType.Text;
                            myCommand3.Connection = myConnection;

                            myConnection.Open();
                            myCommand3.ExecuteNonQuery();
                            myConnection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("bir hata oluştu");
                            myConnection.Close();
                        }
                    }

                    string AracSilme = "DELETE FROM AracBilgileri where AracModel = '" + SecilenAracModel + "' and AracSeriNo = '" + SecilenAracseriNo + "'";
                    try
                    {
                        SqlCommand myCommand4 = new SqlCommand(AracSilme, myConnection);
                        myCommand4.CommandType = CommandType.Text;
                        myCommand4.Connection = myConnection;

                        myConnection.Open();
                        myCommand4.ExecuteNonQuery();
                        myConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("bir hata oluştu");
                        myConnection.Close();
                    }
                }
          
            else
            {
                MessageBox.Show("lütfen silmek istediğiniz sirketi seçiniz");
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
