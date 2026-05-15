using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StaffUniformTracker.Models;
using StaffUniformTracker.Patterns.Observer;

//Entity Framework Core context for the SQLite database used in the application.

namespace StaffUniformTracker.Data;

public sealed class LaundryDbContext : DbContext
{
    public DbSet<Client> Clients => Set<Client>();
    public DbSet<Staff> Staffs => Set<Staff>();
    public DbSet<Uniform> Uniforms => Set<Uniform>();
    public DbSet<AuditEvent> AuditEvents => Set<AuditEvent>();

    public static string DatabasePath { get; } =
        Path.Combine(System.AppContext.BaseDirectory, "staff_uniform_tracker.db");

    protected override void OnConfiguring(DbContextOptionsBuilder o)
        => o.UseSqlite($"Data Source={DatabasePath}");

    protected override void OnModelCreating(ModelBuilder mb)
    {
        mb.Entity<Client>().HasKey(c => c.Id);
        mb.Entity<Staff>().HasKey(s => s.Id);
        mb.Entity<Uniform>().HasKey(u => u.Id);
        mb.Entity<Uniform>()
            .HasDiscriminator<string>("UniformKind")
            .HasValue<Shirt>("Shirt").HasValue<Trouser>("Trouser")
            .HasValue<Jacket>("Jacket").HasValue<Scrub>("Scrub");
        mb.Entity<AuditEvent>().HasKey(e => e.Id);
    }
}
