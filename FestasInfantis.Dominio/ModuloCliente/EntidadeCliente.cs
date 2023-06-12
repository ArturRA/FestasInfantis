using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.Dominio.ModuloCliente
{
    public class EntidadeCliente : Entidade<EntidadeCliente>
    {
        private string nome;
        private string telefone;
        private string email;

        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }

        public EntidadeCliente(int id, string nome, string telefone, string email)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }

        public override List<string> Validar()
        {
            List<string> listaErros = new();

            if (string.IsNullOrEmpty(nome)) listaErros.Add("O campo 'nome' não pode estar vazio");

            if (string.IsNullOrEmpty(telefone)) listaErros.Add("O campo 'telefone' não pode estar vazio");

            if (string.IsNullOrEmpty(email)) listaErros.Add("O campo 'email' não pode estar vazio");

            return listaErros;
        }
    }
}
