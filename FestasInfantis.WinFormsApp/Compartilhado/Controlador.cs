namespace FestasInfantis.WinFormsApp.Compartilhado
{
    public abstract class Controlador
    {
        public abstract string TipoDoCadastro { get; }
        public string ToolTipInserir => $"Inserir novo {TipoDoCadastro}";
        public string ToolTipEditar => $"Editar {TipoDoCadastro} existente";
        public string ToolTipExcluir => $"Excluir {TipoDoCadastro} existente";
        public virtual string ToolTipAdicionarItens => "";
        public string ObterTipoCadastro => $"Cadastro de {TipoDoCadastro}";

        public virtual bool ToolTipEnableInserir => true;
        public virtual bool ToolTipEnableEditar => true;
        public virtual bool ToolTipEnableExcluir => true;
        public virtual bool ToolTipEnableAdicionarItens => false;

        public abstract void Inserir();
        public abstract void Editar();
        public abstract void Excluir();
        public virtual void Filtrar()
        {
        }
        public virtual void AdicionarItens()
        {
        }
        public virtual void ConcluirItens()
        {
        }
        public virtual void ListarDespesas()
        {
        }
        public abstract UserControl ObterListagem();

    }

}
