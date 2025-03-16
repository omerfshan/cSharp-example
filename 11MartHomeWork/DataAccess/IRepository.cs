namespace ProgrammingLanguagesManagement.DataAccess;
using System.Collections.Generic;


public interface Irepository<T>
{
//add update delete getall getbyid
 void Add (T entity);
 void Delete(T entity);
 void Update(T entity);
 List<T> GetAll();
 T GetById(int id);
}