using FestasInfantis.Dominio.Compartilhado;
using FestasInfantis.Dominio.ModuloCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinFormsApp.ModuloCliente
{
    public class ControladorCliente : Controlador
    {
        IRepositorio<EntidadeCliente> RepositorioCliente;
        public override string TipoDoCadastro => "Clientes";

        public override void Inserir()
        {
            throw new NotImplementedException();
        }
        public override UserControl ObterListagem()
        {
            throw new NotImplementedException();
        }
        public override void Excluir()
        {
            throw new NotImplementedException();
        }
        public override void Editar()
        {
            throw new NotImplementedException();
        }
    }
}
