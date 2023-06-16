using FestasInfantis.Dominio.ModuloItemTema;
using FestasInfantis.Dominio.ModuloTema;

namespace FestasInfantis.WinFormsApp.ModuloTema
{
    public partial class DialogAdicionar : Form
    {
        private EntidadeTema entidadeTema;

        private List<EntidadeItemTema> ItensTema { get; set; }

        public DialogAdicionar(List<EntidadeItemTema> entidadeItemTemas)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            ItensTema= entidadeItemTemas;
            CarregarItens(ItensTema);
        }


        public EntidadeTema Tema
        {
            get
            {
                return entidadeTema;
            }
            set
            {
                entidadeTema = value;
                lblTema.Text = entidadeTema.Nome;
                MarcarItensDaListBox();
            }
        }

        public void CarregarItens(List<EntidadeItemTema> entidades)
        {
            clbItensTema.Items.AddRange(entidades.ToArray());
        }

        private void MarcarItensDaListBox()
        {
            for (int i = 0; i < clbItensTema.Items.Count; i++)
            {
                EntidadeItemTema obj = (EntidadeItemTema)clbItensTema.Items[i];
                clbItensTema.SetItemChecked(i, obj.Temas.Any(e => e.Id == entidadeTema.Id));
            }
        }

        public List<EntidadeItemTema> ObterItensMarcados()
        {
            return clbItensTema.CheckedItems.Cast<EntidadeItemTema>().ToList();
        }

        public List<EntidadeItemTema> ObterItensDesmarcados()
        {
            return clbItensTema.Items.Cast<EntidadeItemTema>().Except(ObterItensMarcados()).ToList();
        }
    }
}
