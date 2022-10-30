<h1>CollectionBase Sınıfı</h1>
.NET Framework kitaplığı, verileri depolamak için genel bir Koleksiyon sınıfı içermez, ancak kendi Koleksiyon sınıfınızı oluşturmak için kullanabileceğiniz bir soyut sınıf vardır -CollectionBase. CollectionBase sınıfı, programcıya özel bir Koleksiyon sınıfını uygulama yeteneği sağlar. Sınıf, bir Koleksiyon sınıfı oluşturmak için gerekli olan iki arayüzü (interfaces), ICollection ve IEnumerable örtük olarak uygular. Programcı yalnızca tipik olarak bir Koleksiyon sınıfının parçası olması gereken yöntemleri uygulamakla yetinir.
<hr>
C#' da kendi Collection sınıfımızı uygulamak için bir sınıf yazdım. Bu birkaç amaca hizmet edecektir: İlk olarak, nesne yönelimli programlama (OOP) konusunda yeterince hızlı değilseniz, bu uygulama size C#'daki bazı basit OOP tekniklerini gösterecektir. Bu bölümü, farklı C# veri yapılarını tartışırken ortaya çıkacak bazı performans sorunlarını tartışmak için de kullanabiliriz. Dilin yalnızca temel öğelerini kullanarak mevcut veri yapılarını yeniden uygulamak gerçekten çok eğlenceli. Bir şeyi bilgisayara öğretene kadar gerçekten iyi öğrenmiş sayılmazsınız. Dolayısıyla, C#'a farklı veri yapılarının nasıl uygulanacağını öğrenerek, bu yapılar hakkında, sizlere tecrübelerimi aktaracağım.
<hr>
C#'ta bir Koleksiyon sınıfını tanımlamanın en kolay yolu, sınıfı System.Collections kitaplığında zaten bulunan soyut bir sınıf olan CollectionBase sınıfına dayandırmaktır. Bu sınıf, kendi koleksiyonunuzu oluşturmak için uygulayabileceğiniz bir dizi soyut yöntem sağlar. CollectionBase sınıfı, sınıfınız için temel olarak
kullanabileceğiniz InnerList (bir ArrayList) adında temel bir veri yapısı sağlar. Bu bölümde, bir Koleksiyon sınıfı oluşturmak için CollectionBase'in nasıl kullanılacağına bakacağız.
<hr>
Koleksiyon sınıfını oluşturacak yöntemlerin tümü, sınıfın temel veri yapısı olan InnerList ile bir tür etkileşim içerir. Bu ilk bölümde uygulayacağımız yöntemler Add, Remove,Count ve Clear yöntemleridir. Bu yöntemler sınıf için kesinlikle gereklidir, ancak diğer yöntemlerin eklenmesi sınıfı daha kullanışlı hale getirir. Diğer yöntemleri eklediğim projemi sayfanın en aşağısında bulabilirsiniz!


<img src="https://user-images.githubusercontent.com/107070882/198885273-8e9d1b83-d395-498a-84f1-afa745ffb689.png" alt="CollectionBase">


<h5>Add:</h5> Bu yöntemin bir parametresi vardır. Koleksiyona eklenecek öğeyi tutan bir Object değişkeni.

<p>ArrayList’ler, verileri nesneler (Object veri türü) olarak depolar, bu nedenle öğeyi Object olarak deklare ettim. ArrayList ile alakalı projemi ilerleyen süreçte yükleyeceğim!</p>

<h5>Remove:</h5> Bu yöntem de benzer şekilde tanımlanır ve koleksiyondan silinecek öğeyi parametre olarak object tipinde alır.
<h5>Count:</h5> Genellikle bir özellik olarak uygulanır, ancak biz onu bir yöntem haline getirmeyi tercih ediyoruz. Ayrıca, Count, temel sınıf CollectionBase’de de tanımlıdır, bu nedenle CollectionBase'de bulunan Count tanımını gizlemek için <b>new</b> anahtar sözcüğü kullanmamız gerekir. Bize koleksiyondaki öğe sayısını integer türünde döndürür.
<h5>Clear:</h5> Tüm öğeleri InnerList'ten kaldırır. Ayrıca yöntemin tanımında new anahtar sözcüğünü kullanmamız gerekiyor.
<hr>
Bir integer dizi, collection ve arraylist yapılarını diğer repository'm deki timing class ile performans ölçümü yapmak için birleştirdim. Sonuçları aşağıdaki linklerden görüp veya projeleri inceleyebilirsiniz!

<p>TimingClass : https://github.com/yemrekaradag/TimingClass</p>
<p>CollectionVsArray : https://github.com/yemrekaradag/CollectionVsArray</p>
