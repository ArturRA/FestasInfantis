using FestasInfantis.Dominio.ModuloAluguel;
using System.Text.RegularExpressions;

namespace FestasInfantis.Dominio.ModuloCliente
{
    public class EntidadeCliente : Entidade<EntidadeCliente>
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public bool Antigo { get; set; }
        public List<EntidadeAluguel> Alugueis { get; set; }

        public EntidadeCliente() { }
        public EntidadeCliente(string nome, string telefone, string email, bool antigo)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Antigo = antigo;
            Alugueis = new List<EntidadeAluguel>();
        }

        public override List<string> Validar()
        {
            List<string> listaErros = new List<string>();

            if (string.IsNullOrEmpty(Nome))
                listaErros.Add("O campo 'nome' não pode estar vazio");

            if (string.IsNullOrWhiteSpace(Telefone) || Telefone.Trim().Length < 14)
                listaErros.Add("O campo 'telefone' não pode estar vazio");

            Regex validarEmail = new Regex("^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$");
            if (string.IsNullOrWhiteSpace(Email) || !validarEmail.IsMatch(Email))
                listaErros.Add("O campo 'email' não pode estar vazio");

            return listaErros;
        }

        public override string? ToString()
        {
            return Nome;
        }

        public void AdicionarAluguel(EntidadeAluguel entidade)
        {
            if (!Alugueis.Any(e => e.Id == entidade.Id))
                Alugueis.Add(entidade);
        }

        public void RemoverAluguel(EntidadeAluguel entidade)
        {
            if (Alugueis.Any(e => e.Id == entidade.Id))
                Alugueis.Remove(Alugueis.Single(e => e.Id == entidade.Id));
        }
    }
}
