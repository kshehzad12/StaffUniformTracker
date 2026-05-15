using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Only for testing. Not used at runtime - the EfRepository is used in production.
namespace StaffUniformTracker.Repositories;

public sealed class InMemoryRepository<T> : IRepository<T> where T : class
{
    private readonly Dictionary<string, T> _s = new();
    private readonly System.Func<T, string> _k;
    public InMemoryRepository(System.Func<T, string> k) => _k = k;
    public void Save(T e) => _s[_k(e)] = e;
    public bool Remove(string id) => _s.Remove(id);
    public T? Find(string id) => _s.TryGetValue(id, out var v) ? v : null;
    public IEnumerable<T> All() => _s.Values;
    public int Count => _s.Count;
    public IEnumerable<T> Where(System.Func<T, bool> p) => _s.Values.Where(p);
}
