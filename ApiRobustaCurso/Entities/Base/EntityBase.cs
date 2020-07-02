using prmToolkit.NotificationPattern;
using System;

namespace ApiRobustaCurso.Entities.Base
{
    public abstract class EntityBase : Notifiable
    {
        protected EntityBase()
        {
            Id = new Guid();
        }
        public Guid Id { get; private set; }
    }
}
