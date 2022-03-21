using _3_ExtensionsMetot.MyExtenions;

string str = "ekrem";
Console.WriteLine(str.ToUpper());

string[] isimler = { "recep" };
Array.Resize(ref isimler, 2);
isimler[1] = str;

int a = UzantiMetotlar.inteCevir("1");
int b = "1".inteCevir();
string deger = "11";

int c = deger.inteCevir();

string kelime = "ada".terscevir();


string sayi = a.stringedonustur();
