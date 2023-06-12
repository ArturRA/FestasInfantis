using FestasInfantis.Dominio.ModuloCliente;
using FestasInfantis.Dominio.ModuloItemTema;
using FestasInfantis.Infra.Dados.Arquivo.Compartilhado;
using FestasInfantis.Infra.Dados.Arquivo.ModuloCliente;
using FestasInfantis.Infra.Dados.Arquivo.ModuloItemTema;
using FestasInfantis.WinFormsApp.ModuloCliente;
using FestasInfantis.WinFormsApp.ModuloItemTema;

namespace FestasInfantis.WinFormsApp
{
    public partial class TelaPrincipalForm : Form
    {
        public static TelaPrincipalForm Instancia { get; set; }

        private Controlador Controlador { get; set; }

        private ContextoDados ContextoDados { get; set; } = new ContextoDados(carregarDados: true);
        //private IRepositorioCategoria RepositorioCategoria { get; set; }   Aluguel
        private IRepositorioCliente repositorioCliente { get; set; }
        private IRepositorioItemTema RepositorioItemTema { get; set; }
        //private IRepositorioContato RepositorioContato { get; set; }    Tema



        public TelaPrincipalForm()
        {
            InitializeComponent();
            ConfigurarRepositorios();
            Instancia=this;
        }

        private void ConfigurarRepositorios()
        {
            //RepositorioCategoria = new RepositorioCategoriaEmArquivo(ContextoDados);      Aluguel
            repositorioCliente = new RepositorioClienteEmArquivo(ContextoDados);
            RepositorioItemTema = new RepositorioItemTemaEmArquivo(ContextoDados);
            //RepositorioContato = new RepositorioContatoEmArquivo(ContextoDados);     Tema
        }

        public void AtualizarToolStrip(string text)
        {
            statusLabelTelaPrincipal.Text = text;
        }

        private void alugueisMenuItem_Click(object sender, EventArgs e)
        {
            //Controlador = new ControladorCompromisso(RepositorioCompromisso, RepositorioContato);

            ConfigurarTelaPrincipal(Controlador);
        }

        private void clientesMenuItem_Click(object sender, EventArgs e)
        {
            Controlador = new ControladorCliente(repositorioCliente);

            ConfigurarTelaPrincipal(Controlador);
        }

        private void temasMenuItem_Click(object sender, EventArgs e)
        {
            //Controlador = new ControladorTarefa(RepositorioTarefa);

            ConfigurarTelaPrincipal(Controlador);
        }

        private void itensTemaMenuItem_Click(object sender, EventArgs e)
        {
            Controlador = new ControladorItemTema(RepositorioItemTema);

            ConfigurarTelaPrincipal(Controlador);
        }

        private void ConfigurarTelaPrincipal(Controlador controladorBase)
        {
            labelTipoCadastro.Text = controladorBase.ObterTipoCadastro;

            ConfigurarToolTips(Controlador);

            ConfigurarListagem(Controlador);
        }

        private void ConfigurarToolTips(Controlador controlador)
        {
            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;
            btnAdicionarItens.ToolTipText = controlador.ToolTipAdicionarItens;

            btnInserir.Enabled = controlador.ToolTipEnableInserir;
            btnEditar.Enabled = controlador.ToolTipEnableEditar;
            btnExcluir.Enabled = controlador.ToolTipEnableExcluir;
            btnAdicionarItens.Enabled = controlador.ToolTipEnableAdicionarItens;
        }

        private void ConfigurarListagem(Controlador controladorBase)
        {
            UserControl listagem = controladorBase.ObterListagem();

            listagem.Dock = DockStyle.Fill;

            panelRegistros.Controls.Clear();

            panelRegistros.Controls.Add(listagem);
        }


        private void btnInserir_Click(object sender, EventArgs e)
        {
            Controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Controlador.Excluir();
        }

        private void btnAdicionarItens_Click(object sender, EventArgs e)
        {
            Controlador.AdicionarItens();
        }
    }
}