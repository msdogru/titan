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
    public partial class GecmisServisDurmu : Form
    {
        private int ServisId = -1;
        private Form[] GelinenTablo = new Form[20];
        private SqlConnection myConnection = Yönlendirmeler.getTitanConnection();
        private string AracModel = "";
        private string AracSeriNo = "";
        private string ParcaAdı = "";
        private string ParcaFiyatı = "";

        private string AracTeslimTarihi = "";
        private string TahminiTerminTarihi = "";
        private string AracTeslim = "";



        public GecmisServisDurmu()
        {
            InitializeComponent();
        }
        public GecmisServisDurmu(int ServisId, Form[] GelinenTablo)
        {
            InitializeComponent();
            this.ServisId = ServisId;
            this.GelinenTablo = GelinenTablo;
            for (int i = 0; i < Yönlendirmeler.getgirilenTabloSayısı(); i++)
            {
                this.GelinenTablo[i] = GelinenTablo[i]; 
            }


            ServisAracBilgileriAl();

        }
        

        private void GecmisServisDurmu_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void ServisTarihleriAl()
        { 
                //servis tarihlerini buradan al .
        }

        private void ServisAracBilgileriAl()
        {
            string AracModel_SeriNoStr = "SELECT AracModel , AracSeriNo , AracTeslimTarihi , TahminiTerminTarihi , TeslimTarihi FROM ServisTarihleri where ServisId = " + ServisId;
            string ServisParcaBilgileri = "select ParcaStokKod, ParcaAdedi ,ParcaBirimFiyatı from ServisParcaBilgileri where ServisId = " + ServisId;
            myConnection.Open();
            SqlDataReader myReader = null;
            SqlDataReader myReader2 = null;
            SqlDataReader myReader3 = null;
            SqlCommand myCommand = new SqlCommand(AracModel_SeriNoStr, myConnection);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                AracModel = myReader["AracModel"].ToString();
                AracSeriNo = myReader["AracSeriNo"].ToString();
                AracTeslimTarihi = string.Format("{0:d MMM, yyyy, dddd}", myReader["AracTeslimTarihi"]);
                TahminiTerminTarihi = string.Format("{0:d MMM, yyyy, dddd}", myReader["TahminiTerminTarihi"]);
                AracTeslim = string.Format("{0:d MMM, yyyy, dddd}", myReader["TeslimTarihi"]);

            }
            myConnection.Close();
            myConnection.Open();
            SqlCommand myCommand2 = new SqlCommand(ServisParcaBilgileri, myConnection);
            myReader2 = myCommand2.ExecuteReader();
            string parcastokKod = "";
            string ParcaAdedi = "";
            string ParcaAdetfiyatı = "";
            string ParcaBilgileri = "";
            while (myReader2.Read())
            {
                parcastokKod = myReader2["ParcaStokKod"].ToString();
                ParcaAdedi = myReader2["ParcaAdedi"].ToString();
                ParcaAdetfiyatı = myReader2["ParcaBirimFiyatı"].ToString();
                LBServisParcaListesi.Items.Add(parcastokKod);
                LBParcaAdetMiktarı.Items.Add(ParcaAdedi);
                LBParcaAdetFiyatı.Items.Add(ParcaAdetfiyatı);

            }
            myConnection.Close();

            for (int i = 0; i < LBServisParcaListesi.Items.Count; i++)
            {
                ParcaBilgileri = "SELECT ParcaAdı FROM ParcaBilgileri where ParcaStokKod = '" + LBServisParcaListesi.Items[i].ToString() + "'";
                SqlCommand myCommand3 = new SqlCommand(ParcaBilgileri, myConnection);
                myConnection.Open();
                myReader3 = myCommand3.ExecuteReader();
                while (myReader3.Read())
                {
                    ParcaAdı = myReader3["ParcaAdı"].ToString();
                }
                myConnection.Close();
                LBParcaAdı.Items.Add(ParcaAdı);
            }

            LabelAracModel.Text = AracModel;
            LabelAracSeriNo.Text = AracSeriNo;
            LAracTeslimTarihi.Text = AracTeslimTarihi;
            LAracTahminiTerminTarihi.Text = TahminiTerminTarihi;
            LAracCıkısTarihi.Text = AracTeslim;

            betterListBox1.Items.Clear();
            for (int x = 1; x <= LBServisParcaListesi.Items.Count; x++)
            {
                betterListBox1.Items.Add(x.ToString());
            }
            ToplamUcretHesapla();

        }

        private string AracSorumluBilgileri(int SorumluKisiId)
        {
            string aracSorumlusu = "";
            string AdıSoyadı = "";
            string Tel1 = "";
            string Tel2 = "";
            string Email = "";
            string kisiBilgileriStr = "SELECT Adı ,Soyadı ,Tel ,Tel2 ,Email " +
            " FROM SirketYetkiliKisi where Id = '" + SorumluKisiId + "'";

            SqlDataReader myReader = null;

            SqlCommand myCommand = new SqlCommand(kisiBilgileriStr, myConnection);

            try
            {
                myConnection.Open();
                myReader = myCommand.ExecuteReader();

                if (myReader.Read())
                {
                    AdıSoyadı = myReader["Adı"].ToString() + " " + myReader["Soyadı"].ToString();
                    Tel1 = myReader["Tel"].ToString();
                    Tel2 = myReader["Tel2"].ToString();
                    Email = myReader["Email"].ToString();
                }
                myConnection.Close();
            }
            catch
            {
                MessageBox.Show("Bir hata oluştu !");
            }
            aracSorumlusu = AdıSoyadı + "\n \n";


            if (Tel1.Length > 5)
            {
                aracSorumlusu = aracSorumlusu + "Tel: " + Tel1 + "\n";
            }

            if (Tel2.Length > 5)
            {
                aracSorumlusu = aracSorumlusu + "Tel2: " + Tel2 + "\n";
            }
            if (Email.Length > 5)
            {
                aracSorumlusu = aracSorumlusu + "Email: " + Email + "\n";
            }
            aracSorumlusu = aracSorumlusu + "\n\n";
            return aracSorumlusu;
        }

        private void scroll(object Sender, global::BetterListBox.BetterListBox.BetterListBoxScrollArgs e)
        {
            LBParcaAdetMiktarı.TopIndex = Convert.ToInt32(e.Top.ToString());
            LBParcaAdı.TopIndex = Convert.ToInt32(e.Top.ToString());
            LBParcaAdetFiyatı.TopIndex = Convert.ToInt32(e.Top.ToString());
            LBServisParcaListesi.TopIndex = Convert.ToInt32(e.Top.ToString());
        }

        private void BtSorumluKisiBilgileri_Click(object sender, EventArgs e)
        {
            string SorumluKisiBilgileriStr = "SELECT TeslimEdenKisiId ,BrinciYetkiliKisiId " +
               ",IkinciYetkiliKisiId ,Acıklama FROM ServisTarihleri where ServisId = '" + ServisId + "'";

            int aracıGetirenKisi = -1;
            int aracBirinciSorumlu = -1;
            int AracIkinciSorumlu = -1;
            string AracAcıklama = "";

            SqlDataReader myReader = null;
            SqlDataReader myReader2 = null;
            SqlDataReader myReader3 = null;
            SqlDataReader myReader4 = null;

            SqlCommand myCommand = new SqlCommand(SorumluKisiBilgileriStr, myConnection);

            myConnection.Open();
            myReader = myCommand.ExecuteReader();
            if (myReader.Read())
            {
                aracıGetirenKisi = myReader["TeslimEdenKisiId"].GetHashCode();
                aracBirinciSorumlu = myReader["BrinciYetkiliKisiId"].GetHashCode();
                AracIkinciSorumlu = myReader["IkinciYetkiliKisiId"].GetHashCode();
                AracAcıklama = myReader["Acıklama"].ToString();
                myConnection.Close();
            }
            else
            {
                myConnection.Close();
                MessageBox.Show("Bir hata oluştu !");
            }

            string Message = "";

            if (aracıGetirenKisi != null && aracıGetirenKisi != -1)
            {
                Message = Message + "Aracı Getiren Kisi : " + AracSorumluBilgileri(aracıGetirenKisi);
            }

            if (aracBirinciSorumlu != null && aracBirinciSorumlu != -1)
            {
                Message = Message + "Arac Birinci Sorumlusu: " + AracSorumluBilgileri(aracBirinciSorumlu);
            }

            if (AracIkinciSorumlu != null && AracIkinciSorumlu != -1)
            {
                Message = Message + "Arac Birinci Sorumlusu: " + AracSorumluBilgileri(AracIkinciSorumlu);
            }
            if (AracAcıklama != null && AracAcıklama.Length > 3)
            {
                Message = Message + " \n " + "Araç Açıklama : " + AracAcıklama;
            }


            MessageBox.Show(Message);
        }

        private void ToplamUcretHesapla()
        {
            BLBToplamDeger.Items.Clear();
            decimal toplamUcret = 0;
            decimal topu = 0;
            int toplamParcaSayısı = 0;
            for (int i = 0; i < LBParcaAdetMiktarı.Items.Count; i++)
            {
                topu = 0;
                topu = (Convert.ToDecimal(LBParcaAdetFiyatı.Items[i]) * (Convert.ToInt32(LBParcaAdetMiktarı.Items[i])));
                BLBToplamDeger.Items.Add(topu);
                toplamUcret += topu;
                toplamParcaSayısı += Convert.ToInt32(LBParcaAdetMiktarı.Items[i]);
            }
            betterListBox1.Items.Add(betterListBox1.Items.Count + 1);
            LBParcaAdı.Items.Add("***    TOPLAM     ***");
            LBParcaAdetMiktarı.Items.Add(toplamParcaSayısı);
            BLBToplamDeger.Items.Add(toplamUcret);

        }

        private void BTGeri_Click(object sender, EventArgs e)
        {
            Yönlendirmeler.setgirilenTabloSayısı(Yönlendirmeler.getgirilenTabloSayısı() - 1);
            GelinenTablo[Yönlendirmeler.getgirilenTabloSayısı()].Show();
            this.SetVisibleCore(false);
        }

        private void BTFatura_Click(object sender, EventArgs e)
        {

           // [parcaStokKod]
           //,[parcaAdı]
           //,[parcaAdedi]
           //,[parcaBirimFiyatı]
           //,[parcaToplamFiyat]
           //,[parcasil])

            string deleteFaturaStr = "Delete from Fatura where parcasil = 0";

            try
            {
                SqlCommand myCommand = new SqlCommand(deleteFaturaStr, myConnection);
                myCommand.CommandType = CommandType.Text;
                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                MessageBox.Show("mevcut fatura silindi !");
                myConnection.Close();
            }
            catch (Exception ex)
            {
                myConnection.Close();
                MessageBox.Show("Bir hata oluştu Lütfen Verileri Kontrol ederek tekrar deneyiniz!");
            }

            string AddFaturaStr = "INSERT INTO Fatura (parcaStokKod ,parcaAdı ,parcaAdedi " +
                ",parcaBirimFiyatı ,parcaToplamFiyat ) " +
                "VALUES (@parcaStokKod ,@parcaAdı ,@parcaAdedi ,@parcaBirimFiyatı " +
                ",@parcaToplamFiyat )";
            for (int i = 0; i < LBServisParcaListesi.Items.Count; i++)
            {
                try
                {
                    SqlCommand myCommand = new SqlCommand(AddFaturaStr, myConnection);
                    myCommand.CommandType = CommandType.Text;
                    myCommand.Connection = myConnection;
                    myCommand.Parameters.AddWithValue("@parcaStokKod", LBServisParcaListesi.Items[i].ToString());
                    myCommand.Parameters.AddWithValue("@parcaAdı", LBParcaAdı.Items[i].ToString());
                    myCommand.Parameters.AddWithValue("@parcaAdedi", LBParcaAdetMiktarı.Items[i]);
                    myCommand.Parameters.AddWithValue("@parcaBirimFiyatı", LBParcaAdetFiyatı.Items[i]);//Burayı düzelt
                    myCommand.Parameters.AddWithValue("@parcaToplamFiyat", BLBToplamDeger.Items[i]);

                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("Servis Başarı ile kaydedildi !");
                    myConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu Lütfen Verileri Kontrol ederek tekrar deneyiniz!");
                }
            }


            GelinenTablo[Yönlendirmeler.getgirilenTabloSayısı()] = this;
            Yönlendirmeler.setgirilenTabloSayısı(Yönlendirmeler.getgirilenTabloSayısı() + 1);
            Fatura fatura = new Fatura(ServisId, GelinenTablo);
            this.SetVisibleCore(false);
            fatura.ShowDialog();
        }

    }
}
