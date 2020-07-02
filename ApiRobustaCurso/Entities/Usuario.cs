using ApiRobustaCurso.Entities.Base;
using ApiRobustaCurso.Extensions;
using prmToolkit.NotificationPattern;
using System;

namespace ApiRobustaCurso.Entities
{

    public class Usuario: EntityBase
    {
        protected Usuario()
        {
        }

        public Usuario(string primeiroNome, string ultimoNome, string email, string senha)
        {
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;
            Email = email;
            Senha = senha;

            new AddNotifications<Usuario>(this).
                IfNullOrInvalidLength(x => x.PrimeiroNome, 3, 150).
                IfNullOrInvalidLength(x => x.UltimoNome, 3, 150).
                IfNullOrInvalidLength(x => x.Senha, 3, 32).
                IfNotEmail(x => x.Email);

            if (!string.IsNullOrEmpty(this.Senha))
            {
                this.Senha = Senha.ConvertToMD5();
            }
            DataCadastro = DateTime.Now;
            Ativo = false;
        }
        public string PrimeiroNome { get; private set; }
        public string UltimoNome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public bool Ativo { get; private set; }
    }
}
