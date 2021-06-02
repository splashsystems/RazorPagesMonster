using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMonster.Models;

namespace RazorPagesMonster.Data
{
    public class RazorPagesMonsterContext : DbContext
    {
        public RazorPagesMonsterContext (DbContextOptions<RazorPagesMonsterContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMonster.Models.Monster> Monster { get; set; }
    }
}
