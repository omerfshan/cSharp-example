using System.Collections.Generic;
using ProgrammingLanguagesManagement.Business;
using ProgrammingLanguagesManagement.Entities;

namespace ProgrammingLanguagesManagement.Business;
public class TechnologyManager : TechnologyService
{
    private readonly TechnologyRepository repository;
    public TechnologyManager()
    {
        repository = new TechnologyRepository();
    }

    public void Add(Technology technology)
    {
        var temp=repository.GetAll().Find(l=>l.Name==technology.Name);
        if(temp!=null)
        {
            Console.WriteLine("var");
        }
        else{
            repository.Add(technology);
        }
    }

    public void Delete(Technology entity)
    {
        var temp =repository.GetById(entity.Id);
        if(temp==null)
        {
         Console.WriteLine("YOK");
        }
        else
        {
            repository.Delete(entity);
        }
        
    }

    public List<Technology> GetAll()
    {
        return repository.GetAll();
    }

    public Technology GetById(int id)
    {
        return repository.GetById(id);
    }

    public void Update(Technology technology)
    {
         var temp =repository.GetById(technology.Id);
        if(temp==null)
        {
         Console.WriteLine("YOK");
        }
        else
        {
            repository.Update(technology);
        }
    }
}