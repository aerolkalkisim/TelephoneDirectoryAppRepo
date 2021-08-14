# TelephoneDirectoryAppRepo

Projenin tüm özellikleriyle ayağa kaldırılması için

1)Presentation layerda bulunan proje içersindeki appsettings.json dosyasında connection string düzenlenmelidir.
2)TelephoneDirectoryApp.MQ.Consumer projesi içersindeki program cs içindeki connection string değiştirilmelidir.

Databasein oluşturulması için Pakage Manager Console açılır. DataContect class libi seçilir ve aşağıdaki komut satırı çalıştırılır;

 -> update-database

Ardından bağlantıda herhangi bir problem yok ise veritabanı ilgili lokasyonda oluşacaktır.

Docker ile rabbitmq engini ayağa kaldırdım. Default host name 127.0.0.1 olarak setlendi. Değiştiilmek isteniyorsa her iki uygulamadada bu adres değiştirlimeli.
Biri consumer projesi içersinde program.cs e direk gömülü.
Diğeri webmanagment katmanı altındaki reportmanager clasının içersinde bulunuyor. 

App içersindeki iki app ayrı ayrı çalıştırılmalıdır. Biri Presentation katmanı. Diğeri Consumer console projesi.

Ardından programı kullanmaya başlayabilirsiniz.
 
