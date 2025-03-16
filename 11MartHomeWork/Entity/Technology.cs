using ProgrammingLanguagesManagement.Core;

namespace ProgrammingLanguagesManagement.Entities;

public class Technology:BaseEntity{
    
    public string? Name { get; set; }
    public ProgrammingLanguage? programmingLanguage{get; set;}
}