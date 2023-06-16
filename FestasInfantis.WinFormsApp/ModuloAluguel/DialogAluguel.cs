using FestasInfantis.Dominio.ModuloAluguel;
using FestasInfantis.Dominio.ModuloCliente;
using FestasInfantis.Dominio.ModuloTema;

namespace FestasInfantis.WinFormsApp.ModuloAluguel
{
    public partial class DialogAluguel : Form
    {
        public EntidadeAluguel aluguel;
        private List<EntidadeAluguel> Alugueis { get; set; }

        public DialogAluguel(List<EntidadeTema> temas, List<EntidadeCliente> clientes, List<EntidadeAluguel> alugueis)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            this.Alugueis = alugueis;

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

            List<string> resultado = aluguel.Validar(Alugueis);

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

        private void btnValor_Click(object sender, EventArgs e)
        {
            EntidadeTema tema = (EntidadeTema)cmbTema.SelectedItem;

            EntidadeCliente cliente = (EntidadeCliente)cmbCliente.SelectedItem;

            double desconto = Convert.ToDouble(txtDesconto.Text);

            EntidadeAluguel valorAluguel = new EntidadeAluguel(desconto, cliente, tema);

            List<string> resultado = valorAluguel.ValidarValor();

            if (resultado.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarToolStrip(resultado[0]);
            }
            else
            {
                decimal valor;

                valor = tema.ValorItens;

                if (cliente.Antigo == true)
                {
                    valor = Math.Round(valor - (valor * Convert.ToDecimal((desconto / 100))), 2);
                }

                txtValor.Text = Convert.ToString(valor);

                decimal entrada = Math.Round(valor * Convert.ToDecimal((tema.PorcentagemEntrada / 100)), 2);

                txtEntrada.Text = Convert.ToString(entrada);

                TelaPrincipalForm.Instancia.AtualizarToolStrip("");
            }
        }
    }
}

