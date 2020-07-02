using ApiRobusta.Infra.Repositories.Base;
using ApiRobustaCurso.Entities;
using ApiRobustaCurso.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiRobusta.Infra.Repositories
{
    public class RepositoryUsuario : RepositoryBase<Usuario, Guid>, IRepositoryUsuario
    {
        private readonly ApiRobustaContext _context;
        public RepositoryUsuario(ApiRobustaContext context) : base(context)
        {
            _context = context;
        }
    }
}
