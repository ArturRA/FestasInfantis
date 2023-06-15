using FestasInfantis.Dominio.Compartilhado;
using FestasInfantis.Dominio.ModuloItemTema;
using FestasInfantis.Dominio.ModuloTema;
using FestasInfantis.WinFormsApp.Compartilhado;
using FestasInfantis.WinFormsApp.ModuloItemTema;

namespace FestasInfantis.WinFormsApp.ModuloTema
{
    public class ControladorTema : Controlador
    {
        private IRepositorioTema RepositorioTema { get; set; }
        private IRepositorioItemTema RepositorioItemTema { get; set; }

        private TabelaTema TabelaTema { get; set; }

        public override string TipoDoCadastro => "Tema";

        public override bool ToolTipEnableAdicionarItens => true;

        public ControladorTema(IRepositorioTema repositorioTema, IRepositorioItemTema repositorioItem)
        {
            this.RepositorioTema = repositorioTema;
            this.RepositorioItemTema = repositorioItem;
        }

        public override void Inserir()
        {
            DialogTema dialogTema = new DialogTema();

            DialogResult opcao = dialogTema.ShowDialog();

            if (opcao == DialogResult.OK)
            {
                EntidadeTema entidade = dialogTema.Tema;

                RepositorioTema.Inserir(entidade);

                CarregarEntidades();
            }
        }


        public override void Editar()
        {
            EntidadeTema? entidade = TabelaTema.ObterEntidadeSelecionada();

            if (entidade == null)
            {
                MessageBox.Show($"Selecione um {TipoDoCadastro} primeiro!",
                                $"Edição de {TipoDoCadastro}s",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                return;
            }

            DialogTema dialog = new DialogTema();

            dialog.Tema = entidade;

            dialog.itens = entidade.Itens;
            dialog.alugueis = entidade.Alugueis;

            DialogResult opcao = dialog.ShowDialog();

            if (opcao == DialogResult.OK)
            {
                entidade = dialog.Tema;
                RepositorioTema.Editar(entidade);

                CarregarEntidades();
            }
        }

        public override void Excluir()
        {
            EntidadeTema? entidade = TabelaTema.ObterEntidadeSelecionada();

            if (entidade == null)
            {
                MessageBox.Show($"Selecione um {TipoDoCadastro} primeiro!",
                                $"Exclusão de {TipoDoCadastro}s",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcao = MessageBox.Show($"Deseja excluir o {TipoDoCadastro} {entidade.Nome}?",
                                                          $"Exclusão de {TipoDoCadastro}s",
                                                          MessageBoxButtons.OKCancel,
                                                          MessageBoxIcon.Question);

            if (opcao == DialogResult.OK)
            {
                entidade.Itens.ForEach(i => i.RemoverTema(entidade));

                RepositorioTema.Excluir(entidade);

                CarregarEntidades();
            }
        }

        public override void AdicionarItens()
        {
            EntidadeTema? entidade = TabelaTema.ObterEntidadeSelecionada();

            if (entidade == null)
            {
                MessageBox.Show($"Selecione um {TipoDoCadastro} primeiro!",
                                $"Adição de Itens",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                return;
            }

            DialogAdicionar dialog = new DialogAdicionar(RepositorioItemTema.SelecionarTodos());
            dialog.Tema = entidade;

            DialogResult opcao = dialog.ShowDialog();

            if (opcao == DialogResult.OK)
            {
                entidade = dialog.Tema;

                List<EntidadeItemTema> itensChecked = dialog.ObterItensMarcados();
                itensChecked.ForEach(i =>
                {
                    i.AdicionarTema(entidade);
                    entidade.AdicionarItemTema(i);

                });

                List<EntidadeItemTema> itensUnChecked = dialog.ObterItensDesmarcados();
                itensUnChecked.ForEach(i =>
                {
                    i.RemoverTema(entidade);
                    entidade.RemoverItemTema(i);
                });

                entidade.AtualizarValorItens();

                CarregarEntidades();
            }
        }

        public override UserControl ObterListagem()
        {
            TabelaTema ??= new TabelaTema(RepositorioTema.SelecionarTodos());

            CarregarEntidades();

            return TabelaTema;
        }

        private void CarregarEntidades()
        {
            List<EntidadeTema> temas = RepositorioTema.SelecionarTodos();

            TabelaTema.AtualizarRegistros(temas);
        }

    }
}
