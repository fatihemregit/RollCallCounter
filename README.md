# RollCallCounter 
�niversite ��rencilerinin devams�zl�klar�n� kolay bir �ekilde takip etmelerini sa�layan projenin kaynak kodlar�n� bar�nd�ran repository
## Projenin Amac�
Projenin amac� �niversite ders devams�zl�klar�n�n kolayl�kla tutulmas�n� sa�lamak
## Bu Committe Yap�lan ��lemler
- Tarih Baz�nda Devams�zl�k G�r�nt�leme sisteminin yap�lmas�
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

## yap�lacaklar

## kendi notlar�m

# projeden kendime ��kar�mlar�m
- while true d�ng�s�nde bir fonksiyon �al��t�r�yorsak ve while true d�ng�s�n�n ba��na d�nmek istiyorsak(�r:istemedi�imiz bir durum oldu d�ng�n�n ba��na gitmemiz laz�m) fonksiyonda nerede ��kmak istiyorsak return null yaz�yoruz(not:fonksiyonun null de�er d�nd�rmeye uygun olmas� laz�m ("donustipi?"))
  <br> while true d�ng�s�nde null check yap�yoruz.null if inde continue deyimini yazarak d�ng�y� ba�a d�nd�r�yoruz
