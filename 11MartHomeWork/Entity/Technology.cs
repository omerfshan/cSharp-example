namespace ProgrammingLanguagesManagement.Entities;

public class Technology{
    public int Id { get; set; }
    public string? Name { get; set; }
    public ProgrammingLanguage? programmingLanguage{get; set;}
}