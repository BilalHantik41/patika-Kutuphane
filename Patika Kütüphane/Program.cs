

using Patika_Kütüphane;

Kitap kitapTablo = new Kitap();

Console.WriteLine("Kitap Tablosu");

// 1. Kitapları tutacak liste
List<Kitap> kitapListesi = new List<Kitap>();

Console.Write("Kaç kitap girmek istiyorsunuz? ");
if (!int.TryParse(Console.ReadLine(), out int adet) || adet <= 0)
{
    Console.WriteLine("Geçersiz sayı.");
    return;
}

// 2. Kullanıcıdan kitap bilgilerini alıp listeye ekleme
for (int i = 1; i <= adet; i++)
{
    Console.WriteLine($"\n--- {i}. Kitap ---");
    Console.Write("Ad: ");
    string ad = Console.ReadLine()!;

    Console.Write("Yazar Adı: ");
    string yazarAdı = Console.ReadLine()!;

    Console.Write("Yazar Soyadı: ");
    string yazarSoyadı = Console.ReadLine()!;

    Console.Write("Sayfa Sayısı: ");
    string sayfaSayısı = Console.ReadLine()!;

    Console.Write("YayınEvi: ");
    string yayınEvi = Console.ReadLine()!;

    Console.Write("Kayıt Tarihi: ");
    DateTime kayıtTarihi = DateTime.Now;


    // Constructor ile nesne oluştur ve listeye ekle
    Kitap yeni = new Kitap(ad, yazarAdı, yazarSoyadı, sayfaSayısı, yayınEvi, kayıtTarihi);
    kitapListesi.Add(yeni);
}

// 3. Listeyi ekrana bastırma   
Console.WriteLine("\n=== Girilen Kitaplar ===");
int no = 1;
foreach (var k in kitapListesi)
{
    Console.WriteLine($"{no++}. \"{k.Ad}\" - \"{k.YazarAdı}\" - \"{k.YazarSoyadı}\" - [{k.SayfaSayısı:F2}] - {k.YayınEvi} - {k.KayıtTarihi} "); // bu şekilde liste yazdırmayı chatgpt'den öğrendim
}
        