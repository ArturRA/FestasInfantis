using FestasInfantis.Dominio.ModuloAluguel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.Infra.Dados.Arquivo.ModuloAluguel
{
    public class RepositorioAluguelEmArquivo : RepositorioEmArquivo<EntidadeAluguel>, IRepositorioAluguel
    {
        public RepositorioAluguelEmArquivo(ContextoDados contexto) : base(contexto)
        {

        }
        protected override List<EntidadeAluguel> ObterRegistros()
        {
            return ContextoDados.Aluguel;
        }
    }
}
