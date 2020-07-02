﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiRobustaCurso.Command.Usuario.AdicionarUsuario
{
    public class AdicionarUsuarioRequest : IRequest<Response>
    {
        public string PrimeiroNome { get;  set; }
        public string UltimoNome { get;  set; }
        public string Email { get;  set; }
        public string Senha { get;  set; }
    }
}
