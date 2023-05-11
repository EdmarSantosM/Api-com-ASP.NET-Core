

using System.Threading.Tasks;
using Api_com_ASP.NET_Core.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Api_com_ASP.NET_Core.Models; 

// Criando  uma rota  que  traz o Hello world

namespace Api_com_ASP.NET_Core.Controllers
{

    [Controller]
    [Route("[controller]")]

    public class PessoaController : ControllerBase
    {

        //Criação de um obj do tipo DataContext para  ter acesso as  funções
        private DataContext dc;

        //Construtor
        public PessoaController(DataContext context)
        {
                //Na chamada da classe 
                this.dc = context; // que recebe do Data
        }

        [HttpPost("api")]
        public async Task<ActionResult> cadastrar([FromBody]Pessoa p) //  assincrono quando recebe o "await"  está linha fica  parada executa as demais  depois que essa finalizar  sua  função
        {
            dc.pessoa.Add(p);  // p parametro pessoa ( Recebe as  caracteristicas - Id, Nome, Cidade, Idade) - retorno do Json
            await dc.SaveChangesAsync();

            return Created("Objeto pessoa",p);
        }

        //Criando o método Listar todas informações
        [HttpGet("api")]
        public async Task<ActionResult> listar()
        {
            var dados = await dc.pessoa.ToListAsync();
            return Ok(dados);
        }

        //Criando o método de listar por Id
        [HttpGet("api/{codigo}")]
        public Pessoa filtrar(int codigo)
        {
            Pessoa p = dc.pessoa.Find(codigo);
            return p;
        }

        [HttpPut("api")] // Com método PUT é encessário passar  todas as  caracteristicas (Atributos)
        public async Task<ActionResult> editar([FromBody] Pessoa p)  // Objeto Pessoa nomeado com p
        {
                dc.pessoa.Update(p);
                await dc.SaveChangesAsync(); // Só executa as  demais linhas apos a alteração / atualização no Banco de Dados.
                return Ok(p);
        }

        [HttpDelete("api/{codigo}")]
        public async Task<ActionResult> remover(int codigo)
        {
            // O método para remover precisa de todas as informações do objeto
            Pessoa p = filtrar(codigo);

            if(p == null)
            {
                return NotFound(); // Caso código não for encontrado 
            }
            else //Remoção
            {
                dc.pessoa.Remove(p);
                await dc.SaveChangesAsync();
                return Ok();
            }
        }

        [HttpGet("oi")] // Get ( Exibe e/ou  Lista)
        public string oi() // Método Simples
        {
            return "Hello World"; 
        }
    }
}

