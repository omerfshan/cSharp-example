using System.Collections.Generic;
using System.Linq;
using ProgrammingLanguagesManagement.Core;
using ProgrammingLanguagesManagement.Entities;

namespace ProgrammingLanguagesManagement.DataAccess;

public class ProgrammingLanguageRepository : BaseRepository<ProgrammingLanguage>
{
    private List<ProgrammingLanguage> programmingLanguages=new List<ProgrammingLanguage>();

    public void Add(ProgrammingLanguage entity)
    {
        programmingLanguages.Add(entity);
    }

    public void Delete(ProgrammingLanguage entity)
    {
       programmingLanguages.Remove(entity);
    }

    public List<ProgrammingLanguage> GetAll()
    {
        return programmingLanguages;
    }

    public ProgrammingLanguage GetById(int id)
    {
        return programmingLanguages.FirstOrDefault(p=>p.Id==id) ??new ProgrammingLanguage();
    }

    public void Update(ProgrammingLanguage entity)
    {
       var language=programmingLanguages.FirstOrDefault(p=>p.Id==entity.Id);
       if(language!=null){
        language.Name=entity.Name;
       }
    }
}