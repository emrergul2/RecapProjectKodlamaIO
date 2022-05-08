# TODO LIST

## LECTURE-7

---

Kampımızla beraber paralelde geliştireceğimiz bir projemiz daha olacak. Araba kiralama sistemi yazıyoruz.

### TODO-7.1 ✅

Yepyeni bir proje oluşturunuz. Adı ReCapProject olacak. (Tekrar ve geliştirme projesi)

### TODO-7.2 ✅

Entities, DataAccess, Business ve Console katmanlarını oluşturunuz.

### TODO-7.3 ✅

Bir araba nesnesi oluşturunuz. "Car"

### TODO-7.4 ✅

Özellik olarak : Id, BrandId, ColorId, ModelYear, DailyPrice, Description alanlarını ekleyiniz. (Brand = Marka)

### TODO-7.5 ✅

InMemory formatta GetById, GetAll, Add, Update, Delete operasyonlarını yazınız.

### TODO-7.6 ✅

Consol'da test ediniz.

## LECTURE-8

---

Araba Kiralama projemiz üzerinde çalışmaya devam edeceğiz.

Car nesnesine ek olarak;

### TODO-8.1 ✅

Brand ve Color nesneleri ekleyiniz(Entity)

Brand-->Id,Name

Color-->Id,Name

### TODO-8.2 ✅

Sql Server tarafında yeni bir veri tabanı kurunuz. Cars,Brands,Colors tablolarını oluşturunuz.

### TODO-8.3 ✅

Sisteme Generic IEntityRepository altyapısı yazınız.

### TODO-8.4 ✅

Car, Brand ve Color nesneleri için Entity Framework altyapısını yazınız.

### TODO-8.5 ✅

GetCarsByBrandId , GetCarsByColorId servislerini yazınız.

### TODO-8.6 ✅

Sisteme yeni araba eklendiğinde aşağıdaki kuralları çalıştırınız.

Araba ismi minimum 2 karakter olmalıdır

Araba günlük fiyatı 0'dan büyük olmalıdır

## Lecture-9

---

### TODO-9.1 ✅

CarRental Projenizde Core katmanı oluşturunuz.

### TODO-9.2 ✅

IEntity, IDto, IEntityRepository, EfEntityRepositoryBase dosyalarınızı 9. gün dersindeki gibi oluşturup ekleyiniz.

### TODO-9.3 ✅

Car, Brand, Color sınıflarınız için tüm CRUD operasyonlarını hazır hale getiriniz

### TODO-9.4 ✅

Console'da Tüm CRUD operasyonlarınızı Car, Brand, Model nesneleriniz için test ediniz. GetAll, GetById, Insert, Update, Delete.

### TODO-9.5 ✅

Arabaları şu bilgiler olacak şekilde listeleyiniz. CarName, BrandName, ColorName, DailyPrice. (İpucu : IDto oluşturup 3 tabloya join yazınız)
