using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecapProject.Entities.Concrete;

namespace RecapProject.DataAccess.Abstract
{
    public interface ICarDal
    {
        Car GetById(int carId);
        List<Car> GetAll();
        void Add(Car car);
        void Update(Car car);
        void Delete(int carID);

    }
}