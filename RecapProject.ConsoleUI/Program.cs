using System;
using System.Collections.Generic;
using RecapProject.Business.Concrete;
using RecapProject.DataAccess.Concrete.EntityFramework;
using RecapProject.DataAccess.Concrete.InMemory;
using RecapProject.Entities.Concrete;

namespace RecapProject.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // InMemoryTest();
            EntityFrameworkTest efTest = new EntityFrameworkTest();
            // efTest.AddColor();
            // efTest.AddBrand();
            efTest.GenerateRandomCar(1000);
        }
        static void InMemoryTest()
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            List<Car> cars = carManager.GetAll();

            foreach (var car in cars)
            {
                Console.WriteLine($"CarID : {car.Id}, ModelYear : {car.ModelYear}, DailyPrice : {car.DailyPrice}");
            }
        }
    }
    class EntityFrameworkTest
    {
        public void AddColor()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            List<Color> colors = new List<Color>
            {
                new Color() {Name="Yellow"},
                new Color() {Name="Red"},
                new Color() {Name="Blue"},
                new Color() {Name="Orange"},
                new Color() {Name="Green"},
                new Color() {Name="Violet"},
                new Color() {Name="Black"}
            };

            foreach (var c in colors)
            {
                colorManager.Add(c);
            }
        }
        public void AddBrand()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            List<Brand> brands = new List<Brand>
            {
                new Brand(){Name="BMW"},
                new Brand(){Name="Toyota"},
                new Brand(){Name="Kia"},
                new Brand(){Name="Honda"},
                new Brand(){Name="Hyundai"},
                new Brand(){Name="Ford"},
                new Brand(){Name="Tesla"},
                new Brand(){Name="Mazda"},
                new Brand(){Name="Porsche"},
                new Brand(){Name="Nissan"},
                new Brand(){Name="Volkswagen"},
                new Brand(){Name="Volvo"},
                new Brand(){Name="Mercedes-Benz"}
            };
            foreach (var brand in brands)
            {
                brandManager.Add(brand);
            }
        }
        public void GenerateRandomCar(int numOfCar)
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            CarManager carManager = new CarManager(new EfCarDal());

            int colorCount = colorManager.GetAll().Count;
            int brandCount = brandManager.GetAll().Count;

            List<Brand> brands = new List<Brand>
            {
                new Brand {Name="BMW"},
                new Brand {Name="Toyota"},
                new Brand {Name="Kia"},
                new Brand {Name="Honda"},
                new Brand {Name="Hyundai"},
                new Brand {Name="Ford"},
                new Brand {Name="Tesla"},
                new Brand {Name="Mazda"},
                new Brand {Name="Porsche"},
                new Brand {Name="Nissan"},
                new Brand {Name="Volkswagen"},
                new Brand {Name="Volvo"},
                new Brand {Name="Mercedes-Benz"}
            };

            for (int i = 0; i < numOfCar; i++)
            {
                Random rnd = new Random();
                int brandId = rnd.Next(colorCount) + 1;
                int colorId = rnd.Next(colorCount) + 1;
                int carBrandCount = carManager.GetCarsByBrandId(brandId).Count + 1;
                int modalYear = rnd.Next(1990, 2022);
                string color = colorManager.Get(colorId).Name;
                Car car = new Car()
                {
                    BrandId = brandId,
                    ColorId = rnd.Next(colorCount) + 1,
                    DailyPrice = rnd.Next(100, 300),
                    ModelYear = modalYear,
                    Description = $"{(brandManager.Get(brandId)).Name} {color} {modalYear}",
                    Name = (brandManager.Get(brandId)).Name + " " + carBrandCount
                };
                carManager.Add(car);
            }
        }
    }
}
