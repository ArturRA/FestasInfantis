using FestasInfantis.Dominio.ModuloItemTema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.Infra.Dados.Arquivo.ModuloItemTema
{
    public class RepositorioItemTemaEmArquivo : RepositorioEmArquivo<EntidadeItemTema>, IRepositorioItemTema
    {
        public RepositorioItemTemaEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<EntidadeItemTema> ObterRegistros()
        {
            return ContextoDados.ItensTemas;
        }
    }
}
