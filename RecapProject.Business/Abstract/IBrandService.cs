using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecapProject.Core.Utilities.Result;
using RecapProject.Entities.Concrete;

namespace RecapProject.Business.Abstract
{
    public interface IBrandService
    {
        IResult Add(Brand brand);
        IResult Delete(Brand brand);
        IResult Update(Brand brand);
        IDataResult<List<Brand>> GetAll();
        IDataResult<Brand> Get(int brandId);
    }
}