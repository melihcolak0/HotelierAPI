# 💎API ile Otel Yönetim ve Rezervasyon Sistemi
Bu repository, Murat Yücedağ'ın Udemy'de bulunan Asp.Net Core Api - Rapid Api ve Api Consume kursunu içermektedir. Bu eğitimde bana yol gösteren Murat Yücedağ'a çok teşekkür ederim.

ASP.NET Core Web Application (.NET Core 5.0 (MVC)) ve ASP.NET Core Web API kullanarak otel vitrini ve yönetici panelinden oluşan tam kapsamlı bir Otel Yönetim ve Rezervasyon sitesi oluşturdum. Bu projede yazılım geliştirme standartlarına uygun olarak N-Tier Architecture (N Katmanlı Mimari) kullanılmış ve Repository Design Pattern ile veri erişimi soyutlanmıştır. Entity, DataAccess, Business, DTO ve UI katmanları net bir şekilde ayrılmıştır. Katmanlar arası veri aktarımında DTO (Data Transfer Object) yapıları ve AutoMapper kütüphanesi etkin biçimde kullanılmıştır. SOLID prensiplerine ve dosya organizasyonuna uygun şekilde geliştirme yaparak kod tekrarını en aza indirmeye çalıştım. Entity Framework Core - Code First yaklaşımını kullanarak veritabanı bağlantılarını oluşturdum. N Katmanlı Mimari, yazılım uygulamalarını birden fazla bağımsız katmana (layer) bölerek geliştirmeye olanak tanıyan bir yazılım mimari modelidir. Bu mimari, uygulamanın farklı katmanlarını belirleyerek modülerlik, ölçeklenebilirlik ve bakım kolaylığı sağlar.

Temel anlamda 6 katman üzerinde projeyi oluşturdum. 
- Entity Layer (Varlık Katmanı), verileri saklayan katmandır. Burası Code-First yaklaşımının başlangıcıdır. Veri tabanındaki tablolar ve sütunlar yerine bu katmanda sınıflar ve property'ler kullandım. Veritabanı modellemesinde ilişkili tablolar kullanılmış, güçlü bir veri yapısı oluşturulmuştur. 
- Data Access Layer (Veri Erişim Katmanı), veri tabanı ile etkileşimi sağlar. Burada veri tabanındaki verileri gereken şekilde kullandım. 
- Business Logic Layer (İş Mantığı Katmanı), uygulamanın kurallarını ve iş mantığını barındırır. Service ve Manager olarak tüm entity'lerin metotlarını oluşturup kontrollerini yaptım. 
- Veri transferi için DTO (Data Transfer Object) katmanı kullanılmış ve AutoMapper ile katmanlar arası dönüşümler kolaylaştırılmıştır. 
- Bir diğer katman da ASP.NET Web API ile servisler oluşturduğum API katmanıdır. API tarafında RESTful Web API geliştirilmiş, Swagger ile dokümantasyonu sağlanmış ve Postman ile testler gerçekleştirilmiştir. API'den alınan veriler API Consume teknikleriyle kullanıcı arayüzüne entegre edilmiştir.
- Presentation Layer (Sunum Katmanı), kullanıcının doğrudan etkileşimde bulunduğu katmandır. Burada HTML5, CSS3, Bootstrap ve JavaScript kullanarak web sayfaları oluşturdum. 

Kullanıcı kimlik doğrulama ve yetkilendirme işlemleri için ASP.NET Identity altyapısı kullanılmış ayrıca JSON Web Token (JWT) ile token bazlı güvenli giriş sistemi oluşturulmuştur. ASP.NET Core Identity, kimlik doğrulama (authentication) ve yetkilendirme (authorization) işlemlerini yönetmek için kullanılan bir sistemdir. Kullanıcı giriş-çıkış işlemlerini, rollerle yetkilendirmeyi ve güvenli parola yönetimini kolaylaştırır. Bu şekilde güvenli bir kullanıcı yönetimi sağlanmıştır. Kullanıcı deneyimini artırmak adına AJAX teknolojisiyle sayfa yenilenmeden işlemler gerçekleştirilmiş, FluentValidation ile form doğrulamaları katmanlı bir şekilde yapılmış ve güçlü, okunabilir validasyon kuralları tanımlanmıştır.

Kullanıcı arayüzü tarafında modüler yapıyı desteklemek için ViewComponent ve PartialView yapıları tercih edilmiştir. Çoğu sayfada Razor Pages yapısına da yer verilmiştir. Harici veri servisleriyle etkileşimde RapidAPI üzerinden alınan veriler projeye entegre edilmiştir. Uygulama ayrıca SMTP protokolü üzerinden e-posta gönderimi yapabilmektedir.

 Tüm bu bileşenlerle proje, hem öğrenim sürecine hem de gerçek dünyadaki kurumsal uygulama ihtiyaçlarına yanıt verebilecek nitelikte yapılandırılmıştır.

Bu proje, hem back-end hem de front-end tarafında kapsamlı teknolojileri içeren, gerçek dünya ihtiyaçlarına uygun olarak geliştirilen ve yazılım mimarisi açısından güçlü temellere sahip bir uygulamadır.

Bu projede değiştirilmesi gereken bazı noktalar olabilir fakat burada asıl amaç Back-end Development anlamında .Net Core ile admin ve vitrin panelli bir sistem kurmaktır. Front-end anlamında düzeltmeler yapılabilir. Ayrıca bu bir eğitim olduğu için tam anlamıyla bir bütünlük kurulmamıştır. Fakat bu eğitimdeki asıl amaç tüm konulardan yola çıkarak tamamen farklı temada bir proje oluşturabilmektir.<br/>

### :triangular_flag_on_post:Projede Kullandığım Teknolojiler
⚙️ ASP.NET Core 5.0 (MVC) – Modern web uygulamaları için güçlü backend çatısı<br/>
🌐 ASP.NET Web API ile RESTful API – Dış sistemlerle etkili veri alışverişi<br/>
🏗️ Katmanlı Mimari – Temiz ve sürdürülebilir kod yapısı<br/>
🗃️ Entity Framework Core (EF Core) – ORM aracıyla veritabanı işlemlerini kolaylaştırma<br/>
📦 Repository Design Pattern – Veri erişim süreçlerinde soyutlama ve yeniden kullanılabilirlik<br/>
🧱 Entity, DataAccess, Business, DTO ve UI Layer – Modüler yapı ile sağlam uygulama iskeleti<br/>
🔄 DTO & AutoMapper – Nesne dönüşümlerinde kolaylık ve performans<br/>
🧪 Swagger & Postman – API testleri ve dökümantasyonu<br/>
📲 API Consume – API'den veri çekme ve kullanma işlemleri<br/>
🌍 RapidAPI – Harici servislerle kolay entegrasyon<br/>
🔁 jQuery – Dinamik kullanıcı etkileşimleri ve DOM işlemleri<br/>
💠 AJAX – Sayfa yenilemeden sunucu ile veri alışverişi<br/>
🛡️ Identity – Kullanıcı kimlik doğrulama ve yetkilendirme sistemi<br/>
🔐 JSON Web Token (JWT) – Güvenli token tabanlı kimlik doğrulama<br/>
✅ Fluent Validation – Model doğrulama işlemlerinde temiz ve okunabilir yapı<br/>
📧 SMTP ile Mail Gönderme – Sistemden otomatik e-posta bildirimleri<br/>
🧩 ViewComponent & PartialView, Razor Pages – Dinamik ve tekrar kullanılabilir arayüz bileşenleri<br/>
🔗 İlişkili Tablolar ile Veri Yönetimi – Veritabanında güçlü ilişki yapıları<br/>
<br/>
Projede genel anlamda 2 farklı bölüm bulunmaktadır;<br/>
1- Vitrin Paneli: Hotelier otelinin hakkında, rezervasyon ve iletişim bölümlerinin yer aldığı paneldir.<br/>
2- Admin Paneli: Adminler'in giriş yapıp odalar, misafirler, rezervasyonlar, personeller ve iletişim gibi alanlar ile ilgili CRUD (Create, Read, Update, Delete) işlemlerinin yaptığı paneldir.  <br/>

## :arrow_forward: Projeden Ekran Görüntüleri

### :triangular_flag_on_post: Vitrin Paneli
<div align="center">
  <img src="https://github.com/melihcolak0/SignalR_MCRestaurant/blob/a9ff7b1ccd5619ef8219d91a7fd1c8c7f0b4e079/ss/localhost_7076_Default_Index.png" alt="image alt">
</div>
<div align="center">
  <img src="https://github.com/melihcolak0/SignalR_MCRestaurant/blob/a9ff7b1ccd5619ef8219d91a7fd1c8c7f0b4e079/ss/localhost_7076_UIMenu_Index.png" alt="image alt">
</div>


