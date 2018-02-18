using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Titan
{
    class Yönlendirmeler
    {
        private static int girilentablosayısı = 0;
        private static string KullanıcıYetkiSeviyesi = "";
        private static SqlConnection myConnection = new SqlConnection("server=localhost;" +
                                       "Trusted_Connection=yes;" +
                                       "database=Titan; " +
                                       "connection timeout=30");
        private static SqlConnection myConnection2 = new SqlConnection("server=localhost;" +
                               "Trusted_Connection=yes;" +
                               "database=NETSIS; " +
                               "connection timeout=30");
        //private char yetkiduzeyi = '0';
        public static SqlConnection getNETSISConnection()
        {
            return myConnection2;
        }
        public static SqlConnection getTitanConnection()
        {
            return myConnection;
        }

        //public void setYetkidüzeyi(char yetkidüzeyi)
        //{
        //    this.yetkiduzeyi = yetkidüzeyi;
        //}
        //public char getYetkiduzeyi()
        //{
        //    return this.yetkiduzeyi;
        //}

        public static void setgirilenTabloSayısı(int tabloSayısı)
        {
            girilentablosayısı = tabloSayısı;
        }

        public static int getgirilenTabloSayısı()
        {
            return girilentablosayısı;
        }

        public static void setKullanıcıYetkiSeviyesi(string KullanıcıYetkiSi)
        {
            KullanıcıYetkiSeviyesi = KullanıcıYetkiSi;
        }

        public static string getKullanıcıYetkiSeviyesi()
        {
            return KullanıcıYetkiSeviyesi;
        }

        public static DateTime tarihDönüstürme(string tarih)
        {

            DateTime dt = DateTime.Parse("tarih");

            return dt;
        }

        public static String StringDuzenle(String S)
        {
            String yeniS = "";

            if (S.Length == 25)
                return S;
            else if (S.Length > 25)
            {
                for (int i = 0; i < 22; i++)
                    yeniS = yeniS + S[i];
                yeniS = yeniS + "...";
                return yeniS;
            }
            else if (S.Length < 25)
            {
                yeniS = S;
                while(yeniS.Length<25)
                {
                    yeniS = yeniS + " ";
                }
                return yeniS;
            }
            return yeniS;   
        }
    }
}
