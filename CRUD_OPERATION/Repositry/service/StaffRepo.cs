using CRUD_OPERATION.DataBase;
using CRUD_OPERATION.Model;
using CRUD_OPERATION.Repositry.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_OPERATION.Repositry.service
{
    public class StaffRepo: Istaffcs
    {
        private readonly DatabaseConnection _context;

        public StaffRepo(DatabaseConnection context)
        {
            _context = context;
        }

        public async Task<List<StaffModel>> GetEmploye()
        {
            var data = await _context.STAFF_DETAILS.ToListAsync();
            return data;
        }
    }
}
