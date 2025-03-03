class Program
{
    static void Main(string[] args)
    {
        InvalidManager manager = new InvalidManager();

        
        Invidual invidualCustomer = new Invidual { Id = 1, Name = "Ahmet", TcNum = "12345678910L" }; 
        manager.Add(invidualCustomer);

        Corporate corporateCustomer = new Corporate { Id = 2, Name = "XYZ Ltd.", VergiNumarasi = "123456", SirketKodu = "XYZ123" };

       
        var customers = manager.GetList();
        foreach (var customer in customers)
        {
            Console.WriteLine($"Müşteri: {customer.Name}");
        }

    
        manager.Delete(1);
    }
}
