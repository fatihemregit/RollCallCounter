using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoklamaTutucu.models;

namespace YoklamaTutucu;




//database işlemleri için IIslemYap tan inherit edilmiş class
public class IslemYapInDatabase : IIslemYap
{
    public List<Dersdevamsizlik> dersBazindaDevamsizlikGetir(Ders ders)
    {
        throw new NotImplementedException();
    }

    public List<Dersdevamsizlik> dersdevamsizliklarigetir()
    {
        throw new NotImplementedException();
    }

    public void dersEkle(Ders ders)
    {
        throw new NotImplementedException();
    }

    public List<Ders> dersleriGetir()
    {
        throw new NotImplementedException();
    }

    public int dersSayisi()
    {
        throw new NotImplementedException();
    }

    public void DevamsizlikEkle(Dersdevamsizlik dersDevamsizlik)
    {
        throw new NotImplementedException();
    }

    public int devamsizlikSayisiGetir(string dersIsmi = "", int dersId = 0)
    {
        throw new NotImplementedException();
    }

    public List<Dersdevamsizlik> tarihBazindaDevamsizlikGetir(DateTime tarih)
    {
        throw new NotImplementedException();
    }
}


//DataContextClass es

public class DersDtoContext:DbContext
{
    public DbSet<DersDto> Dersler { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql("Host = localhost; Database = RollCallCounter;Username = postgres;Password=12345");
    }
}


public class DersdevamsizlikDtoContext : DbContext
{
    public DbSet<DersdevamsizlikDto> dersdevamsizliklar { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql("Host = localhost; Database = RollCallCounter;Username = postgres;Password=12345");
    }
}


//DTO objects
public class DersDto
{
    public int Id { get; set; }
    public string dersAdi { get; set; }

    public string DersOgretimGorevlisiAdi { get; set; }

}

public class DersdevamsizlikDto
{
    public int Id { get; set; }
    public DersDto Ders { get; set; }
    public int dersDevamsizlikSayisi { get; set; }
    public DateTime devamsizlikTarihi { get; set; }
}


