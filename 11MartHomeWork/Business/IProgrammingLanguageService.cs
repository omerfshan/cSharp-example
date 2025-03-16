using System.Collections.Generic;
using ProgrammingLanguagesManagement.Entities;

namespace ProgrammingLanguagesManagement.Business;

    public interface IProgrammingLanguageService
    {
        void Add(ProgrammingLanguage programmingLanguage);
        void Delete(ProgrammingLanguage programmingLanguage);
        void Update(ProgrammingLanguage programmingLanguage);
        List<ProgrammingLanguage> GetAll();
        ProgrammingLanguage GetById(int id);
    }