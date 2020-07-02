using MediatR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApiRobustaCurso.Command.Usuario.AdicionarUsuario.Notifications
{
    class EnviarEmailDeAtivacaoDoUsuario : INotificationHandler<AdicionaUsuarioNotification>
    {
        public async Task Handle(AdicionaUsuarioNotification notification, CancellationToken cancellationToken)
        {
            Debug.WriteLine("Enviar email para usuario " + notification.Usuario.PrimeiroNome);
        }
    }
}
