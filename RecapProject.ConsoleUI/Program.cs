using System;
using System.Collections.Generic;
using RecapProject.Business.Concrete;
using RecapProject.DataAccess.Concrete.InMemory;
using RecapProject.Entities.Concrete;

namespace RecapProject.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            List<Car> cars = carManager.GetAll();

            foreach (var car in cars)
            {
                Console.WriteLine($"CarID : {car.Id}, ModelYear : {car.ModelYear}, DailyPrice : {car.DailyPrice}");
            }
        }
    }
}
