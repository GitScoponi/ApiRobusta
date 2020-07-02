using System;
using System.Collections.Generic;
using System.Text;

namespace ApiRobusta.Infra.Repositories.Transactions
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApiRobustaContext _contexto;

        public UnitOfWork(ApiRobustaContext contexto)
        {
            _contexto = contexto;
        }

        public void SaveChanges()
        {
            _contexto.SaveChanges();
        }
    }
}
