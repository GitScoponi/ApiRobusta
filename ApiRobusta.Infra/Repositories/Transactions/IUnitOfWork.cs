using System;
using System.Collections.Generic;
using System.Text;

namespace ApiRobusta.Infra.Repositories.Transactions
{
    public interface IUnitOfWork
    {
        void SaveChanges(); 
    }
}
