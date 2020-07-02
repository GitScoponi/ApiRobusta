using ApiRobustaCurso.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiRobustaCurso.Command.Grupo.ExcluirGrupo
{
   public class RemoverGrupoNotification: INotification
    {
        public RemoverGrupoNotification(Entities.Grupo grupo)
        {
            Grupo = grupo;
        }

        public Entities.Grupo Grupo { get; set; }
    }
}
