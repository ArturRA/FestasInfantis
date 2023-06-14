using FestasInfantis.Dominio.Compartilhado;
using FestasInfantis.Dominio.ModuloAluguel;
using FestasInfantis.Dominio.ModuloCliente;
using FestasInfantis.Dominio.ModuloItemTema;
using FestasInfantis.Dominio.ModuloTema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestasInfantis.WinFormsApp.ModuloAluguel
{
    public partial class DialogAluguel : Form
    {
        public EntidadeAluguel aluguel;
        private List<EntidadeTema> temas;
        private List<EntidadeCliente> clientes;

        public DialogAluguel(List<EntidadeTema> temas, List<EntidadeCliente> clientes)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            this.temas = temas;

            this.clientes = clientes;

            cmbCliente.DisplayMember = "Nome";
            cmbCliente.ValueMember = "Id";
            cmbCliente.DataSource = clientes;

            cmbTema.DisplayMember = "Nome";
            cmbTema.ValueMember = "Id";
            cmbTema.DataSource = temas;
        }

        public EntidadeAluguel Aluguel
        {
            get
            {
                return aluguel;
            }
            set
            {
                aluguel = value;
                labelId.Text = aluguel.Id.ToString();
                txtNome.Text = aluguel.NomeDaFesta;
                cmbTema.SelectedItem = aluguel.Tema;
                txtLocal.Text = aluguel.Local;
                dtpDataInicio.Value = aluguel.DataInicio;
                dtpDataFim.Value = aluguel.DataFim;
                cmbCliente.SelectedItem = aluguel.Cliente;
                txtDesconto.Text = Convert.ToString(aluguel.Desconto);
                dtpPagamento.Value = aluguel.DataPagamentoRestante;

            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            EntidadeTema tema = (EntidadeTema)cmbTema.SelectedItem;

            string local = txtLocal.Text;

            DateTime dataInicio = dtpDataInicio.Value;

            DateTime dataFim = dtpDataFim.Value;

            EntidadeCliente cliente = (EntidadeCliente)cmbCliente.SelectedItem;

            double desconto = Convert.ToDouble(txtDesconto.Text);

            DateTime dataPgto = dtpPagamento.Value;

            aluguel = new EntidadeAluguel(nome, desconto, dataInicio, dataFim, cliente, tema, local, dataPgto);

            List<string> resultado = aluguel.Validar();

            if (resultado.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarToolStrip(resultado[0]);
                DialogResult = DialogResult.None;
            }
            else
            {
                bool edicao = labelId.Text != "0";

                if (edicao)
                    aluguel.Id = Convert.ToInt32(labelId.Text);
                TelaPrincipalForm.Instancia.AtualizarToolStrip("");
            }

        }
    }
}
