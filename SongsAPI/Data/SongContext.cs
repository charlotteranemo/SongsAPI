using Microsoft.EntityFrameworkCore;
using SongsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SongsAPI.Data
{
    public class SongContext : DbContext
    {
        public SongContext(DbContextOptions<SongContext> options) : base(options)
        {

        }

        public DbSet<Songs> Songs { get; set; }
    }
}
