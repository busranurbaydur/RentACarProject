using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (RentACarDbContext context = new RentACarDbContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (RentACarDbContext context = new RentACarDbContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter) //tek data getirecek
        {
            using (RentACarDbContext context = new RentACarDbContext())
            {
                return context.Set<Car>().SingleOrDefault(filter); //car tablosunu döndürecek
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (RentACarDbContext context = new RentACarDbContext())
            {
                return filter == null
                    ? context.Set<Car>().ToList() //Filtre yoksa çalışır
                    : context.Set<Car>().Where(filter).ToList(); //Filtre varsa  çalışır.
            }
        }

        public void Update(Car entity)
        {
            using (RentACarDbContext context = new RentACarDbContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
