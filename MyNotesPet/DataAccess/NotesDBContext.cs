using Microsoft.EntityFrameworkCore;
using MyNotesPet.Models;

namespace MyNotesPet.DataAccess
{
    public class NotesDbContext: DbContext
    {
        private readonly IConfiguration _configuration;
        public NotesDbContext(IConfiguration configuration)
        {
            _configuration= configuration;
        }

        public DbSet<Note> Notes => Set<Note>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseNpgsql(_configuration.GetConnectionString("Database"));
            //подключает провайдер npgsql и передаю строку подключения

            optionsBuilder.UseMySQL(_configuration.GetConnectionString("Database"));
            //буду использовать MySql
            
        }

    }

   
}
