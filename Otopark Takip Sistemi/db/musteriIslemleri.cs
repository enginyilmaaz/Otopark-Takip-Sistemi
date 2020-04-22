using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.db
{
    class musteriIslemleri
    {


        public static void musteriEkle(string musCepNO, string musAdSoyad)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Musteriler (musAdSoyad, musCepNO)
                                            VALUES (@musAdSoyad, @musCepNO)";
            cmd.Parameters.AddWithValue("@musCepNO", musCepNO);
            cmd.Parameters.AddWithValue("@musAdSoyad", musAdSoyad);
          
            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }

        
        public static DataTable musteriBilgiGetir(string musCepNO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select * from Musteriler where musCepNO=@muscepNO";
            cmd.Parameters.AddWithValue("@musCepNO", musCepNO);
                    DataTable tbl = dbislem.SelectSorgusuCalistir(cmd);
            return tbl;
        }



        public static DataTable musterileriGetir()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select musCepNO [Müşteri Cep NO],  musAdSoyad [Ad Soyad] from Musteriler where isActive=1";

            DataTable tbl = dbislem.SelectSorgusuCalistir(cmd);
            return tbl;
        }


      



        public static DataTable musteriAra(string musteriAra)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select musCepNO [Müşteri Cep NO],   musAdSoyad [Ad Soyad]  
from Musteriler  where ( musCepNO like @musteriAra)
or( musAdSoyad like @musteriAra)";
cmd.Parameters.AddWithValue("@musteriAra",  musteriAra + "%");
                                DataTable tbl = dbislem.SelectSorgusuCalistir(cmd);
            return tbl;
        }



 





        public static DataTable musteriKontrol(string musCepNO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select * from Musteriler where musCepNO=@musCepNO";
            cmd.Parameters.AddWithValue("@musCepNO", musCepNO);
            return dbislem.SelectSorgusuCalistir(cmd);
        }





        public static DataTable plakaMusteriGetir(string plakaNo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select m.musCepNO [Müşteri Cep NO],  musAdSoyad [Ad Soyad], a.aracPlaka from Musteriler as m
join Araclar as a on m.musCepNO=a.musCepNo where a.aracPlaka=@plakaNo
";

            cmd.Parameters.AddWithValue("@plakaNo", plakaNo);
            DataTable tbl = dbislem.SelectSorgusuCalistir(cmd);


            return tbl;
        }



























    }
}
