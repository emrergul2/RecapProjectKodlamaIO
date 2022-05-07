using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecapProject.DataAccess.Abstract;
using RecapProject.Entities.Concrete;

namespace RecapProject.DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using (RecapProjectContext context = new RecapProjectContext())
            {
                var addedBrand = context.Entry(entity);
                addedBrand.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Delete(Brand entity)
        {
            using (RecapProjectContext context = new RecapProjectContext())
            {
                var deletedBrand = context.Entry(entity);
                deletedBrand.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (RecapProjectContext context = new RecapProjectContext())
            {
                return context.Set<Brand>().FirstOrDefault(filter);
            }
        }
        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (RecapProjectContext context = new RecapProjectContext())
            {
                return filter == null
                    ? context.Set<Brand>().ToList()
                    : context.Set<Brand>().Where(filter).ToList();
            }
        }
        public void Update(Brand entity)
        {
            using (RecapProjectContext context = new RecapProjectContext())
            {
                var updatedBrand = context.Entry(entity);
                updatedBrand.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}