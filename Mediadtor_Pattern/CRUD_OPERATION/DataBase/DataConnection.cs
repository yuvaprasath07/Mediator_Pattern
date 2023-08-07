using CRUD_OPERATION.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CRUD_OPERATION.DataBase
{
    public class DataConnection: DbContext
    {
        protected readonly IConfiguration _Configuration;

        public DataConnection(IConfiguration configuration)
        {
            _Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(_Configuration.GetConnectionString("DefaultConnection"));
        }
        public DbSet<StaffModel> STAFF_DETAILS { get; set; }
    }
}
