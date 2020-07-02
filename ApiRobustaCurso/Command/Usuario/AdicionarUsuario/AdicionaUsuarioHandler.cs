using ApiRobustaCurso.Interfaces.Repositories;
using MediatR;
using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApiRobustaCurso.Command.Usuario.AdicionarUsuario
{
    class AdicionaUsuarioHandler :Notifiable, IRequestHandler<AdicionarUsuarioRequest, Response>
    {
        public readonly IRepositoryUsuario _repositoryUsuario;
        public readonly IMediator _mediator;

        public AdicionaUsuarioHandler(IRepositoryUsuario repositoryUsuario, IMediator mediator)
        {
            _repositoryUsuario = repositoryUsuario;
            _mediator = mediator;
        }

        public async Task<Response> Handle(AdicionarUsuarioRequest request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                AddNotification("Request", "Informe os dados do usuário!");
                return new Response(this);
            }
            if (_repositoryUsuario.Existe(x => x.Email == request.Email))
            {
                AddNotification("Email", "E-mail já cadastrado no sistema!");
                return new Response(this);
            }
            Entities.Usuario usuario = new Entities.Usuario(request.PrimeiroNome,request.UltimoNome,request.Email,request.Senha);
            AddNotifications(usuario);
            if (IsInvalid())
            {
                return new Response(this);
            }
            usuario = _repositoryUsuario.Adicionar(usuario);
            var response = new Response(this, usuario);
            AdicionaUsuarioNotification adicionaUsuarioNotification = new AdicionaUsuarioNotification(usuario);
            await _mediator.Publish(adicionaUsuarioNotification);
            return await Task.FromResult(response);
            
        }
    }
}
