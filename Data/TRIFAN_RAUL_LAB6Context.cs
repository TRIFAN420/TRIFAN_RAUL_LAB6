using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TRIFAN_RAUL_LAB6.Models;

namespace TRIFAN_RAUL_LAB6.Data
{
    public class TRIFAN_RAUL_LAB6Context : DbContext
    {
        public TRIFAN_RAUL_LAB6Context (DbContextOptions<TRIFAN_RAUL_LAB6Context> options)
            : base(options)
        {
        }

        public DbSet<TRIFAN_RAUL_LAB6.Models.Book> Book { get; set; }
    }
}
