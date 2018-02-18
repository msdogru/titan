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
    public partial class GecmisServisleriGoruntule : Form
    {
        private SqlConnection myConnection = Yönlendirmeler.getTitanConnection();

        private Form[] GelinenTablo;

        private int[] ServisId = new int[2000];
        private string KullanıcıYetkiseviyesi = "";


        public GecmisServisleriGoruntule()
        {
            InitializeComponent();
        }

        public GecmisServisleriGoruntule(Form[] GelinenTablo)
        {
            InitializeComponent();

            this.GelinenTablo = GelinenTablo;
            for (int i = 0; i < Yönlendirmeler.getgirilenTabloSayısı(); i++)
            {
                this.GelinenTablo[i] = GelinenTablo[i];
            }

        }


        private void GecmisServisleriGoruntule_Load(object sender, EventArgs e)
        {

        }

        private void BTServisleriGoruntule_Click(object sender, EventArgs e)
        {
            string[] AracModel = new string[2000];
            string[] AracseriNo = new string[2000];
            string[] AracTeslimTarihi = new string[2000];
            string[] TahminiTerminTarihi = new string[2000];
            string[] AracTeslim = new string[2000];

            string sqlServisListStr = "select ServisId, AracModel, AracSeriNo, AracTeslimTarihi, TahminiTerminTarihi, TeslimTarihi " +
            "from ServisTarihleri " +
            " where ServisAcıkVeyaKapalı = '2' and " + " TeslimTarihi > '" + TarihDegistir(DTPBaslangıc.Value.Date.ToString()) + "' and TeslimTarihi < '" + TarihDegistir(DTPBitis.Value.Date.ToString()) + "'";


            int verisayısı = 0;
            try
            {

                myConnection.Open();
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand(sqlServisListStr, myConnection);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    
                    ServisId[verisayısı] = myReader["ServisId"].GetHashCode();
                    AracModel[verisayısı] = Yönlendirmeler.StringDuzenle(myReader["AracModel"].ToString());
                    AracseriNo[verisayısı] = Yönlendirmeler.StringDuzenle(myReader["AracSeriNo"].ToString());
                    AracTeslimTarihi[verisayısı] = Yönlendirmeler.StringDuzenle(string.Format("{0:d MMM, yyyy, dddd}", myReader["AracTeslimTarihi"]));
                    TahminiTerminTarihi[verisayısı] = Yönlendirmeler.StringDuzenle(string.Format("{0:d MMM, yyyy, dddd}", myReader["TahminiTerminTarihi"]));
                    AracTeslim[verisayısı] = Yönlendirmeler.StringDuzenle(string.Format("{0:d MMM, yyyy, dddd}", myReader["TeslimTarihi"]));

                    verisayısı++;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata");
            }
            myConnection.Close();
            for (int i = 0; i < verisayısı; i++)
            {
                CLBServisler.Items.Add(AracModel[i] + AracseriNo[i] + AracTeslimTarihi[i] + TahminiTerminTarihi[i] + AracTeslim[i]);
            }
            this.ControlBox = false;
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

        private void CLBServisler_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            GelinenTablo[Yönlendirmeler.getgirilenTabloSayısı()] = this;
            Yönlendirmeler.setgirilenTabloSayısı(Yönlendirmeler.getgirilenTabloSayısı() + 1);
            GecmisServisDurmu yeniServis = new GecmisServisDurmu(ServisId[CLBServisler.SelectedIndex], GelinenTablo);
            this.SetVisibleCore(false);
            yeniServis.ShowDialog(); 
        }
    }
}
