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
    public partial class AracBilgisiDuzenle : Form
    {
        private Form[] GelinenTablo = new Form[20];

        private string KullanıcıYetkiSeviyesi = "";

        private int[] sirketId = new int[500];
        private string[] sirketAdı = new string[500];

        private string[] AracModel = new string[1000];
        private string[] AracseriNo = new string[1000];

        private int secilenSirketId = -1;
        private int secilenYeniSirketId = -1;
        private string SecilenAracModel = "-1";
        private string SecilenAracseriNo = "-1";
        private int SirketSayısı = 0;
        private int AracSayısı = 0;

        private SqlConnection myConnection = Yönlendirmeler.getTitanConnection();
        private string SirketVirileriStr = "SELECT SirketId ,SirketAdı FROM SirketBilgileri";

        public AracBilgisiDuzenle()
        {
            InitializeComponent();
        }

        public AracBilgisiDuzenle(Form[] GelinenTablo)
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
                
                SirketSayısı++;
            }
            myConnection.Close();
            CBYeniSirket.Items.Clear();
            CBSirkeT.Items.Clear();
            for (int i = 0; i < SirketSayısı; i++)
            {
                CBYeniSirket.Items.Add(sirketAdı[i]);
                CBSirkeT.Items.Add(sirketAdı[i]);
            }

            LSirketTik.ForeColor = System.Drawing.Color.Red;
            LSirketTik.Text = "*";
            LAracTik.ForeColor = System.Drawing.Color.Red;
            LAracTik.Text = "*";
            LYeniSirketTik.ForeColor = System.Drawing.Color.Red;
            LSirketTik.Text = "*";
            
            
        }

        private void AracBilgisiDuzenle_Load(object sender, EventArgs e)
        {
            
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

        private void CBSirket_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenSirketId = sirketId[CBSirkeT.SelectedIndex];
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
                TBAracSeriNo.Text = SecilenAracseriNo;
                TBAracModel.Text = SecilenAracModel;
                LAracTik.ForeColor = System.Drawing.Color.Green;
                LAracTik.Text = ((char)0x221A).ToString();
            }
        }

        private void BTAracEkle_Click(object sender, EventArgs e)
        {
             DialogResult result1 = MessageBox.Show("Arac Bilgilerini Değiştirmek istediğinizden eminmisiniz ?", "Kapatma İşlemi Onayı", MessageBoxButtons.YesNo);
             if (result1.ToString() == "Yes")
             {
                 string Arackaydet = "Update AracBilgileri set AracModel = '" + TBAracModel.Text.ToString() +
                     "' , AracSeriNo = '" + TBAracSeriNo.Text.ToString() + "' , SirketId = " + sirketId[CBYeniSirket.SelectedIndex] +
                     " where AracModel  = '" + AracModel[CBArac.SelectedIndex].ToString() + "' and AracSeriNo  = '" + AracseriNo[CBArac.SelectedIndex].ToString() + "'";
                 if (CBYeniSirket.SelectedIndex > -1)
                 {
                     try
                     {
                         SqlCommand myCommand2 = new SqlCommand(Arackaydet, myConnection);
                         myCommand2.CommandType = CommandType.Text;
                         myCommand2.Connection = myConnection;

                         myConnection.Open();
                         myCommand2.ExecuteNonQuery();
                         myConnection.Close();
                     }
                     catch (Exception ex)
                     {
                         myConnection.Close();
                         MessageBox.Show("bir hata oluştu ! " + ex);
                     }
                 }
                 else
                 {
                     MessageBox.Show("Lütfen yeni şirketi seçiniz !");
                 }
                 string servisAracDegis = "Update ServisTarihleri set AracModel = '" + TBAracModel.Text.ToString() +
                     "' , AracSeriNo = '" + TBAracSeriNo.Text.ToString() +
                     "' where AracModel  = '" + AracModel[CBArac.SelectedIndex].ToString() + "' and AracSeriNo  = '" + AracseriNo[CBArac.SelectedIndex].ToString() + "'";

                 if (CBYeniSirket.SelectedIndex > -1)
                 {
                     try
                     {
                         SqlCommand myCommand2 = new SqlCommand(servisAracDegis, myConnection);
                         myCommand2.CommandType = CommandType.Text;
                         myCommand2.Connection = myConnection;

                         myConnection.Open();
                         myCommand2.ExecuteNonQuery();
                         myConnection.Close();
                         MessageBox.Show("Kullanıcı Bilgileri Başarılı şekilde güncellendi !");
                     }
                     catch (Exception ex)
                     {
                         myConnection.Close();
                         MessageBox.Show("bir hata oluştu ! " + ex);
                     }
                 }
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
