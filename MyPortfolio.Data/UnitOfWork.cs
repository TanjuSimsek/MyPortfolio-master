using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolio.Data
{
    // birden fazla repository işlemini tek bir transaction içinde çalıştırmayı sağlar
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext db;
        public UnitOfWork(ApplicationDbContext db)
        {
            this.db = db;
        }
        public void SaveChanges()
        {
            db.SaveChanges();
        }
    }
}
