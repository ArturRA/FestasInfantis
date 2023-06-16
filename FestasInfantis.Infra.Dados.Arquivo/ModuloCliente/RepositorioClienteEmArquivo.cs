using FestasInfantis.Dominio.ModuloCliente;

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
