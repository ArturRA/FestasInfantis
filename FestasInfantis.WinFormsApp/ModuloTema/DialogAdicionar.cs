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

            MarcarItensDaListBox();
        }

        private void MarcarItensDaListBox()
        {

            if (tema.Itens.Count > 0)
            {
                int i = 0;
                foreach (EntidadeItemTema e in itens)
                {
                    bool marcado = false;

                    if (tema.Itens.Contains(e))
                    {
                        EntidadeItemTema item = Tema.Itens.FirstOrDefault(x => x == e);
                    }

                    listItens.SetItemChecked(i, true);

                    i++;
                }
            }
        }

        public List<EntidadeItemTema> ObterItensMarcados()
        {
            return listItens.CheckedItems.Cast<EntidadeItemTema>().ToList();
        }
    }
}
