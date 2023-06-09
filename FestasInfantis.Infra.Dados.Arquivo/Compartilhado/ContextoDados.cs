using System.Text.Json.Serialization;
using System.Text.Json;
using FestasInfantis.Dominio.ModuloItemTema;

namespace FestasInfantis.Infra.Dados.Arquivo.Compartilhado
{
    public class ContextoDados
    {
        private const string PATH_NOME_ARQUIVO = "Compartilhado\\e-AgendaDados.json";
        private FileInfo fileInfo = new FileInfo(PATH_NOME_ARQUIVO);
        //public List<EntidadeAluguel> Categorias { get; set; }   Aluguel
        //public List<EntidadeCliente> Compromissos { get; set; }   Cliente
        public List<EntidadeItemTema> ItensTemas { get; set; }
        //public List<EntidadeTema> Contatos { get; set; }     Tema

        public ContextoDados()
        {
            //Categorias = new List<EntidadeAluguel>();    Aluguel
            //Compromissos = new List<EntidadeCliente>();    Cliente
            ItensTemas = new List<EntidadeItemTema>();
            //Contatos = new List<EntidadeTema>();    Tema
        }

        public ContextoDados(bool carregarDados) : this()
        {
            CarregarDoArquivoJson();
        }

        public void GravarEmArquivoJson()
        {
            JsonSerializerOptions config = ObterConfiguracoes();

            string registrosJson = JsonSerializer.Serialize(this, config);

            fileInfo.Directory!.Create(); // Se o diretorio já existe este metodo não vai fazer nada(não vai precisar)
            File.WriteAllText(fileInfo.FullName, registrosJson);
        }

        private void CarregarDoArquivoJson()
        {
            JsonSerializerOptions config = ObterConfiguracoes();

            if (File.Exists(fileInfo.FullName))
            {
                string registrosJson = File.ReadAllText(fileInfo.FullName);

                if (registrosJson.Length > 0)
                {
                    ContextoDados ctx = JsonSerializer.Deserialize<ContextoDados>(registrosJson, config);

                    //this.Categorias = ctx.Categorias;    Aluguel
                    //this.Compromissos = ctx.Compromissos;    Cliente
                    this.ItensTemas = ctx.ItensTemas;
                    //this.Contatos = ctx.Contatos;        Tema
                }
            }
        }

        private static JsonSerializerOptions ObterConfiguracoes()
        {
            JsonSerializerOptions opcoes = new JsonSerializerOptions();
            opcoes.IncludeFields = true;
            opcoes.WriteIndented = true;
            opcoes.ReferenceHandler = ReferenceHandler.Preserve;

            return opcoes;
        }
    }
}
