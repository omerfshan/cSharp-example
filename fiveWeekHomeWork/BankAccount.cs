using System;


class BankAccount
{
    public string AccountHolder { get; set; }
    public decimal Balance { get; set; }

    public BankAccount(string accountHolder, decimal balance)
    {
        AccountHolder = accountHolder;
        Balance = balance;
    }

 
    public virtual void CalculateInterest()
    {
        Console.WriteLine("Interest calculation not implemented.");
    }
}


class SavingsAccount : BankAccount
{
    public SavingsAccount(string accountHolder, decimal balance) 
        : base(accountHolder, balance) { }

 
    public override void CalculateInterest()
    {
        decimal interest = Balance * 0.05m;
        Console.WriteLine($"{AccountHolder}'s Savings Account Interest: {interest:C}");
    }
}


class CheckingAccount : BankAccount
{
    public CheckingAccount(string accountHolder, decimal balance) 
        : base(accountHolder, balance) { }


    public override void CalculateInterest()
    {
        Console.WriteLine("Checking accounts do not earn interest.");
    }
}


class Program
{
    static void Main()
    {
       
        BankAccount savings = new SavingsAccount("Ahmet", 1000m);
        savings.CalculateInterest();
        
        
        BankAccount checking = new CheckingAccount("Mehmet", 2000m);
        checking.CalculateInterest();
    }
}
