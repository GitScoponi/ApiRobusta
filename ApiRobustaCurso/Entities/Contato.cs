using ApiRobustaCurso.Entities.Base;
using ApiRobustaCurso.Enums;

namespace ApiRobustaCurso.Entities
{
    public  class Contato :EntityBase
    {
        protected Contato()
        {
        }
        public string Nome { get; private set; }
        public string Telefone { get; private set; }
        public EnumsNicho Nicho { get; private set; }
        public Usuario Usuario { get;private set; }
    }
}
