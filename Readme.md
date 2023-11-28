# Singleton Desing Pattern
- Programlama esnasýnda classlarýn instancený alýp defalarca kullanmak zorunda kalýyoruz.Ya da ayný anda birden fazla kullanýcý 
tarafýndan ayný nesneye talepte bulunuyorsa program ayný nesneyi defalarca bellekte tutacak þekilde oluþturur. Bu durumda 
uygulama performans açýcýsýnda belliði oldukça yorar ve saðlýk bir çalýþma yöntemi olmaz. Singleton Desing Pattern ise nesneye
oluþan talep doðrultusunda bir defa instance alýp bellekte tutar. Ayný nesnelere tekrardan talep olmasý durumdan bellekte oluþturulmuþ
instance kullanýcýya sunulur. Bu sayede program performans açýsýndan oldukça verimli çalýþýr.

# Factory Method Desing Pattern
- Nesne oluþturma iþlemini bir alt sýnýfa devretmek için kullanýlan bir desendir. Bu desen, bir nesne oluþturma iþlemini alt sýnýflara 
býrakarak, istemci kodunun hangi alt sýnýfýn örneðini oluþturacaðýna karar vermesine olanak tanýr. Bu, kodun daha esnek, geniþletilebilir 
ve bakýmý daha kolay hale gelmesine yardýmcý olabilir.

# Abstract Factory Desing Pattern
- Bir nesne grubunun birlikte çalýþabilir ve birbirlieriyle uyumlu olmasý gereken durumlarda kullanýlan desendir. Bu desen, 
bu nesnelerin yaratýlma sürecini soyut bir fabrika arayüzü üzerinden gerçekleþtirir.