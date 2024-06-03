using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (ETradeContext context = new ETradeContext(new DbContextOptionsBuilder<ETradeContext>().UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ETrade;Integrated Security=True").Options))
            {
                return context.Products.ToList();
            }
        }

        public List<Product> GetByName(string key)
        {
            using (ETradeContext context = new ETradeContext(new DbContextOptionsBuilder<ETradeContext>().UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ETrade;Integrated Security=True").Options))
            {
                return context.Products.Where(p => p.Name.Contains(key)).ToList();
            }
        }

        public List<Product> GetByUnitePrice(decimal price)
        {
            using (ETradeContext context = new ETradeContext(new DbContextOptionsBuilder<ETradeContext>().UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ETrade;Integrated Security=True").Options))
            {
                return context.Products.Where(p => p.UnitePrice>=price).ToList();
            }
        }

        public List<Product> GetByUnitePrice(decimal min, decimal max)
        {
            using (ETradeContext context = new ETradeContext(new DbContextOptionsBuilder<ETradeContext>().UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ETrade;Integrated Security=True").Options))
            {
                return context.Products.Where(p => p.UnitePrice >= min && p.UnitePrice<=max).ToList();
            }
        }

        public Product GetById(int id)
        {
            using (ETradeContext context = new ETradeContext(new DbContextOptionsBuilder<ETradeContext>().UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ETrade;Integrated Security=True").Options))
            {
                return context.Products.FirstOrDefault(p => p.Id == id);
            }
        }


        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext(new DbContextOptionsBuilder<ETradeContext>().UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ETrade;Integrated Security=True").Options))
            {
                //context.Products.Add(product);
                var entity = context.Entry(product);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (ETradeContext context = new ETradeContext(new DbContextOptionsBuilder<ETradeContext>().UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ETrade;Integrated Security=True").Options))
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext(new DbContextOptionsBuilder<ETradeContext>().UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ETrade;Integrated Security=True").Options))
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
