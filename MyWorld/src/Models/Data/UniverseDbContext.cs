using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;

using MyWorld.Exceptions;

namespace MyWorld.Models
{
    public class UniverseDbContext : DbContext
    {
        public UniverseDbContext(DbContextOptions<UniverseDbContext> options)
            : base(options)
        {
        }

        public DbSet<Universe> UniverseItems { get; set; }
    }
}