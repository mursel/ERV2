using Entities;
using Entities.Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public class UposleniciRepository : Repository<Uposlenici>, IUposlenici
    {
        public UposleniciRepository(MainContext mainContext) :base(mainContext) { }

        public Uposlenici GetById(int id)
        {
            return Find(u => u.Id == id).FirstOrDefault();
        }
    }
}
