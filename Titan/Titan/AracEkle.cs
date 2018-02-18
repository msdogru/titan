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
    public partial class AracEkle : Form
    {
        private int []sirketId = new int[500];
        private string[] sirketAdı = new string[500];
        private string MevcutTabloismi = "AracEkle";
        private Form[] GelinenTablo = new Form[20];

        private string KullanıcıYetkiSeviyesi = "";
        private int secilenSirketId = -1;
        private int AlınanVeriSayısı;
        private SqlConnection myConnection = Yönlendirmeler.getTitanConnection();
        private string SirketVirileriStr = "SELECT SirketId ,SirketAdı FROM SirketBilgileri";
        private string AracEklemeStr = "INSERT INTO AracBilgileri (AracModel, AracSeriNo ,SirketId ,Acıklama) " +
        "VALUES (@AracModel,@AracSeriNo,@SirketId,@Acıklama)";

        public AracEkle()
        {
            InitializeComponent();
            AlınanVeriSayısı = 0;

            myConnection.Open();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand(SirketVirileriStr, myConnection);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                sirketId[AlınanVeriSayısı] = myReader["SirketId"].GetHashCode();
                sirketAdı[AlınanVeriSayısı] = myReader["SirketAdı"].ToString();
                CBAracinSirketi.Items.Add(sirketAdı[AlınanVeriSayısı]);
                AlınanVeriSayısı++;
            }
            myConnection.Close();

        }

        public AracEkle(Form[] GelinenTablo, string KullanıcıYetkiSeviyesi)
        {
            this.GelinenTablo = GelinenTablo;
            this.KullanıcıYetkiSeviyesi = KullanıcıYetkiSeviyesi;
            for (int i = 0; i < 20; i++)
            {
                this.GelinenTablo[i] = GelinenTablo[i];
            }
            InitializeComponent();

            AlınanVeriSayısı = 0;

            myConnection.Open();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand(SirketVirileriStr, myConnection);
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                sirketId[AlınanVeriSayısı] = myReader["SirketId"].GetHashCode();
                sirketAdı[AlınanVeriSayısı] = myReader["SirketAdı"].ToString();
                CBAracinSirketi.Items.Add(sirketAdı[AlınanVeriSayısı]);
                AlınanVeriSayısı++;
            }
            myConnection.Close();

        }

        private void BTAracEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(AracEklemeStr, myConnection);
                myCommand.CommandType = CommandType.Text;
                myCommand.Connection = myConnection;
                myCommand.Parameters.AddWithValue("@AracModel",TBAracModel.Text);
                myCommand.Parameters.AddWithValue("@AracSeriNo", TBAracSeriNo.Text);
                myCommand.Parameters.AddWithValue("@SirketId", secilenSirketId);
                myCommand.Parameters.AddWithValue("@Acıklama", TBAcıklama.Text);
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Arac Başarılı Şekilde Listeye Eklenmiştir !");
                myConnection.Close();
            }
            catch (Exception ex)
            {
                myConnection.Close();
                MessageBox.Show("Bir hata oluştu yada veriler eksik Lütfen tekrar Kontrol Ederek deneyiniz !");
            }
        }

        private void BTCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            GelinenTablo[Yönlendirmeler.getgirilenTabloSayısı()] = this;
            Yönlendirmeler.setgirilenTabloSayısı(Yönlendirmeler.getgirilenTabloSayısı() + 1);
            YeniSirketEkle SirketEkle = new YeniSirketEkle(GelinenTablo,KullanıcıYetkiSeviyesi);
            this.SetVisibleCore(false);
            SirketEkle.ShowDialog();
        }

        private void AracEkle_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void CBAracinSirketi_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenSirketId = sirketId[CBAracinSirketi.SelectedIndex];
        }

        private void BTGeri_Click(object sender, EventArgs e)
        {

            Yönlendirmeler.setgirilenTabloSayısı(Yönlendirmeler.getgirilenTabloSayısı() - 1);
            GelinenTablo[Yönlendirmeler.getgirilenTabloSayısı()].Show();
            this.SetVisibleCore(false);
        }

    }
}
