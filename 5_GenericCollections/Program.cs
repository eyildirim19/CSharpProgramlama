
// Generic Collections => Generic yapısı şablon tip olarak çevrilir..
// tipini instance aldığımızda belirlediğimiz yapılara denir...instance alırken tip belirlendiği için tip güvenliği vardır..boxing ve unboxing işlemi tipi tutulmazlar...

// <T> generic operatörüdür....
// List => Arraylistin generic halidir...

// bundan sonraki süreçler koleksiyonlar kullanılacaktır...
using _5_GenericCollections;
List<int> nums = new List<int>();
nums.Add(100);
nums.Add(101);
nums.Add(102);
nums[2] = 103;

List<string> names = new List<string>();
names.Add("ahmet");
names.Add("emre");
names.Add("recep");

for (int i = 0; i < 1000; i++)
{
    nums.Add(i);
}
Ogrenci ogr = new Ogrenci();
ogr.Name = "Bilal";

List<Ogrenci> ogrencis = new List<Ogrenci>();
ogrencis.Add(new Ogrenci { Name = "Kaan" });
ogrencis.Add(ogr);

// Dictionary => Hastable sınıfının generic halidir...
// Dictinory key ve value şeklinde veri saklar..key value için indexi ifade eder...
Dictionary<string, int> keyNums = new Dictionary<string, int>();
keyNums.Add("A", 100);
keyNums.Add("B", 101);
keyNums.Add("C", 102);
keyNums["C"] = 103;

int num = keyNums["B"];
Dictionary<int, string> keyStrings = new Dictionary<int, string>();
keyStrings.Add(0, "A");
keyStrings.Add(1, "B");
keyStrings.Add(2, "C");
keyStrings[2] = "Ç";
string str = keyStrings[1];

Dictionary<int, List<int>> numsnums = new Dictionary<int, List<int>>();
Dictionary<char,Ogrenci> ogrdic = new Dictionary<char,Ogrenci>();