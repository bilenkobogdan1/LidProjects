using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LidProjectContext
{
    public class LidProjectContext : DbContext
    {
        public LidProjectContext(DbContextOptions<LidProjectContext> options) : base(options)
        {
        }
        public DbSet<Data.LidProject.ContactLids> ContactLids { get; set; }

        public DbSet<Data.LidProject.CategoryLids> CategoryLids { get; set; }
    }
}
