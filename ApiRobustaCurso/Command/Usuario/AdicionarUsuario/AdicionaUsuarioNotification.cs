using ApiRobustaCurso.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiRobustaCurso.Command.Usuario.AdicionarUsuario
{
    class AdicionaUsuarioNotification: INotification
    {
        public AdicionaUsuarioNotification(Entities.Usuario usuario)
        {
            Usuario = usuario;
        }

        public Entities.Usuario Usuario { get; set; }
    }
}
