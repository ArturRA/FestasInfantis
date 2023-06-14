using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.Dominio.ModuloCliente
{
    public class EntidadeCliente : Entidade<EntidadeCliente>
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public EntidadeCliente() { } //Não sei por que se eu não colocar aqui uma EntidadeCliente vazia ele só não deserializa
        public EntidadeCliente(string nome, string telefone, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }

        public override List<string> Validar()
        {
            List<string> listaErros = new();

            if (string.IsNullOrEmpty(Nome)) listaErros.Add("O campo 'nome' não pode estar vazio");

            if (string.IsNullOrEmpty(Telefone)) listaErros.Add("O campo 'telefone' não pode estar vazio");

            if (string.IsNullOrEmpty(Email)) listaErros.Add("O campo 'email' não pode estar vazio");

            return listaErros;
        }
    }
}
