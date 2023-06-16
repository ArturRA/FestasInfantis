using FestasInfantis.Dominio.ModuloItemTema;
using FestasInfantis.Dominio.ModuloTema;

namespace FestasInfantis.WinFormsApp.ModuloItemTema
{
    public partial class DialogItemTema : Form
    {
        private EntidadeItemTema entidadeItemTema;
        private List<EntidadeTema> temas;

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
                temas = entidadeItemTema.Temas;
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
                // Editando a entidade
                if (labelId.Text != "0")
                {
                    entidadeItemTema.Id = Convert.ToInt32(labelId.Text);
                    entidadeItemTema.Temas = temas;
                }
                
                TelaPrincipalForm.Instancia.AtualizarToolStrip("");
            }
        }
    }
}
