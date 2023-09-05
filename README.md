## TraversalProject

Traversal Rezervasyon Asp.Net Core 6.0 Proje

Proje Hakkında
Bu proje, tatil rezervasyonu alanında faaliyet gösteren bir web sitesini temsil etmektedir. Sitede, çeşitli tatil seçeneklerinin listelendiği, kullanıcıların kişisel hesabına ve siteye ait bilgilere erişebildiği ve admin kullanıcısının da site içerisinde CRUD işlemleri gerçekleştirebildiği üç farklı tasarıma sahip bir projedir.

## Teknolojiler ve Araçlar

- ASP.NET Core 6.0
- Entity Framework Core
- MVC 
- SQL Server
- Mapper

## Kurulum ve Çalıştırma

1. Depoyu bilgisayarınıza klonlayın.
2. SQL Server üzerinde bir veritabanı oluşturun.
3. appsettings.json dosyasında veritabanı bağlantı dizesini güncelleyin.
4. `dotnet ef database update` komutunu çalıştırarak veritabanı tablolarını oluşturun.
5. Projeyi çalıştırın ve web uygulamasını tarayıcınızda görüntüleyin.


## Proje Geliştirme Aşamaları
Katmanlar oluşturuldu ve projenin genel yapısı belirlendi.

Proje geliştirme aşamaları için katmanlar oluşturuldu.
N Tier Architecture mimarisi benimsendi.
Veritabanı işlemleri için Context sınıfı tanımlandı ve migration işlemi gerçekleştirildi.

Veritabanı işlemleri için gerekli olan Context sınıfı oluşturuldu.
Entity Framework Core Code First yaklaşımı kullanılarak migration işlemi gerçekleştirildi.
DataAccessLayer ve BusinessLayer Generic Interface'leri kullanılarak veri erişimi yapıldı.

Veri tabanına erişim için DataAccessLayer'da Generic Repository Interface'i kullanıldı.
BusinessLayer, DataAccessLayer'a bağımlı oldu ve veri erişimi sağlandı.
Repository Design Pattern yaklaşımı kullanılarak veritabanı işlemleri gerçekleştirildi.

Veritabanı işlemlerini yönetmek için Repository Design Pattern yaklaşımı kullanıldı.
Her entity için ayrı Repository sınıfları oluşturuldu.
Fluent Validation kütüphanesi kullanılarak giriş yapılan verilerin doğruluğu kontrol edildi.

Giriş yapılan verilerin doğruluğunu kontrol etmek için Fluent Validation kütüphanesi kullanıldı.
Entity sınıfları için gerekli doğrulama kuralları tanımlandı.
Partial Async ve View Component yapıları kullanılarak performans artırımı sağlandı.

Performansı artırmak için asenkron operasyonlar kullanıldı.
Partial Async ve View Component yapıları sayfaların daha hızlı yüklenmesini sağladı.
MSSQL veritabanı kullanılarak CRUD işlemleri yapıldı.

Verileri saklamak için MSSQL veritabanı kullanıldı.
CRUD (Create, Read, Update, Delete) işlemleri gerçekleştirildi.
Yorumları ait olduğu rotaya göre listeleme ve yaptırma işlemleri gerçekleştirildi.

Rotalara ait yorumların listelenmesi ve yaptırılması işlemleri yapıldı.
İlgili rotaya yorum eklemek ve silmek mümkün hale getirildi.
Identity kullanılarak kullanıcı girişi yapıldı ve kullanıcının profil bilgileri getirildi.

Kullanıcı girişi ve kimlik doğrulama işlemleri için Identity sistemi kullanıldı.
Kullanıcının profil bilgilerini görüntülemesi sağlandı.
Login ve Register sayfaları oluşturuldu.

Kullanıcıların giriş yapabileceği Login ve yeni hesap oluşturabileceği Register sayfaları oluşturuldu.
Kullanıcı kimlik doğrulama işlemleri gerçekleştirildi.

![8](https://github.com/EnesFevzi/TraversalCoreProject/assets/118919666/bfabafdd-4039-4039-b351-239336ef67f0)
![7](https://github.com/EnesFevzi/TraversalCoreProject/assets/118919666/7d951a43-dbb9-46bc-add6-a44e5cb581b7)
![6](https://github.com/EnesFevzi/TraversalCoreProject/assets/118919666/8dee0369-3a06-4bbf-8a89-cdfb0d059ec3)
![5](https://github.com/EnesFevzi/TraversalCoreProject/assets/118919666/ef101fa7-c3b0-4796-a0ac-bfc5a979f528)
![4](https://github.com/EnesFevzi/TraversalCoreProject/assets/118919666/b2f650dc-a034-47e8-8adf-29df5f5cd71f)
![1](https://github.com/EnesFevzi/TraversalCoreProject/assets/118919666/2d94c98a-e1d4-4a58-a183-ecf10a397563)
![2](https://github.com/EnesFevzi/TraversalCoreProject/assets/118919666/a64af02c-d862-488f-92c3-cb061bc03e8e)
![3](https://github.com/EnesFevzi/TraversalCoreProject/assets/118919666/b3a9abde-400e-4bc0-acb8-1636e8b8f4fd)


