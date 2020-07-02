using ApiRobustaCurso.Entities.Base;

namespace ApiRobustaCurso.Entities
{
    public class Envio: EntityBase
    {
        protected Envio()
        {
        }
        public Campanha Campanha { get; private set; }
        public Grupo Grupo { get; private set; }
        public Contato Contato { get; private set; }
        public bool Enviado { get; private set; }
    }
}

