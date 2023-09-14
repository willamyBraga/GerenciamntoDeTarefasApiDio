using System.Data.Entity;

namespace GerenciamntoDeTarefasApiDio.Model
{
    public class DbContextDio : DbContext
    {
        public DbContextDio() : base("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GerenciadorTarefasApi;Integrated Security=True;Connect Timeout=30;")
        {
        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
