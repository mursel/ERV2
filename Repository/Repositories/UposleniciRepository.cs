using Entities;
using Entities.Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories
{
    public class UposleniciRepository : Repository<Uposlenici>, IUposlenici
    {
        public UposleniciRepository(MainContext mainContext) :base(mainContext) { }
    }
}
