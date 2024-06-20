# RollCallCounter 
Üniversite öðrencilerinin devamsýzlýklarýný kolay bir þekilde takip etmelerini saðlayan projenin kaynak kodlarýný barýndýran repository
## Projenin Amacý
Projenin amacý üniversite ders devamsýzlýklarýnýn kolaylýkla tutulmasýný saðlamak
## Bu Committe Yapýlan Ýþlemler
- projenin veritabaný iþlemlerinin yeni mimariye uygun hale getirilmesi
## Proje Günlüðü
### Gün 1 (18.01.2024)
- Visual Studio Üzerinden Proje Oluþturuldu.
- Kodlarý bulut sistemler üzerinde tutmak için public þekilde github repository si oluþturuldu.
- README.md dosyasý ve gitignore dosyasý oluþturuldu
- basit bir konsol menüsü tasarlandý
- ders model class ý oluþturuldu
- iþlem class ý oluþturuldu(clean code amacýyla)(devamsýzlýk iþlemleri için)
### Gün 2 (19.01.2024)
- islemyap class ý kullanýlarak devamsýzlýk ekleme iþlemi için  ders seçimi sistemi yapýldý
- ders ekleme sistemi yapýldý
- ders model class bir adetti.ders devamsýzlýk ve Ders class ý olarak iki ayrý model class a dönüþtürüldü(iþlevsellik amacýyla deðiþtirildi)
### Gün 3 (20.01.2024)
- devamsýzýlýk ekleme tarih seçimi sistemi yapýldý
- devamsýzýlýk ekleme tarih seçimi sistemi tryparse metotudu kullanýlmasý
- program.cs deki kodlar(ders seçimi,tarih seçimi) ayrý ayrý  fonksiyonlara atandý
### Gün 4 (25.01.2024)
- Ders Ekleme sisteminde kullanýcýnýn geçersiz veri girmesi(baþýnda boþluk,sonunda boþluk,deðer girmeme) engellendi
### Gün 5 (28.01.2024)
- tarih seçiminde kullanýcýnýn geçersiz veri girme(baþýnda boþluk,arasýnda boþluk,sonunda boþluk,boþ veri) engelleme iþlemi
- Devamsýzlýk ekleme sisteminin bitirilmesi ve kodda ufak düzeltmeler
### Gün 6 (31.01.2024)
- Ders Bazýnda Devamsýzlýk Görüntüleme sisteminin yapýlmasý
### Gün 7 (2.02.2024)
- Tarih Bazýnda Devamsýzlýk Görüntüleme sisteminin yapýlmasý
### Gün 8 (3.03.2024)
- proje dotnet sürüm yükseltmesi(net 6.0 => net 8.0)(yapýldý)
- projenin veritabaný iþlemleri için uygun hale getirilmesi(IslemYap.cs dosyasýnýn interface sistemine çevirilmesi)(yapýldý)
- projenin veritabaný iþlemleri için uygun hale getirilmesi(Dto Modellerinin oluþturulmasý)(yapýldý)
- projenin veritabaný iþlemleri için gerekli kütüphanelerin yüklenmesi(ef core,ef core tools,postgresql)(yapýldý)
- genel kod düzeltmeleri(class prop düzeltmeleri(ders.cs,Dersdevamsizlik.cs))(yapýldý)
- genel kod düzeltmeleri(IslemYapInMemory(eski adýyla IslemYap.cs) classsýndaki dersBazindaDevamsizlikGetir ve tarihBazindaDevamsizlikGetir fonksiyonlarýnýn kýsaltýlmasý(linq where metodu))(yapýldý)
## Gün 9 (3.03.2024)
- projenin veritabaný iþlemlerinin yazýlmasý(IslemYapInDatabase classýnýn doldurulmasý)(yapýldý)(yapana kadar caným çýktý sebebi ise veritabanýný mimarisini yanlýþ kurgulamýþým onu düzelttim)

## Gün 10 (20.06.2024)
- proje mimarisinin deðiþtirlmesi
- IslemYapInMemory dosyasýndaki iþ kurallarýnýn ayrýþtýrýlmasý
- IIslemYapManager dosyasýnýn kodlanmasý
- projenin veritabaný iþlemlerinin yeni mimariye uygun hale getirilmesi
## yapýlacaklar
dersdevamsizliklarigetir fonksiyonu hata veriyor onu düzelt (IslemYapInDatabase)

projedeki veritabanlý sistemde tarih seçimi hatasýnýn düzeltilmesi
ders seçiminde varolan ders eklenirse engelleme(yapýldý)


genel kod düzeltmeleri




## kendi notlarým

# projeden kendime çýkarýmlarým
- while true döngüsünde bir fonksiyon çalýþtýrýyorsak ve while true döngüsünün baþýna dönmek istiyorsak(ör:istemediðimiz bir durum oldu döngünün baþýna gitmemiz lazým) fonksiyonda nerede çýkmak istiyorsak return null yazýyoruz(not:fonksiyonun null deðer döndürmeye uygun olmasý lazým ("donustipi?"))
  <br> while true döngüsünde null check yapýyoruz.null if inde continue deyimini yazarak döngüyü baþa döndürüyoruz
- ef core da iki tablo iliþkili(þuanlýk bildiðim kadarýyla one to one ) ise (bizim örneðimizde DersdevamsizlikDto,DersDto one to one iliþkili) ana iliþkili migrate etmek yeterli.iki tabloyu migrate etmeye gerek yok.