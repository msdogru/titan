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
    public partial class YeniServisGirisi : Form
    {
        private string MevcutTabloismi = "YeniServisGirisi";
        private Form[] GelinenTablo = new Form[20];

        private string KullanıcıYetkiSeviyesi = "";

        private int[] sirketId = new int[500];
        private string[] sirketAdı = new string[500];

        private int[] AracSirketSorumlusuId = new int[2000];
        private string[] AracSirketSorumlusuAdı = new string[2000];
        private string[] AracSirketSorumlusuSoyadı = new string[2000];
        private string[] AracSirketSorumlusuTel = new string[2000];

        private string[] AracModel = new string[1000];
        private string[] AracseriNo = new string[1000];

        private int secilenBirinciAracSorumlusuId = -1;
        private int secilenIkinciAracSorumlusuId = -1;
        private int secilenAracıGetirenKisiId = -1;

        private int secilenSirketId = -1;
        private string SecilenAracModel = "-1";
        private string SecilenAracseriNo = "-1";
        private int SirketSayısı = 0;
        private int AracSayısı = 0;
        private int SirketKisiSayısı = 0;

        private int seciliKisiIndex = -1;
        private int SeciliKisiId = -1;

        private SqlConnection myConnection = Yönlendirmeler.getTitanConnection();
        private string SirketVirileriStr = "SELECT SirketId ,SirketAdı FROM SirketBilgileri";



        public YeniServisGirisi()
        {
            InitializeComponent();
        }

        public YeniServisGirisi(Form[] GelinenTablo, string KullanıcıYetkiSeviyesi)
        {
            this.GelinenTablo = GelinenTablo;

            this.KullanıcıYetkiSeviyesi = KullanıcıYetkiSeviyesi;
            for (int i = 0; i < 20; i++)
            {
                this.GelinenTablo[i] = GelinenTablo[i];
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
            LAracıGetirenKisiTik.ForeColor = System.Drawing.Color.Red;
            LAracıGetirenKisiTik.Text = "*"; 
            LAracTik.ForeColor = System.Drawing.Color.Red;
            LAracTik.Text = "*"; 
            LBirinciYetkiliKisiTik.ForeColor = System.Drawing.Color.Red;
            LBirinciYetkiliKisiTik.Text = "*"; 
            LIkinciYetkiliKisiTik.ForeColor = System.Drawing.Color.Red;
            LIkinciYetkiliKisiTik.Text = "*"; 

        }

        private void YeniServisGirisi_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void BTCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CBSirket_SelectedIndexChanged(object sender, EventArgs e)
        {

            secilenSirketId = sirketId[CBSirket.SelectedIndex];

            secilenAracıGetirenKisiId = -1;
            secilenIkinciAracSorumlusuId = -1;
            secilenBirinciAracSorumlusuId = -1;

            AracListesiYenile();
            SirketKisiListesiyenile();
            KisiBilgisiTemizle();

            LSirketTik.ForeColor = System.Drawing.Color.Green;
            LSirketTik.Text = ((char)0x221A).ToString();

            LAracıGetirenKisiTik.ForeColor = System.Drawing.Color.Red;
            LAracıGetirenKisiTik.Text = "*";
            LAracTik.ForeColor = System.Drawing.Color.Red;
            LAracTik.Text = "*";
            LBirinciYetkiliKisiTik.ForeColor = System.Drawing.Color.Red;
            LBirinciYetkiliKisiTik.Text = "*";
            LIkinciYetkiliKisiTik.ForeColor = System.Drawing.Color.Red;
            LIkinciYetkiliKisiTik.Text = "*"; 
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
                CBArac.Items.Add("Arac Model: " +AracModel[AracSayısı] + "  Arac Seri No : " + AracseriNo[AracSayısı]);
                AracSayısı++;
            }
            myConnection.Close();
        }

        private void SirketKisiListesiyenile()
        {
            string KisiListesiStr = "SELECT Id, Adı, Soyadı,Tel FROM SirketYetkiliKisi where SirketId = '" + secilenSirketId + "'";
            CBAracıGetirenKisi.SelectedIndex = -1;
            CBBirinciYetkiliKisi.SelectedIndex = -1;
            CBİkinciYetkiliKisi.SelectedIndex = -1;
            CBAracıGetirenKisi.Items.Clear();
            CBBirinciYetkiliKisi.Items.Clear();
            CBİkinciYetkiliKisi.Items.Clear();
            SirketKisiSayısı = 0;

            myConnection.Open();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand(KisiListesiStr, myConnection);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                AracSirketSorumlusuId[SirketKisiSayısı] = myReader["Id"].GetHashCode();
                AracSirketSorumlusuAdı[SirketKisiSayısı] = myReader["Adı"].ToString();
                AracSirketSorumlusuSoyadı[SirketKisiSayısı] = myReader["Soyadı"].ToString();
                AracSirketSorumlusuTel[SirketKisiSayısı] = myReader["Tel"].ToString();

                CBAracıGetirenKisi.Items.Add(AracSirketSorumlusuAdı[SirketKisiSayısı] + " " +
                AracSirketSorumlusuSoyadı[SirketKisiSayısı] + " " + AracSirketSorumlusuTel[SirketKisiSayısı]);
                CBBirinciYetkiliKisi.Items.Add(AracSirketSorumlusuAdı[SirketKisiSayısı] + " " +
                AracSirketSorumlusuSoyadı[SirketKisiSayısı] + " " + AracSirketSorumlusuTel[SirketKisiSayısı]);
                CBİkinciYetkiliKisi.Items.Add(AracSirketSorumlusuAdı[SirketKisiSayısı] + " " +
                AracSirketSorumlusuSoyadı[SirketKisiSayısı] + " " + AracSirketSorumlusuTel[SirketKisiSayısı]);

                SirketKisiSayısı++;
            }
            myConnection.Close();

            if (secilenAracıGetirenKisiId != -1)
            {
                for (int i = 0; i < SirketKisiSayısı; i++)
                {
                    if (AracSirketSorumlusuId[i] == secilenAracıGetirenKisiId)
                    {
                        CBAracıGetirenKisi.SelectedIndex = i;
                    }
                }
            }

            if (secilenBirinciAracSorumlusuId != -1)
            {
                for (int i = 0; i < SirketKisiSayısı; i++)
                {
                    if (AracSirketSorumlusuId[i] == secilenBirinciAracSorumlusuId)
                    {
                        CBBirinciYetkiliKisi.SelectedIndex = i;
                    }
                }
            }

            if (secilenIkinciAracSorumlusuId != -1)
            {
                for (int i = 0; i < SirketKisiSayısı; i++)
                {
                    if (AracSirketSorumlusuId[i] == secilenIkinciAracSorumlusuId)
                    {
                        CBİkinciYetkiliKisi.SelectedIndex = i;
                    }
                }
            }
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

        private void CBAracıGetirenKisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBAracıGetirenKisi.SelectedIndex > -1)
            {
                secilenAracıGetirenKisiId = AracSirketSorumlusuId[CBAracıGetirenKisi.SelectedIndex];
                LAracıGetirenKisiTik.ForeColor = System.Drawing.Color.Green;
                LAracıGetirenKisiTik.Text = ((char)0x221A).ToString();
                SeciliKisiId = AracSirketSorumlusuId[CBAracıGetirenKisi.SelectedIndex];
                seciliKisiIndex = 1;
                KisiBilgisiDoldur(seciliKisiIndex, secilenAracıGetirenKisiId);
            }
        }

        private void CBBirinciYetkiliKisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBirinciYetkiliKisi.SelectedIndex > -1)
            {
                secilenBirinciAracSorumlusuId = AracSirketSorumlusuId[CBBirinciYetkiliKisi.SelectedIndex];
                LBirinciYetkiliKisiTik.ForeColor = System.Drawing.Color.Green;
                LBirinciYetkiliKisiTik.Text = ((char)0x221A).ToString();
                SeciliKisiId = AracSirketSorumlusuId[CBBirinciYetkiliKisi.SelectedIndex];
                seciliKisiIndex = 2;
                KisiBilgisiDoldur(seciliKisiIndex, secilenBirinciAracSorumlusuId);
            }
        }

        private void CBİkinciYetkiliKisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBİkinciYetkiliKisi.SelectedIndex > -1)
            {
                secilenIkinciAracSorumlusuId = AracSirketSorumlusuId[CBİkinciYetkiliKisi.SelectedIndex];
                LIkinciYetkiliKisiTik.ForeColor = System.Drawing.Color.Green;
                LIkinciYetkiliKisiTik.Text = ((char)0x221A).ToString();
                SeciliKisiId = AracSirketSorumlusuId[CBİkinciYetkiliKisi.SelectedIndex];
                seciliKisiIndex = 3;
                KisiBilgisiDoldur(seciliKisiIndex, secilenIkinciAracSorumlusuId);
            }
        }

        private void KisiBilgisiDoldur(int seciliKisiIndex,int SeciliKisiId)
        {
            string KisiBilgisiStr = "SELECT Adı, Soyadı,Tel, Tel2, Email FROM SirketYetkiliKisi where Id = '" + SeciliKisiId + "'";

            myConnection.Open();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand(KisiBilgisiStr, myConnection);
            myReader = myCommand.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    TBAdı.Text = myReader["Adı"].ToString();
                    TBSoyadı.Text = myReader["Soyadı"].ToString();
                    TBTel1.Text = myReader["Tel"].ToString();
                    TBTel2.Text = myReader["Tel2"].ToString();
                    TBEmail.Text = myReader["Email"].ToString();
                }
                myConnection.Close();
            }
            catch
            {
                MessageBox.Show("Bir Hata Oluştu !");
            }
        }

        private void KisiBilgisiTemizle()
        {
            TBAdı.Text = "";
            TBSoyadı.Text = "";
            TBTel1.Text = "";
            TBTel2.Text ="";
            TBEmail.Text = "";
        }

        private void BTDuzenleKaydet_Click(object sender, EventArgs e)
        {
            if (SeciliKisiId != -1)
            {
                string KisiDuzenleKaydetStr = "UPDATE SirketYetkiliKisi SET Adı = @Adı ,Soyadı = @Soyadı ,Tel = @Tel ,Tel2 = @Tel2 " +
                    ",Email = @Email WHERE Id = '" + SeciliKisiId + "'";
                try
                {
                    SqlCommand myCommand = new SqlCommand(KisiDuzenleKaydetStr, myConnection);
                    myCommand.CommandType = CommandType.Text;
                    myCommand.Connection = myConnection;
                    myCommand.Parameters.AddWithValue("@Adı", TBAdı.Text);
                    myCommand.Parameters.AddWithValue("@Soyadı", TBSoyadı.Text);
                    myCommand.Parameters.AddWithValue("@Tel", TBTel1.Text);
                    myCommand.Parameters.AddWithValue("@Tel2", TBTel2.Text);
                    myCommand.Parameters.AddWithValue("@Email", TBEmail.Text);
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                    SirketKisiListesiyenile();
                    MessageBox.Show("Kişi Bİlgileri Başarılı şekilde Güncellendi !");
                }
                catch (Exception ex)
                {
                    myConnection.Close();
                    MessageBox.Show("Bir hata oluştu yada veriler eksik Lütfen tekrar Kontrol Ederek deneyiniz !");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Gerekli verileri girerek Tıklayınız !");
            }
        }

        private void BTYeniKisiKaydet_Click(object sender, EventArgs e)
        {
            string Adı = TBAdı.Text;
            string Soyadı = TBSoyadı.Text;
            int sirketId = secilenSirketId;

            string YeniSirketYetkilisiEkle = "INSERT INTO SirketYetkiliKisi (Adı, Soyadı, Tel, Tel2, Email, SirketId) " +
                "VALUES (@Adı, @Soyadı, @Tel, @Tel2, @Email, @SirketId)";

            try
            {
                SqlCommand myCommand = new SqlCommand(YeniSirketYetkilisiEkle, myConnection);
                myCommand.CommandType = CommandType.Text;
                myCommand.Connection = myConnection;
                myCommand.Parameters.AddWithValue("@Adı", TBAdı.Text);
                myCommand.Parameters.AddWithValue("@Soyadı", TBSoyadı.Text);
                myCommand.Parameters.AddWithValue("@Tel", TBTel1.Text);
                myCommand.Parameters.AddWithValue("@Tel2", TBTel2.Text);
                myCommand.Parameters.AddWithValue("@Email", TBEmail.Text);
                myCommand.Parameters.AddWithValue("@SirketId", secilenSirketId);
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Yeni KişiBaşarılı Şekilde Sisteme Eklendi !");
                myConnection.Close();
            }
            catch (Exception ex)
            {
                myConnection.Close();
                MessageBox.Show("Bir hata oluştu yada veriler eksik Lütfen tekrar Kontrol Ederek deneyiniz !");
            }

            string KisiBilgisiStr = "SELECT Id FROM SirketYetkiliKisi where SirketId = '" + sirketId + "' And Adı = '" +
            Adı + "' And Soyadı = '" + Soyadı + "'";
            try
            {
                myConnection.Open();
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand(KisiBilgisiStr, myConnection);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    if (seciliKisiIndex == 1)
                    {
                        secilenAracıGetirenKisiId = myReader["Id"].GetHashCode();
                    }
                    else if (seciliKisiIndex == 2)
                    {
                        secilenBirinciAracSorumlusuId = myReader["Id"].GetHashCode();
                    }
                    else if (seciliKisiIndex == 3)
                    {
                        secilenIkinciAracSorumlusuId = myReader["Id"].GetHashCode();
                    }
                }
                myConnection.Close();
            }
            catch
            {
                myConnection.Close();
                MessageBox.Show("Bir hata oluştu yada veriler eksik Lütfen tekrar Kontrol Ederek deneyiniz !");
            }

            SirketKisiListesiyenile();
        }

        private void BTServisKaydet_Click(object sender, EventArgs e)
        {

            string ServisBilgiKaydetStr = "INSERT INTO ServisTarihleri (ServisAcıkVeyaKapalı ,AracModel ,AracSeriNo " +
                ",AracTeslimTarihi ,TahminiTerminTarihi " +
                ",TeslimEdenKisiId ,BrinciYetkiliKisiId ,IkinciYetkiliKisiId ,Acıklama) " +
                "VALUES (@ServisAcıkVeyaKapalı ,@AracModel ,@AracSeriNo ,@AracTeslimTarihi " +
                ",@TahminiTerminTarihi ,@TeslimEdenKisiId ,@BrinciYetkiliKisiId " +
                ",@IkinciYetkiliKisiId ,@Acıklama)";
            string ServisBilgiKaydetStr2 = "INSERT INTO ServisTarihleri (ServisAcıkVeyaKapalı ,AracModel ,AracSeriNo " +
                ",AracTeslimTarihi ,TahminiTerminTarihi " +
                ",TeslimEdenKisiId ,BrinciYetkiliKisiId ,Acıklama) " +
                "VALUES (@ServisAcıkVeyaKapalı ,@AracModel ,@AracSeriNo ,@AracTeslimTarihi " +
                ",@TahminiTerminTarihi ,@TeslimEdenKisiId ,@BrinciYetkiliKisiId " +
                ",@Acıklama)";
            if (secilenIkinciAracSorumlusuId != -1)
            {
                try
                {
                    SqlCommand myCommand = new SqlCommand(ServisBilgiKaydetStr, myConnection);
                    myCommand.CommandType = CommandType.Text;
                    myCommand.Connection = myConnection;
                    myCommand.Parameters.AddWithValue("@ServisAcıkVeyaKapalı", "1");
                    myCommand.Parameters.AddWithValue("@AracModel", SecilenAracModel);
                    myCommand.Parameters.AddWithValue("@AracSeriNo", SecilenAracseriNo);
                    myCommand.Parameters.AddWithValue("@AracTeslimTarihi", DTimePickerAracGelisTarihi.Value.Date);//Burayı düzelt
                    myCommand.Parameters.AddWithValue("@TahminiTerminTarihi", DTimePickerAracTerminTarihi.Value.Date);
                    myCommand.Parameters.AddWithValue("@TeslimEdenKisiId", secilenAracıGetirenKisiId);
                    myCommand.Parameters.AddWithValue("@BrinciYetkiliKisiId", secilenBirinciAracSorumlusuId);
                    myCommand.Parameters.AddWithValue("@IkinciYetkiliKisiId", secilenIkinciAracSorumlusuId);
                    myCommand.Parameters.AddWithValue("@Acıklama", TBAcıklama.Text);

                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("Servis Başarı ile kaydedildi !");
                    myConnection.Close();
                    BasaDon();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu Lütfen Verileri Kontrol ederek tekrar deneyiniz!");
                }
            }
            else
            {
                try
                {
                    SqlCommand myCommand = new SqlCommand(ServisBilgiKaydetStr2, myConnection);
                    myCommand.CommandType = CommandType.Text;
                    myCommand.Connection = myConnection;
                    myCommand.Parameters.AddWithValue("@ServisAcıkVeyaKapalı", "1");
                    myCommand.Parameters.AddWithValue("@AracModel", SecilenAracModel);
                    myCommand.Parameters.AddWithValue("@AracSeriNo", SecilenAracseriNo);
                    myCommand.Parameters.AddWithValue("@AracTeslimTarihi", DTimePickerAracGelisTarihi.Value.Date);//Burayı düzelt
                    myCommand.Parameters.AddWithValue("@TahminiTerminTarihi", DTimePickerAracTerminTarihi.Value.Date);
                    myCommand.Parameters.AddWithValue("@TeslimEdenKisiId", secilenAracıGetirenKisiId);
                    myCommand.Parameters.AddWithValue("@BrinciYetkiliKisiId", secilenBirinciAracSorumlusuId);
                    myCommand.Parameters.AddWithValue("@Acıklama", TBAcıklama.Text);

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
        }

        private void BTGeri_Click(object sender, EventArgs e)
        {

            Yönlendirmeler.setgirilenTabloSayısı(Yönlendirmeler.getgirilenTabloSayısı() - 1);
            GelinenTablo[Yönlendirmeler.getgirilenTabloSayısı()].Show();
            this.SetVisibleCore(false);

        }

        private void BasaDon()
        {
            GelinenTablo = new Form[20];
            Yönlendirmeler.setgirilenTabloSayısı(0);
            TitanGiris giriseDon = new TitanGiris(GelinenTablo, KullanıcıYetkiSeviyesi);
            this.SetVisibleCore(false);
            giriseDon.ShowDialog();
        }

        private void BTYeniSirketEkle_Click(object sender, EventArgs e)
        {
            GelinenTablo[Yönlendirmeler.getgirilenTabloSayısı()] = this;
            Yönlendirmeler.setgirilenTabloSayısı(Yönlendirmeler.getgirilenTabloSayısı() + 1);
            YeniSirketEkle SirketEkle = new YeniSirketEkle(GelinenTablo, KullanıcıYetkiSeviyesi);
            this.SetVisibleCore(false);
            SirketEkle.ShowDialog();
        }

        private void BTYeniAracEkle_Click(object sender, EventArgs e)
        {
            GelinenTablo[Yönlendirmeler.getgirilenTabloSayısı()] = this;
            Yönlendirmeler.setgirilenTabloSayısı(Yönlendirmeler.getgirilenTabloSayısı() + 1);
            AracEkle yeniArac = new AracEkle(GelinenTablo, KullanıcıYetkiSeviyesi);
            this.SetVisibleCore(false);
            yeniArac.ShowDialog(); 
        }

        public void setSeciliSirketId(int SId)
        {

            SirketKisiListesiyenile();
            
            for(int i = 0; i<CBSirket.Items.Count;i++)
            {
                if (this.sirketId[i] == SId)
                {
                    CBSirket.SelectedIndex = i;
                }
            }
        }

        private void BTYeniAracGetirenKisi_Click(object sender, EventArgs e)
        {
            seciliKisiIndex = 1;
            SeciliKisiId = -1;
            TBAdı.Text = "";
            TBSoyadı.Text = "";
            TBTel1.Text = "";
            TBTel2.Text = "";
            TBEmail.Text = "";
            TBAcıklama.Text = "";
            MessageBox.Show("Yeni Kişi Eklemek için sağ bölümdeki kişi bilgilerini doldurup yeni kişi olarak kaydete tıklayınız !");
        }

        private void BTYeniAracBirinciSorumlusu_Click(object sender, EventArgs e)
        {
            seciliKisiIndex = 2;
            SeciliKisiId = -1;
            TBAdı.Text = "";
            TBSoyadı.Text = "";
            TBTel1.Text = "";
            TBTel2.Text = "";
            TBEmail.Text = "";
            TBAcıklama.Text = "";
            MessageBox.Show("Yeni Kişi Eklemek için sağ bölümdeki kişi bilgilerini doldurup yeni kişi olarak kaydete tıklayınız !");
        }

        private void BTYeniAracIkinciSorumlusu_Click(object sender, EventArgs e)
        {
            seciliKisiIndex = 3;
            SeciliKisiId = -1;
            TBAdı.Text = "";
            TBSoyadı.Text = "";
            TBTel1.Text = "";
            TBTel2.Text = "";
            TBEmail.Text = "";
            TBAcıklama.Text = "";
            MessageBox.Show("Yeni Kişi Eklemek için sağ bölümdeki kişi bilgilerini doldurup yeni kişi olarak kaydete tıklayınız !");
        }
    }
}
