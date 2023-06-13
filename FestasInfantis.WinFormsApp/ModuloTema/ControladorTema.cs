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
                EntidadeTema tema = dialogTema.Tema;

                RepositorioTema.Inserir(tema);

                CarregarEntidades();
            }
        }


        public override void Editar()
        {
            EntidadeTema tema = TabelaTema.ObterEntidadeSelecionada();

            if (tema == null)
            {
                MessageBox.Show($"Selecione um {TipoDoCadastro} primeiro!",
                                $"Edição de {TipoDoCadastro}s",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                return;
            }

            DialogTema dialogTema = new DialogTema();
            dialogTema.Tema = tema;

            DialogResult opcao = dialogTema.ShowDialog();

            if (opcao == DialogResult.OK)
            {
                RepositorioTema.Editar(dialogTema.Tema);

                CarregarEntidades();
            }

        }

        public override void Excluir()
        {
            EntidadeTema tema = TabelaTema.ObterEntidadeSelecionada();

            if (tema == null)
            {
                MessageBox.Show($"Selecione um {TipoDoCadastro} primeiro!",
                                $"Exclusão de {TipoDoCadastro}s",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                return;
            }


            DialogResult opcao = MessageBox.Show($"Deseja excluir o {TipoDoCadastro} {tema.Nome}?",
                                                          $"Exclusão de {TipoDoCadastro}s",
                                                          MessageBoxButtons.OKCancel,
                                                          MessageBoxIcon.Question);

            if (opcao == DialogResult.OK)
            {
                tema.Itens.ForEach(i => i.RemoverTema(tema));

                RepositorioTema.Excluir(tema);

                CarregarEntidades();
            }
        }

        public override void AdicionarItens()
        {
            EntidadeTema tema = TabelaTema.ObterEntidadeSelecionada();

            if (tema == null)
            {
                MessageBox.Show($"Selecione um {TipoDoCadastro} primeiro!",
                                $"Adição de Itens",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                return;
            }

            DialogAdicionar dialogAdicionar = new DialogAdicionar();
            dialogAdicionar.Tema = tema;
            dialogAdicionar.Itens = RepositorioItemTema.SelecionarTodos();
            dialogAdicionar.CarregarItens();


            DialogResult opcao = dialogAdicionar.ShowDialog();

            if (opcao == DialogResult.OK)
            {
                tema.Itens = dialogAdicionar.ObterItensMarcados();

                foreach(EntidadeItemTema i in tema.Itens)
                {
                    if (i.Temas.Contains(tema) == false)
                    i.AdicionarTema(tema);
                }

                List<EntidadeItemTema> itensDesmarcados = dialogAdicionar.ObterItensDesmarcados();

                foreach (EntidadeItemTema i in itensDesmarcados)
                {
                    if (i.Temas.Contains(tema) == true)
                        i.RemoverTema(tema);
                }

                CarregarEntidades();
            }

            
        }

        private void AtualizarValorTotalDosItens(EntidadeTema tema)
        {
            tema.ValorItens = 0;
            foreach (EntidadeItemTema i in tema.Itens)
            {
                tema.ValorItens += i.Valor;
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

            foreach (EntidadeTema tema in temas)
            AtualizarValorTotalDosItens(tema);
        }

    }
}
