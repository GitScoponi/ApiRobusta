using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiRobustaCurso.Command.Grupo.ExcluirGrupo
{
    public class RemoverGrupoRequest: IRequest<Response>
    {
        public RemoverGrupoRequest(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
