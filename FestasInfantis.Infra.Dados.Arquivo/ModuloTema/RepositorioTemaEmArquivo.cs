using FestasInfantis.Dominio.ModuloTema;
using FestasInfantis.Infra.Dados.Arquivo.Compartilhado;

namespace FestasInfantis.Infra.Dados.Arquivo.ModuloTema
{
    public class RepositorioTemaEmArquivo : RepositorioEmArquivo<EntidadeTema>, IRepositorioTema
    {

        public RepositorioTemaEmArquivo(ContextoDados contextoDados) : base(contextoDados)
        {
        }

        protected override List<EntidadeTema> ObterRegistros()
        {
            return ContextoDados.Temas;
        }
    }
}
