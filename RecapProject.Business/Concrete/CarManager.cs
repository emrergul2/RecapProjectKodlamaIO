using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecapProject.Business.Abstract;
using RecapProject.DataAccess.Abstract;
using RecapProject.Entities.Concrete;

namespace RecapProject.Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            _carDal.Add(car);
        }

        public void Delete(int carID)
        {
            _carDal.Delete(carID);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetById(int carId)
        {
            return _carDal.GetById(carId);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}