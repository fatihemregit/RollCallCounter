# RollCallCounter 
Üniversite öðrencilerinin devamsýzlýklarýný kolay bir þekilde takip etmelerini saðlayan projenin kaynak kodlarýný barýndýran repository
## Projenin Amacý
Projenin amacý üniversite ders devamsýzlýklarýnýn kolaylýkla tutulmasýný saðlamak
## Bu Committe Yapýlan Ýþlemler
- Tarih Bazýnda Devamsýzlýk Görüntüleme sisteminin yapýlmasý
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

## yapýlacaklar

## kendi notlarým

# projeden kendime çýkarýmlarým
- while true döngüsünde bir fonksiyon çalýþtýrýyorsak ve while true döngüsünün baþýna dönmek istiyorsak(ör:istemediðimiz bir durum oldu döngünün baþýna gitmemiz lazým) fonksiyonda nerede çýkmak istiyorsak return null yazýyoruz(not:fonksiyonun null deðer döndürmeye uygun olmasý lazým ("donustipi?"))
  <br> while true döngüsünde null check yapýyoruz.null if inde continue deyimini yazarak döngüyü baþa döndürüyoruz
