﻿using FestasInfantis.Dominio.ModuloAluguel;
using FestasInfantis.Dominio.ModuloCliente;
using FestasInfantis.Dominio.ModuloTema;

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
            DialogAluguel dialog = new DialogAluguel(RepositorioTema.SelecionarTodos(), RepositorioCliente.SelecionarTodos(), RepositorioAluguel.SelecionarTodos());
            DialogResult opcaoEscolhida = dialog.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                EntidadeAluguel entidade = dialog.Aluguel;

                entidade.Tema.AdicionarAluguel(entidade);
                entidade.Cliente.AdicionarAluguel(entidade);

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

            DialogAluguel dialog = new DialogAluguel(RepositorioTema.SelecionarTodos(), RepositorioCliente.SelecionarTodos(), RepositorioAluguel.SelecionarTodos());

            dialog.Aluguel = entidade;

            DialogResult opcao = dialog.ShowDialog();

            if (opcao == DialogResult.OK)
            {
                //EntidadeTema entidadeTema = dialog.Aluguel.Tema;
                if (entidade.Tema != dialog.Aluguel.Tema)
                {
                    entidade.Tema.RemoverAluguel(entidade);

                    dialog.Aluguel.Tema.AdicionarAluguel(entidade);
                }

                //EntidadeCliente entidadeCliente = dialog.Aluguel.Cliente;

                if (entidade.Cliente != dialog.Aluguel.Cliente)
                {
                    entidade.Cliente.RemoverAluguel(entidade);

                    dialog.Aluguel.Cliente.AdicionarAluguel(entidade);
                }

                RepositorioAluguel.Editar(dialog.Aluguel);

                CarregarEntidades();
            }
        }

        public override void Excluir()
        {
            EntidadeAluguel? entidade = TabelaAluguel.ObterEntidadeSelecionada();

            if (entidade == null)
            {
                MessageBox.Show($"Selecione um {TipoDoCadastro} primeiro!",
                                $"Exclusão de Alugueis",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcao = MessageBox.Show($"Deseja excluir o {TipoDoCadastro} {entidade.NomeDaFesta}?",
                                                          $"Exclusão de Alugueis",
                                                          MessageBoxButtons.OKCancel,
                                                          MessageBoxIcon.Question);

            if (opcao == DialogResult.OK)
            {
                RepositorioAluguel.Excluir(entidade);

                CarregarEntidades();
            }
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
