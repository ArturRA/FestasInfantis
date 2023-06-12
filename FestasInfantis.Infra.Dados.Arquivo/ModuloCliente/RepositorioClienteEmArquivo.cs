using FestasInfantis.Dominio.ModuloCliente;
using FestasInfantis.Dominio.ModuloItemTema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.Infra.Dados.Arquivo.ModuloCliente
{
    public class RepositorioClienteEmArquivo : RepositorioEmArquivo<EntidadeCliente>, IRepositorioCliente
    {
        public RepositorioClienteEmArquivo(ContextoDados contexto) : base(contexto)
        {

        }
        protected override List<EntidadeCliente> ObterRegistros()
        {
            return ContextoDados.Clientes;
        }
    }
}
