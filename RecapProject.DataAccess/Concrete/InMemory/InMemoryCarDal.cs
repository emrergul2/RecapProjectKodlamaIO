using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using RecapProject.DataAccess.Abstract;
using RecapProject.Entities.Concrete;
using RecapProject.Entities.DTOs;

namespace RecapProject.DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{BrandId=1,ColorId=1,ModelYear=1995,DailyPrice=199.99m,Description="Just car, nothing special."},
                new Car{BrandId=1,ColorId=1,ModelYear=2000,DailyPrice=249.99m,Description="Just car, nothing special."},
                new Car{BrandId=1,ColorId=1,ModelYear=2005,DailyPrice=299.99m,Description="Just car, nothing special."},
                new Car{BrandId=2,ColorId=1,ModelYear=2010,DailyPrice=349.99m,Description="Just car, nothing special."},
                new Car{BrandId=3,ColorId=1,ModelYear=2010,DailyPrice=399.99m,Description="Just car, nothing special."},
                new Car{BrandId=3,ColorId=1,ModelYear=2001,DailyPrice=299.99m,Description="Just car, nothing special."}
            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(int carID)
        {
            Car deleteCar = _car.SingleOrDefault(c => c.Id == carID);
            _car.Remove(deleteCar);
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int carId)
        {
            return _car.SingleOrDefault(c => c.Id == carId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car updateToCar = _car.SingleOrDefault(c => c.Id == car.Id);
            updateToCar.BrandId = car.BrandId;
            updateToCar.ColorId = car.ColorId;
            updateToCar.ModelYear = car.ModelYear;
            updateToCar.DailyPrice = car.DailyPrice;
            updateToCar.Description = car.Description;

        }
    }
}