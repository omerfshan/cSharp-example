using System.Collections.Generic;
using ProgrammingLanguagesManagement.Entities;

namespace ProgrammingLanguagesManagement.Business;

public interface TechnologyService{
    void Add(Technology technology);
        void Delete(Technology entity);
        void Update(Technology technology);
        List<Technology> GetAll();
        Technology GetById(int id);
}
