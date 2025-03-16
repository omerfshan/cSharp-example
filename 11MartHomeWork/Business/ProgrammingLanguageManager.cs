using System;
using System.Collections.Generic;
using ProgrammingLanguagesManagement.DataAccess;
using ProgrammingLanguagesManagement.Entities;

namespace ProgrammingLanguagesManagement.Business;

public class ProgrammingLanguageManager : IProgrammingLanguageService
{
    private  ProgrammingLanguageRepository programmingLanguageRes;



public ProgrammingLanguageManager(){
    programmingLanguageRes=new ProgrammingLanguageRepository();
}

    public void Add(ProgrammingLanguage programmingLanguage)
    {
        // İş mantığı: Aynı isimde programlama dili eklenmesin
        var temp = programmingLanguageRes.GetAll().Find(l=>l.Name==programmingLanguage.Name);
        if(temp!=null)
        {
            Console.WriteLine($"{programmingLanguage.Name} zaten mevcut");
            return;
        }
        else
        {
            programmingLanguageRes.Add(programmingLanguage);
            Console.WriteLine($"{programmingLanguage.Name} eklendi");
        }

    }

    public void Delete(ProgrammingLanguage programmingLanguage)
    {
         var temp = programmingLanguageRes.GetById(programmingLanguage.Id);
         if(temp==null){
           Console.WriteLine("obje yok");
         }
         else{
            programmingLanguageRes.Delete(programmingLanguage);
            Console.WriteLine("silindi");
         }
    }

    public List<ProgrammingLanguage> GetAll()
    {
        return programmingLanguageRes.GetAll();
    }

    public ProgrammingLanguage GetById(int id)
    {
        return programmingLanguageRes.GetById(id);
    }

    public void Update(ProgrammingLanguage programmingLanguage)
    {
       var temp = programmingLanguageRes.GetById(programmingLanguage.Id);
       if(temp==null){
        Console.WriteLine("Bulamadim");
       }
       else{
        programmingLanguageRes.Update(programmingLanguage);
       }
    }
}