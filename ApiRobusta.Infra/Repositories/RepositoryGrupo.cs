using ApiRobusta.Infra.Repositories.Base;
using ApiRobustaCurso.Entities;
using ApiRobustaCurso.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiRobusta.Infra.Repositories
{
    public class RepositoryGrupo : RepositoryBase<Grupo, Guid>, IRepositoryGrupo
    {
        private readonly ApiRobustaContext _context;
        public RepositoryGrupo(ApiRobustaContext context) : base(context)
        {
            _context = context;
        }
    }
}
