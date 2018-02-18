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
    public partial class Titan : Form
    {
        private string kullanıcı_Adı;
        private string kullanıcı_Sifre;
        private string CmdEsleme;
        private SqlConnection myConnection = Yönlendirmeler.getTitanConnection();
        private string MevcutTabloismi = "Titan";
        private Form[] GelinenTablo;
        private string yetkidüzeyi = "";

        public Titan()
        {
            InitializeComponent();
            
        }

        private void Titan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                myConnection.Open();
                SqlDataReader myReader = null;
                CmdEsleme = @"select KullanıcıAdı , Sifre , YetkiDüzeyi from YetkiliKisi where KullanıcıAdı = ( '" + TBUserName.Text.ToString() +
                    "' ) and  Sifre = ( '" + TBSifre.Text.ToString()+"' ) ";
                try
                {
                    SqlCommand myCommand = new SqlCommand(CmdEsleme, myConnection);
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        yetkidüzeyi = myReader["YetkiDüzeyi"].ToString();
                        kullanıcı_Adı = myReader["KullanıcıAdı"].ToString();
                        kullanıcı_Sifre = myReader["Sifre"].ToString();
                    }
                    if (kullanıcı_Sifre == TBSifre.Text.ToString() && kullanıcı_Adı == TBUserName.Text.ToString())
                    {
                        myConnection.Close();
                        GelinenTablo = new Form[20];
                        TitanGiris titan = new TitanGiris(GelinenTablo, yetkidüzeyi);
                        this.SetVisibleCore(false);
                        Yönlendirmeler.setKullanıcıYetkiSeviyesi(yetkidüzeyi);
                        titan.ShowDialog();   
                    }
                    else
                    {
                        myConnection.Close();
                        MessageBox.Show("Kullanici adi veya sifre hatalı!");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("You failed!! " + ex.Message);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("You failed!" + ex.Message);
            }
        }
    }
}
