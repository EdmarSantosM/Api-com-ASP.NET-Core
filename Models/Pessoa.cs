using System.ComponentModel.DataAnnotations;

namespace Api_com_ASP.NET_Core.Models
{
    public class Pessoa
    {
        //criacao dos atributos + inclusão de  annotation
        [Key]
        public int Id{get; set;} // get obtem e/ou extrai a informação e  o set  envia a informação
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public int idade { get; set; }
    }
}