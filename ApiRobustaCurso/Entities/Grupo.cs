using System;
using ApiRobustaCurso.Command.Grupo.AlterarGrupo;
using ApiRobustaCurso.Entities.Base;
using ApiRobustaCurso.Enums;
using prmToolkit.NotificationPattern;

namespace ApiRobustaCurso.Entities
{
    public  class Grupo: EntityBase
    {
        public Grupo(string nome, EnumsNicho nicho, Usuario usuario)
        {
            Nome = nome;
            Nicho = nicho;
            Usuario = usuario;

            if (usuario == null) AddNotification("Usuario","Informe o usuário"); 
            new AddNotifications<Grupo>(this).
                IfNullOrInvalidLength(x => x.Nome, 3, 150).
                IfEnumInvalid(x=>x.Nicho);
            
              
        }

        protected Grupo()
        {
        }
        public string Nome { get;  set; }
        public EnumsNicho Nicho { get;  set; }
        public Usuario Usuario { get; set; }

      public void Atualizar (string nome, EnumsNicho nicho)
        {
            this.Nicho = nicho;
            this.Nome = nome;
        }
    }
}
