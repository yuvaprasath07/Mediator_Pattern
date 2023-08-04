using CRUD_Operation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CRUD_Operation.DataBase
{
    public class DataConnection : DbContext
    {
        protected readonly IConfiguration _Configuration;

        public DataConnection(IConfiguration configuration)
        {
            _Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<EmployeModel> Employee { get; set; }
    }
}