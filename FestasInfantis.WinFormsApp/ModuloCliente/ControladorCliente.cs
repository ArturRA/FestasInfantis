using FestasInfantis.Dominio.Compartilhado;
using FestasInfantis.Dominio.ModuloCliente;
using FestasInfantis.Dominio.ModuloItemTema;
using FestasInfantis.WinFormsApp.ModuloItemTema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinFormsApp.ModuloCliente
{
    public class ControladorCliente : Controlador
    {
        private IRepositorioCliente RepositorioCliente;

        private TabelaItemCliente tabelaItemCliente { get; set; }

        public override string TipoDoCadastro => "Clientes";

        public ControladorCliente(IRepositorioCliente repositorioCliente)
        {
            RepositorioCliente = repositorioCliente;
        }

        public override void Inserir()
        {
            DialogItemCliente dialog = new DialogItemCliente();
            DialogResult opcaoEscolhida = dialog.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                EntidadeCliente entidade = dialog.Cliente;

                RepositorioCliente.Inserir(entidade);

                CarregarEntidades();
            }
        }
        public override UserControl ObterListagem()
        {
            tabelaItemCliente ??= new TabelaItemCliente(RepositorioCliente.SelecionarTodos());

            CarregarEntidades();

            return tabelaItemCliente;
        }
        private void CarregarEntidades()
        {
            List<EntidadeCliente> Clientes = RepositorioCliente.SelecionarTodos();

            tabelaItemCliente.AtualizarRegistros(Clientes);
        }
        public override void Excluir()
        {
            EntidadeCliente entidade = tabelaItemCliente.ObterEntidadeSelecionada();

            if (entidade == null)
            {
                MessageBox.Show($"Selecione um {TipoDoCadastro} primeiro!",
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
                RepositorioCliente.Excluir(entidade);

                CarregarEntidades();
            }
        }
        public override void Editar()
        {
            EntidadeCliente? entidade = tabelaItemCliente.ObterEntidadeSelecionada();

            if (entidade == null)
            {
                MessageBox.Show($"Selecione um {TipoDoCadastro} primeiro!",
                                $"Edição de {TipoDoCadastro}s",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                return;
            }

            DialogItemCliente dialog = new DialogItemCliente();
            dialog.Cliente = entidade;

            DialogResult opcaoEscolhida = dialog.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                RepositorioCliente.Editar(dialog.Cliente);

                CarregarEntidades();
            }
        }
    }
}
