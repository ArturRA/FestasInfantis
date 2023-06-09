using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.Dominio.Compartilhado
{
    public abstract class Entidade<TipoEntidade>
        where TipoEntidade : Entidade<TipoEntidade>
    {
        public int Id { get; set; }

        public void Editar(TipoEntidade entidadeAtualizado)
        {
            // Pega o tipo e para cada propriedade, que não seja o id, atualiza o valor
            typeof(TipoEntidade).GetProperties().ToList().ForEach(p =>
            {
                if (!p.Name.Equals("Id"))
                    p.SetValue(this, p.GetValue(entidadeAtualizado));
            });
        }

        public abstract List<string> Validar();
    }
}
