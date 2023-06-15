using FestasInfantis.Dominio.ModuloAluguel;
using FestasInfantis.Dominio.ModuloCliente;
using FestasInfantis.Dominio.ModuloItemTema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestasInfantis.WinFormsApp.ModuloItemTema
{
    public partial class DialogItemCliente : Form
    {
        private EntidadeCliente EntidadeCliente;

        public List<EntidadeAluguel> alugueis;

        public DialogItemCliente()
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }

        public EntidadeCliente Cliente
        {
            set
            {
                EntidadeCliente = value;
                labelId.Text = EntidadeCliente.Id.ToString();
                txtNome.Text = EntidadeCliente.Nome;
                txtTel.Text = EntidadeCliente.Telefone;
                txtEmail.Text = EntidadeCliente.Email;
                cbAntigo.Checked = EntidadeCliente.Antigo;
            }
            get
            {
                return EntidadeCliente;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            string telefone = txtTel.Text;

            string email = txtEmail.Text;

            bool antigo = cbAntigo.Checked;

            EntidadeCliente = new EntidadeCliente(nome, telefone, email, antigo);

            List<string> resultado = EntidadeCliente.Validar();
            if (resultado.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarToolStrip(resultado[0]);
                DialogResult = DialogResult.None;
            }
            else
            {
                if (labelId.Text != "0")
                {
                    EntidadeCliente.Id = Convert.ToInt32(labelId.Text);
                    EntidadeCliente.Alugueis = alugueis;
                }
                TelaPrincipalForm.Instancia.AtualizarToolStrip("");
            }
        }
    }
}
