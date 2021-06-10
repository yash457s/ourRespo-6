using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppcore_exercise.Models;

namespace WebAppcore_exercise.Data
{
    public class PlayersDbContext : DbContext
    {
        public PlayersDbContext (DbContextOptions<PlayersDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppcore_exercise.Models.Players> Players { get; set; }
    }
}
