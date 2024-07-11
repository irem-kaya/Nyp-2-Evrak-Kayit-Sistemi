# Nyp-2 Evrak Kayıt Sistemi

Bu proje, evrakların kaydedilmesi ve yönetilmesi için geliştirilmiş bir arşiv kayıt sistemidir. Kullanıcıların evrak ekleme, arama, güncelleme ve silme işlemlerini kolayca gerçekleştirmesini sağlar.

## İçindekiler

- [Özellikler](#özellikler)
- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Sınıf Detayları](#sınıf-detayları)
- [Katkıda Bulunma](#katkıda-bulunma)
- [Lisans](#lisans)

## Özellikler

- Evrak ekleme
- Evrak arama
- Evrak güncelleme
- Evrak silme
- Kullanıcı dostu arayüz

## Kurulum

Projeyi yerel makinenize kurmak için aşağıdaki adımları izleyin:

1. Bu projeyi klonlayın:
    ```bash
    git clone https://github.com/irem-kaya/Nyp-2-Evrak-Kayit-Sistemi.git
    ```

2. Proje dizinine gidin:
    ```bash
    cd Nyp-2-Evrak-Kayit-Sistemi/ArşivKay%C4%B1tSistemi%20NYP-2/Aşriv%20Kayıt%20Sistemi
    ```

3. Gerekli bağımlılıkları yükleyin:
    ```bash
    pip install -r requirements.txt
    ```

## Kullanım

Projeyi çalıştırmak için aşağıdaki adımları izleyin:

1. Ana dosyayı çalıştırın:
    ```bash
    python main.py
    ```

2. Program başlatıldığında, kullanıcı arayüzü üzerinden evrak ekleme, arama, güncelleme ve silme işlemlerini gerçekleştirebilirsiniz.

### Örnek Kullanım

```python
from archive_system import ArchiveSystem

# Sistem oluşturma
archive = ArchiveSystem()

# Evrak ekleme
archive.add_document('Evrak 1', 'Özet 1', 'Yazar 1', '2023-07-11')

# Evrak arama
results = archive.search_document('Evrak 1')
print(results)

# Evrak güncelleme
archive.update_document(1, 'Yeni Evrak 1', 'Yeni Özet 1', 'Yeni Yazar 1', '2023-07-12')

# Evrak silme
archive.delete_document(1)
