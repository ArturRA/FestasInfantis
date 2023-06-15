using FestasInfantis.Dominio.ModuloAluguel;
using FestasInfantis.Dominio.ModuloItemTema;
using System.Drawing;

namespace FestasInfantis.Dominio.ModuloTema
{
    public class EntidadeTema : Entidade<EntidadeTema>
    {
        public string Nome { get; set; }
        public List<EntidadeItemTema> Itens { get; set; }
        public List<EntidadeAluguel> Alugueis { get; set; }
        public double PorcentagemEntrada { get; set; }
        public decimal ValorItens { get; set; }

        public EntidadeTema()
        {
        }

        public EntidadeTema(string nome, double porcentagemEntrada)
        {
            Nome = nome;
            Itens = new List<EntidadeItemTema>();
            PorcentagemEntrada = porcentagemEntrada;
            Alugueis = new List<EntidadeAluguel>();
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrWhiteSpace(Nome))
                erros.Add("Digite um Nome valido");
            if (string.IsNullOrWhiteSpace(PorcentagemEntrada.ToString()))
                erros.Add("Digite uma Porcentagem de entrada valida");

            return erros;
        }

        public void AdicionarItemTema(EntidadeItemTema entidade)
        {
            if (!Itens.Any(e => e.Id == entidade.Id))
                Itens.Add(entidade);
        }

        public void RemoverItemTema(EntidadeItemTema entidade)
        {
            if (Itens.Any(e => e.Id == entidade.Id))
                Itens.Remove(Itens.Single(e => e.Id == entidade.Id));
        }

        public void AtualziarValorItens()
        {
            ValorItens = 0;
            ValorItens = Itens.Sum(itemTema => itemTema.Valor);
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
