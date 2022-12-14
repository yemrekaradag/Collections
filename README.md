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
<h1>CollectionBase S??n??f??</h1>
.NET Framework kitapl??????, verileri depolamak i??in genel bir Koleksiyon s??n??f?? i??ermez, ancak kendi Koleksiyon s??n??f??n??z?? olu??turmak i??in kullanabilece??iniz bir soyut s??n??f vard??r -CollectionBase. CollectionBase s??n??f??, programc??ya ??zel bir Koleksiyon s??n??f??n?? uygulama yetene??i sa??lar. S??n??f, bir Koleksiyon s??n??f?? olu??turmak i??in gerekli olan iki aray??z?? (interfaces), ICollection ve IEnumerable ??rt??k olarak uygular. Programc?? yaln??zca tipik olarak bir Koleksiyon s??n??f??n??n par??as?? olmas?? gereken y??ntemleri uygulamakla yetinir.
<hr>
C#' da kendi Collection s??n??f??m??z?? uygulamak i??in bir s??n??f yazd??m. Bu birka?? amaca hizmet edecektir: ??lk olarak, nesne y??nelimli programlama (OOP) konusunda yeterince h??zl?? de??ilseniz, bu uygulama size C#'daki baz?? basit OOP tekniklerini g??sterecektir. Bu b??l??m??, farkl?? C# veri yap??lar??n?? tart??????rken ortaya ????kacak baz?? performans sorunlar??n?? tart????mak i??in de kullanabiliriz. Dilin yaln??zca temel ????elerini kullanarak mevcut veri yap??lar??n?? yeniden uygulamak ger??ekten ??ok e??lenceli. Bir ??eyi bilgisayara ????retene kadar ger??ekten iyi ????renmi?? say??lmazs??n??z. Dolay??s??yla, C#'a farkl?? veri yap??lar??n??n nas??l uygulanaca????n?? ????renerek, bu yap??lar hakk??nda, sizlere tecr??belerimi aktaraca????m.
<hr>
C#'ta bir Koleksiyon s??n??f??n?? tan??mlaman??n en kolay yolu, s??n??f?? System.Collections kitapl??????nda zaten bulunan soyut bir s??n??f olan CollectionBase s??n??f??na dayand??rmakt??r. Bu s??n??f, kendi koleksiyonunuzu olu??turmak i??in uygulayabilece??iniz bir dizi soyut y??ntem sa??lar. CollectionBase s??n??f??, s??n??f??n??z i??in temel olarak
kullanabilece??iniz InnerList (bir ArrayList) ad??nda temel bir veri yap??s?? sa??lar. Bu b??l??mde, bir Koleksiyon s??n??f?? olu??turmak i??in CollectionBase'in nas??l kullan??laca????na bakaca????z.
<hr>
Koleksiyon s??n??f??n?? olu??turacak y??ntemlerin t??m??, s??n??f??n temel veri yap??s?? olan InnerList ile bir t??r etkile??im i??erir. Bu ilk b??l??mde uygulayaca????m??z y??ntemler Add, Remove,Count ve Clear y??ntemleridir. Bu y??ntemler s??n??f i??in kesinlikle gereklidir, ancak di??er y??ntemlerin eklenmesi s??n??f?? daha kullan????l?? hale getirir. Di??er y??ntemleri ekledi??im projemi sayfan??n en a??a????s??nda bulabilirsiniz!
<hr>
<img src="https://user-images.githubusercontent.com/107070882/198885273-8e9d1b83-d395-498a-84f1-afa745ffb689.png" alt="CollectionBase">
<hr>
<h3>Add:</h3> Bu y??ntemin bir parametresi vard??r. Koleksiyona eklenecek ????eyi tutan bir Object de??i??keni.
<p>ArrayList???ler, verileri nesneler (Object veri t??r??) olarak depolar, bu nedenle ????eyi Object olarak deklare ettim. ArrayList ile alakal?? projemi ilerleyen s??re??te y??kleyece??im!</p>
<h3>Remove:</h3> Bu y??ntem de benzer ??ekilde tan??mlan??r ve koleksiyondan silinecek ????eyi parametre olarak object tipinde al??r.
<h3>Count:</h3> Genellikle bir ??zellik olarak uygulan??r, ancak biz onu bir y??ntem haline getirmeyi tercih ediyoruz. Ayr??ca, Count, temel s??n??f CollectionBase???de de tan??ml??d??r, bu nedenle CollectionBase'de bulunan Count tan??m??n?? gizlemek i??in <b>new</b> anahtar s??zc?????? kullanmam??z gerekir. Bize koleksiyondaki ????e say??s??n?? integer t??r??nde d??nd??r??r.
<h3>Clear:</h3> T??m ????eleri InnerList'ten kald??r??r. Ayr??ca y??ntemin tan??m??nda new anahtar s??zc??????n?? kullanmam??z gerekiyor.
<h3>Insert:</h3> Object olarak veriyi ve hangi index'e eklenece??ini parametre olarak al??r ve InnerList'e ekler.
<h3>Contains:</h3> Kontrol edilecek veriyi parametre olarak al??r ve InnerList'de arar. O(n) karma????kl??????na sahiptir. Ayr??ca ArrayList'de parametreden gelen veriyi bulursa True bulamazsa False d??nd??r??r.
<h3>IndexOf:</h3> Parametre olarak veriyi al??r ve InnerList'te buldu??u verinin index numaras??n?? d??nd??r??r. O(n) karma????kl??????na sahiptir.
<h3>RemoveAt:</h3> InnerList'den silinecek index numaras??n?? parametre olarak al??r ve belirlenen indexi ????e ile birlikte siler. Dolay??s??yla Koleksiyonun uzunlu??u azal??r. Mant??ken eri??ece??imiz ????enin index numaras?? bir azalm???? olacakt??r.
<hr>
<p>Bir integer dizi, collection ve arraylist yap??lar??n?? di??er repository'm deki timing class ile performans ??l????m?? yapmak i??in birle??tirdim. Sonu??lar?? a??a????daki linklerden g??rebilir veya projeleri inceleyebilirsiniz!</p>
<p>TimingClass : https://github.com/yemrekaradag/TimingClass</p>
<p>CollectionVsArray : https://github.com/yemrekaradag/CollectionVsArray</p>
