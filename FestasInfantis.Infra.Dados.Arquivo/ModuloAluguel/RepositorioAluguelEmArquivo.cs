using FestasInfantis.Dominio.ModuloAluguel;

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
