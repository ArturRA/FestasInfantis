﻿using FestasInfantis.Dominio.ModuloItemTema;

namespace FestasInfantis.WinFormsApp.ModuloItemTema
{
    public class ControladorItemTema : Controlador
    {
        private IRepositorioItemTema RepositorioItemTema { get; set; }
        private TabelaItemTema TabelaItemTema { get; set; }
        public override string TipoDoCadastro => "Itens Tema";


        public ControladorItemTema(IRepositorioItemTema repositorioItemTema)
        {
            RepositorioItemTema = repositorioItemTema;
        }
        public override void Inserir()
        {
            DialogItemTema dialog = new DialogItemTema();
            DialogResult opcaoEscolhida = dialog.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                EntidadeItemTema entidade = dialog.ItemTema;

                RepositorioItemTema.Inserir(entidade);

                CarregarEntidades();
            }
        }


        public override void Editar()
        {
            EntidadeItemTema? entidade = TabelaItemTema.ObterEntidadeSelecionada();

            if (entidade == null)
            {
                MessageBox.Show($"Selecione um {TipoDoCadastro} primeiro!",
                                $"Edição de {TipoDoCadastro}s",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                return;
            }

            DialogItemTema dialog = new DialogItemTema();
            dialog.ItemTema = entidade;

            DialogResult opcaoEscolhida = dialog.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                entidade = dialog.ItemTema;

                entidade.Temas.ForEach(tema => tema.AtualizarValorItens());

                RepositorioItemTema.Editar(entidade);

                CarregarEntidades();
            }
        }

        public override void Excluir()
        {
            EntidadeItemTema? entidade = TabelaItemTema.ObterEntidadeSelecionada();

            if (entidade == null)
            {
                MessageBox.Show($"Selecione um {TipoDoCadastro} primeiro!",
                                $"Exclusão de {TipoDoCadastro}s",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                return;
            }

            if (entidade.Temas.Count > 0)
            {
                MessageBox.Show($"{TipoDoCadastro} esta sendo utilizada em outro lugar!",
                                $"Exclusão de {TipoDoCadastro}s",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                return;
            }


            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o {TipoDoCadastro} {entidade.Nome}?",
                                                          $"Exclusão de {TipoDoCadastro}s",
                                                          MessageBoxButtons.OKCancel,
                                                          MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                RepositorioItemTema.Excluir(entidade);

                CarregarEntidades();
            }
        }


        private void CarregarEntidades()
        {
            List<EntidadeItemTema> contatos = RepositorioItemTema.SelecionarTodos();

            TabelaItemTema.AtualizarRegistros(contatos);
        }

        public override UserControl ObterListagem()
        {
            TabelaItemTema ??= new TabelaItemTema(RepositorioItemTema.SelecionarTodos());

            CarregarEntidades();

            return TabelaItemTema;
        }
    }
}
