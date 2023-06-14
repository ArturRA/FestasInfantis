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
        public DateTime Data { get; set; }
        public EntidadeCliente Cliente { get; set; }
        public List<EntidadeTema> Temas { get; set; }

        public EntidadeAluguel(string nome, double desconto, DateTime data, EntidadeCliente c)
        {
            NomeDaFesta = nome;
            Desconto = desconto;
            Data = data;
            Temas = new();
            Cliente = c;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrWhiteSpace(Desconto.ToString()))
                erros.Add("Digite um Desconto Valido");
            if (string.IsNullOrWhiteSpace(Data.ToString()))
                erros.Add("Digite uma Data Valida");

            return erros;
        }
    }
}
