﻿using FestasInfantis.Dominio.ModuloCliente;
using FestasInfantis.Dominio.ModuloTema;

namespace FestasInfantis.Dominio.ModuloAluguel
{
    public class EntidadeAluguel : Entidade<EntidadeAluguel>
    {
        public string NomeDaFesta { get; set; }
        public double Desconto { get; set; }
        public string Local { get; set; }
        public DateTime DataFim { get; set; }
        public DateTime DataInicio { get; set; }
        public EntidadeCliente Cliente { get; set; }
        public EntidadeTema Tema { get; set; }
        public DateTime DataPagamentoRestante { get; set; }

        public EntidadeAluguel() { }
        public EntidadeAluguel(string nome, double desconto, DateTime data, DateTime dataFim, EntidadeCliente c, EntidadeTema tema, string local, DateTime DataPgto)
        {
            NomeDaFesta = nome;
            Desconto = desconto;
            DataInicio = data;
            DataFim = dataFim;
            Tema = tema;
            Cliente = c;
            Local = local;
            DataPagamentoRestante = DataPgto;
        }

        public EntidadeAluguel(double desconto, EntidadeCliente cliente, EntidadeTema tema) 
        {
            Desconto = desconto;
            Cliente = cliente;
            Tema = tema;
        }
        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrWhiteSpace(NomeDaFesta))
                erros.Add("Digite um Nome Valido");
            if (string.IsNullOrWhiteSpace(Local))
                erros.Add("Digite um Local Valido");
            if (string.IsNullOrWhiteSpace(Desconto.ToString()))
                erros.Add("Digite um Desconto Valido");
            if (Tema == null)
                erros.Add("Selecione um Tema");
            if (Cliente == null)
                erros.Add("Selecione um Cliente");
            if (string.IsNullOrWhiteSpace(DataInicio.ToString()))
                erros.Add("Digite uma Data de inicio Valida");
            if (string.IsNullOrWhiteSpace(DataFim.ToString()))
                erros.Add("Digite uma Data do fim Valida");
            if (string.IsNullOrWhiteSpace(DataPagamentoRestante.ToString()))
                erros.Add("Digite uma Data do pagamento restante Valida");
            if (DataInicio > DataFim)
                erros.Add("A Data de início não pode ser maior que a Data do fim");

            return erros;
        }

        public List<string> Validar(List<EntidadeAluguel> alugueis)
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrWhiteSpace(NomeDaFesta))
                erros.Add("Digite um Nome Valido");
            if (string.IsNullOrWhiteSpace(Local))
                erros.Add("Digite um Local Valido");
            if (string.IsNullOrWhiteSpace(Desconto.ToString()))
                erros.Add("Digite um Desconto Valido");
            if (Tema == null)
                erros.Add("Selecione um Tema");
            if (Cliente == null)
                erros.Add("Selecione um Cliente");
            if (string.IsNullOrWhiteSpace(DataInicio.ToString()))
                erros.Add("Digite uma Data de inicio Valida");
            if (string.IsNullOrWhiteSpace(DataFim.ToString()))
                erros.Add("Digite uma Data do fim Valida");
            if (string.IsNullOrWhiteSpace(DataPagamentoRestante.ToString()))
                erros.Add("Digite uma Data do pagamento restante Valida");
            if (DataInicio > DataFim)
                erros.Add("A Data de início não pode ser maior que a Data do fim");
            alugueis.ForEach(a =>
            {
                if (DataInicio > a.DataInicio && DataInicio < a.DataFim
                || DataFim > a.DataInicio && DataFim < a.DataFim
                || DataInicio > a.DataInicio && DataFim < a.DataFim
                || DataInicio < a.DataInicio && DataFim > a.DataFim)
                {
                    a.Tema.Itens.ForEach(i =>
                    {
                        if (Tema!.Itens.Contains(i))
                            erros.Add("Esse Tema possui Itens que serão usados no período escolhido");
                    });
                }
            });

            return erros;
        }

        public override void RemoverReferenciasDeMemoria()
        {
            this.Tema.RemoverAluguel(this);
            this.Cliente.RemoverAluguel(this);
        }

        public List<string> ValidarValor()
        {
            List<string> erros = new List<string>();

            if (Tema == null)
                erros.Add("Selecione um Tema");
            if (Cliente == null)
                erros.Add("Selecione um Cliente");
            if (string.IsNullOrWhiteSpace(Desconto.ToString()))
                erros.Add("Digite um Desconto Valido");

            return erros;
        }
    }
}
