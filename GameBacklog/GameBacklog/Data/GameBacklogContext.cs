using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GameBacklog.Models;

namespace GameBacklog.Data
{
    public class GameBacklogContext : DbContext
    {
        public GameBacklogContext (DbContextOptions<GameBacklogContext> options)
            : base(options)
        {
        }

        public DbSet<GameBacklog.Models.Game>? Game { get; set; }
    }
}
