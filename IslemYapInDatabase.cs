using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using YoklamaTutucu.models;

namespace YoklamaTutucu;




//database işlemleri için IIslemYap tan inherit edilmiş class
public class IslemYapInDatabase : IIslemYap
{
    private readonly DersDtoContextAndDersdevamsizlikDtoContext db;

    public IslemYapInDatabase()
    {
        db = new DersDtoContextAndDersdevamsizlikDtoContext();

        tumVerileriSil();
        db.SaveChanges();

    }

    public void tumVerileriSil()
    {
        Console.WriteLine("tüm veriler silinecek onaylıyor musunuz?(iptal için i)");
        string onay = Console.ReadLine();
        if (onay == "i" || onay == "İ")
        {
            Console.WriteLine("iptal edildi");
            return;
        }
        Console.WriteLine("tüm veriler siliniyor");
        Console.WriteLine("dersler siliniyor");
        foreach (DersDto dersDto in db.dersler.ToList())
        {
            db.dersler.Remove(dersDto);
        }
        Console.WriteLine("devamsızlıklar siliniyor");
        foreach (DersdevamsizlikDto dersdevamsizlikDto in db.devamsizliklar.ToList())
        {
            db.devamsizliklar.Remove(dersdevamsizlikDto);
        }
        db.SaveChanges();
        Console.WriteLine("tüm veriler silindi");

    }

    public List<Dersdevamsizlik> dersBazindaDevamsizlikGetir(Ders ders)
    {
        List<Dersdevamsizlik> dersdevamsizliklar = new List<Dersdevamsizlik>();
        if (db.devamsizliklar.Count() <= 0)
        {
            //veritabanında veri yok;
            return dersdevamsizliklar;
        }
        List<DersdevamsizlikDto> dersdevamsizlikDtos = db.devamsizliklar.Where(dersdevamsizlikDto => (dersdevamsizlikDto.Ders.DersAdi == ders.adi) && (dersdevamsizlikDto.Ders.DersOgretimGorevlisiAdi == ders.hocasi)).ToList();
        //mapping
        foreach (DersdevamsizlikDto dersdevamsizlikDto in dersdevamsizlikDtos)
        {
            Ders ders1 = new Ders(dersdevamsizlikDto.Ders.DersAdi, dersdevamsizlikDto.Ders.DersOgretimGorevlisiAdi);
            Dersdevamsizlik dersdevamsizlik = new Dersdevamsizlik(ders1, dersdevamsizlikDto.DevamsizlikSayisi, dersdevamsizlikDto.devamsizlikTarihi);
            dersdevamsizliklar.Add(dersdevamsizlik);
        }
        return dersdevamsizliklar;
    }

    public List<Dersdevamsizlik> dersdevamsizliklarigetir()
    {
        //bu fonksiyon
        List<Dersdevamsizlik> dersdevamsizliklar = new List<Dersdevamsizlik>();
        Console.WriteLine($"devammmsızlık {db.devamsizliklar.Count()}");
        if ((db.devamsizliklar.Count() <= 0) || (db.devamsizliklar == null))
        {
            //veritabanında veri yok;
            return dersdevamsizliklar;
        }
        //mapping
        List<DersdevamsizlikDto> dersdevamsizlikDtos = db.devamsizliklar.ToList();
        foreach (DersdevamsizlikDto dersdevamsizlikDto in dersdevamsizlikDtos)
        {
            //aşağıdaki satır hata veriyor
            /*Hata
             System.NullReferenceException: 'Object reference not set to an instance of an object.'

YoklamaTutucu.DersdevamsizlikDto.Ders.get, null döndürdü.

             */
            Ders ders1 = new Ders(dersdevamsizlikDto.Ders.DersAdi, dersdevamsizlikDto.Ders.DersOgretimGorevlisiAdi);
            Dersdevamsizlik dersdevamsizlik = new Dersdevamsizlik(ders1, dersdevamsizlikDto.DevamsizlikSayisi, dersdevamsizlikDto.devamsizlikTarihi);
            dersdevamsizliklar.Add(dersdevamsizlik);
        }
        return dersdevamsizliklar;
    }

    public bool dersEkle(Ders ders)
    {
        //fonksiyon test için böyle yazıldı lütfen düzelt
        db.dersler.Add(new DersDto() { DersAdi = ders.adi, DersOgretimGorevlisiAdi = ders.hocasi });
        db.SaveChanges();
        return true;
    }

    public List<Ders> dersleriGetir()
    {
        List<Ders> dersler = new List<Ders>();
        if (db.dersler.Count() <= 0)
        {
            //veritabanında veri yok
            return dersler;
        }
        //mapping
        List<DersDto> dersDtos = db.dersler.ToList();
        foreach (DersDto dersDto in dersDtos)
        {
            Ders ders = new Ders(dersDto.DersAdi, dersDto.DersOgretimGorevlisiAdi);
            dersler.Add(ders);
        }
        return dersler;
    }

    public int dersSayisi()
    {
        return db.dersler.Count();
    }

    public void DevamsizlikEkle(Dersdevamsizlik dersDevamsizlik)
    {
        //fonksiyon test için böyle yazıldı lütfen düzelt
        //ders tablosuna çift kayıt olunca engellemek için çeşitli işlemler
        DersDto dersDto = db.dersler.FirstOrDefault(fdersDto => (fdersDto.DersAdi == dersDevamsizlik.ders.adi) && (fdersDto.DersOgretimGorevlisiAdi == dersDevamsizlik.ders.hocasi));
        if (dersDto == null)
        {
            // ders eklenmemiş
            return;
        }
        DersdevamsizlikDto dersdevamsizlikDto = new DersdevamsizlikDto()
        {
            Ders = dersDto,
            DevamsizlikSayisi = dersDevamsizlik.dersDevamsizlikSayisi + 1,
            devamsizlikTarihi = dersDevamsizlik.devamsizlikTarihi,
            DersId = dersDto.Id,
        };
        db.devamsizliklar.Add(dersdevamsizlikDto);
        db.SaveChanges();
    }

    public int devamsizlikSayisiGetir(string dersIsmi = "")
    {
        if (db.devamsizliklar.Where(dersdevamsizlikDto => dersdevamsizlikDto.Ders.DersAdi == dersIsmi) == null)
        {
            return 0;
        }
        List<DersdevamsizlikDto> dersdevamsizlikDtos = db.devamsizliklar.Where(dersdevamsizlikDto => dersdevamsizlikDto.Ders.DersAdi == dersIsmi).ToList();
        if (dersdevamsizlikDtos.Count <= 0)
        {
            return 0;
        }
        Console.WriteLine($"count {dersdevamsizlikDtos.Count}");
        return dersdevamsizlikDtos[dersdevamsizlikDtos.Count - 1].DevamsizlikSayisi;
    }

    public List<Dersdevamsizlik> tarihBazindaDevamsizlikGetir(DateTime tarih)
    {
        List<Dersdevamsizlik> dersdevamsizliklar = new List<Dersdevamsizlik>();
        if (db.devamsizliklar.Count() <= 0)
        {
            //veritabanında veri yok;
            return dersdevamsizliklar;
        }
        List<DersdevamsizlikDto> dersdevamsizlikDtos = db.devamsizliklar.Where(dersdevamsizlikDto => dersdevamsizlikDto.devamsizlikTarihi == tarih).ToList();
        //mapping
        foreach (DersdevamsizlikDto dersdevamsizlikDto in dersdevamsizlikDtos)
        {
            Ders ders1 = new Ders(dersdevamsizlikDto.Ders.DersAdi, dersdevamsizlikDto.Ders.DersOgretimGorevlisiAdi);
            Dersdevamsizlik dersdevamsizlik = new Dersdevamsizlik(ders1, dersdevamsizlikDto.DevamsizlikSayisi, dersdevamsizlikDto.devamsizlikTarihi);
            dersdevamsizliklar.Add(dersdevamsizlik);
        }
        return dersdevamsizliklar;
    }

    public string veriBarindirmaTuru()
    {
        return "In Db";
    }
}//end


//DataContextClass

//public class DersDtoContext : DbContext
//{
//    public DbSet<DersDto> Dersler { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder options)
//    {
//        options.UseNpgsql("Host = localhost; Database = RollCallCounter;Username = postgres;Password=12345");
//    }
//}



//DataContextClass
public class DersDtoContextAndDersdevamsizlikDtoContext : DbContext
{
    public DbSet<DersDto> dersler { get; set; }
    public DbSet<DersdevamsizlikDto> devamsizliklar { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DersdevamsizlikDto>()
            .HasOne(dersdevamsizlikDto => dersdevamsizlikDto.Ders)
            .WithMany(dersDto => dersDto.DersdevamsizlikDtos)
            .HasForeignKey(dersdevamsizlikDto => dersdevamsizlikDto.DersId);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql("Host = localhost; Database = RollCallCounter;Username = postgres;Password=12345");
    }
}


//DtoClass
public class DersDto
{
    public int Id { get; set; }
    public string DersAdi { get; set; }

    public string DersOgretimGorevlisiAdi { get; set; }

    public List<DersdevamsizlikDto> DersdevamsizlikDtos { get; set; }

}
//DtoClass

public class DersdevamsizlikDto
{
    public int Id { get; set; }
    public int DersId { get; set; }
    public DersDto Ders { get; set; }

    public int DevamsizlikSayisi { get; set; }

    public DateTime devamsizlikTarihi { get; set; }


}




