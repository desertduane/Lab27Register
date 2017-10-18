using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab27Register.Models
{
    public class Lab27RegisterContext : DbContext
    {
        public Lab27RegisterContext (DbContextOptions<Lab27RegisterContext> options)
            : base(options)
        {
        }

        public DbSet<Lab27Register.Models.CMS> CMS { get; set; }
    }
}
