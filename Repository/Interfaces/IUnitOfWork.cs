using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface IUnitOfWork
    {
        IUposlenici Uposlenici { get; }
        void SaveChanges();
    }
}
