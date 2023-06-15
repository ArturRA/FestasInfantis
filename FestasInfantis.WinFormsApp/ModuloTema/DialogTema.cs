using FestasInfantis.Dominio.ModuloAluguel;
using FestasInfantis.Dominio.ModuloItemTema;
using FestasInfantis.Dominio.ModuloTema;

namespace FestasInfantis.WinFormsApp.ModuloTema
{
    public partial class DialogTema : Form
    {
        private EntidadeTema tema;
        public List<EntidadeItemTema> itens;
        public List<EntidadeAluguel> alugueis;
        public DialogTema()
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }



        public EntidadeTema Tema
        {
            get
            {
                return tema;
            }
            set
            {
                tema = value;
                labelId.Text = tema.Id.ToString();
                txtNome.Text = tema.Nome;
                txtPctgmEntrada.Text = tema.PorcentagemEntrada.ToString();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            double porcentagemEntrada = Convert.ToDouble(txtPctgmEntrada.Text);

            tema = new EntidadeTema(nome, porcentagemEntrada);

            List<string> resultado = tema.Validar();

            if (resultado.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarToolStrip(resultado[0]);
                DialogResult = DialogResult.None;
            }
            else
            {
                if (labelId.Text != "0")
                {
                    tema.Id = Convert.ToInt32(labelId.Text);
                    tema.Itens = itens;
                    tema.Alugueis = alugueis;
                }
                TelaPrincipalForm.Instancia.AtualizarToolStrip("");
            }
        }
    }
}
