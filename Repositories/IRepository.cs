using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// REPOSITORY abstraction : architectural pattern
namespace StaffUniformTracker.Repositories;

public interface IRepository<T> where T : class
{//CRUD abstraction
    void Save(T entity);
    bool Remove(string id);
    T? Find(string id);
    IEnumerable<T> All();
    int Count { get; }
    IEnumerable<T> Where(System.Func<T, bool> p);
}
