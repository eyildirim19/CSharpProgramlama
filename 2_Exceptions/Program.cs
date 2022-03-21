

// Hataları 3' ayıyoruz;
// 1) Derlenme hatalarıdır.. (syntax hataları sebeb olur)
//in s = 1;
//2) Mantıklsal hatalardır. (En tehlikeli hata türüdür.. uygulama çalıyordur ancak hatalı çalışıyordur) => Break point ile uygulamayı takip etmektir. bütün senoryoları düşünerek hareket etmek gerikir..
// 3) Runtime hataları... => çalışma zamanında oluşan hatalardır....kullanıcıdan kaynaklı, veya bağlantı koması vb. gibi durumlarda oluşan hatalardır. Eğer runtime hatalarını yönetmezsek uygulama hata aldığı yerde duracaktır..

// Runtime hatalarını Try-Catch blokları ile yönetiriz...Exception ilede hataların detaylarına erişiriz..

short sayi;
Console.WriteLine("Lütfen bir sayı giriniz");
// hata oluşacağnı düşündüğünüz komutlar try ile çalıştırılır. Eğer try bloğu içerisinde bir hata olursa program durmadan catch bloğı hatayı yakalacaktır...Hata oluşan satırdan sonrası çalışmaz. 
try
{
    sayi = Convert.ToInt16(Console.ReadLine());
    sayi += 5;
    Console.WriteLine($"Girilen sayınının 5 fazlası {sayi}");
}
catch (FormatException ex)// Sadece format exceptionları yakala....
{
    // bu blokta hatanın detayınada erişebilir.. bu blokta genelde hata alınan satır bir dosyaya loglanır. uygulama çalışmaya devam eder.....
    Console.WriteLine($"bir hata aldınız {ex.Message}....");
}
catch (OverflowException ex) // sadece taşma hatalarını yakala
{
    Console.WriteLine($"bir hata aldınız {ex.Message}");
}
finally
{
    // hata olsun olmasın çalışcak bölümdür..sık kullanılmaz...
}


// Tek exteption ile'de bütün hataların detayına erişebiliriz...
try
{
    sayi = Convert.ToInt16(Console.ReadLine());
    sayi += 5;
    Console.WriteLine($"Girilen sayınının 5 fazlası {sayi}");
}
catch (Exception ex)// Bütün hataları yakala...
{
    Console.WriteLine($"bir hata aldınız {ex.Message}....");

    if (ex is FormatException)
    {
    }
    else if (ex is OverflowException)
    {
    }
}


Console.WriteLine("İşlemler devam ediyor.....");
Console.WriteLine("İşlemler bitti");
