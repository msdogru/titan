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
    public partial class TitanGiris : Form
    {
        private SqlConnection myConnection = Yönlendirmeler.getTitanConnection();
        private string sqlServisListStr = "select ServisId, AracModel, AracSeriNo, AracTeslimTarihi, TahminiTerminTarihi " +
            "from ServisTarihleri " +
            " where ServisAcıkVeyaKapalı = '1'";
        //public string[] ServisId = new string[10];
        private string MevcutTabloismi = "TitanGiris";
        private Form[] GelinenTablo;

        private string KullanıcıYetkiseviyesi = "";
        private int[] ServisId = new int[10];


        public TitanGiris()
        {
            InitializeComponent();
            
            string[] AracModel = new string[10];
            string[] AracseriNo = new string[10];
            string[] AracTeslimTarihi = new string[20];
            string[] TahminiTerminTarihi = new string[20];

            DateTime[] AracTeslimTarihi2 = new DateTime[20];
            DateTime[] TahminiTerminTarihi2 = new DateTime[20];

            int verisayısı = 0;
            myConnection.Open();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand(sqlServisListStr, myConnection);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                ServisId[verisayısı] = myReader["ServisId"].GetHashCode();
                AracModel[verisayısı] = myReader["AracModel"].ToString();
                AracseriNo[verisayısı] = myReader["AracSeriNo"].ToString();
                AracTeslimTarihi[verisayısı] = myReader["AracTeslimTarihi"].ToString();
                TahminiTerminTarihi[verisayısı] = myReader["TahminiTerminTarihi"].ToString();
                verisayısı++;
                
            }
            myConnection.Close();
            for (int i = 0; i < verisayısı; i++)
            {
                CBServis.Items.AddRange(new object[] { AracModel[i] + "       " + AracseriNo[i] + "       " + AracTeslimTarihi[i] + "       " + TahminiTerminTarihi[i]});
            }
            this.ControlBox = false;
        }
        public TitanGiris(Form []gelinentablo,string kullYetkiseviyesi)
        {
            this.KullanıcıYetkiseviyesi = kullYetkiseviyesi;
            this.GelinenTablo = new Form[20];
            for (int i = 0; i < 20;i++ )
            {
                this.GelinenTablo[i] = gelinentablo[i];
            }

            InitializeComponent();
            if (kullYetkiseviyesi == "2")
            {
                button1.Visible = false;
                BTYeniKullanıcı.Visible = false;
            }
            else if (kullYetkiseviyesi == "3")
            {
                button1.Visible = false;
            }
            this.ControlBox = false;
            string[] AracModel = new string[10];
            string[] AracseriNo = new string[10];
            string[] AracTeslimTarihi = new string[10];
            string[] TahminiTerminTarihi = new string[10];

            DateTime[] AracTeslimTarihi2 = new DateTime[20];
            DateTime[] TahminiTerminTarihi2 = new DateTime[20];

            int verisayısı = 0;
            myConnection.Open();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand(sqlServisListStr, myConnection);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                ServisId[verisayısı] = myReader["ServisId"].GetHashCode();
                AracModel[verisayısı] = Yönlendirmeler.StringDuzenle(myReader["AracModel"].ToString());
                AracseriNo[verisayısı] = Yönlendirmeler.StringDuzenle(myReader["AracSeriNo"].ToString());
                AracTeslimTarihi[verisayısı] =  Yönlendirmeler.StringDuzenle(string.Format("{0:d MMM, yyyy, dddd}", myReader["AracTeslimTarihi"]));
                TahminiTerminTarihi[verisayısı] = Yönlendirmeler.StringDuzenle(string.Format("{0:d MMM, yyyy, dddd}", myReader["TahminiTerminTarihi"]));
                verisayısı++;
            }
            myConnection.Close();

            //for (int i = 0; i < verisayısı; i++)
            //{
            //    AracTeslimTarihi2[i] = Yönlendirmeler.tarihDönüstürme(AracTeslimTarihi[i]);
            //}

            for (int i = 0; i < verisayısı; i++)
            {
                CBServis.Items.AddRange(new object[] { AracModel[i] + " " + AracseriNo[i] + " " + AracTeslimTarihi[i] + " " + TahminiTerminTarihi[i] });
            }
        }

        private void BTYeniKullanıcı_Click(object sender, EventArgs e)
        {
            GelinenTablo[Yönlendirmeler.getgirilenTabloSayısı()] = this;
            Yönlendirmeler.setgirilenTabloSayısı(Yönlendirmeler.getgirilenTabloSayısı() + 1);
            Yeni_Kullanıcı YeniKullanıcı = new Yeni_Kullanıcı(GelinenTablo,KullanıcıYetkiseviyesi);
            this.SetVisibleCore(false);
            YeniKullanıcı.ShowDialog();
        }

        private void BTCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void BTYeniSirket_Click(object sender, EventArgs e)
        //{
        //    GelinenTablo[Yönlendirmeler.getgirilenTabloSayısı()] = this;
        //    Yönlendirmeler.setgirilenTabloSayısı(Yönlendirmeler.getgirilenTabloSayısı() + 1);
        //    YeniSirketEkle SirketEkle = new YeniSirketEkle(GelinenTablo,KullanıcıYetkiseviyesi);
        //    this.SetVisibleCore(false);
        //    SirketEkle.ShowDialog();
        //}

        //private void BTYeniAracEkle_Click(object sender, EventArgs e)
        //{
        //    GelinenTablo[Yönlendirmeler.getgirilenTabloSayısı()] = this;
        //    Yönlendirmeler.setgirilenTabloSayısı(Yönlendirmeler.getgirilenTabloSayısı() + 1);
        //    AracEkle yeniArac = new AracEkle(GelinenTablo, KullanıcıYetkiseviyesi);
        //    this.SetVisibleCore(false);
        //    yeniArac.ShowDialog(); 
        //}

        private void BTYeniServisAc_Click(object sender, EventArgs e)
        {
            GelinenTablo[Yönlendirmeler.getgirilenTabloSayısı()] = this;
            Yönlendirmeler.setgirilenTabloSayısı(Yönlendirmeler.getgirilenTabloSayısı() + 1);
            YeniServisGirisi yeniServis = new YeniServisGirisi(GelinenTablo,KullanıcıYetkiseviyesi);
            this.SetVisibleCore(false);
            yeniServis.ShowDialog(); 
        }

        private void CBServis_SelectedIndexChanged(object sender, EventArgs e)
        {
            GelinenTablo[Yönlendirmeler.getgirilenTabloSayısı()] = this;
            Yönlendirmeler.setgirilenTabloSayısı(Yönlendirmeler.getgirilenTabloSayısı() + 1);
            AracServisDurumu ServisDurumu = new AracServisDurumu(ServisId[CBServis.SelectedIndex],GelinenTablo,KullanıcıYetkiseviyesi);
            this.SetVisibleCore(false);
            ServisDurumu.ShowDialog();
        }

        private void TitanGiris_Load(object sender, EventArgs e)
        {

        }

        private void BTGecmisServisGoruntule_Click(object sender, EventArgs e)
        {
            GelinenTablo[Yönlendirmeler.getgirilenTabloSayısı()] = this;
            Yönlendirmeler.setgirilenTabloSayısı(Yönlendirmeler.getgirilenTabloSayısı() + 1);
            GecmisServisleriGoruntule gecmisServisGoruntule = new GecmisServisleriGoruntule(GelinenTablo);
            this.SetVisibleCore(false);
            gecmisServisGoruntule.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GelinenTablo[Yönlendirmeler.getgirilenTabloSayısı()] = this;
            Yönlendirmeler.setgirilenTabloSayısı(Yönlendirmeler.getgirilenTabloSayısı() + 1);
            DigerIslemler gecmisServisGoruntule = new DigerIslemler(GelinenTablo);
            this.SetVisibleCore(false);
            gecmisServisGoruntule.ShowDialog();
        }

    }
}
