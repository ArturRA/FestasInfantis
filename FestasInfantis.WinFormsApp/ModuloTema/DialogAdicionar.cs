using FestasInfantis.Dominio.ModuloItemTema;
using FestasInfantis.Dominio.ModuloTema;

namespace FestasInfantis.WinFormsApp.ModuloTema
{
    public partial class DialogAdicionar : Form
    {
        public DialogAdicionar()
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }

        private EntidadeTema tema;

        private List<EntidadeItemTema> itens;

        public EntidadeTema Tema
        {
            get
            {
                return tema;
            }
            set
            {
                tema = value;
                lblTema.Text = tema.Nome;
            }
        }

        public List<EntidadeItemTema> Itens 
        {
            get 
            {
                return itens;
            }
            set
            {
                itens = value;
            }
        }

        public void CarregarItens()
        {
            listItens.Items.AddRange(itens.ToArray());
        }


    }
}
