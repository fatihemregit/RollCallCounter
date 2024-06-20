# RollCallCounter 
�niversite ��rencilerinin devams�zl�klar�n� kolay bir �ekilde takip etmelerini sa�layan projenin kaynak kodlar�n� bar�nd�ran repository
## Projenin Amac�
Projenin amac� �niversite ders devams�zl�klar�n�n kolayl�kla tutulmas�n� sa�lamak
## Bu Committe Yap�lan ��lemler
- projenin veritaban� i�lemlerinin yeni mimariye uygun hale getirilmesi
## Proje G�nl���
### G�n 1 (18.01.2024)
- Visual Studio �zerinden Proje Olu�turuldu.
- Kodlar� bulut sistemler �zerinde tutmak i�in public �ekilde github repository si olu�turuldu.
- README.md dosyas� ve gitignore dosyas� olu�turuldu
- basit bir konsol men�s� tasarland�
- ders model class � olu�turuldu
- i�lem class � olu�turuldu(clean code amac�yla)(devams�zl�k i�lemleri i�in)
### G�n 2 (19.01.2024)
- islemyap class � kullan�larak devams�zl�k ekleme i�lemi i�in  ders se�imi sistemi yap�ld�
- ders ekleme sistemi yap�ld�
- ders model class bir adetti.ders devams�zl�k ve Ders class � olarak iki ayr� model class a d�n��t�r�ld�(i�levsellik amac�yla de�i�tirildi)
### G�n 3 (20.01.2024)
- devams�z�l�k ekleme tarih se�imi sistemi yap�ld�
- devams�z�l�k ekleme tarih se�imi sistemi tryparse metotudu kullan�lmas�
- program.cs deki kodlar(ders se�imi,tarih se�imi) ayr� ayr�  fonksiyonlara atand�
### G�n 4 (25.01.2024)
- Ders Ekleme sisteminde kullan�c�n�n ge�ersiz veri girmesi(ba��nda bo�luk,sonunda bo�luk,de�er girmeme) engellendi
### G�n 5 (28.01.2024)
- tarih se�iminde kullan�c�n�n ge�ersiz veri girme(ba��nda bo�luk,aras�nda bo�luk,sonunda bo�luk,bo� veri) engelleme i�lemi
- Devams�zl�k ekleme sisteminin bitirilmesi ve kodda ufak d�zeltmeler
### G�n 6 (31.01.2024)
- Ders Baz�nda Devams�zl�k G�r�nt�leme sisteminin yap�lmas�
### G�n 7 (2.02.2024)
- Tarih Baz�nda Devams�zl�k G�r�nt�leme sisteminin yap�lmas�
### G�n 8 (3.03.2024)
- proje dotnet s�r�m y�kseltmesi(net 6.0 => net 8.0)(yap�ld�)
- projenin veritaban� i�lemleri i�in uygun hale getirilmesi(IslemYap.cs dosyas�n�n interface sistemine �evirilmesi)(yap�ld�)
- projenin veritaban� i�lemleri i�in uygun hale getirilmesi(Dto Modellerinin olu�turulmas�)(yap�ld�)
- projenin veritaban� i�lemleri i�in gerekli k�t�phanelerin y�klenmesi(ef core,ef core tools,postgresql)(yap�ld�)
- genel kod d�zeltmeleri(class prop d�zeltmeleri(ders.cs,Dersdevamsizlik.cs))(yap�ld�)
- genel kod d�zeltmeleri(IslemYapInMemory(eski ad�yla IslemYap.cs) classs�ndaki dersBazindaDevamsizlikGetir ve tarihBazindaDevamsizlikGetir fonksiyonlar�n�n k�salt�lmas�(linq where metodu))(yap�ld�)
## G�n 9 (3.03.2024)
- projenin veritaban� i�lemlerinin yaz�lmas�(IslemYapInDatabase class�n�n doldurulmas�)(yap�ld�)(yapana kadar can�m ��kt� sebebi ise veritaban�n� mimarisini yanl�� kurgulam���m onu d�zelttim)

## G�n 10 (20.06.2024)
- proje mimarisinin de�i�tirlmesi
- IslemYapInMemory dosyas�ndaki i� kurallar�n�n ayr��t�r�lmas�
- IIslemYapManager dosyas�n�n kodlanmas�
- projenin veritaban� i�lemlerinin yeni mimariye uygun hale getirilmesi
## yap�lacaklar
dersdevamsizliklarigetir fonksiyonu hata veriyor onu d�zelt (IslemYapInDatabase)

projedeki veritabanl� sistemde tarih se�imi hatas�n�n d�zeltilmesi
ders se�iminde varolan ders eklenirse engelleme(yap�ld�)


genel kod d�zeltmeleri




## kendi notlar�m

# projeden kendime ��kar�mlar�m
- while true d�ng�s�nde bir fonksiyon �al��t�r�yorsak ve while true d�ng�s�n�n ba��na d�nmek istiyorsak(�r:istemedi�imiz bir durum oldu d�ng�n�n ba��na gitmemiz laz�m) fonksiyonda nerede ��kmak istiyorsak return null yaz�yoruz(not:fonksiyonun null de�er d�nd�rmeye uygun olmas� laz�m ("donustipi?"))
  <br> while true d�ng�s�nde null check yap�yoruz.null if inde continue deyimini yazarak d�ng�y� ba�a d�nd�r�yoruz
- ef core da iki tablo ili�kili(�uanl�k bildi�im kadar�yla one to one ) ise (bizim �rne�imizde DersdevamsizlikDto,DersDto one to one ili�kili) ana ili�kili migrate etmek yeterli.iki tabloyu migrate etmeye gerek yok.