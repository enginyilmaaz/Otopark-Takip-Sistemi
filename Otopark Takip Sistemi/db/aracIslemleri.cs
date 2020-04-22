using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.db
{


    class aracIslemleri
    {


        public static DataTable henuzCikisYapmamisAraclar(string aracPlaka)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT aracPlaka from araclar where aracPlaka=@aracPlaka and isParked=1";
            cmd.Parameters.AddWithValue("@aracPlaka", aracPlaka);


            return dbislem.SelectSorgusuCalistir(cmd);
        }

        public static DataTable henuzCikisYapmamisAraclarOtoparkaGore(int otoparkID)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select islemZamani as [Giriş Zamanı], a.aracPlaka as [Araç Plakası], musAdSoyad as [Müşteri Bilgisi], m.musCepNO as [Müşteri Cep NO] from kayitlar as k
join araclar as a on a.aracPlaka=k.aracPlaka
join Musteriler as m on m.musCepNO=a.musCepNo
where  isLastCheckin=1   and otoparkID=@otoparkID 
order by islemID ";
            cmd.Parameters.AddWithValue("@otoparkID", otoparkID);


            return dbislem.SelectSorgusuCalistir(cmd);
        }


        public static DataTable cikisYapilacakAracAraOtoparkaGorePlaka(int otoparkID)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT distinct a.aracPlaka from araclar as a
                                join kayitlar as k on k.aracPlaka=a.aracPlaka 
                                where otoparkID=@otoparkID and isParked=1";

            cmd.Parameters.AddWithValue("@otoparkID", otoparkID);
            

            return dbislem.SelectSorgusuCalistir(cmd);
        }




        public static DataTable plakaVarsaGetir()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select a.aracPlaka from Musteriler as m
join Araclar as a on m.musCepNO=a.musCepNo
";

            DataTable tbl = dbislem.SelectSorgusuCalistir(cmd);
            return tbl;
        }


        public static DataTable plakaKontrol(string plakaNo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select aracPlaka from araclar where aracPlaka=@aracPlaka";
            cmd.Parameters.AddWithValue("@aracPlaka", plakaNo);
            return dbislem.SelectSorgusuCalistir(cmd);
        }

        public static void aracEkle(string musCepNo,string aracPlaka)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Araclar
            (musCepNo, aracPlaka, isParked) VALUES 
            (@musCepNo, @aracPlaka,1)";

            cmd.Parameters.AddWithValue("@musCepNo", musCepNo);
            cmd.Parameters.AddWithValue("@aracPlaka", aracPlaka);

            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);


        }



        public static void aracGuncelle(string aracPlaka, bool isparked)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update Araclar set isParked=@isparked where aracPlaka=@aracPlaka";


            cmd.Parameters.AddWithValue("@aracPlaka", aracPlaka);
            cmd.Parameters.AddWithValue("@isparked", isparked);

            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);


        }



        public static DataTable girisBilgileriniGetir(string plakaNo, int otoparkID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT TOP 1 * FROM Kayitlar 
          where kayitTuru=0 and aracPlaka=@aracPlaka and otoparkID=@otoparkID
                       ORDER BY islemID DESC ";
            cmd.Parameters.AddWithValue("@aracPlaka", plakaNo);
            cmd.Parameters.AddWithValue("@otoparkID", otoparkID);
            return dbislem.SelectSorgusuCalistir(cmd);
        }


    }
}
