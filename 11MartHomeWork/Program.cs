using System;
using ProgrammingLanguagesManagement.Business;
using ProgrammingLanguagesManagement.Entities;

class Program
{
    static void Main()
    {
        var languageManager = new ProgrammingLanguageManager();
        var technologyManager = new TechnologyManager();

        // Programlama dillerini ekleyelim
        var csharp = new ProgrammingLanguage { Id = 1, Name = "C#" };
        var java = new ProgrammingLanguage { Id = 2, Name = "Java" };

        languageManager.Add(csharp);
        languageManager.Add(java);
        languageManager.Add(new ProgrammingLanguage { Id = 3, Name = "C#" }); // Aynı isimde eklenemez

        // Teknolojileri ekleyelim
        var aspNet = new Technology { Id = 1, Name = "ASP.NET Core", programmingLanguage = csharp };
        var spring = new Technology { Id = 2, Name = "Spring Boot", programmingLanguage = java };

        technologyManager.Add(aspNet);
        technologyManager.Add(spring);

        // Güncelleme yapalım
        csharp.Name = "C# 10";
        languageManager.Update(csharp);

        aspNet.Name = "ASP.NET 7";
        technologyManager.Update(aspNet);

        // Silme işlemia
        languageManager.Delete(csharp);

        // Güncellenmiş verileri yazdıralım
        Console.WriteLine("\n=== Güncellenmiş Veriler ===");
        foreach (var lang in languageManager.GetAll())
        {
            Console.WriteLine($"ID: {lang.Id}, Name: {lang.Name}");
        }

        foreach (var tech in technologyManager.GetAll())
        {
            Console.WriteLine($"ID: {tech.Id}, Name: {tech.Name}, Language: {tech.programmingLanguage.Name}");
        }
    }
}
