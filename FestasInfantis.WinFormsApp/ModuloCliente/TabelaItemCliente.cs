using FestasInfantis.Dominio.ModuloCliente;
using FestasInfantis.Dominio.ModuloItemTema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
