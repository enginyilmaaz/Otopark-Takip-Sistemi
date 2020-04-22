using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApplication1.db
{
    class otoparkIslem
    {


        public static DataTable otoparklariGetir()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select distinct otoparkID as [Park NO],  
otoparkAdi as [Otopark Adı], 
CASE o.otoparkTuru WHEN 1 THEN 'Açık' else 'Kapalı' END as [Otopark Türü],
 i.SehirAdi as [Şehir],  ii.ilceAdi as [İlçe], 
o.adres as [Adres],  o.aracKapasitesi as [Araç Kapasitesi], o.anlikKapasite [Şuanki Kapasite]

from Otopark as o
 join ilceler as ii on ii.ilceID=o.ilceID
 join iller as i on i.SehirId=ii.SehirID
where  o.isActive=1   ";

            return dbislem.SelectSorgusuCalistir(cmd);
        }





        public static DataTable dolulukOrani()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select distinct otoparkID as [Park NO],  
otoparkAdi as [Otopark Adı], 
 --i.SehirAdi as [Şehir],  ii.ilceAdi as [İlçe], 
  o.aracKapasitesi as [Araç Kapasitesi],(o.aracKapasitesi-o.anlikKapasite) as [Şuanki Otoparkta Bulunan Araç Sayısı],
(o.aracKapasitesi-o.anlikKapasite)*100/aracKapasitesi as [Doluluk Oranı (Yüzde)]

from Otopark as o
 join ilceler as ii on ii.ilceID=o.ilceID
 join iller as i on i.SehirId=ii.SehirID
where  o.isActive=1 
  ";

            return dbislem.SelectSorgusuCalistir(cmd);
        }


        public static DataTable dolulukOraniOtoparkaGore(int otoparkID)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select distinct otoparkID as [Park NO],  
otoparkAdi as [Otopark Adı], 
 --i.SehirAdi as [Şehir],  ii.ilceAdi as [İlçe], 
  o.aracKapasitesi as [Araç Kapasitesi],(o.aracKapasitesi-o.anlikKapasite) as [Şuanki Otoparkta Bulunan Araç Sayısı],
(o.aracKapasitesi-o.anlikKapasite)*100/aracKapasitesi as [Doluluk Oranı (Yüzde)]

from Otopark as o
 join ilceler as ii on ii.ilceID=o.ilceID
 join iller as i on i.SehirId=ii.SehirID
where  o.isActive=1 and o.otoparkID=@otoparkID
  ";
            cmd.Parameters.AddWithValue("@otoparkID", otoparkID);
            return dbislem.SelectSorgusuCalistir(cmd);
        }




        public static DataTable kayitlariGetirFiltreli(string giris, string cikis,string filtreSorgusu)
        {

            SqlCommand cmd = new SqlCommand(); 
            cmd.CommandText = @"select islemID as [İşlem NO],  otoparkAdi as [Otopark], 
 i.SehirAdi as [Şehir],  ii.ilceAdi as [İlçe], 
  a.aracPlaka as [Araç Plakası],  a.musCepNo as [Müşteri Cep No] , 
  musAdSoyad as [Müşteri Bilgisi], islemZamani as [İşlem Zamanı],
  CASE kayitTuru WHEN 1 THEN 'Çıkış' else 'Giriş' END as [Kayıt Türü],
   prsAdSoyad as [İşlemi Yapan Personel], faturaTutari as [Fatura Tutarı (TL)],
  CASE f.faturaDurumu WHEN 1 THEN 'Ödendi' else 'Ödenmedi' END as [Fatura Durumu]
from Kayitlar as k
join otopark as o on o.otoparkID=k.otoparkID
 join ilceler as ii on ii.ilceID=o.ilceID
 join iller as i on i.SehirId=ii.SehirID
 join araclar as a on a.aracPlaka=k.aracPlaka
join musteriler as m on m.musCepNO=a.musCepNo
join personeller as p on p.prsKimlikNO=k.islemiYapanKimlikNO
join faturalar as f on f.faturaNo=k.faturaNo
where islemZamani>=@giris and islemZamani<=@cikis " + filtreSorgusu+
@" order by k.islemZamani desc
 ";
            cmd.Parameters.AddWithValue("@giris", giris);
            cmd.Parameters.AddWithValue("@cikis", cikis);
            cmd.Parameters.AddWithValue("@filtreSorgusu", filtreSorgusu);
            return dbislem.SelectSorgusuCalistir(cmd);
        }


        public static DataRow kaydiGetir(int islemID)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select islemID as [İşlem NO],  otoparkAdi as [Otopark], 
 i.SehirAdi as [Şehir],  ii.ilceAdi as [İlçe], 
  a.aracPlaka as [Araç Plakası],  a.musCepNo as [Müşteri Cep No] , 
  musAdSoyad as [Müşteri Bilgisi], islemZamani as [İşlem Zamanı],
  CASE kayitTuru WHEN 1 THEN 'Çıkış' else 'Giriş' END as [Kayıt Türü],
   prsAdSoyad as [İşlemi Yapan Personel], faturaTutari as [Fatura Tutarı (TL)],
  CASE f.faturaDurumu WHEN 1 THEN 'Ödendi' else 'Ödenmedi' END as [Fatura Durumu], o.otoparkID,ii.ilceID,i.SehirID,prsKimlikNO
from Kayitlar as k
join otopark as o on o.otoparkID=k.otoparkID
 join ilceler as ii on ii.ilceID=o.ilceID
 join iller as i on i.SehirId=ii.SehirID
 join araclar as a on a.aracPlaka=k.aracPlaka
join musteriler as m on m.musCepNO=a.musCepNo
join personeller as p on p.prsKimlikNO=k.islemiYapanKimlikNO
join faturalar as f on f.faturaNo=k.faturaNo
 where islemID=@islemID";
            cmd.Parameters.AddWithValue("@islemID", islemID);
            DataTable tbl = dbislem.SelectSorgusuCalistir(cmd);
            return tbl.Rows[0];
        }





        public static DataTable kayitAra(string giris, string cikis, string ara)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select islemID as [İşlem NO],  otoparkAdi as [Otopark], 
 i.SehirAdi as [Şehir],  ii.ilceAdi as [İlçe], 
  a.aracPlaka as [Araç Plakası],  a.musCepNo as [Müşteri Cep No] , 
  musAdSoyad as [Müşteri Bilgisi], islemZamani as [İşlem Zamanı],
  CASE kayitTuru WHEN 1 THEN 'Çıkış' else 'Giriş' END as [Kayıt Türü],
   prsAdSoyad as [İşlemi Yapan Personel], faturaTutari as [Fatura Tutarı (TL)],
  CASE f.faturaDurumu WHEN 1 THEN 'Ödendi' else 'Ödenmedi' END as [Fatura Durumu]
from Kayitlar as k
join otopark as o on o.otoparkID=k.otoparkID
 join ilceler as ii on ii.ilceID=o.ilceID
 join iller as i on i.SehirId=ii.SehirID
 join araclar as a on a.aracPlaka=k.aracPlaka
join musteriler as m on m.musCepNO=a.musCepNo
join personeller as p on p.prsKimlikNO=k.islemiYapanKimlikNO
join faturalar as f on f.faturaNo=k.faturaNo
where (m.musCepNo like @ara or musAdSoyad like @ara or  o.otoparkID like @ara
or islemiYapanKimlikNO like @ara or a.aracPlaka like @ara)  and islemZamani>=@giris and islemZamani<=@cikis
order by k.islemZamani desc
";
            cmd.Parameters.AddWithValue("@ara", ara + "%");
            cmd.Parameters.AddWithValue("@giris", giris);
            cmd.Parameters.AddWithValue("@cikis", cikis);
     



            return dbislem.SelectSorgusuCalistir(cmd);
        }




        public static DataTable kayitAraOtoparkaGoreTarihFiltreli(int otoparkID, string giris, string cikis, string ara)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select islemID as [İşlem NO],  otoparkAdi as [Otopark], 
 i.SehirAdi as [Şehir],  ii.ilceAdi as [İlçe], 
  a.aracPlaka as [Araç Plakası],  a.musCepNo as [Müşteri Cep No] , 
  musAdSoyad as [Müşteri Bilgisi], islemZamani as [İşlem Zamanı],
  CASE kayitTuru WHEN 1 THEN 'Çıkış' else 'Giriş' END as [Kayıt Türü],
   prsAdSoyad as [İşlemi Yapan Personel], faturaTutari as [Fatura Tutarı (TL)],
  CASE f.faturaDurumu WHEN 1 THEN 'Ödendi' else 'Ödenmedi' END as [Fatura Durumu]
from Kayitlar as k
join otopark as o on o.otoparkID=k.otoparkID
 join ilceler as ii on ii.ilceID=o.ilceID
 join iller as i on i.SehirId=ii.SehirID
 join Faturalar as f on f.faturaNo=k.faturaNo
 join araclar as a on a.aracPlaka=k.aracPlaka
join musteriler as m on m.musCepNO=a.musCepNo
join personeller as p on p.prsKimlikNO=k.islemiYapanKimlikNO
where (m.musCepNo like @ara or musAdSoyad like @ara or  o.otoparkID like @ara
or islemiYapanKimlikNO like @ara or a.aracPlaka like @ara)  and
 o.otoparkID=@otoparkID and islemZamani>=@giris and islemZamani<=@cikis
order by k.islemZamani desc
";
            cmd.Parameters.AddWithValue("@ara", ara + "%");
            cmd.Parameters.AddWithValue("@giris", giris);
            cmd.Parameters.AddWithValue("@cikis", cikis);
            cmd.Parameters.AddWithValue("@otoparkID", otoparkID);


            return dbislem.SelectSorgusuCalistir(cmd);
        }




        public static void kayitEkle(int otoparkID,bool kayitTuru, string islemiYapanKimlikNO,string islemZamani,int FaturaNo,string plakaNo, bool isLastCheckin)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Kayitlar
            ( otoparkID, kayitTuru, islemiYapanKimlikNO, islemZamani, aracPlaka,FaturaNo, isLastCheckin) VALUES 
            (@otoparkID, @kayitTuru,  @islemiYapanKimlikNO, @islemZamani, @plakaNo,@FaturaNo,@isLastCheckin)";

            cmd.Parameters.AddWithValue("@otoparkID", otoparkID);
            cmd.Parameters.AddWithValue("@kayitTuru", kayitTuru);
            cmd.Parameters.AddWithValue("@islemiYapanKimlikNO", islemiYapanKimlikNO);
            cmd.Parameters.AddWithValue("@islemZamani", islemZamani);
            cmd.Parameters.AddWithValue("@plakaNo", plakaNo);
            cmd.Parameters.AddWithValue("@isLastCheckin", isLastCheckin);
            cmd.Parameters.AddWithValue("@FaturaNo", FaturaNo);
            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }




        public static void kayitGuncelle(int islemID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update kayitlar set isLastCheckin=0 WHERE islemID=@islemID";

            cmd.Parameters.AddWithValue("@islemID", islemID);
     
            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }





        public static DataRow kayitGuncellenecekIslemIDGetir(string aracPlaka)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select top 1 aracPlaka,islemID from kayitlar
                                  where aracPlaka=@aracPlaka and isLastCheckin=1
                                   order by islemID desc";

            cmd.Parameters.AddWithValue("@aracPlaka", aracPlaka);

            
            DataTable tbl = dbislem.SelectSorgusuCalistir(cmd);
            return tbl.Rows[0];
        }






        public static void otoparkEkle( string otoparkAdi, int ilceID, string Adres, int aracKapasitesi,bool otoparkTuru,int anlikKapasite)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Otopark 
            ( otoparkAdi, ilceID, adres, aracKapasitesi, otoparkTuru,anlikKapasite) VALUES 
            (@otoparkAdi, @ilceID,  @adres, @aracKapasitesi, @otoparkTuru,@aracKapasitesi)";
      
            cmd.Parameters.AddWithValue("@otoparkAdi", otoparkAdi);
            cmd.Parameters.AddWithValue("@ilceID", Convert.ToInt16(ilceID));
            cmd.Parameters.AddWithValue("@adres", Adres);
            cmd.Parameters.AddWithValue("@aracKapasitesi", aracKapasitesi);
            cmd.Parameters.AddWithValue("@otoparkTuru", otoparkTuru);
            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }





        public static void otoparkSil(int parkNo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update otopark set isActive=0 WHERE otoparkID=@parkNo";
            cmd.Parameters.AddWithValue("@parkNo", parkNo) ;
            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }





        public static DataRow otoparkGetir(int parkNo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select distinct otoparkID as [Park NO],  
otoparkAdi as [Otopark Adı],  i.SehirAdi as [Şehir],  ii.ilceAdi as [İlçe], 
o.adres as [Adres],  o.aracKapasitesi as [Araç Kapasitesi], o.anlikKapasite [Şuanki Kapasite],
CASE o.otoparkTuru WHEN 1 THEN 'Açık' else 'Kapalı' END as [Otopark Türü]
from Otopark as o
 join ilceler as ii on ii.ilceID=o.ilceID
 join iller as i on i.SehirId=ii.SehirID
where  o.otoparkID=@parkNo ";
         
            cmd.Parameters.AddWithValue("@parkNo", parkNo);
            DataTable tbl = dbislem.SelectSorgusuCalistir(cmd);
            return tbl.Rows[0];
        }







        public static void otoparkGuncelle(int parkNo, string otoparkAdi, int ILCE_ID, string adres,int kapasite)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update otopark set otoparkAdi=@otoparkAdi, ilceID=@ILCE_ID, adres=@adres, 
                  aracKapasitesi=aracKapasitesi+@kapasite, anlikKapasite=anlikKapasite+@kapasite where otoparkID=@parkNo";

            cmd.Parameters.AddWithValue("@parkNo", Convert.ToInt16(parkNo));
            cmd.Parameters.AddWithValue("@otoparkAdi", otoparkAdi);
            cmd.Parameters.AddWithValue("@ILCE_ID", Convert.ToInt16(ILCE_ID));
            cmd.Parameters.AddWithValue("@adres", adres);
            cmd.Parameters.AddWithValue("@kapasite", kapasite);


            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }











       

        public static DataTable otoparkAra(string otoparkAra)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select otoparkID as [Park NO],  
otoparkAdi as [Otopark Adı],  i.SehirAdi as [Şehir],  ii.ilceAdi as [İlçe], 
o.adres as [Adres],  o.aracKapasitesi as [Araç Kapasitesi], o.anlikKapasite [Şuanki Kapasite],
CASE o.otoparkTuru WHEN 1 THEN 'Açık' else 'Kapalı' END as [Otopark Türü]
from Otopark as o
 join ilceler as ii on ii.ilceID=o.ilceID
 join iller as i on i.SehirId=ii.SehirID
 where (o.otoparkAdi like @otoparkAra or i.SehirAdi like @otoparkAra) and isActive=1";
            cmd.Parameters.AddWithValue("@otoparkAra", otoparkAra + "%");


            DataTable tbl = dbislem.SelectSorgusuCalistir(cmd);
            return tbl;
        }



        public static DataTable sehirGetir()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT distinct sehirAdi, SehirId from iller order by sehirAdi ";

            return dbislem.SelectSorgusuCalistir(cmd);
        }




        public static DataTable ilceGetir(int SehirId)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT * from ilceler where SehirId=@sehirId order by ilceAdi";

            cmd.Parameters.AddWithValue("@sehirId", Convert.ToInt16(SehirId));


            return dbislem.SelectSorgusuCalistir(cmd);
        }
        



        public static DataTable otoparklaraGoreGirisYapanAracSayisiFiltreli(string giris, string cikis)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select  otoparkAdi as [Otopark Adı], count(islemID) [Giriş Yapan Araç Sayısı]
        from kayitlar as k
		join otopark as o on o.otoparkID=k.otoparkID
where  k.kayitTuru=0 and islemZamani>=@giris and islemZamani<=@cikis
group by o.otoparkAdi";

            cmd.Parameters.AddWithValue("@giris", giris);
            cmd.Parameters.AddWithValue("@cikis", cikis);
            return dbislem.SelectSorgusuCalistir(cmd);
        }



        public static DataTable otoparkGoreGirisYapanAracSayisiFiltreli(string giris, string cikis, int otoparkID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select  otoparkAdi as [Otopark Adı], count(islemID) [Giriş Yapan Araç Sayısı]
        from kayitlar as k
		join otopark as o on o.otoparkID=k.otoparkID
where  k.kayitTuru=0 and islemZamani>=@giris and islemZamani<=@cikis and o.otoparkID=@otoparkID group by o.otoparkAdi";

            cmd.Parameters.AddWithValue("@giris", giris);
            cmd.Parameters.AddWithValue("@cikis", cikis);
            cmd.Parameters.AddWithValue("@otoparkID", otoparkID);
            return dbislem.SelectSorgusuCalistir(cmd);
        }






        public static DataTable toplamGirisAracSayisiFiltreli(string giris, string cikis)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select  count(islemID) [Giriş Yapan Araç Sayısı]
        from kayitlar as k
		join otopark as o on o.otoparkID=k.otoparkID
where  k.kayitTuru=0 and islemZamani>=@giris and islemZamani<=@cikis";

            cmd.Parameters.AddWithValue("@giris", giris);
            cmd.Parameters.AddWithValue("@cikis", cikis);
            return dbislem.SelectSorgusuCalistir(cmd);
        }


        public static DataTable toplamOtoparkSayisi()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select  count(otoparkID) [Toplam Otopark Sayısı]
        from otopark where  isActive=1";

        
            return dbislem.SelectSorgusuCalistir(cmd);
        }



        public static DataTable toplamGirisAracSayisi()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select  count(islemID) [Giriş Yapan Araç Sayısı]
        from kayitlar as k
		join otopark as o on o.otoparkID=k.otoparkID
where  k.kayitTuru=0";

            return dbislem.SelectSorgusuCalistir(cmd);
        }


        public static DataTable toplamGirisAracSayisiOtoparkaGore(int otoparkID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select  count(islemID) [Giriş Yapan Araç Sayısı]
        from kayitlar as k
		join otopark as o on o.otoparkID=k.otoparkID
where  k.kayitTuru=0 and o.otoparkID=@otoparkID";
            cmd.Parameters.AddWithValue("@otoparkID", otoparkID);
            return dbislem.SelectSorgusuCalistir(cmd);
        }

    }
}
