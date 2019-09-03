using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface IUposlenici : IRepository<Uposlenici>
    {
        Uposlenici GetById(int id);

        IEnumerable<Uposlenici> GetAllBySectorId(int id);

        Uposlenici GetByUserAndPass(string u, string p);

    }
}
