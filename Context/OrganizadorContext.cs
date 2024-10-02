using Microsoft.EntityFrameworkCore;
using TrilhaApiDesafio.Models;

namespace TrilhaApiDesafio.Context
{
    //tudo que estiver nesse Context e no DbSet abaixo virarão tabelas no BD
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options)
        {
            
        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}