using System;
using System.Collections.Generic;
using System.Linq;

public class InvalidManager
{
    private List<Invidual> _customers;

    public InvalidManager()
    {
        _customers = new List<Invidual>(); 
    }

    public void Add(Invidual customer)
    {
        _customers.Add(customer);
        Console.WriteLine($"{customer.Name} eklendi");
    }

    public List<Invidual> GetList()
    {
        return _customers;
    }

    public void Delete(int id)
    {
        var customer = _customers.FirstOrDefault(c => c.Id == id);
        if (customer != null)
        {
            _customers.Remove(customer);
            Console.WriteLine($"{customer.Name} silindi");
        }
        else
        {
            Console.WriteLine("Müşteri bulunamadı");
        }
    }

    public Invidual GetById(int id)
    {
        var customer = _customers.FirstOrDefault(c => c.Id == id);
        if (customer != null)
        {
            Console.WriteLine($"{customer.Name}");
        }
        return customer ?? new Invidual { Id = -1, Name = "Bilinmeyen" }; 
    }
}
