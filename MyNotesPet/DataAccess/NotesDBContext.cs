using Microsoft.EntityFrameworkCore;

namespace MyNotesPet.DataAccess
{
    public class NotesDBContext: DbContext
    {
        private readonly IConfiguration _configuration;
        public NotesDBContext(IConfiguration configuration)
        {
            _configuration= configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseNpgsql(_configuration.GetConnectionString("Database"));
            //подключает провайдер npgsql и передаю строку подключения

            optionsBuilder.UseMySQL(_configuration.GetConnectionString("Database"));
            //буду использовать MySql
            
        }

    }

   
}
