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

            CarregarTemas(temas);

            CarregarClientes(clientes);
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

            }
        }

        public void CarregarTemas(List<EntidadeTema> temas)
        {
            temas.ForEach(t => cmbTema.Items.Add(t));
        }

        public void CarregarClientes(List<EntidadeCliente> clientes)
        {
            clientes.ForEach(c => cmbCliente.Items.Add(c));
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            EntidadeTema tema = (EntidadeTema)cmbTema.SelectedValue;

            string local = txtLocal.Text;

            DateTime dataInicio = dtpDataInicio.Value;

            DateTime dataFim = dtpDataFim.Value;

            EntidadeCliente cliente = (EntidadeCliente)cmbCliente.SelectedValue;

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
