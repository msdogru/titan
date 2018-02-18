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
    public partial class AracınGecmisServisleriniSistemdenKAldırma : Form
    {
        private Form[] GelinenTablo;
        private int SirketSayısı = 0;
        private int AracSayısı = 0;
        private int secilenSirketId = -1;
        private string SecilenAracModel = "-1";
        private string SecilenAracseriNo = "-1";
        private int[] sirketId = new int[500];
        private string[] sirketAdı = new string[500];

        private string[] AracModel = new string[1000];
        private string[] AracseriNo = new string[1000];

        private SqlConnection myConnection = Yönlendirmeler.getTitanConnection();
        private string SirketVirileriStr = "SELECT SirketId ,SirketAdı FROM SirketBilgileri";

        public AracınGecmisServisleriniSistemdenKAldırma()
        {
            InitializeComponent();
        }

        public AracınGecmisServisleriniSistemdenKAldırma(Form[] gelinenTablo)
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
            LAracTik.ForeColor = System.Drawing.Color.Red;
            LAracTik.Text = "*";

        }

        private void AracListesiYenile()
        {
            string AracVirileriStr = "SELECT AracModel ,AracSeriNo FROM AracBilgileri where SirketId = '" + secilenSirketId + "'";
            CBArac.SelectedIndex = -1;
            CBArac.Items.Clear();
            AracSayısı = 0;

            myConnection.Open();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand(AracVirileriStr, myConnection);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                AracModel[AracSayısı] = myReader["AracModel"].ToString();
                AracseriNo[AracSayısı] = myReader["AracSeriNo"].ToString();
                CBArac.Items.Add("Arac Model: " + AracModel[AracSayısı] + "  Arac Seri No : " + AracseriNo[AracSayısı]);
                AracSayısı++;
            }
            myConnection.Close();
        }

        private void AracınGecmisServisleriniSistemdenKAldırma_Load(object sender, EventArgs e)
        {

        }

        private void CBSirket_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenSirketId = sirketId[CBSirket.SelectedIndex];

            AracListesiYenile();

            LSirketTik.ForeColor = System.Drawing.Color.Green;
            LSirketTik.Text = ((char)0x221A).ToString();


            LAracTik.ForeColor = System.Drawing.Color.Red;
            LAracTik.Text = "*";
        }

        private void CBArac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBArac.SelectedIndex > -1)
            {
                SecilenAracModel = AracModel[CBArac.SelectedIndex];
                SecilenAracseriNo = AracseriNo[CBArac.SelectedIndex];

                LAracTik.ForeColor = System.Drawing.Color.Green;
                LAracTik.Text = ((char)0x221A).ToString();
            }
        }

        private void BTServisSil_Click(object sender, EventArgs e)
        {
            if (CBArac.SelectedIndex > -1)
            {
                DialogResult result1 = MessageBox.Show("Aracın servis bilgilerini silmek istediğinizden eminmisiniz  ? \n ", "Kapatma İşlemi Onayı", MessageBoxButtons.YesNo);
                if (result1.ToString() == "Yes")
                {
                    int[] servisId = new int[2000];

                    string selectServisId = "SELECT ServisId  FROM ServisTarihleri where AracModel = '" + SecilenAracModel + "' and AracSeriNo = '" + SecilenAracseriNo + "' and TeslimTarihi < '" + TarihDegistir(DTPBitis.Value.Date.ToString()) + "'";

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
                    MessageBox.Show("Araca Ait servislere Ait parca bilgileri silindi");

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
                    MessageBox.Show("Araca Ait servisler silindi");
                }
                else
                {
                    MessageBox.Show("Arac ile ilgili bilgiler silinmedi ");
                }

            }
            else
            {
                MessageBox.Show("lütfen servisini silmek istediğiniz aracı seçiniz");
            }
        }

        private string TarihDegistir(string Tarih)
        {
            string yeni = "";

            for (int i = 0; i < (Tarih.Length - 9); i++)
            {
                yeni = yeni + Tarih[i];
            }

            int index = 0;
            string gun = "";
            string ay = "";
            string yil = "";
            while (yeni[index] != '.')
            {
                gun = gun + yeni[index];
                index++;
            }
            index++;
            while (yeni[index] != '.')
            {
                ay = ay + yeni[index];
                index++;
            }
            index++;
            for (int i = index; i < yeni.Length; i++)
            {
                yil = yil + yeni[i];
            }
            yeni = ay + "." + gun + "." + yil;
            return yeni;
        }

        private void BTGeri_Click(object sender, EventArgs e)
        {
            Yönlendirmeler.setgirilenTabloSayısı(Yönlendirmeler.getgirilenTabloSayısı() - 1);
            GelinenTablo[Yönlendirmeler.getgirilenTabloSayısı()].Show();
            this.SetVisibleCore(false);
        }
    }
}
