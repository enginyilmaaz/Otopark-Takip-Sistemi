using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1.db
{
    class dbislem
    {
        static string serverBilgisiAl=  File.ReadAllLines("server.txt").FirstOrDefault();
        static string baglantiCumlesi = "server="+serverBilgisiAl+"; database = OtoparkApp;Integrated Security = true;";
        static SqlConnection baglanti;


        public static void BaglantiAc()
        {
            baglanti = new SqlConnection();
            baglanti.ConnectionString = baglantiCumlesi;
            baglanti.Open();
        }


        public static void BaglantiKapat()
        {
            baglanti.Close();
        }


        public static void InsertUpdateDeleteSorgusuCalistir(SqlCommand komut)
        {
            BaglantiAc();
            komut.Connection = baglanti;
            komut.ExecuteNonQuery();
            BaglantiKapat();
        }

        public static DataTable SelectSorgusuCalistir(SqlCommand komut)
        {
            BaglantiAc();
            komut.Connection = baglanti;
            DataTable dt = new DataTable();
            dt.Load(komut.ExecuteReader());
            BaglantiKapat();
            return dt;
    }







    }
}
