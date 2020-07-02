using ApiRobustaCurso.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiRobustaCurso.Command.Grupo.AlterarGrupo
{
    public class AlterarGrupoRequest : IRequest<Response>
    {
        public Guid? IdGrupo { get; set; }
        public Guid? IdUsuario { get; set; }
        public string Nome { get; set; }
        public EnumsNicho Nicho { get; set; }
    }
}
