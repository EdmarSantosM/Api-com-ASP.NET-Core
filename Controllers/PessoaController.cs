
using System.Threading.Tasks;
using Api_com_ASP.NET_Core.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api_com_ASP.NET_Core.Controllers
{

    [Controller]
    [Route("[controller]")]

    public class PessoaController
    {
        [HttpGet("oi")]
        public string oi()
        {
            return "Hello World";
        }
    }
}