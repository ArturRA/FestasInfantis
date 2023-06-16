using FestasInfantis.Dominio.ModuloCliente;
using System.ComponentModel;
using System.Data;

namespace FestasInfantis.WinFormsApp.ModuloItemTema
{
    public partial class TabelaItemCliente : UserControl
    {
        public TabelaItemCliente(List<EntidadeCliente> listaDeEntidades)
        {
            InitializeComponent();

            AtualizarRegistros(listaDeEntidades);

            grid.ConfigurarGridZebrado();

            grid.ConfigurarGridSomenteLeitura();
        }

        public void AtualizarRegistros(List<EntidadeCliente> listaDeEntidades)
        {
            BindingList<EntidadeCliente> bindingList = new BindingList<EntidadeCliente>(listaDeEntidades);
            BindingSource source = new BindingSource(bindingList, null);
            grid.DataSource = source;
        }

        public EntidadeCliente? ObterEntidadeSelecionada()
        {
            List<DataGridViewRow> rows = grid.SelectedRows.Cast<DataGridViewRow>().ToList();
            if (rows.Count > 0)
            {
                return rows[0].DataBoundItem as EntidadeCliente;
            }
            return null;
        }
    }
}
