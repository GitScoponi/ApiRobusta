using prmToolkit.NotificationPattern;
using System.Collections.Generic;

namespace ApiRobustaCurso.Command
{
   public class Response
    {
        public Response (INotifiable notifiable)
        {
            this.Success = notifiable.IsInvalid();
            this.Notifications = notifiable.Notifications;
        }
        public Response(INotifiable notifiable, object Data)
        {
            this.Success = notifiable.IsInvalid();
            this.Notifications = notifiable.Notifications;
            this.Data = Data;
        }
        public IEnumerable<Notification> Notifications { get; }
        public bool Success { get; private set; }
        public object Data { get; private set; }

        //public void SetResult<TData>(TData data) where TData : class;
        //public void SetResult(object data);
    }
}
