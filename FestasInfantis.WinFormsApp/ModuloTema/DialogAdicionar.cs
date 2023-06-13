using FestasInfantis.Dominio.ModuloItemTema;
using FestasInfantis.Dominio.ModuloTema;

namespace FestasInfantis.WinFormsApp.ModuloTema
{
    public partial class DialogAdicionar : Form
    {
        private EntidadeTema tema;

        private List<EntidadeItemTema> itens;

        public DialogAdicionar(List<EntidadeItemTema> entidadeItemTemas)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            itens= entidadeItemTemas;
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
                lblTema.Text = tema.Nome;
                CarregarItens(itens);
            }
        }

        public void CarregarItens(List<EntidadeItemTema> entidades)
        {
            listItens.Items.AddRange(entidades.ToArray());

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
                        listItens.SetItemChecked(i, true);
                    }

                    i++;
                }
            }
        }

        public List<EntidadeItemTema> ObterItensMarcados()
        {
            return listItens.CheckedItems.Cast<EntidadeItemTema>().ToList();
        }

        public List<EntidadeItemTema> ObterItensDesmarcados()
        {
            return listItens.Items.Cast<EntidadeItemTema>().Except(ObterItensMarcados()).ToList();
        }
    }
}
