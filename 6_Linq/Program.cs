
/*
 * LINQ (LANGUAGE INTEGRATED QUERY) => DİLE ENTEGRE SORGULAMA => linq ifadeleri bizi birçok döngü,karar yapısı gibi ifadelerden kurtarır...
 * 
 * 1) linq to object (c# objeleri üzerinde işlem yapılır)
 * 2) linq to sql (sql objeleri üzerine işlem yapılır)
 * 3) linq to xml (xml verileri üzerinde işlem yapılır)
 * 
 */
List<int> sayilar = new List<int>();
for (int i = 0; i < 100; i++)
{
    sayilar.Add(i);
}
//List<int> ciftler = new List<int>();
//for (int i = 0; i < sayilar.Count; i++)
//{
//    if (sayilar[i] % 2 == 0)
//        sayilar.Add(i);
//}
List<int> ciftler = (from sayi in sayilar // in ifadesi her bir item'ı sayi değişkenene atar
                     where sayi % 2 == 0 // where kriter belirler
                     select sayi).ToList(); // select ile kritere uyan veriler çekilir...

List<int> kucukler = (from a in sayilar 
                      where a < 20 
                      select a).ToList();

List<int> kucukCiftler = (from a in sayilar
                              //where a  % 2==0 && a < 20
                          where ciftler.Contains(a) && kucukler.Contains(a)
                          select a).ToList();
// order by => sıralama (ascending (artan) ve descending (azalan))
List<int> Buyuktenkucuge = (from a in sayilar
                            orderby a descending
                            select a).ToList();
