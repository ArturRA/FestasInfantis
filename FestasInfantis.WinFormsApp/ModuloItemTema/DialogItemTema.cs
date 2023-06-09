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
    public partial class DialogItemTema : Form
    {
        private EntidadeItemTema entidadeItemTema;

        public DialogItemTema()
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }

        public EntidadeItemTema ItemTema
        {
            set
            {
                entidadeItemTema = value;
                labelId.Text = entidadeItemTema.Id.ToString();
                txtNome.Text = entidadeItemTema.Nome;
                txtValor.Text = entidadeItemTema.Valor.ToString();
            }
            get
            {
                return entidadeItemTema;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            decimal valor = Convert.ToDecimal(txtValor.Text);

            entidadeItemTema = new EntidadeItemTema(nome, valor);

            List<string> resultado = entidadeItemTema.Validar();
            if (resultado.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarToolStrip(resultado[0]);
                DialogResult = DialogResult.None;
            }
            else
            {
                if (labelId.Text != "0")
                    entidadeItemTema.Id = Convert.ToInt32(labelId.Text);
                TelaPrincipalForm.Instancia.AtualizarToolStrip("");
            }
        }
    }
}
