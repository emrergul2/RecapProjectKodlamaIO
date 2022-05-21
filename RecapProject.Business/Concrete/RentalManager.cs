using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecapProject.Business.Abstract;
using RecapProject.Business.Constant;
using RecapProject.Core.Utilities.Result;
using RecapProject.DataAccess.Abstract;
using RecapProject.Entities.Concrete;

namespace RecapProject.Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {
            var result = _rentalDal.GetAll(r => r.CarId == rental.CarId).LastOrDefault();
            if (result.ReturnDate > rental.RentDate)
            {
                return new ErrorResult(Messages.ItemNotAdded);
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.ItemAdded);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.ItemDeleted);
        }
        public IDataResult<Rental> Get(int customerId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(u => u.Id == customerId), Messages.ItemListed);
        }
        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }
        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.ItemUpdated);
        }
    }
}