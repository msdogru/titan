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
    public partial class AracServisDurumu : Form
    {
        private SqlConnection myConnection = Yönlendirmeler.getTitanConnection();
        private SqlConnection myConnection2 = Yönlendirmeler.getNETSISConnection();
        private string MevcutTabloismi = "AracServisDurumu";
        private int servisId = 0;
        private int []servisGecmisiServisId = new int[500];
        private string AracModel = "";
        private string AracSeriNo = "";
        private Form[] GelinenTablo = new Form[20];

        private string KullanıcıYetkiSeviyesi = "";
        private string ParcaStokKod = "";
        private int parcaStokDurumu = 0;
        private string ParcaAdı = "";
        private string ParcaFiyatı = "";
        private string ParcaAcıklama = "";
        private string[] SilinicekStokKod = new String[100];


        public AracServisDurumu()
        {
            InitializeComponent();
        }
        public AracServisDurumu(int ServisId, Form[] GelinenTablo, string KullanıcıYetkiSeviyesi)
        {
            for (int i = 0; i < 100; i++)
            {
                SilinicekStokKod[i] = "";
            }

            this.GelinenTablo = GelinenTablo;
            
            this.KullanıcıYetkiSeviyesi = KullanıcıYetkiSeviyesi;

            for (int i = 0; i < 20; i++)
            {
                this.GelinenTablo[i] = GelinenTablo[i];
            }
            InitializeComponent();
            
            servisId = ServisId;
            string AracModel_SeriNoStr = "SELECT AracModel , AracSeriNo FROM ServisTarihleri where ServisId = " + servisId;
            string ServisParcaBilgileri = "select ParcaStokKod, ParcaAdedi ,ParcaBirimFiyatı from ServisParcaBilgileri where ServisId = " + servisId; 
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
            }
            myConnection.Close();
            myConnection.Open();
            SqlCommand myCommand2 = new SqlCommand(ServisParcaBilgileri, myConnection);
            myReader2 = myCommand2.ExecuteReader();
            string parcastokKod = "";
            string ParcaAdedi = "";
            string ParcaAdetfiyatı = "";
            string ParcaBilgileri = "";
            int silmeindex = 0;
            while (myReader2.Read())
            {
                parcastokKod = myReader2["ParcaStokKod"].ToString();
                ParcaAdedi = myReader2["ParcaAdedi"].ToString();
                ParcaAdetfiyatı = myReader2["ParcaBirimFiyatı"].ToString();
                if (Convert.ToInt32(ParcaAdedi.ToString()) > 0)
                {
                    LBServisParcaListesi.Items.Add(parcastokKod);
                    LBParcaAdetMiktarı.Items.Add(ParcaAdedi);
                    LBParcaAdetFiyatı.Items.Add(ParcaAdetfiyatı);
                }
                else
                {
                   SilinicekStokKod[silmeindex] = parcastokKod.ToString();
                }
                silmeindex++;
            }
            myConnection.Close();

            for (int i = 0; i < LBServisParcaListesi.Items.Count;i++)
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

            for (int i = 0; i < silmeindex;i++ )
            {
                try
                {
                    SqlCommand myCommand4 = new SqlCommand("delete from ServisParcaBilgileri where ParcaStokKod = '" + SilinicekStokKod[i].ToString() + "'", myConnection);
                    myCommand4.CommandType = CommandType.Text;
                    myCommand4.Connection = myConnection;
                    myCommand4.Parameters.AddWithValue("@ParcaStokKod", ParcaStokKod);
                    myConnection.Open();
                    myCommand4.ExecuteNonQuery();
                    myConnection.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu !");
                }
            }

            LabelAracModel.Text = AracModel;
            LabelAracSeriNo.Text = AracSeriNo;

            
            betterListBox1.Items.Clear();
            for (int x = 1; x <= LBServisParcaListesi.Items.Count;x++)
            {
                betterListBox1.Items.Add(x.ToString());
            }

            AracServisGecmisiYükle();
        }

        private void AracServisGecmisiYükle()
        {
            CBAracServisgecmisi.Items.Clear();

            string ServisGecmisiStr = "select ServisId, AracTeslimTarihi, TahminiTerminTarihi, TeslimTarihi " +
            "from ServisTarihleri " +
            " where ServisAcıkVeyaKapalı = '2' and AracModel = '" + AracModel + "' and AracSeriNo = '" + AracSeriNo + "'";

            string[] AracTeslimTarihi = new string[500];
            string[] TahminiTerminTarihi = new string[500];
            string[] TeslimTarihi = new string[500];

            int verisayısı = 0;
            try
            {
                myConnection.Open();
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand(ServisGecmisiStr, myConnection);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    servisGecmisiServisId[verisayısı] = myReader["ServisId"].GetHashCode();
                    AracTeslimTarihi[verisayısı] = myReader["AracTeslimTarihi"].ToString();
                    TahminiTerminTarihi[verisayısı] = myReader["TahminiTerminTarihi"].ToString();
                    TeslimTarihi[verisayısı] = myReader["TahminiTerminTarihi"].ToString();
                    verisayısı++;
                }
                myConnection.Close();

                for (int i = 0; i < verisayısı; i++)
                {
                    CBAracServisgecmisi.Items.AddRange(new object[] { AracTeslimTarihi[i] + "       " + TeslimTarihi[i] });
                }
            }
            catch(Exception ex)
            {
                myConnection.Close();
            }
        }

        private void AracServisDurumu_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTParcaBul_Click(object sender, EventArgs e)
        {
            try
            {
                string TitanParcaBilgileri = "SELECT ParcaStokAdedi, ParcaAdı, ParcaAdetFiyatı, ParcaAcıklama " +
                "FROM ParcaBilgileri where ParcaStokKod = '" + TBParcaStokKod.Text.ToString() + "'";

                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand(TitanParcaBilgileri, myConnection2);

                myConnection2.Open();
                myReader = myCommand.ExecuteReader();
                if (!myReader.Read())
                {
                    myConnection2.Close();
                    LBParcaBilgileri.Items.Clear();
                    TBParcaAcıklama.Text = "";
                    MessageBox.Show("Parca Sistemde Kayıtlı değil!"); 
                    ParcaStokKod = "";
                    parcaStokDurumu = 0;
                    ParcaAdı = "";
                    ParcaFiyatı = "";
                    ParcaAcıklama = "";
                }
                else
                {
                    parcaStokDurumu = myReader["ParcaStokAdedi"].GetHashCode();
                    ParcaAdı = myReader["ParcaAdı"].ToString();
                    ParcaFiyatı = myReader["ParcaAdetFiyatı"].ToString();
                    ParcaAcıklama = myReader["ParcaAcıklama"].ToString();
 
                    myConnection2.Close();

                    LBParcaBilgileri.Items.Clear();
                    ParcaStokKod = TBParcaStokKod.Text;
                    LBParcaBilgileri.Items.Add("Parca Stok Durumu: " + parcaStokDurumu);
                    LBParcaBilgileri.Items.Add("Parca Adı: " + ParcaAdı);
                    LBParcaBilgileri.Items.Add("Parca Adet Fiyatı: " + ParcaFiyatı);
                    TBParcaAcıklama.Text = "Parca Açıklama: " + ParcaAcıklama;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sisteme Ulasamadı bağlantılarda bir sorun var !");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ParcaEkle(Convert.ToInt32(TBParcaAdedi.Text));
        }

        private void BTYenile_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                SilinicekStokKod[i] = "";
            }
            string ServisParcaBilgileri = "select ParcaStokKod, ParcaAdedi ,ParcaBirimFiyatı from ServisParcaBilgileri where ServisId = " + servisId;
            LBParcaAdetFiyatı.Items.Clear();
            LBParcaAdetMiktarı.Items.Clear();
            LBParcaAdı.Items.Clear();
            LBServisParcaListesi.Items.Clear();

            SqlDataReader myReader = null;
            SqlDataReader myReader2 = null;
            SqlDataReader myReader3 = null;

            myConnection.Open();
            SqlCommand myCommand2 = new SqlCommand(ServisParcaBilgileri, myConnection);
            myReader2 = myCommand2.ExecuteReader();

            string parcastokKod = "";
            string ParcaAdedi = "";
            string ParcaAdetfiyatı = "";
            string ParcaBilgileri = "";
            int silmeindex = 0;
            while (myReader2.Read())
            {
                parcastokKod = myReader2["ParcaStokKod"].ToString();
                ParcaAdedi = myReader2["ParcaAdedi"].ToString();
                ParcaAdetfiyatı = myReader2["ParcaBirimFiyatı"].ToString();
                if (Convert.ToInt32(ParcaAdedi.ToString()) > 0)
                {
                    LBServisParcaListesi.Items.Add(parcastokKod);
                    LBParcaAdetMiktarı.Items.Add(ParcaAdedi);
                    LBParcaAdetFiyatı.Items.Add(ParcaAdetfiyatı);
                }
                else
                {
                    SilinicekStokKod[silmeindex] = parcastokKod.ToString();
                }
                silmeindex++;
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

            for (int i = 0; i < silmeindex; i++)
            {
                try
                {
                    SqlCommand myCommand4 = new SqlCommand("delete from ServisParcaBilgileri where ParcaStokKod = '" + SilinicekStokKod[i].ToString() + "'", myConnection);
                    myCommand4.CommandType = CommandType.Text;
                    myCommand4.Connection = myConnection;
                    myCommand4.Parameters.AddWithValue("@ParcaStokKod", ParcaStokKod);
                    myConnection.Open();
                    myCommand4.ExecuteNonQuery();
                    myConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu !");
                }
            }

            betterListBox1.Items.Clear();
            for (int x = 1; x <= LBServisParcaListesi.Items.Count; x++)
            {
                betterListBox1.Items.Add(x.ToString());
            }
        }

        private void LBServisParcaListesi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void scroll(object Sender, global::BetterListBox.BetterListBox.BetterListBoxScrollArgs e)
        {
            LBParcaAdetMiktarı.TopIndex = Convert.ToInt32(e.Top.ToString());
            LBParcaAdı.TopIndex = Convert.ToInt32(e.Top.ToString());
            LBParcaAdetFiyatı.TopIndex = Convert.ToInt32(e.Top.ToString());
            LBServisParcaListesi.TopIndex = Convert.ToInt32(e.Top.ToString());
        }

        private void BTGeri_Click(object sender, EventArgs e)
        {

            Yönlendirmeler.setgirilenTabloSayısı(Yönlendirmeler.getgirilenTabloSayısı() - 1);
            GelinenTablo[Yönlendirmeler.getgirilenTabloSayısı()].Show();
            this.SetVisibleCore(false);
        }

        private void BTServisKapat_Click(object sender, EventArgs e)
        {
            GelinenTablo[Yönlendirmeler.getgirilenTabloSayısı()] = this;
            Yönlendirmeler.setgirilenTabloSayısı(Yönlendirmeler.getgirilenTabloSayısı() + 1);
            ServisKapatmaEkranı yeniServis = new ServisKapatmaEkranı(servisId, GelinenTablo);
            this.SetVisibleCore(false);
            yeniServis.ShowDialog(); 
        }

        private void BtSorumluKisiBilgileri_Click(object sender, EventArgs e)
        {
            string SorumluKisiBilgileriStr = "SELECT TeslimEdenKisiId ,BrinciYetkiliKisiId " +
                ",IkinciYetkiliKisiId ,Acıklama FROM ServisTarihleri where ServisId = '" + servisId + "'";

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
            else {
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
                aracSorumlusu = aracSorumlusu +"Tel2: " + Tel2 + "\n";
            }
            if (Email.Length > 5)
            {
                aracSorumlusu = aracSorumlusu + "Email: " + Email + "\n";
            }
            aracSorumlusu = aracSorumlusu +"\n\n";
            return aracSorumlusu;
        }

        private void BTParçaÇıkart_Click(object sender, EventArgs e)
        {
            ParcaEkle((-1)*Convert.ToInt32(TBParcaAdedi.Text));
        }

        private void ParcaEkle(int parcaAdedi)
        {

            string ParcaKontrol1 = "SELECT ParcaStokKod,ServisId FROM ServisParcaBilgileri where ParcaStokKod = '" + ParcaStokKod + "' and ServisId = '" + servisId + "'";

            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand(ParcaKontrol1, myConnection);

            myConnection.Open();
            myReader = myCommand.ExecuteReader();
            if (!myReader.Read())
            {
                myConnection.Close();
                string ParcaBilgiKontrol = "SELECT ParcaStokKod FROM ParcaBilgileri where ParcaStokKod = '" + ParcaStokKod + "'";

                SqlDataReader myReader5 = null;
                SqlCommand myCommand5 = new SqlCommand(ParcaBilgiKontrol, myConnection);

                myConnection.Open();
                myReader5 = myCommand5.ExecuteReader();

                if (!myReader5.Read())
                {
                    myConnection.Close();
                    try
                    {
                        SqlCommand myCommand2 = new SqlCommand("insert into ParcaBilgileri (ParcaStokKod, ParcaAdı, ParcaAcıklama) " +
                        " values(@ParcaStokKod,@ParcaAdı,@ParcaAcıklama)", myConnection);
                        myCommand2.CommandType = CommandType.Text;
                        myCommand2.Connection = myConnection;

                        myCommand2.Parameters.AddWithValue("@ParcaStokKod", ParcaStokKod);
                        myCommand2.Parameters.AddWithValue("@ParcaAdı", ParcaAdı);
                        myCommand2.Parameters.AddWithValue("@ParcaAcıklama", ParcaAcıklama);
                        myConnection.Open();
                        myCommand2.ExecuteNonQuery();
                        myConnection.Close();
                    }
                    catch (Exception ex)
                    {

                    }
                }
                else
                {
                    myConnection.Close();
                }
                try
                {
                    SqlCommand myCommand4 = new SqlCommand("insert into ServisParcaBilgileri (ParcaStokKod, ServisId, ParcaAdedi, ParcaBirimFiyatı) " +
                    " values(@ParcaStokKod,@ServisId,@ParcaAdedi,@ParcaBirimFiyatı)", myConnection);
                    myCommand4.CommandType = CommandType.Text;
                    myCommand4.Connection = myConnection;

                    myCommand4.Parameters.AddWithValue("@ParcaStokKod", ParcaStokKod);
                    myCommand4.Parameters.AddWithValue("@ServisId", servisId);
                    myCommand4.Parameters.AddWithValue("@ParcaAdedi", parcaAdedi);
                    myCommand4.Parameters.AddWithValue("@ParcaBirimFiyatı", Convert.ToDecimal(ParcaFiyatı.ToString()));
                    myConnection.Open();
                    myCommand4.ExecuteNonQuery();
                    myConnection.Close();

                }
                catch (Exception ex)
                {
                    myConnection.Close();
                    MessageBox.Show("Bir hata oluştu !");
                }

            }
            else
            {
                myConnection.Close();

                try
                {
                    SqlCommand myCommand4 = new SqlCommand("update ServisParcaBilgileri Set ParcaAdedi = (ParcaAdedi+@PAdet) where ServisId = @SID and ParcaStokKod = @PStokKod", myConnection);
                    SqlCommand myCommand5 = new SqlCommand("update ServisParcaBilgileri Set ParcaBirimFiyatı = @PBirimFiyatı where ServisId = @SID and ParcaStokKod = @PStokKod", myConnection);

                    myCommand4.CommandType = CommandType.Text;
                    myCommand5.CommandType = CommandType.Text;

                    myCommand4.Connection = myConnection;
                    myCommand4.Parameters.AddWithValue("@PAdet",parcaAdedi);
                    myCommand4.Parameters.AddWithValue("@SID", servisId);
                    myCommand4.Parameters.AddWithValue("@PStokKod", ParcaStokKod);

                    myCommand5.Connection = myConnection;
                    myCommand5.Parameters.AddWithValue("@PBirimFiyatı", Convert.ToDecimal(ParcaFiyatı.ToString()));
                    myCommand5.Parameters.AddWithValue("@SID", servisId);
                    myCommand5.Parameters.AddWithValue("@PStokKod", ParcaStokKod);

                    myConnection.Open();
                    myCommand4.ExecuteNonQuery();
                    myConnection.Close();

                    myConnection.Open();
                    myCommand5.ExecuteNonQuery();
                    myConnection.Close();
                }
                catch (Exception ex)
                {
                    myConnection.Close();
                    MessageBox.Show("Bir hata oluştu !");
                }
            }

            BTYenile_Click(new Object(), new EventArgs());
        }

        private void CBAracServisgecmisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            GelinenTablo[Yönlendirmeler.getgirilenTabloSayısı()] = this;
            Yönlendirmeler.setgirilenTabloSayısı(Yönlendirmeler.getgirilenTabloSayısı() + 1);
            GecmisServisDurmu yeniServis = new GecmisServisDurmu(servisGecmisiServisId[CBAracServisgecmisi.SelectedIndex], GelinenTablo);
            this.SetVisibleCore(false);
            yeniServis.ShowDialog(); 
        }


    }
}
