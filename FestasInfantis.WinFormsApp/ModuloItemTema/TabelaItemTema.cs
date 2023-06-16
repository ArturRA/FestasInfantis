using FestasInfantis.Dominio.ModuloItemTema;
using System.ComponentModel;
using System.Data;

namespace FestasInfantis.WinFormsApp.ModuloItemTema
{
    public partial class TabelaItemTema : UserControl
    {
        public TabelaItemTema(List<EntidadeItemTema> listaDeEntidades)
        {
            InitializeComponent();

            AtualizarRegistros(listaDeEntidades);

            grid.ConfigurarGridZebrado();

            grid.ConfigurarGridSomenteLeitura();
        }

        // TODO a variavel de auxilio "Marcado" da EntidadeItemTema está aparecendo na apresentação dos itens pela tabela
        public void AtualizarRegistros(List<EntidadeItemTema> listaDeEntidades)
        {
            BindingList<EntidadeItemTema> bindingList = new BindingList<EntidadeItemTema>(listaDeEntidades);
            BindingSource source = new BindingSource(bindingList, null);
            grid.DataSource = source;
        }

        public EntidadeItemTema? ObterEntidadeSelecionada()
        {
            List<DataGridViewRow> rows = grid.SelectedRows.Cast<DataGridViewRow>().ToList();
            if (rows.Count > 0)
            {
                return rows[0].DataBoundItem as EntidadeItemTema;
            }
            return null;
        }
    }
}
