using FestasInfantis.Dominio.Compartilhado;
using FestasInfantis.Dominio.ModuloTema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FestasInfantis.Dominio.ModuloItemTema
{
    public class EntidadeItemTema : Entidade<EntidadeItemTema>
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        public List<EntidadeTema> Temas { get; set; }

        public EntidadeItemTema()
        {
        }

        public EntidadeItemTema(string nome, decimal valor)
        {
            Nome=nome;
            Valor=valor;
            Temas = new List<EntidadeTema>();
        }

        public EntidadeItemTema(string nome, decimal valor, List<EntidadeTema> temas)
        {
            Nome = nome;
            Valor = valor;
            Temas = temas;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();
            if (string.IsNullOrWhiteSpace(Nome))
                erros.Add("Digite um Nome valido");
            if (string.IsNullOrWhiteSpace(Valor.ToString()))
                erros.Add("Digite um Valor valido");

            return erros;
        }

        public override string? ToString()
        {
            return Nome;
        }

        public void AdicionarTema(EntidadeTema tema)
        {
            Temas.Add(tema);
        }

        public void RemoverTema(EntidadeTema tema)
        {
            if (Temas.Any(e => e.Id == tema.Id))
                Temas.Remove(Temas.Single(e => e.Id == tema.Id));
        }
    }
}
