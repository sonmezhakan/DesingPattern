# Singleton Desing Pattern
- Programlama esnasında classların instancenı defalarca almak zorunda kalıyoruz. Ya da aynı anda birden fazla kullanıcı 
tarafından aynı nesneye talepte bulunuyorsa program aynı nesneyi defalarca bellekte tutacak şekilde oluşturur. Bu durumda 
uygulama performans açısından belliği oldukça yorar ve sağlık bir çalışma yöntemi olmaz. Singleton Desing Pattern ise nesneye
oluşan talep doğrultusunda bir defa instance alıp bellekte tutar. Aynı nesnelere tekrardan talep olması durumdan bellekte oluşturulmuş
instance kullanıcıya sunulur. Bu sayede program performans açısından oldukça verimli çalışır.

# Factory Method Desing Pattern
- Nesne oluşturma işlemini bir alt sınıfa devretmek için kullanılan bir desendir. Bu desen, bir nesne oluşturma işlemini alt sınıflara 
bırakarak, istemci kodunun hangi alt sınıfın örneğini oluşturacağına karar vermesine olanak tanır. Bu, kodun daha esnek, genişletilebilir 
ve bakımı daha kolay hale gelmesine yardımcı olabilir.

# Abstract Factory Desing Pattern
- Bir nesne grubunun birlikte çalışabilir ve birbirlieriyle uyumlu olması gereken durumlarda kullanılan desendir. Bu desen, 
bu nesnelerin yaratılma sürecini soyut bir fabrika arayüzü üzerinden gerçekleştirir.
