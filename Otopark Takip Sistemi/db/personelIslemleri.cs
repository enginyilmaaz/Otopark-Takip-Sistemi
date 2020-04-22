using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1.db
{
    class personelIslemleri
    {


        public static DataTable girisKontrolu(string prsKimlikNo, string prsSifre)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select p.prsKimlikNO,p.prsAdSoyad,p.ROL_ID,o.otoparkAdi,r.rolAciklamasi,m.modulAdi
FROM Personeller as p 
 join Otopark as o on o.otoparkID=p.otoparkID
join Roller as r on p.ROL_ID=r.ROL_ID
join Moduller as m on m.modulId=r.modulerisimi
where (p.prsKimlikNo = @prsKimlikNo and p.prsParola = @Parola) and  p.isActive=1";
            cmd.Parameters.AddWithValue("@prsKimlikNo", prsKimlikNo);
            cmd.Parameters.AddWithValue("@Parola", prsSifre);
            DataTable tbl = dbislem.SelectSorgusuCalistir(cmd);
            return tbl;
        }


        public static DataTable sifremiUnuttum(string yetkili_Mail)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Personeller where prsEposta=@yetkili_Mail and isActive=1";
            cmd.Parameters.AddWithValue("@yetkili_Mail", yetkili_Mail);
            DataTable tbl = dbislem.SelectSorgusuCalistir(cmd);
            return tbl;
        }



        public static void sifreDegistir(string Yeni_Sifre, string yetkili_Mail)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update Personeller set prsParola=@yetkili_Sifre where prsEposta=@yetkili_Mail";
            cmd.Parameters.AddWithValue("@yetkili_Sifre", Yeni_Sifre);
            cmd.Parameters.AddWithValue("@yetkili_Mail", yetkili_Mail);
            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }

        public static void personelEkle(string prs_TC_No, string prs_Ad_Soyad, int ROL_ID, string prs_Tel_No, string prs_Mail, string prs_Sifre, string prs_Gizli_Soru, string prs_Gizli_Soru_Cevabi, bool prs_Cinsiyet, int prs_parkNo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Personeller (prsKimlikNO, prsAdSoyad, ROL_ID, prsCepNo,
prsEposta, prsParola, prsGizliSoru, prsGizliSoruCevap, prsCinsiyet,otoparkID)
   VALUES (@prs_TC_No, @prs_Ad_Soyad, @ROL_ID, @prs_Tel_No, 
 @prs_Mail, @prs_Sifre, @prs_Gizli_Soru, @prs_Gizli_Soru_Cevabi,  @prs_Cinsiyet, @prs_ParkNo)";
            cmd.Parameters.AddWithValue("@prs_TC_No", prs_TC_No);
            cmd.Parameters.AddWithValue("@prs_Ad_Soyad", prs_Ad_Soyad);
            cmd.Parameters.AddWithValue("@ROL_ID", Convert.ToInt16(ROL_ID));
            cmd.Parameters.AddWithValue("@prs_Tel_No", prs_Tel_No);
            cmd.Parameters.AddWithValue("@prs_Mail", prs_Mail);
            cmd.Parameters.AddWithValue("@prs_Sifre", prs_Sifre);
            cmd.Parameters.AddWithValue("@prs_Gizli_Soru", prs_Gizli_Soru);
            cmd.Parameters.AddWithValue("@prs_Gizli_Soru_Cevabi", prs_Gizli_Soru_Cevabi);
            cmd.Parameters.AddWithValue("@prs_Cinsiyet", prs_Cinsiyet);
            cmd.Parameters.AddWithValue("@prs_ParkNo", prs_parkNo);
            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }








        public static bool EmailKontrol(string eposta)
        {
            const string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
    @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
    @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

            return (new Regex(strRegex)).IsMatch(eposta);
        }




        public static DataTable YetkiliVarmi(string prsKimlikNo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select * from Personeller where prsKimlikNo=@prsKimlikNo";
            cmd.Parameters.AddWithValue("@prsKimlikNo", prsKimlikNo);
            return dbislem.SelectSorgusuCalistir(cmd);
        }



        public static DataTable PersonelleriGetir()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select p.prsAdSoyad as [Ad Soyad],
p.prsKimlikNo as [Kimlik NO],  
case when prsCinsiyet=1 then 'Erkek'  else 'Kadın' end as [Cinsiyet], 
prsCepNo as [Telefon No],
 prsEposta as [Eposta],
r.rolAciklamasi [Yetkisi],
o.otoparkAdi as [Otopark Adı],
sehirAdi as [Otopark İl],
ilceAdi as [Otopark İlçe]
 from personeller as p  join otopark as o on o.otoparkID=p.otoparkID
  join ilceler as ii on ii.ilceID=o.ilceID
join iller as i on i.SehirId=ii.SehirID
join Roller as r on r.ROL_ID=p.ROL_ID
where p.isActive=1
 order by p.prsAdSoyad";
            return dbislem.SelectSorgusuCalistir(cmd);
        }


        public static DataTable otoparkaGorePersoneller(int parkNo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select p.prsAdSoyad as [Ad Soyad],
p.prsKimlikNo as [Kimlik NO],  
case when prsCinsiyet=1 then 'Erkek'  else 'Kadın' end as [Cinsiyet], 
prsCepNo as [Telefon No],
 prsEposta as [Eposta],
r.rolAciklamasi [Yetkisi],
o.otoparkAdi as [Otopark Adı],
sehirAdi as [Otopark İl],
ilceAdi as [Otopark İlçe]
 from personeller as p  join otopark as o on o.otoparkID=p.otoparkID
  join ilceler as ii on ii.ilceID=o.ilceID
join iller as i on i.SehirId=ii.SehirID
join Roller as r on r.ROL_ID=p.ROL_ID
where p.isActive=1 and o.otoparkID=@otoparkID
 order by p.prsAdSoyad";
           
            cmd.Parameters.AddWithValue("@otoparkID", parkNo);
            return dbislem.SelectSorgusuCalistir(cmd);

        }



        public static DataRow personelGetir(string prsKimlikNo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select p.prsAdSoyad as [Ad Soyad],
p.prsKimlikNo as [Kimlik NO],  
case when prsCinsiyet=1 then 'Erkek'  else 'Kadın' end as [Cinsiyet], 
r.rolAciklamasi [Yetkisi],
o.otoparkAdi as [Otopark Adı],
prsCepNo as [Telefon No],
 prsEposta as [Eposta],
prsParola as [Şifre],
o.otoparkID as [Park NO],
prsGizliSoru as [Gizli Soru]
 from personeller as p  join otopark as o on o.otoparkID=p.otoparkID
  join ilceler as ii on ii.ilceID=o.ilceID
join iller as i on i.SehirId=ii.SehirID
join Roller as r on r.ROL_ID=p.ROL_ID
 where prsKimlikNo=@prsKimlikNo";
            cmd.Parameters.AddWithValue("@prsKimlikNo", prsKimlikNo);
            DataTable tbl = dbislem.SelectSorgusuCalistir(cmd);
            return tbl.Rows[0];
        }


        public static void PersonelSil(string prsKimlikNo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update personeller set isActive=0 where prsKimlikNo=@prsKimlikNo";
            cmd.Parameters.AddWithValue("@prsKimlikNo", prsKimlikNo);
            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }




        public static void personelGuncelle(string prsAdSoyad, string prsKimlikNO, int prsROL_ID, int otoparkID, string prsCepNo, string prsEposta, string prsParola, string prsGizliSoru, string prsGizliSoruCevap)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"UPDATE Personeller set 
                  prsAdSoyad=@prsAdSoyad,  prsCepNo = @prsCepNo, 
                               prsEposta = @prsEposta, 
                              prsParola =@prsParola, 
                               prsGizliSoru=@prsGizliSoru, 
                               prsGizliSoruCevap=@prsGizliSoruCevap,
                              ROL_ID=@prsROL_ID, otoparkID=@otoparkID   where prsKimlikNO=@prsKimlikNO";
            cmd.Parameters.AddWithValue("@prsKimlikNO", prsKimlikNO);
            cmd.Parameters.AddWithValue("@prsCepNo", prsCepNo);
            cmd.Parameters.AddWithValue("@prsEposta", prsEposta);
            cmd.Parameters.AddWithValue("@prsROL_ID", prsROL_ID);
            cmd.Parameters.AddWithValue("@otoparkID", otoparkID);
            cmd.Parameters.AddWithValue("@prsParola", prsParola);
            cmd.Parameters.AddWithValue("@prsGizliSoru", prsGizliSoru);
            cmd.Parameters.AddWithValue("@prsGizliSoruCevap", prsGizliSoruCevap);
            cmd.Parameters.AddWithValue("@prsAdSoyad", prsAdSoyad);
            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }








        public static DataTable personelAra(string personelAra)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select p.prsAdSoyad as [Ad Soyad],
p.prsKimlikNo as [Kimlik NO],  
case when prsCinsiyet=1 then 'Erkek'  else 'Kadın' end as [Cinsiyet], 
r.rolAciklamasi [Yetkisi],
o.otoparkAdi as [Otopark Adı],
prsCepNo as [Telefon No],
 prsEposta as [Eposta],
prsParola as [Şifre],
o.otoparkID as [Park NO],
prsGizliSoru as [Gizli Soru]
 from personeller as p  join otopark as o on o.otoparkID=p.otoparkID
  join ilceler as ii on ii.ilceID=o.ilceID
join iller as i on i.SehirId=ii.SehirID
join Roller as r on r.ROL_ID=p.ROL_ID
where (prsAdSoyad like @personelAra 
               or prsKimlikNo like @personelAra
               or prsCepNo like @personelAra)  and p.isActive=1
              order by prsAdSoyad ";
            cmd.Parameters.AddWithValue("@personelAra",  personelAra  +"%");

            return dbislem.SelectSorgusuCalistir(cmd);
        }



        public static DataTable personelAraOtoparkaGore(string personelAra,int otoparkID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select p.prsAdSoyad as [Ad Soyad],
p.prsKimlikNo as [Kimlik NO],  
case when prsCinsiyet=1 then 'Erkek'  else 'Kadın' end as [Cinsiyet], 
r.rolAciklamasi [Yetkisi],
o.otoparkAdi as [Otopark Adı],
prsCepNo as [Telefon No],
 prsEposta as [Eposta],
prsParola as [Şifre],
o.otoparkID as [Park NO],
prsGizliSoru as [Gizli Soru]
 from personeller as p  join otopark as o on o.otoparkID=p.otoparkID
  join ilceler as ii on ii.ilceID=o.ilceID
join iller as i on i.SehirId=ii.SehirID
join Roller as r on r.ROL_ID=p.ROL_ID
where (prsAdSoyad like @personelAra 
               or prsKimlikNo like @personelAra
               or prsCepNo like @personelAra) and o.otoparkID=@otoparkID 
              order by prsAdSoyad";
            cmd.Parameters.AddWithValue("@personelAra", personelAra + "%");
            cmd.Parameters.AddWithValue("@otoparkID", otoparkID);

            return dbislem.SelectSorgusuCalistir(cmd);
        }

        public static DataTable otoparklaraGorePersonelSayisi()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select
otoparkAdi as [Otopark Adı], count(*) [Personel Sayısı]
        from Personeller as p left join Otopark as o on p.otoparkID=o.otoparkID
where o.isActive=1 and p.isActive=1 group by otoparkAdi";
            return dbislem.SelectSorgusuCalistir(cmd);
        }

        public static DataTable otoparkaGorePersonelSayisi(int otoparkID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select
otoparkAdi as [Otopark Adı], count(*) [Personel Sayısı]
        from Personeller as p join Otopark as o on p.otoparkID=o.otoparkID
where o.isActive=1 and p.isActive=1 and o.otoparkID=@otoparkID group by o.otoparkAdi";
            cmd.Parameters.AddWithValue("@otoparkID", otoparkID);
            return dbislem.SelectSorgusuCalistir(cmd);

        }



        public static DataTable toplamPersonelSayisi()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select count(*) [Toplam Personel Sayısı]
        from Personeller where isActive=1";
            return dbislem.SelectSorgusuCalistir(cmd);
        }




        public static void yetkiEkle(string Aciklama,int modulID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO roller (rolAciklamasi,modulErisimi)
                                            VALUES (@Aciklama,@modulErisimi)";
            cmd.Parameters.AddWithValue("@Aciklama", Aciklama);
            cmd.Parameters.AddWithValue("@modulErisimi",modulID);


            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }



        public static void yetkiGuncelle(string rolAciklamasi,int modulID, int ROL_ID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update  Roller set rolAciklamasi=@rolAciklamasi , 
                                       modulErisimi=@modulID 
                                      where ROL_ID=@ROL_ID";
            cmd.Parameters.AddWithValue("@rolAciklamasi", rolAciklamasi);
            cmd.Parameters.AddWithValue("@ROL_ID", ROL_ID);
            cmd.Parameters.AddWithValue("@modulID", modulID);


            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }

        public static DataTable yetkiAra(string yetki)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select 
ROL_ID as [Yetki No],
rolAciklamasi as [Yetki Açıklaması], m.modulAdi [Ekran Erişimi]
 from roller  as r
join Moduller as m on r.modulErisimi=m.modulID
where isActive=1 and rolAciklamasi like @yetki";
            cmd.Parameters.AddWithValue("@yetki", "%" + yetki+ "%");
            return dbislem.SelectSorgusuCalistir(cmd);
        }




        public static DataRow yetkiyiGetir(int ROL_ID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @" select 
ROL_ID as [Yetki No],
rolAciklamasi as [Yetki Açıklaması], m.modulAdi [Ekran Erişimi]
 from roller  as r
join Moduller as m on r.modulErisimi=m.modulID
where ROL_ID=@ROL_ID";
            cmd.Parameters.AddWithValue("@ROL_ID", ROL_ID);
            DataTable tbl = dbislem.SelectSorgusuCalistir(cmd);
            return tbl.Rows[0];
        }


        public static DataTable yetkileriGetir()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @" select 
ROL_ID as [Yetki No],
rolAciklamasi as [Yetki Açıklaması], m.modulAdi [Ekran Erişimi]
 from roller  as r
join Moduller as m on r.modulErisimi=m.modulID where isActive=1    ";
            return dbislem.SelectSorgusuCalistir(cmd);
        }

        public static void yetkiSil(int ROL_ID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update roller  set isActive=0 WHERE ROL_ID=@ROL_ID";
            cmd.Parameters.AddWithValue("@ROL_ID", ROL_ID);
            dbislem.InsertUpdateDeleteSorgusuCalistir(cmd);
        }



        public static DataTable modulleriListele()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from moduller";

            return  dbislem.SelectSorgusuCalistir(cmd);
        }


















    }
}
