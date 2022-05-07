using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecapProject.Entities.Concrete;

namespace RecapProject.Business.Abstract
{
    public interface IBrandService
    {
        void Add(Brand brand);
        List<Brand> GetAll();
        Brand Get(int brandId);
    }
}