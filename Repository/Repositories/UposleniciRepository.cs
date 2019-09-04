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

        public IEnumerable<Uposlenici> GetAllBySectorId(int id)
        {
            return Find(u => u.SektorId == id).ToList();
        }

        public Uposlenici GetById(int id)
        {
            return Find(u => u.Id == id).FirstOrDefault();
        }

        public Uposlenici GetByUserAndPass(string u, string p)
        {
            var uposlenik = Find(a => a.Username == u && a.Password == p).FirstOrDefault();
            uposlenik = Find(a => a.Username == u && a.Password == p).SingleOrDefault();
            var uposlenici = Find(a => a.Username == u && a.Password == p);
            return uposlenik;
        }
    }
}
