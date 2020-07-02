using ApiRobustaCurso.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiRobustaCurso.Command.Grupo
{
    public class AdicionarGrupoRequest: IRequest<Response>
    {
       

        public Guid? IdUsuario { get; set; }
        public string Nome { get;  set; }
        public EnumsNicho Nicho { get;  set; }
    }
}
