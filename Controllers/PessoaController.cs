

using System.Threading.Tasks;
using Api_com_ASP.NET_Core.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// Criando  uma rota  que  traz o Hello world

namespace Api_com_ASP.NET_Core.Controllers
{

    [Controller]
    [Route("[controller]")]

    public class PessoaController
    {
        [HttpGet("oi")] // Get ( Exibe e/ou  Lista)
        public string oi() // Método Simples
        {
            return "Hello World"; 
        }
    }
}