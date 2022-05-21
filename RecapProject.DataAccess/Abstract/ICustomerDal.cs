using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecapProject.Core.DataAccess.EntityFramework;
using RecapProject.Entities.Concrete;

namespace RecapProject.DataAccess.Abstract
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {

    }
}