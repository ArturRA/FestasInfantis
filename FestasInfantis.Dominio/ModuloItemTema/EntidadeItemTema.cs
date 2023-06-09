using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FestasInfantis.Dominio.ModuloItemTema
{
    public class EntidadeItemTema : Entidade<EntidadeItemTema>
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        public EntidadeItemTema()
        {
        }

        public EntidadeItemTema(string nome, decimal valor)
        {
            Nome=nome;
            Valor=valor;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();
            if (string.IsNullOrWhiteSpace(Nome))
                erros.Add("Digite um Nome valido");
            if (string.IsNullOrWhiteSpace(Valor.ToString()))
                erros.Add("Digite um Valor valido");

            return erros;
        }
    }
}
