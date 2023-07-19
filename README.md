## TraversalProject

Traversal Rezervasyon Asp.Net Core 6.0 Proje

Proje Hakkında
Bu proje, tatil rezervasyonu alanında faaliyet gösteren bir web sitesini temsil etmektedir. Sitede, çeşitli tatil seçeneklerinin listelendiği, kullanıcıların kişisel hesabına ve siteye ait bilgilere erişebildiği ve admin kullanıcısının da site içerisinde CRUD işlemleri gerçekleştirebildiği üç farklı tasarıma sahip bir projedir.

## Teknolojiler ve Katmanlar
-ASP.NET Core 5.0
-Entity Framework Core
-SQL Server
-N Tier Architecture
-PresentationLayer
-BusinessLayer
-DataAccessLayer
-DTOLayer
-EntityLayer
-SignalRApiForSQL
-SignalRConsume


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
