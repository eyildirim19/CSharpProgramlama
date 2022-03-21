// kendi tiplerimiz için oluşturulan namespaceler proje adımızdır.

using _1_ClassTypes.PartialClass;
using _1_ClassTypes.SealedClass;
using _1_ClassTypes.StaticClass;

//_1_ClassTypes.PartialClass.A aa = new _1_ClassTypes.PartialClass.A();


#region PartialKavrami

A aa = new A();
aa.Adi = "eKREM";
aa.SoyAdi = "yILDIRIM";
aa.Yasi = 33;

#endregion

#region SealedKavrami

_1_ClassTypes.SealedClass.Ogrenci ogr = new _1_ClassTypes.SealedClass.Ogrenci();
ogr.Adi = "Recep";


#endregion


// farklı namespacelerde aynı sınıf ismi kullanılabilir. ancak kullanılırken namespace ile çağrılmalıdır...
_1_ClassTypes.StaticClass.Ogrenci ogr1 = new _1_ClassTypes.StaticClass.Ogrenci();
_1_ClassTypes.SealedClass.Ogrenci ogr2 = new _1_ClassTypes.SealedClass.Ogrenci();

#region StaticKavramı

// sınıf üyerlerine erişmek için instance alırız.. Bazı durumlarda sınıflardan instacne alınmadan da sınıf üyelerine erişmek isteriz...Bu senorya genelde nesneye bakılmaksıznın sabit yapılacak işlemler için geçerlidir. Yani gereksiz yere instance alınmadan üyenin kullanılmasıdır...

Calisan.KurumAdi = "BT Akademi";


Calisan calisan = new Calisan();
calisan.Adi = "Kaan";


Calisan cls = new Calisan();
cls.Adi = "Emre";

Calisan.KurumAdiYazdir();


int a = Convert.ToInt32("1");
int reuslt = Calisan.Topla(1, 2);


// static üyelerden instance alınamaz..
//CalisanIslemleri operasyon = new CalisanIslemleri();

decimal mayis = CalisanIslemleri.MaasHesapla(30, 500);
int izin = CalisanIslemleri.IzınHesapla(calisan);

#endregion