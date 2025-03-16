using System.Collections.Generic;
using System.Linq;
namespace ProgrammingLanguagesManagement.Entities;

using ProgrammingLanguagesManagement.DataAccess;

public class TechnologyRepository : Irepository<Technology>
{
    private List<Technology> technologies = new List<Technology>();
    public void Add(Technology entity)
    {
       technologies.Add(entity);
    }

    public void Delete(Technology entity)
    {
        technologies.Remove(entity);
    }

    public List<Technology> GetAll()
    {
        return technologies;
    }

    public Technology GetById(int id)
    {
       return technologies.FirstOrDefault(p=>p.Id==id) ?? new Technology();
    }

    public void Update(Technology entity)
    {
       var tech=technologies.FirstOrDefault(p=>p.Id==entity.Id) ?? new Technology();
       if(tech!=null)
       {
        tech.programmingLanguage=entity.programmingLanguage;
       }
    }
}
  
