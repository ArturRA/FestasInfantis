using FestasInfantis.Dominio.ModuloTema;
using System.ComponentModel;

namespace FestasInfantis.WinFormsApp.ModuloTema
{
    public partial class TabelaTema : UserControl
    {
        public TabelaTema(List<EntidadeTema> temas)
        {
            InitializeComponent();

            AtualizarRegistros(temas);

            grid.ConfigurarGridZebrado();

            grid.ConfigurarGridSomenteLeitura();
        }

        public void AtualizarRegistros(List<EntidadeTema> temas)
        {
            BindingList<EntidadeTema> bindingList = new BindingList<EntidadeTema>(temas);
            BindingSource source = new BindingSource(bindingList, null);
            grid.DataSource = source;
        }

        public EntidadeTema? ObterEntidadeSelecionada()
        {
            List<DataGridViewRow> rows = grid.SelectedRows.Cast<DataGridViewRow>().ToList();
            if (rows.Count > 0)
            {
                return rows[0].DataBoundItem as EntidadeTema;
            }
            return null;
        }
    }
}
