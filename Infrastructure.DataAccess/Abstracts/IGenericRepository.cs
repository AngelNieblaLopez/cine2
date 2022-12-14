using System.Collections.Generic;

namespace Infrastructure.DataAccess.Abstracts
{
    public interface IGenericRepository<Entity> where Entity : class
    {
        int add(Entity entity);
        int edit(Entity entity);
        int remove(int id);
        IEnumerable<Entity> All { get; }

        IEnumerable<Entity> getByValue(string value);
    }
}
