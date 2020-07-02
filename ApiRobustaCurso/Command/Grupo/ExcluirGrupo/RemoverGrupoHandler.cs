using ApiRobustaCurso.Interfaces.Repositories;
using MediatR;
using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApiRobustaCurso.Command.Grupo.ExcluirGrupo
{
    public class RemoverGrupoHandler : Notifiable, IRequestHandler<RemoverGrupoRequest, Response>
    {
        private readonly IMediator _mediator;
        private readonly IRepositoryGrupo _repository;

        public RemoverGrupoHandler(IMediator mediator, IRepositoryGrupo repository)
        {
            _mediator = mediator;
            _repository = repository;
        }

        public async Task<Response> Handle(RemoverGrupoRequest request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                AddNotification("Request", "Request é obrigatório");
                return new Response(this);
            }
            Entities.Grupo grupo = _repository.ObterPorId(request.Id);

            if(grupo == null)
            {
                AddNotification("Request", "Grupo não encontrado!");
                return new Response(this);
            }
            _repository.Remover(grupo);
            var result = new { Id = grupo.Id };
            var response = new Response(this);

            RemoverGrupoNotification removerGrupoNotification = new RemoverGrupoNotification(grupo);
            await _mediator.Publish(removerGrupoNotification);
            return await Task.FromResult(response);



        }
    }
}
