﻿using FestasInfantis.Dominio.ModuloTema;

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

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();
            if (string.IsNullOrWhiteSpace(Nome))
                erros.Add("Digite um Nome valido");
            if (string.IsNullOrWhiteSpace(Valor.ToString()))
                erros.Add("Digite um Valor valido");

            return erros;
        }
        public override void RemoverReferenciasDeMemoria()
        {
            this.Temas.ForEach(t => t.RemoverItemTema(this));
        }

        public override string? ToString()
        {
            return Nome;
        }

        public void AdicionarTema(EntidadeTema tema)
        {
            if (!Temas.Any(e => e.Id == tema.Id))
                Temas.Add(tema);
        }

        public void RemoverTema(EntidadeTema tema)
        {
            if (Temas.Any(e => e.Id == tema.Id))
                Temas.Remove(Temas.Single(e => e.Id == tema.Id));
        }
    }
}
