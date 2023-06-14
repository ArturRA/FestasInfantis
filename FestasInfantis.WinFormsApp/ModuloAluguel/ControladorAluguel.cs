using FestasInfantis.Dominio.ModuloAluguel;
using FestasInfantis.Dominio.ModuloCliente;
using FestasInfantis.Dominio.ModuloItemTema;
using FestasInfantis.Dominio.ModuloTema;
using FestasInfantis.WinFormsApp.ModuloItemTema;
using FestasInfantis.WinFormsApp.ModuloTema;

namespace FestasInfantis.WinFormsApp.ModuloAluguel
{
    public class ControladorAluguel : Controlador
    {
        private IRepositorioAluguel RepositorioAluguel { get; set; }
        private IRepositorioCliente RepositorioCliente { get; set; }
        private IRepositorioTema RepositorioTema { get; set; }
        private TabelaAluguel TabelaAluguel { get; set; }
        public override string TipoDoCadastro => "Aluguel";

        public ControladorAluguel(IRepositorioAluguel repositorioAluguel, IRepositorioTema repositorioTema, IRepositorioCliente repositorioCliente)
        {
            RepositorioAluguel = repositorioAluguel;
            RepositorioTema = repositorioTema;
            RepositorioCliente = repositorioCliente;
        }

        public override void Inserir()
        {
            DialogAluguel dialog = new DialogAluguel(RepositorioTema.SelecionarTodos(), RepositorioCliente.SelecionarTodos()) ;
            DialogResult opcaoEscolhida = dialog.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                EntidadeAluguel entidade = dialog.Aluguel;

                RepositorioAluguel.Inserir(entidade);

                CarregarEntidades();
            }
        }

        public override void Editar()
        {
            EntidadeAluguel? entidade = TabelaAluguel.ObterEntidadeSelecionada();

            if (entidade == null)
            {
                MessageBox.Show($"Selecione um {TipoDoCadastro} primeiro!",
                                $"Edição de Alugueis",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                return;
            }

            DialogAluguel dialog = new DialogAluguel(RepositorioTema.SelecionarTodos(), RepositorioCliente.SelecionarTodos());

            dialog.Aluguel = entidade;

            DialogResult opcao = dialog.ShowDialog();

            if (opcao == DialogResult.OK)
            {
                RepositorioAluguel.Editar(dialog.Aluguel);

                CarregarEntidades();
            }
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override UserControl ObterListagem()
        {
            TabelaAluguel ??= new TabelaAluguel(RepositorioAluguel.SelecionarTodos());

            CarregarEntidades();

            return TabelaAluguel;
        }

        private void CarregarEntidades()
        {
            List<EntidadeAluguel> alugueis = RepositorioAluguel.SelecionarTodos();

            TabelaAluguel.AtualizarRegistros(alugueis);
        }
    }
}
