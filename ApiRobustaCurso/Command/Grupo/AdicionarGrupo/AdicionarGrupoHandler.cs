using ApiRobustaCurso.Interfaces.Repositories;
using MediatR;
using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApiRobustaCurso.Command.Grupo.AdicionarGrupo
{
    class AdicionarGrupoHandler : Notifiable, IRequestHandler<AdicionarGrupoRequest, Response>
    {
        private readonly IMediator _mediator;
        private readonly IRepositoryGrupo _repositoryGrupo;
        private readonly IRepositoryUsuario _repositoryUsuario;

        public AdicionarGrupoHandler(IMediator mediator, IRepositoryGrupo repositoryGrupo, IRepositoryUsuario repositoryUsuario)
        {
            _mediator = mediator;
            _repositoryGrupo = repositoryGrupo;
            _repositoryUsuario = repositoryUsuario;
        }

        public async Task<Response> Handle(AdicionarGrupoRequest request, CancellationToken cancellationToken)
        {
            //Validar se o requeste veio preenchido
            if (request == null)
            {
                AddNotification("Resquest", "Request Obrigarotorio");

                return new Response(this);
            }

            var usuario = _repositoryUsuario.ObterPorId(request.IdUsuario.Value);


            if (usuario == null)
            {
                AddNotification("Usuario", ("Usuário não informado"));
                return new Response(this);
            }


            Entities.Grupo grupo = new Entities.Grupo( request.Nome, request.Nicho,usuario);

            AddNotifications(grupo);

            if (IsInvalid())
            {
                return new Response(this);
            }

            grupo = _repositoryGrupo.Adicionar(grupo);

            var result = new { Id = grupo.Id, Nome = grupo.Nome, Nicho = grupo.Nicho };

            //Criar meu objeto de resposta
            var response = new Response(this, result);

            return await Task.FromResult(response);
        }
    }
}

