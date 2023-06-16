using FestasInfantis.Dominio.ModuloItemTema;

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
