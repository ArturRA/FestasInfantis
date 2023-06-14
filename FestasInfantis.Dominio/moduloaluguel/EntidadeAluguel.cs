using FestasInfantis.Dominio.ModuloCliente;
using FestasInfantis.Dominio.ModuloTema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.Dominio.ModuloAluguel
{
    public class EntidadeAluguel : Entidade<EntidadeAluguel>
    {
        public EntidadeAluguel() { }
        public string NomeDaFesta { get; set; }
        public double Desconto { get; set; }
        public string Local { get; set; }
        public DateTime DataFim { get; set; }
        public DateTime DataInicio { get; set; }
        public EntidadeCliente Cliente { get; set; }
        public EntidadeTema Tema { get; set; }
        public DateTime DataPagamentoRestante { get; set; }

        public EntidadeAluguel(string nome, double desconto, DateTime data, DateTime dataFim, EntidadeCliente c, EntidadeTema tema, string local, DateTime DataPgto)
        {
            NomeDaFesta = nome;
            Desconto = desconto;
            DataInicio = data;
            DataFim = dataFim;
            Tema = tema;
            Cliente = c;
            Local = local;
            DataPagamentoRestante = DataPgto;
            //string dataFormatada = Data.ToString("dd/MM/yyyy HH:mm:ss");
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrWhiteSpace(Desconto.ToString()))
                erros.Add("Digite um Desconto Valido");
            if (string.IsNullOrWhiteSpace(DataInicio.ToString()))
                erros.Add("Digite uma Data Valida");
            if (string.IsNullOrWhiteSpace(DataFim.ToString()))
                erros.Add("Digite uma Data Valida");

            return erros;
        }
    }
}
