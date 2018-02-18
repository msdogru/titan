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
    public partial class ServisKapatmaEkranı : Form
    {
        private SqlConnection myConnection = Yönlendirmeler.getTitanConnection();


        private int servisId = -1;
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


        public ServisKapatmaEkranı()
        {
            InitializeComponent();
        }

        public ServisKapatmaEkranı(int ServisId, Form[] GelinenTablo)
        {

            for (int i = 0; i < 100; i++)
            {
                SilinicekStokKod[i] = "";
            }
            this.GelinenTablo = GelinenTablo;

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

            LabelAracModel.Text = AracModel;
            LabelAracSeriNo.Text = AracSeriNo;

            betterListBox1.Items.Clear();
            for (int x = 1; x <= LBServisParcaListesi.Items.Count; x++)
            {
                betterListBox1.Items.Add(x.ToString());
            }
            ToplamUcretHesapla();
        }

        private void ServisKapatmaEkranı_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void BTGeri_Click(object sender, EventArgs e)
        {
            Yönlendirmeler.setgirilenTabloSayısı(Yönlendirmeler.getgirilenTabloSayısı() - 1);
            GelinenTablo[Yönlendirmeler.getgirilenTabloSayısı()].Show();
            this.SetVisibleCore(false);
        }

        private void BTCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToplamUcretHesapla()
        {
            BLBToplamDeger.Items.Clear();
            decimal toplamUcret = 0;
            decimal topu = 0;
            int toplamParcaSayısı = 0;
            for (int i = 0; i < LBParcaAdetMiktarı.Items.Count;i++)
            {
                topu = 0;
                topu = (Convert.ToDecimal(LBParcaAdetFiyatı.Items[i]) * (Convert.ToInt32(LBParcaAdetMiktarı.Items[i])));
                BLBToplamDeger.Items.Add(topu);
                toplamUcret += topu;
                toplamParcaSayısı += Convert.ToInt32(LBParcaAdetMiktarı.Items[i]);
            }
            betterListBox1.Items.Add(betterListBox1.Items.Count+1);
            LBParcaAdı.Items.Add("***    TOPLAM     ***");
            LBParcaAdetMiktarı.Items.Add(toplamParcaSayısı);
            BLBToplamDeger.Items.Add(toplamUcret);

        }

        private void BTServisKapat_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Servisi Kaldırmak İstediğinizden Eminmisiniz ? \nKaldırmanız durumunda Birdaha Değişiklik Yapılamaz !", "Kapatma İşlemi Onayı", MessageBoxButtons.YesNo);
            if (result1.ToString() == "Yes")
            {
                try
                {
                    
                    SqlCommand myCommand = new SqlCommand("update ServisTarihleri Set ServisAcıkVeyaKapalı = '2' , TeslimTarihi = @TesT  where ServisId = @SID ", myConnection);
                    myCommand.CommandType = CommandType.Text;
                    myCommand.Connection = myConnection;
                    myCommand.Parameters.AddWithValue("@TesT", DTPTeslimTarihi.Value.Date);
                    myCommand.Parameters.AddWithValue("@SID", servisId);

                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                    MessageBox.Show("Servis Başarılı Şekilde Kapatılmıştır !");
                    GelinenTablo = new Form[GelinenTablo.Length];
                    Yönlendirmeler.setgirilenTabloSayısı(0);
                    TitanGiris F = new TitanGiris(GelinenTablo,KullanıcıYetkiSeviyesi);
                    this.SetVisibleCore(false);
                    F.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu ! Lütfen Bağlantınızı Kontrol Ediniz !");
                }
            }
            else {
                MessageBox.Show("Servis Kaldırılmadı Değişiklik yapılabilir !");
            }
        }
    }
}
