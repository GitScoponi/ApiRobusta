using ApiRobustaCurso.Entities;
using ApiRobustaCurso.Interfaces.Repositories.Base;
using System;

namespace ApiRobustaCurso.Interfaces.Repositories
{
    public interface IRepositoryUsuario : IRepositoryBase<Usuario,Guid>
    {
    }
}
