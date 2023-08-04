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
    public class DatabaseConnection: DbContext
    {
        public readonly IConfiguration _configuration;

        public DatabaseConnection(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_configuration.GetConnectionString("StaffDetails"));  
        }

        public DbSet<StaffModel> STAFF_DETAILS { get; set; }

    }
}


