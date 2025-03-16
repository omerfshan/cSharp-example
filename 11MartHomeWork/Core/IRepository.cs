using System.Collections.Generic;

namespace ProgrammingLanguagesManagement.Core
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        List<T> GetAll();
        T GetById(int id);
    }
}
