using System.Collections.Generic;
using System.Linq;

namespace ProgrammingLanguagesManagement.Core
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected List<T> _entities = new List<T>();

        public void Add(T entity)
        {
            _entities.Add(entity);
        }

        public void Update(T entity)
        {
            var existingEntity = _entities.FirstOrDefault(e => e.Id == entity.Id);
            if (existingEntity != null)
            {
                _entities.Remove(existingEntity);
                _entities.Add(entity);
            }
        }

        public void Delete(int id)
        {
            var entity = _entities.FirstOrDefault(e => e.Id == id);
            if (entity != null)
            {
                _entities.Remove(entity);
            }
        }

        public List<T> GetAll()
        {
            return _entities;
        }

        public T GetById(int id)
        {
            return _entities.FirstOrDefault(e => e.Id == id);
        }
    }
}
