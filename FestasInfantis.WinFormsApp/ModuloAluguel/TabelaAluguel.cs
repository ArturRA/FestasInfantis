using FestasInfantis.Dominio.ModuloAluguel;
using FestasInfantis.Dominio.ModuloTema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestasInfantis.WinFormsApp.ModuloAluguel
{
    public partial class TabelaAluguel : UserControl
    {
        public TabelaAluguel(List<EntidadeAluguel> alugueis)
        {
            InitializeComponent();

            AtualizarRegistros(alugueis);

            grid.ConfigurarGridZebrado();

            grid.ConfigurarGridSomenteLeitura();
        }

        public void AtualizarRegistros(List<EntidadeAluguel> alugueis)
        {
            BindingList<EntidadeAluguel> bindingList = new BindingList<EntidadeAluguel>(alugueis);
            BindingSource source = new BindingSource(bindingList, null);
            grid.DataSource = source;
        }

        public EntidadeAluguel? ObterEntidadeSelecionada()
        {
            List<DataGridViewRow> rows = grid.SelectedRows.Cast<DataGridViewRow>().ToList();
            if (rows.Count > 0)
            {
                return rows[0].DataBoundItem as EntidadeAluguel;
            }
            return null;
        }
    }
}
