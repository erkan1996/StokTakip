# StokTakip
proje içerisindeki StokTakipDB.bak dosyasını c dizinine alınız daha sonra sql management studio yu acıp Object Explorer panelindeki Databse kısmına sağ tık yapıp Restore Database seçeneğini seçiniz bu işlemi yaptıktan sonra açılan pencerede source kısmandan device seçeneğini seçip c dizinine atmış olduğunuz StokTakipDB.bak dosyasını seçerek slq serverınıza veri tabanını ekleyeniz

Ekleme işlemini tamamladıktan sonra proje içerisindeki Web.config dosyasının içinde bulunan aşağıdaki kod bloğunu kendi server adınıza göre düzenleyip proje çalıştırabilirsiniz.
  <connectionStrings>
    <add name="StokTakipDB" connectionString="Server=bu alana kendi server adınızı yazınız;Database=StokTakipDB;Integrated Security=True" providerName="System.Data.SqlClient"/>
  </connectionStrings>