using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.db
{
    class tarifeIslem
    {


        public static void tarifeEkle(int otoparkID, int ilksaatUcreti,int sonrakiSaatUcreti,int gunlukUcret)
        { 
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO tarifeler (otoparkID, ilksaatUcreti,sonrakiSaatbasiEkUcret,gunlukUcret)
                                            VALUES (@otoparkID, @ilksaatUcreti,@sonrakiSaatbasiEkUcret,@gunlukUcret)";
            cmd.Parameters.AddWithValue("@otoparkID", otoparkID);
            cmd.Parameters.AddWithValue("@ilksaatUcreti", ilksaatUcreti);
            cmd.Parameters.AddWithValue("@sonrakiSaatbasiEkUcret",sonrakiSaatUcreti);
            cmd.Parameters.AddWithValue("@gunlukUcret", gunlukUcret);

            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }


        public static DataTable tarifeleriGetir()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select o.otoparkId as [Park No],otoparkAdi as [Otopark Adı], ilkSaatUcreti as [İlk Saat Ücreti], sonrakiSaatbasiEkUcret as [Sonraki Saat Başı Ücret],
gunlukUcret as [Günlük Ücret]
from Tarifeler as t
join Otopark as o on o.otoparkID=t.otoparkID";

            return dbislem.SelectSorgusuCalistir(cmd);
        }

        public static DataTable tarifeAra(string otoparkAdi)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select o.otoparkId as [Park No], ilkSaatUcreti as [İlk Saat Ücreti], sonrakiSaatbasiEkUcret as [Sonraki Saat Başı Ücret],
gunlukUcret as [Günlük Ücret]
from Tarifeler as t
join Otopark as o on o.otoparkID=t.otoparkID where otoparkAdi like @otoparkAdi";
            cmd.Parameters.AddWithValue("@otoparkAdi", otoparkAdi + "%");
            return dbislem.SelectSorgusuCalistir(cmd);
        }



        public static void tarifeGuncelle(int ilkSaatUcreti,int sonrakiSaatbasiEkUcret,int gunlukUcret,int otoparkID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update tarifeler set  
ilkSaatUcreti=@ilkSaatUcreti,
sonrakiSaatbasiEkUcret=@sonrakiSaatbasiEkUcret,
gunlukUcret=@gunlukUcret
where otoparkID=@otoparkID";
            cmd.Parameters.AddWithValue("@ilkSaatUcreti", ilkSaatUcreti);
            cmd.Parameters.AddWithValue("@sonrakiSaatbasiEkUcret", sonrakiSaatbasiEkUcret);
            cmd.Parameters.AddWithValue("@gunlukUcret", gunlukUcret);
            cmd.Parameters.AddWithValue("@otoparkID", otoparkID);

            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }



        public static DataRow tarifeyiGetir(int otoparkID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select o.otoparkId as [Park No], otoparkAdi as [Otopark Adı], ilkSaatUcreti as [İlk Saat Ücreti], sonrakiSaatbasiEkUcret as [Sonraki Saat Başı Ücret],
gunlukUcret as [Günlük Ücret]
from Tarifeler as t
join Otopark as o on o.otoparkID=t.otoparkID
where o.otoparkID=@otoparkID";

            cmd.Parameters.AddWithValue("@otoparkID", otoparkID);
      
            DataTable tbl = dbislem.SelectSorgusuCalistir(cmd);
            return tbl.Rows[0];
        }




        public static DataTable tarifesiOlmayanOtoparklariGetir()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select distinct o.otoparkID as [Park NO], 
otoparkAdi as [Otopark Adı] from Otopark as o
left join Tarifeler as t on t.otoparkID=o.otoparkID
where  o.isActive=1 and tarifeNO is null order by otoparkAdi";

            return dbislem.SelectSorgusuCalistir(cmd);
        }




        public static void faturaOlustur(string OlusturanPersonel)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Faturalar (OlusturanPersonel)
                                            VALUES (@OlusturanPersonel)";
            cmd.Parameters.AddWithValue("@OlusturanPersonel", OlusturanPersonel);
         

            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }



        public static void faturaOdendiGuncelle(int faturaNo, string faturaTarihi, int faturaTutari, bool odemeYontemi)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"UPDATE Faturalar 
SET faturaDurumu = 1  , faturaTarihi=@faturaTarihi, faturaTutari=@faturaTutari, odemeYontemi=@odemeYontemi
FROM Faturalar f  
WHERE faturaNo=@faturaNo";
            cmd.Parameters.AddWithValue("@faturaNo", faturaNo);
            cmd.Parameters.AddWithValue("@faturaTarihi", faturaTarihi);
            cmd.Parameters.AddWithValue("@faturaTutari", faturaTutari);
            cmd.Parameters.AddWithValue("@odemeYontemi", odemeYontemi);

            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }





        public static DataTable faturalariGetir(string giris, string cikis)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select f.faturaNo as [Fatura NO],  otoparkAdi as [Otopark], 
 i.SehirAdi as [Şehir],  ii.ilceAdi as [İlçe], 
  a.aracPlaka as [Araç Plakası],  m.musCepNo as [Müşteri Cep No] , 
  musAdSoyad as [Müşteri Bilgisi], islemZamani as [İşlem Zamanı],
   prsAdSoyad as [İşlemi Yapan Yetkili], faturaTutari as [Fatura Tutarı (TL)],
   CASE f.odemeYontemi WHEN 1 THEN 'Nakit' WHEN 0 THEN 'Kredi Kartı' else '-' END as [Ödeme Yöntemi]  ,
  CASE f.faturaDurumu WHEN 1 THEN 'Ödendi' else 'Ödenmedi' END as [Fatura Durumu]
from Faturalar as f
join kayitlar as k on f.faturaNo=k.faturaNo
join otopark as o on o.otoparkID=k.otoparkID
 join ilceler as ii on ii.ilceID=o.ilceID
 join iller as i on i.SehirId=ii.SehirID
 join araclar as a on a.aracPlaka=k.aracPlaka
join musteriler as m on m.musCepNO=a.musCepNo
join personeller as p on p.prsKimlikNO=k.islemiYapanKimlikNO 
where islemZamani>=@giris and islemZamani<=@cikis
order by islemZamani desc";
            cmd.Parameters.AddWithValue("@giris", giris);
            cmd.Parameters.AddWithValue("@cikis", cikis);
            return dbislem.SelectSorgusuCalistir(cmd);
        }



        public static DataTable faturaAra(string ara, string giris, string cikis)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select distinct f.faturaNo as [Fatura NO],  otoparkAdi as [Otopark], 
 i.SehirAdi as [Şehir],  ii.ilceAdi as [İlçe], 
  a.aracPlaka as [Araç Plakası],  m.musCepNo as [Müşteri Cep No] , 
  musAdSoyad as [Müşteri Bilgisi], islemZamani as [İşlem Zamanı],
   prsAdSoyad as [İşlemi Yapan Yetkili], faturaTutari as [Fatura Tutarı (TL)],
   CASE f.odemeYontemi WHEN 1 THEN 'Nakit' WHEN 0 THEN 'Kredi Kartı' else '-' END as [Ödeme Yöntemi]  ,
  CASE f.faturaDurumu WHEN 1 THEN 'Ödendi' else 'Ödenmedi' END as [Fatura Durumu]
from Faturalar as f
join kayitlar as k on f.faturaNo=k.faturaNo
join otopark as o on o.otoparkID=k.otoparkID
 join ilceler as ii on ii.ilceID=o.ilceID
 join iller as i on i.SehirId=ii.SehirID
 join araclar as a on a.aracPlaka=k.aracPlaka
join musteriler as m on m.musCepNO=a.musCepNo
join personeller as p on p.prsKimlikNO=k.islemiYapanKimlikNO
 where (m.musCepNo like @ara or musAdSoyad like @ara or o.otoparkID like @ara
or islemiYapanKimlikNO like @ara or a.aracPlaka like @ara)  
and islemZamani>=@giris and islemZamani<=@cikis
order by islemZamani desc";
            cmd.Parameters.AddWithValue("@ara", ara + "%");
            cmd.Parameters.AddWithValue("@giris", giris);
            cmd.Parameters.AddWithValue("@cikis", cikis);
            return dbislem.SelectSorgusuCalistir(cmd);
        }



        public static DataTable faturalariGetirOtoparkaGore(int otoparkID, string giris, string cikis)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select distinct f.faturaNo as [Fatura NO],  otoparkAdi as [Otopark], 
 i.SehirAdi as [Şehir],  ii.ilceAdi as [İlçe], 
  a.aracPlaka as [Araç Plakası],  m.musCepNo as [Müşteri Cep No] , 
  musAdSoyad as [Müşteri Bilgisi], islemZamani as [İşlem Zamanı],
   prsAdSoyad as [İşlemi Yapan Yetkili], faturaTutari as [Fatura Tutarı (TL)],
   CASE f.odemeYontemi WHEN 1 THEN 'Nakit' WHEN 0 THEN 'Kredi Kartı' else '-' END as [Ödeme Yöntemi]  ,
  CASE f.faturaDurumu WHEN 1 THEN 'Ödendi' else 'Ödenmedi' END as [Fatura Durumu]
from Faturalar as f
join kayitlar as k on f.faturaNo=k.faturaNo
join otopark as o on o.otoparkID=k.otoparkID
 join ilceler as ii on ii.ilceID=o.ilceID
 join iller as i on i.SehirId=ii.SehirID
 join araclar as a on a.aracPlaka=k.aracPlaka
join musteriler as m on m.musCepNO=a.musCepNo
join personeller as p on p.prsKimlikNO=k.islemiYapanKimlikNO
 where o.otoparkID=@otoparkID 
and islemZamani>=@giris and islemZamani<=@cikis
order by islemZamani desc";
            cmd.Parameters.AddWithValue("@otoparkID", otoparkID);
            cmd.Parameters.AddWithValue("@giris", giris);
            cmd.Parameters.AddWithValue("@cikis", cikis);
            return dbislem.SelectSorgusuCalistir(cmd);
        }


        public static DataTable faturaAraOtoparkaGore(string ara,int otoparkID, string giris, string cikis)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select distinct f.faturaNo as [Fatura NO],  otoparkAdi as [Otopark], 
 i.SehirAdi as [Şehir],  ii.ilceAdi as [İlçe], 
  a.aracPlaka as [Araç Plakası],  m.musCepNo as [Müşteri Cep No] , 
  musAdSoyad as [Müşteri Bilgisi], islemZamani as [İşlem Zamanı],
   prsAdSoyad as [İşlemi Yapan Yetkili], faturaTutari as [Fatura Tutarı (TL)],
   CASE f.odemeYontemi WHEN 1 THEN 'Nakit' WHEN 0 THEN 'Kredi Kartı' else '-' END as [Ödeme Yöntemi]  ,
  CASE f.faturaDurumu WHEN 1 THEN 'Ödendi' else 'Ödenmedi' END as [Fatura Durumu]
from Faturalar as f
join kayitlar as k on f.faturaNo=k.faturaNo
join otopark as o on o.otoparkID=k.otoparkID
 join ilceler as ii on ii.ilceID=o.ilceID
 join iller as i on i.SehirId=ii.SehirID
 join araclar as a on a.aracPlaka=k.aracPlaka
join musteriler as m on m.musCepNO=a.musCepNo
join personeller as p on p.prsKimlikNO=k.islemiYapanKimlikNO
 where (m.musCepNo like @ara or musAdSoyad like @ara or o.otoparkID like @ara
or islemiYapanKimlikNO like @ara or a.aracPlaka like @ara) and 
o.otoparkID=@otoparkID  and islemZamani>=@giris and islemZamani<=@cikis
order by islemZamani desc";
            cmd.Parameters.AddWithValue("@ara", ara + "%");
            cmd.Parameters.AddWithValue("@otoparkID", otoparkID);
            cmd.Parameters.AddWithValue("@giris", giris);
            cmd.Parameters.AddWithValue("@cikis", cikis);
            return dbislem.SelectSorgusuCalistir(cmd);
        }




        public static DataRow sonEklenenFaturaID(string olusturanPersonel)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT faturaNo FROM Faturalar 
WHERE faturaNo=(SELECT max(faturaNo) FROM Faturalar) and olusturanPersonel=@olusturanPersonel";
            cmd.Parameters.AddWithValue("@olusturanPersonel", olusturanPersonel);

            DataTable tbl = dbislem.SelectSorgusuCalistir(cmd);
            return tbl.Rows[0];
        }



        public static DataTable otoparklaraGoreToplamCiro()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select  otoparkAdi as [Otopark Adı], sum(faturaTutari) [Ciro (TL)]
        from Faturalar as f 
		join Kayitlar as k on k.faturaNo=f.faturaNo
		join Otopark as o on o.otoparkID=k.otoparkID
where o.isActive=1 and k.kayitTuru=1 
group by otoparkAdi";

            return dbislem.SelectSorgusuCalistir(cmd);
        }

        public static DataTable ToplamCiro()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select   sum(faturaTutari) [Ciro (TL)]
        from Faturalar as f 
		join Kayitlar as k on k.faturaNo=f.faturaNo
		join Otopark as o on o.otoparkID=k.otoparkID
where o.isActive=1 and k.kayitTuru=1 ";

            return dbislem.SelectSorgusuCalistir(cmd);
        }


        public static DataTable ToplamCiroPtoparkaGore(int otoparkID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select   sum(faturaTutari) [Ciro (TL)]
        from Faturalar as f 
		join Kayitlar as k on k.faturaNo=f.faturaNo
		join Otopark as o on o.otoparkID=k.otoparkID
where o.isActive=1 and k.kayitTuru=1 and o.otoparkID=@otoparkID ";
            cmd.Parameters.AddWithValue("@otoparkID", otoparkID);
            return dbislem.SelectSorgusuCalistir(cmd);
        }



        public static DataTable ToplamCiroFiltreli(string giris, string cikis)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select   sum(faturaTutari) [Ciro (TL)]
        from Faturalar as f 
		join Kayitlar as k on k.faturaNo=f.faturaNo
		join Otopark as o on o.otoparkID=k.otoparkID
where o.isActive=1 and k.kayitTuru=1 and islemZamani>=@giris and islemZamani<=@cikis";

            cmd.Parameters.AddWithValue("@giris", giris);
            cmd.Parameters.AddWithValue("@cikis", cikis);
            return dbislem.SelectSorgusuCalistir(cmd);
        }

        public static DataTable ToplamCiroFiltreliOtoparkaGore(string giris, string cikis,int otoparkID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select   sum(faturaTutari) [Ciro (TL)]
        from Faturalar as f 
		join Kayitlar as k on k.faturaNo=f.faturaNo
		join Otopark as o on o.otoparkID=k.otoparkID
where o.isActive=1 and k.kayitTuru=1 and islemZamani>=@giris and islemZamani<=@cikis and o.otoparkID=@otoparkID";

            cmd.Parameters.AddWithValue("@giris", giris);
            cmd.Parameters.AddWithValue("@cikis", cikis);
            cmd.Parameters.AddWithValue("@otoparkID", otoparkID);
            return dbislem.SelectSorgusuCalistir(cmd);
        }

        public static DataTable otoparklaraGoreToplamCiroFiltreli(string giris, string cikis)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select  otoparkAdi as [Otopark Adı], sum(faturaTutari) [Ciro (TL)]
        from Faturalar as f 
		join Kayitlar as k on k.faturaNo=f.faturaNo
		join Otopark as o on o.otoparkID=k.otoparkID
where o.isActive=1 and k.kayitTuru=1  and islemZamani>=@giris and islemZamani<=@cikis
group by otoparkAdi";

            cmd.Parameters.AddWithValue("@giris", giris);
            cmd.Parameters.AddWithValue("@cikis", cikis);
            return dbislem.SelectSorgusuCalistir(cmd);
        }
















    }
}
