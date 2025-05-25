Patika Kütüphane

Açıklama

Patika.dev C# Eğitimi kapsamında geliştirilen basit bir konsol tabanlı kitap kayıt ve listeleme uygulaması.

Özellikler

Kullanıcıdan bir kerede girilecek kitap adedini alma

Kitap bilgilerini (Ad, Yazar Adı, Yazar Soyadı, Sayfa Sayısı, YayınEvi) alarak nesne oluşturma

Otomatik olarak kayıt tarihi atama

Girilen kitapları liste halinde formatlı olarak ekrana yazdırma

Gereksinimler

.NET 6.0 SDK veya daha üstü

Visual Studio 2022 (veya Visual Studio Code gibi bir IDE)

Kurulum

Depoyu klonlayın:

git clone https://github.com/BilalHantik41/patika-Kutuphane.git

Proje dizinine gidin:

cd patika-Kutuphane

Visual Studio ile Patika Kütuphane.sln dosyasını açın.

Uygulamayı F5 (Debug) veya Ctrl+F5 (Debugsuz) ile çalıştırın.

Kullanım

Uygulama çalıştığında konsolda önce kaç kitap girmek istediğinizi sorar.

Girilecek adet pozitif bir tam sayı değilse program sonlanır.

Her kitap için sırasıyla aşağıdaki bilgileri girin:

Ad

Yazar Adı

Yazar Soyadı

Sayfa Sayısı (numerik değer olarak girilmeli)

Yayın Evi

Kitap nesnesi oluşturulurken kayıt tarihi otomatik olarak DateTime.Now ile atanır.

Tüm kitaplar girildikten sonra ekrana aşağıdaki formatta liste yazdırılır:

1. "Girişimci Ruh" - "Ahmet" - "Yılmaz" - [250] - Pearson - 2025-05-25 21:00:00
2. "C# 101"      - "Mehmet" - "Demir"  - [320] - KodKitap    - 2025-05-25 21:00:05
...

Proje Yapısı

patika-Kutuphane/
│
├─ Patika Kütuphane.sln     // Çözüm dosyası
├─ Patika Kütuphane/        // C# proje klasörü
│   ├─ Program.cs           // Uygulama giriş noktası ve kitap kayıt-listeleme akışı
│   ├─ Models/              // `Kitap` model sınıfını barındırır
│
├─ .gitignore
└─ README.md

Katkıda Bulunma

Yeni özellikler veya hata düzeltmeleri için pull request açabilirsiniz.

Sorunları (issues) bildirerek katkıda bulunabilirsiniz.
