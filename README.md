<h1>CollectionBase Class</h1>
The .NET Framework library does not include a generic Collection class to store data, but there is an abstract class -CollectionBase that you can use to create your own Collection class. The CollectionBase class provides the programmer with the ability to implement a custom Collection class. The class implicitly implements the two interfaces required to create a Collection class, ICollection and IEnumerable. The programmer can only implement methods that should typically be part of a Collection class.
<hr>
I wrote a class to implement our own Collection class in C#. This will serve several purposes: First, if you're not fast enough with object-oriented programming (OOP), this app will show you some simple OOP techniques in C#. We can also use this section to discuss some of the performance issues that will arise when discussing different C# data structures. It's really fun to re-implement existing data structures using only the core elements of the language. You're not really good at learning something until you teach it to the computer. Therefore, by learning how to apply different data structures to C#, I will share my experience with these structures.
<hr>
The easiest way to define a Collection class in C# is to base the class on the CollectionBase class, which is an abstract class that already exists in the System.Collections library. This class provides a set of abstract methods that you can implement to create your own collection. The CollectionBase class is the basis for your class
It provides a basic data structure called InnerList (an ArrayList) that you can use. In this section, we'll look at how to use CollectionBase to create a Collection class.
<hr>
The methods that will create the Collection class all involve some form of interaction with the underlying data structure of the class, InnerList. The methods we will apply in this first section are the Add, Remove,Count and Clear methods. These methods are absolutely necessary for the class, but adding other methods makes the class more useful. You can find my project where I added other methods at the bottom of the page!
<hr>
<img src="https://user-images.githubusercontent.com/107070882/198885273-8e9d1b83-d395-498a-84f1-afa745ffb689.png" alt="CollectionBase">
<hr>
<h3>Add:</h3> This method has one parameter. An Object variable holding the item to be added to the collection.
<p>ArrayLists store data as objects (the Object data type), so I declared the item as Object. I will upload my project related to ArrayList in the future!</p>
<hr>
<h3>Remove:</h3> This method is defined similarly and takes the item to be deleted from the collection as a parameter of type object.
<h3>Count:</h3> Usually implemented as a property, but we prefer to make it a method. Also, Count is defined in the base class CollectionBase, so we need to use the <b>new</b> keyword to hide the definition of Count in CollectionBase. Returns us the number of items in the collection of type integer.
<h3>Clear:</h3> Removes all items from the InnerList. We also need to use the new keyword in the definition of the method.
<h3>Insert:</h3> It takes the data as Object and which index it will be inserted as a parameter and adds it to the InnerList.
<h3>Contains:</h3> It takes the data to be checked as a parameter and searches it in the InnerList. It has O(n) complexity. It also returns True if it finds the data from the parameter in the ArrayList, otherwise it returns False.
<h3>IndexOf:</h3> It takes the data as a parameter and returns the index number of the data it finds in the InnerList. It has O(n) complexity.
<h3>RemoveAt:</h3> Takes the index number to be deleted from the InnerList as a parameter and deletes the specified index together with the item. Logically the length of the Collection is reduced. The index number of the item to be accessed logically will decrease by one.
<hr>
<p>I combined an integer array, collection and arraylist structures with the timing class in my other repository to measure performance. You can see the results from the links below or review the projects!</p>
<p>TimingClass : https://github.com/yemrekaradag/TimingClass</p>
<p>CollectionVsArray : https://github.com/yemrekaradag/CollectionVsArray</p>
<hr>
<h1>CollectionBase Sınıfı</h1>
.NET Framework kitaplığı, verileri depolamak için genel bir Koleksiyon sınıfı içermez, ancak kendi Koleksiyon sınıfınızı oluşturmak için kullanabileceğiniz bir soyut sınıf vardır -CollectionBase. CollectionBase sınıfı, programcıya özel bir Koleksiyon sınıfını uygulama yeteneği sağlar. Sınıf, bir Koleksiyon sınıfı oluşturmak için gerekli olan iki arayüzü (interfaces), ICollection ve IEnumerable örtük olarak uygular. Programcı yalnızca tipik olarak bir Koleksiyon sınıfının parçası olması gereken yöntemleri uygulamakla yetinir.
<hr>
C#' da kendi Collection sınıfımızı uygulamak için bir sınıf yazdım. Bu birkaç amaca hizmet edecektir: İlk olarak, nesne yönelimli programlama (OOP) konusunda yeterince hızlı değilseniz, bu uygulama size C#'daki bazı basit OOP tekniklerini gösterecektir. Bu bölümü, farklı C# veri yapılarını tartışırken ortaya çıkacak bazı performans sorunlarını tartışmak için de kullanabiliriz. Dilin yalnızca temel öğelerini kullanarak mevcut veri yapılarını yeniden uygulamak gerçekten çok eğlenceli. Bir şeyi bilgisayara öğretene kadar gerçekten iyi öğrenmiş sayılmazsınız. Dolayısıyla, C#'a farklı veri yapılarının nasıl uygulanacağını öğrenerek, bu yapılar hakkında, sizlere tecrübelerimi aktaracağım.
<hr>
C#'ta bir Koleksiyon sınıfını tanımlamanın en kolay yolu, sınıfı System.Collections kitaplığında zaten bulunan soyut bir sınıf olan CollectionBase sınıfına dayandırmaktır. Bu sınıf, kendi koleksiyonunuzu oluşturmak için uygulayabileceğiniz bir dizi soyut yöntem sağlar. CollectionBase sınıfı, sınıfınız için temel olarak
kullanabileceğiniz InnerList (bir ArrayList) adında temel bir veri yapısı sağlar. Bu bölümde, bir Koleksiyon sınıfı oluşturmak için CollectionBase'in nasıl kullanılacağına bakacağız.
<hr>
Koleksiyon sınıfını oluşturacak yöntemlerin tümü, sınıfın temel veri yapısı olan InnerList ile bir tür etkileşim içerir. Bu ilk bölümde uygulayacağımız yöntemler Add, Remove,Count ve Clear yöntemleridir. Bu yöntemler sınıf için kesinlikle gereklidir, ancak diğer yöntemlerin eklenmesi sınıfı daha kullanışlı hale getirir. Diğer yöntemleri eklediğim projemi sayfanın en aşağısında bulabilirsiniz!
<hr>
<img src="https://user-images.githubusercontent.com/107070882/198885273-8e9d1b83-d395-498a-84f1-afa745ffb689.png" alt="CollectionBase">
<hr>
<h3>Add:</h3> Bu yöntemin bir parametresi vardır. Koleksiyona eklenecek öğeyi tutan bir Object değişkeni.
<p>ArrayList’ler, verileri nesneler (Object veri türü) olarak depolar, bu nedenle öğeyi Object olarak deklare ettim. ArrayList ile alakalı projemi ilerleyen süreçte yükleyeceğim!</p>
<hr>
<h3>Remove:</h3> Bu yöntem de benzer şekilde tanımlanır ve koleksiyondan silinecek öğeyi parametre olarak object tipinde alır.
<h3>Count:</h3> Genellikle bir özellik olarak uygulanır, ancak biz onu bir yöntem haline getirmeyi tercih ediyoruz. Ayrıca, Count, temel sınıf CollectionBase’de de tanımlıdır, bu nedenle CollectionBase'de bulunan Count tanımını gizlemek için <b>new</b> anahtar sözcüğü kullanmamız gerekir. Bize koleksiyondaki öğe sayısını integer türünde döndürür.
<h3>Clear:</h3> Tüm öğeleri InnerList'ten kaldırır. Ayrıca yöntemin tanımında new anahtar sözcüğünü kullanmamız gerekiyor.
<h3>Insert:</h3> Object olarak veriyi ve hangi index'e ekleneceğini parametre olarak alır ve InnerList'e ekler.
<h3>Contains:</h3> Kontrol edilecek veriyi parametre olarak alır ve InnerList'de arar. O(n) karmaşıklığına sahiptir. Ayrıca ArrayList'de parametreden gelen veriyi bulursa True bulamazsa False döndürür.
<h3>IndexOf:</h3> Parametre olarak veriyi alır ve InnerList'te bulduğu verinin index numarasını döndürür. O(n) karmaşıklığına sahiptir.
<h3>RemoveAt:</h3> InnerList'den silinecek index numarasını parametre olarak alır ve belirlenen indexi öğe ile birlikte siler. Dolayısıyla Koleksiyonun uzunluğu azalır. Mantıken erişeceğimiz öğenin index numarası bir azalmış olacaktır.
<hr>
<p>Bir integer dizi, collection ve arraylist yapılarını diğer repository'm deki timing class ile performans ölçümü yapmak için birleştirdim. Sonuçları aşağıdaki linklerden görüp veya projeleri inceleyebilirsiniz!</p>
<p>TimingClass : https://github.com/yemrekaradag/TimingClass</p>
<p>CollectionVsArray : https://github.com/yemrekaradag/CollectionVsArray</p>
