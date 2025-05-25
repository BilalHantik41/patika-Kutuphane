Patika Kütüphane

Açıklama

Patika.dev C# Eğitimi kapsamında geliştirilen basit bir konsol tabanlı Kütüphane Yönetim Sistemi.

Özellikler

Kitap ekleme ve listeleme

Üye ekleme ve listeleme

Kitap ödünç alma ve iade işlemleri

Etkileşimli menü tabanlı kullanım

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

Uygulama çalıştığında ekrana basit bir menü gelecek.

Menüdeki numaraları girerek ilgili işlemi seçin:

Kitap Ekle

Kitap Listele

Üye Ekle

Üye Listele

Kitap Ödünç Ver

Kitap İade Al

Çıkış

İşlem tamamlandıktan sonra ana menü tekrar görüntülenecektir.

Proje Yapısı

patika-Kutuphane/
│
├─ Patika Kütuphane.sln      // Çözüm dosyası
├─ Patika Kütuphane/         // C# proje klasörü
│   ├─ Program.cs            // Uygulama giriş noktası ve menü akışını barındırır
│   ├─ Models/               // `Kitap`, `Uye` gibi model sınıfları
│   └─ Helpers/              // Yardımcı metotlar ve servis sınıfları
│
├─ .gitignore
└─ README.md

