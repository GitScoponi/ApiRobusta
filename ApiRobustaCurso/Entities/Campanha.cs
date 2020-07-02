using ApiRobustaCurso.Entities.Base;

namespace ApiRobustaCurso.Entities
{
    public class Campanha : EntityBase
    {
        protected Campanha()
        {
        }
        public string Nome { get; private set; }
        public Usuario Usuario { get; set; }
    }
}
