using  Api_com_ASP.NET_Core.Models;
using Microsoft.EntityFrameworkCore;


namespace Api_com_ASP.NET_Core.Data
{
    public class DataContext : DbContext  //Herança
    {
        //Criação de um  método construtor
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {}

        public DbSet<Pessoa> pessoa{get; set;}
    }
}