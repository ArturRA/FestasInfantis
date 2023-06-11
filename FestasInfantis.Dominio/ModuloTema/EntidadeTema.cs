using FestasInfantis.Dominio.ModuloItemTema;
using System.Drawing;

namespace FestasInfantis.Dominio.ModuloTema
{
    public class EntidadeTema : Entidade<EntidadeTema>
    {
        public string Nome { get; set; }
        public List<EntidadeItemTema> Itens { get; set; }
        // TODO public List<EntidadeAluguel> Alugueis { get; set; } Criar entidade Aluguel
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

        public void EncontrarESelecionar(EntidadeItemTema item)
        {
            if (this.Itens.Contains(item))
            {
                EntidadeItemTema itemEncontrado = this.Itens.FirstOrDefault(x => x.Equals(item));

                itemEncontrado.Selecionar();
            }
        }

        public void EncontrarEDeselecionar(EntidadeItemTema item)
        {
            if (this.Itens.Contains(item))
            {
                EntidadeItemTema itemEncontrado = this.Itens.FirstOrDefault(x => x.Equals(item));

                itemEncontrado.Deselecionar();
            }
        }
    }
}
