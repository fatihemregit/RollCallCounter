# RollCallCounter 
Üniversite öğrencilerinin devamsızlıklarını kolay bir şekilde takip etmelerini sağlayan projenin kaynak kodlarını barındıran repository
## Projenin Amacı
Projenin amacı üniversite ders devamsızlıklarının kolaylıkla tutulmasını sağlamak
## Bu Committe Yapılan İşlemler
- genel kod düzeltmeleri

## Proje Günlüğü
### Gün 1 (18.01.2024)
- Visual Studio Üzerinden Proje Oluşturuldu.
- Kodları bulut sistemler üzerinde tutmak için public şekilde github repository si oluşturuldu.
- README.md dosyası ve gitignore dosyası oluşturuldu
- basit bir konsol menüsü tasarlandı
- ders model class ı oluşturuldu
- işlem class ı oluşturuldu(clean code amacıyla)(devamsızlık işlemleri için)
### Gün 2 (19.01.2024)
- islemyap class ı kullanılarak devamsızlık ekleme işlemi için  ders seçimi sistemi yapıldı
- ders ekleme sistemi yapıldı
- ders model class bir adetti.ders devamsızlık ve Ders class ı olarak iki ayrı model class a dönüştürüldü(işlevsellik amacıyla değiştirildi)
### Gün 3 (20.01.2024)
- devamsızılık ekleme tarih seçimi sistemi yapıldı
- devamsızılık ekleme tarih seçimi sistemi tryparse metotudu kullanılması
- program.cs deki kodlar(ders seçimi,tarih seçimi) ayrı ayrı  fonksiyonlara atandı
### Gün 4 (25.01.2024)
- Ders Ekleme sisteminde kullanıcının geçersiz veri girmesi(başında boşluk,sonunda boşluk,değer girmeme) engellendi
### Gün 5 (28.01.2024)
- tarih seçiminde kullanıcının geçersiz veri girme(başında boşluk,arasında boşluk,sonunda boşluk,boş veri) engelleme işlemi
- Devamsızlık ekleme sisteminin bitirilmesi ve kodda ufak düzeltmeler
### Gün 6 (31.01.2024)
- Ders Bazında Devamsızlık Görüntüleme sisteminin yapılması
### Gün 7 (2.02.2024)
- Tarih Bazında Devamsızlık Görüntüleme sisteminin yapılması
### Gün 8 (3.03.2024)
- proje dotnet sürüm yükseltmesi(net 6.0 => net 8.0)(yapıldı)
- projenin veritabanı işlemleri için uygun hale getirilmesi(IslemYap.cs dosyasının interface sistemine çevirilmesi)(yapıldı)
- projenin veritabanı işlemleri için uygun hale getirilmesi(Dto Modellerinin oluşturulması)(yapıldı)
- projenin veritabanı işlemleri için gerekli kütüphanelerin yüklenmesi(ef core,ef core tools,postgresql)(yapıldı)
- genel kod düzeltmeleri(class prop düzeltmeleri(ders.cs,Dersdevamsizlik.cs))(yapıldı)
- genel kod düzeltmeleri(IslemYapInMemory(eski adıyla IslemYap.cs) classsındaki dersBazindaDevamsizlikGetir ve tarihBazindaDevamsizlikGetir fonksiyonlarının kısaltılması(linq where metodu))(yapıldı)
## Gün 9 (3.03.2024)
- projenin veritabanı işlemlerinin yazılması(IslemYapInDatabase classının doldurulması)(yapıldı)(yapana kadar canım çıktı sebebi ise veritabanını mimarisini yanlış kurgulamışım onu düzelttim)

## Gün 10 (20.06.2024)
- proje mimarisinin değiştirlmesi
- IslemYapInMemory dosyasındaki iş kurallarının ayrıştırılması
- IIslemYapManager dosyasının kodlanması
- projenin veritabanı işlemlerinin yeni mimariye uygun hale getirilmesi
## yapılacaklar
dersdevamsizliklarigetir fonksiyonu hata veriyor onu düzelt (IslemYapInDatabase)(kod yeniden yazıldığı için otomatik olarak düzeltildi)

projedeki veritabanlı sistemde tarih seçimi hatasının düzeltilmesi(kod yeniden yazıldığı için otomatik olarak düzeltildi)
ders seçiminde varolan ders eklenirse engelleme(yapıldı)


ders daha önceden devamsızlık olarak eklenmiş mi onun kontrol edilmesi




## kendi notlarım

# projeden kendime çıkarımlarım
- while true döngüsünde bir fonksiyon çalıştırıyorsak ve while true döngüsünün başına dönmek istiyorsak(ör:istemediğimiz bir durum oldu döngünün başına gitmemiz lazım) fonksiyonda nerede çıkmak istiyorsak return null yazıyoruz(not:fonksiyonun null değer döndürmeye uygun olması lazım ("donustipi?"))
  <br> while true döngüsünde null check yapıyoruz.null if inde continue deyimini yazarak döngüyü başa döndürüyoruz
- ef core da iki tablo ilişkili(şuanlık bildiğim kadarıyla one to one ) ise (bizim örneğimizde DersdevamsizlikDto,DersDto one to one ilişkili) ana ilişkili migrate etmek yeterli.iki tabloyu migrate etmeye gerek yok.