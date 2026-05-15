using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StaffUniformTracker.Data;

// CONCRETE REPOSITORY backed by SQLite + EF Core.

namespace StaffUniformTracker.Repositories;

public sealed class EfRepository<T> : IRepository<T> where T : class
{
    private readonly LaundryDbContext _ctx;
    private readonly Func<T, string> _key;
    public EfRepository(LaundryDbContext ctx, Func<T, string> key) { _ctx = ctx; _key = key; }
    private DbSet<T> Set => _ctx.Set<T>();

    public void Save(T entity)
    {
        var existing = Set.Find(_key(entity));
        if (existing is null) Set.Add(entity);
        else if (!ReferenceEquals(existing, entity))
            _ctx.Entry(existing).CurrentValues.SetValues(entity);
        _ctx.SaveChanges();
    }
    public bool Remove(string id)
    {
        var e = Set.Find(id); if (e is null) return false;
        Set.Remove(e); _ctx.SaveChanges(); return true;
    }
    public T? Find(string id) => Set.Find(id);
    public IEnumerable<T> All() => Set.ToList();             // tracked snapshot
    public int Count => Set.Count();
    public IEnumerable<T> Where(Func<T, bool> p) => Set.AsNoTracking().AsEnumerable().Where(p);
}
