# casgem-portfolio
#### ÇASGEM Full Stack .NET Framework MVC 5 Eğitim Kampı 1. Gün Oluşturulan Proje ve Verilen Ödev
#### Projenin Amacı:
Kişisel tanıtım, özgeçmiş ve CV projesidir. Amaç ise işe alımı kolaylaştırmak ve işverenlere kendimizi iyi bir şekilde tanıtmak.
#### Proje hangi teknolojiler ile kodlandı: ASP.NET MVC 5, Entity Framework, MSSQL Server, HTML5, CSS, JS ve Bootstrap.
Aslında proje CRUD(Create, Read, Update, Delete) yapmaktan öteye gitmiyor. Okuma ve yazma yapıyor, hepsi o kadar.
Projemiz ÇASGEM(Çalışma Sosyal Güvenlik Araştırma ve Eğitim Merkezi)'de Murat Yücedağ hocamız tarafından verildi. Kendisi başarılı, ünlü, genç, dinamik ve saygılı bir hocamız. Bizi eğitmeye devam ediyor.
Bu proje tek katmanlı bir projedir. İlk yaptığımız proje olduğu için komplex bir proje değildir.
Projenin tek katmanı Presentation Layer(gösterim katmanı)'dır. MVC tasarım şablonu ile kodlanmıştır.
# MVC(Model View Controller)
ASP.NET MVC, C#’da web uygulamaları oluşturmak için bir framework / çerçeve / çatı) dır.
• Model / View / Controller(Model-Görünüm-Kontrol) tasarım şablonuna dayalıdır.
• Kontrolün tersine çevrilmesi ve bağımlılık enjeksiyonu gibi temel .NET veya .NET Core çerçevesinin özelliklerinden yararlanır.
Model / View / Controller(Model-Görünüm-Denetleyici) nedir?

MVC bir tasarım desenidir ancak bir katmanlı mimari değildir. Herhangi bir yazılım firmasına ait değildir. Tüm yazılımcılar arasında kabul görmüş ve kullanılan ortak bir tasarım şablonudur. .NET Framework / Core MVC, MVC tasarım şablonuna göre yazılmış bir çatı / framework’dür.
İsteği / request’i ilk alan yer front controller / ön kontrolcüdür. Ön kontrolcü isteği aldıktan sonra ilgili kontrolcüye gönderir. İlgili kontrolcü isteği aldıktan sonra servis katmanına, servis katmanı ise veri erişim katmanına gider. Veri erişim katmanı veri tabanından verileri çeker getirir. Kontrolcü veriyi elde ettikten sonra ilgili verileri model nesnesinin içine koyar ve o modeli görünümün yani view’in içine gömer. İlgili view kullanıcıya html(hyper text markup language) olarak döner.
View ile Controller arasında taşınan nesne aslında Model nesnesidir.

Client tarafından gelen form nesnesi de aslında model nesnesidir.

Model aslında Controller ile View arasında iletişim sağlayan nesnedir.

Controller GET, POST, PUT, DELETE, PATCH gibi HTTP isteklerini karşılayan nesnedir / yapıdır.

View yapısı Chrome, Firefox yada Opera gibi Web tarayıcılarda gösterilen HTML(Hyper Text Markup Language) dosyasıdır. İçerisinde JS / Java Script, CSS / Cascading Style Sheet, JQuery gibi yapılar barındırabilir.
Denetleyici / Kontrolcü / Controller:

Denetleyici sınıfları, geliştiriciler tarafından oluşturulur.
• İş mantığını içerir ve isteği işler.
• Veri tabanından ve diğer hizmetlerden veri depolar ve alır.
• Verileri modelin içine koyar ve modeli de View / HTML’nin içine koyar.
Model:

• Model, yalnızca verileri içeren bir java nesnesidir.
• Veri tabanından veya web hizmetinden verileri depolamamıza ve almamıza yardımcı olacaktır.

View:

View HTML, CSS, JS kodlarını barındırır. Kullanıcıya gösterilen kısım burasıdır. Butonlar, tablolar, resimler vs. görsel componentler bu kısımda yer alır.

#### Projenin Görselleri: 
![001](https://github.com/huseyinaydin99/casgem-portfolio/assets/16438043/3ca0f1fc-da3f-485a-8824-d9391c1b21e7)
![002](https://github.com/huseyinaydin99/casgem-portfolio/assets/16438043/d4f7ca97-6f17-415f-9e76-949b6b3a8723)
![003](https://github.com/huseyinaydin99/casgem-portfolio/assets/16438043/a6a8fd33-e29e-480b-a8f4-7807bbcacc38)
![004](https://github.com/huseyinaydin99/casgem-portfolio/assets/16438043/77fdf648-d097-4893-b1c9-de9d7b1808d1)
![005](https://github.com/huseyinaydin99/casgem-portfolio/assets/16438043/15c3b62c-09fa-46e0-887f-1df7e1dbe652)
![006](https://github.com/huseyinaydin99/casgem-portfolio/assets/16438043/ac3e68b7-de14-426d-a372-586cea168d8a)
![007](https://github.com/huseyinaydin99/casgem-portfolio/assets/16438043/c1634abd-9da3-455f-8e4e-2e9a573a9057)
![008](https://github.com/huseyinaydin99/casgem-portfolio/assets/16438043/34dd0e0c-5ee1-4a12-9eac-41a4b7b90c1a)
![009](https://github.com/huseyinaydin99/casgem-portfolio/assets/16438043/a4c03e7a-a50b-4df6-8122-0d8e7235ae49)
![010](https://github.com/huseyinaydin99/casgem-portfolio/assets/16438043/131eeca3-c925-4b36-850b-ee38f945d6d9)
![011](https://github.com/huseyinaydin99/casgem-portfolio/assets/16438043/33bdfc97-47ce-4042-8fbf-bf4f697eb2af)
![012](https://github.com/huseyinaydin99/casgem-portfolio/assets/16438043/cc052b4d-51f5-4dc3-a87d-0f6e4bdf5b4c)
![013](https://github.com/huseyinaydin99/casgem-portfolio/assets/16438043/b1cfb070-a3a4-4461-90b1-c6315abbdf0a)
![014](https://github.com/huseyinaydin99/casgem-portfolio/assets/16438043/917d95f3-6649-444d-8c3c-1e1f2dc4eb4f)
![015](https://github.com/huseyinaydin99/casgem-portfolio/assets/16438043/5e32af40-51f5-4e25-871f-8884d85b5c6a)
![016](https://github.com/huseyinaydin99/casgem-portfolio/assets/16438043/568aacbe-18db-4174-9db6-be987e0d612f)
![017](https://github.com/huseyinaydin99/casgem-portfolio/assets/16438043/54da324e-b982-4446-b0c3-468ed1e580ec)
![018](https://github.com/huseyinaydin99/casgem-portfolio/assets/16438043/88e6e320-8618-4cc2-aae2-0002be3991db)
![019](https://github.com/huseyinaydin99/casgem-portfolio/assets/16438043/13132fee-94c5-44af-8c7a-213d97488395)
![020](https://github.com/huseyinaydin99/casgem-portfolio/assets/16438043/fe82efca-512e-41c5-9a88-8517bb627c56)
![021](https://github.com/huseyinaydin99/casgem-portfolio/assets/16438043/ccf68543-75ba-49cb-aed0-4f010e7e33da)
![022](https://github.com/huseyinaydin99/casgem-portfolio/assets/16438043/736a175e-0c12-4f7f-b6ec-3835c16fa0c7)
![023](https://github.com/huseyinaydin99/casgem-portfolio/assets/16438043/d5e15e02-27d1-4c8c-bdee-091dba9d662c)
![024](https://github.com/huseyinaydin99/casgem-portfolio/assets/16438043/a4ac0e42-eb2b-4565-a700-ea651941e2b2)
![025](https://github.com/huseyinaydin99/casgem-portfolio/assets/16438043/6577eeb5-0e13-482d-99f8-4452814fd1b3)

#### Projenin Videosu: 
<iframe width="560" height="315" src="https://www.youtube.com/embed/nl1yHH_btjM" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" allowfullscreen></iframe>
