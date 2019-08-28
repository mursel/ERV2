using Entities;
using Repository.Interfaces;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private IUposlenici uposlenici;
        private MainContext mainContext;

        public IUposlenici Uposlenici
        {
            get
            {
                if(uposlenici == null)
                {
                    return new UposleniciRepository(mainContext);
                }
                return uposlenici;
            }
        }

        public UnitOfWork(MainContext _mainContext) => this.mainContext = _mainContext;

        public void SaveChanges()
        {
            mainContext.SaveChanges();
        }
    }
}
