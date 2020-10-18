using Marvel.Interfaces.Entities;
using System.Collections.Generic;

namespace Marvel.Interfaces
{
    public interface IService<T>
        where T : IEntity
    {
        ICollection<T> GetAll();
        T GetById(int id);
    }
}
