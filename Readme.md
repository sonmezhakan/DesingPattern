# Singleton Desing Pattern
- Programlama esnas�nda classlar�n instancen� al�p defalarca kullanmak zorunda kal�yoruz.Ya da ayn� anda birden fazla kullan�c� 
taraf�ndan ayn� nesneye talepte bulunuyorsa program ayn� nesneyi defalarca bellekte tutacak �ekilde olu�turur. Bu durumda 
uygulama performans a��c�s�nda belli�i olduk�a yorar ve sa�l�k bir �al��ma y�ntemi olmaz. Singleton Desing Pattern ise nesneye
olu�an talep do�rultusunda bir defa instance al�p bellekte tutar. Ayn� nesnelere tekrardan talep olmas� durumdan bellekte olu�turulmu�
instance kullan�c�ya sunulur. Bu sayede program performans a��s�ndan olduk�a verimli �al���r.

# Factory Method Desing Pattern
- Nesne olu�turma i�lemini bir alt s�n�fa devretmek i�in kullan�lan bir desendir. Bu desen, bir nesne olu�turma i�lemini alt s�n�flara 
b�rakarak, istemci kodunun hangi alt s�n�f�n �rne�ini olu�turaca��na karar vermesine olanak tan�r. Bu, kodun daha esnek, geni�letilebilir 
ve bak�m� daha kolay hale gelmesine yard�mc� olabilir.

# Abstract Factory Desing Pattern
- Bir nesne grubunun birlikte �al��abilir ve birbirlieriyle uyumlu olmas� gereken durumlarda kullan�lan desendir. Bu desen, 
bu nesnelerin yarat�lma s�recini soyut bir fabrika aray�z� �zerinden ger�ekle�tirir.