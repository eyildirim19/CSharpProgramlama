using _4_Collections;
using System.Collections; // ArrayList sınıfını kullanmak için...
// Array => aynı tipden verileri bir arada tutmak iiçin kullanılan varlıklar...
int[] arr = new int[3];
string[] str = new string[4];
Ogrenci[] ogrler = new Ogrenci[1];
// Collections, Arraylar gibi kullanılan ancak eleman sayısı belirtilmeden kullanılan objelerdir...
// koleksiyonlarda eleman eklemek için Add metodu kullanılır...
// Koleksyonun uzunluğu eleman ekledikçe artar.
ArrayList nums = new ArrayList();
nums.Add(110);
nums.Add(120);
nums.Add(130);
nums[2] = 7; // bu index olduğu için değer atanabilir.
//nums[3] = 7; koleksiyonun uzunluğu 3, en büyük indexide 2 olduğu için bu şekilde değer atanamaz...

Console.WriteLine(nums.Count); // koleksyionun uzunluğunu verir
ArrayList names = new ArrayList();
names.Add("Recep");
names.Add("Kaan");
names.Add("Emre");

Ogrenci ogr = new Ogrenci();
ogr.Name = "Ahmet";
string[] gunler = { "pazartesi", "salı", "çarşamba" };
Ogrenci ogr2 = new Ogrenci { Name = "Nur" }; // object initializer

ArrayList ogrencis = new ArrayList();
ogrencis.Add(ogr);
ogrencis.Add(new Ogrenci { Name = "Alper" });
ogrencis.Add(ogr2);


// koleksiyonları kullanmayız çünkü object tipinden veri saklar.. 
// koleksiyonları kullanmayız çünkü tip güvenliği olmayan varlıkladır;

// objecte dönüşüm işlemine boxing(kutulama) denir
object o = "ekrem"; // stringi object'e atamış olduk
object oo = new string[] { "ali", "emre", "recep" }; // string diziyi objecte atadık
object ooo = new Ogrenci { Name = "ekrem" };

// objectten dönüşüm işleminde unboxing (kutudan çıkarma)denir...
Ogrenci newO = (Ogrenci)ooo; // objectten alt tipe dönüştür


// koleksiyonların elemanlarına erişirken [] kullanılır....
for (int i = 0; i < nums.Count; i++)
    Console.WriteLine(nums[i]);

foreach (var item in nums)
    Console.WriteLine(item);

foreach (var item in names)
    Console.WriteLine(item);

foreach (var item in ogrencis)
{
    // koleksiyondan da okunacak işemleri unboxing işlemine tabi tutmak gerekir...
    Ogrenci ogrTemp = (Ogrenci)item; // unboxing
    Console.WriteLine(ogrTemp);
}
// Hastable => arraylistler gibi birden fazla veri saklamak için kullanılır. Arraylar veya Koleksiyonlarda elemanlara index ile erişilir...Bu indexler otomatik oluşan değerlerdir...Hastable kullanımında ise elemanların indexleri bizim tarafımızdan belirleniir....

// bu tür yapılar (Hastable) küçük değerler için kullanılabilir...
Hashtable hst = new Hashtable();
hst.Add("a", "ekrem");
hst.Add("b", "recep");
hst.Add("c", "emre");
hst.Add("d", "bilal");
hst.Add("e", "nur");
hst["e"] = "demo";

//hst.Add("e", "demo"); // keyler unique olmalıdır...
string yogr = (string)hst["c"]; // c indexteki elemanı ver..



// koleksiyonlarda tip günveliği yoktur çünkü koleksyon tipleri objecttir..
ArrayList son = new ArrayList();
son.Add(1);
son.Add("AAA");
son.Add(new string[] { "a","b","c"});
son.Add('E');
son.Add(new Ogrenci { Name = "Deneme" });