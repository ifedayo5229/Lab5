using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
           BankA firtbank = new BankA();
           firtbank.getBalance();
           BankB gtbank = new BankB();
           gtbank.getBalance();
           BankC unionbank= new BankC();
           unionbank.getBalance();
        }
    }

    public class BankA :Bank
    {
        public decimal bal  = 100.00M;
        public override void getBalance()
        {
          
        Console.WriteLine("your  firstbank balance is " +"$"+ bal);
        }


    }
    public class BankB :Bank
    { 
        public decimal bal  = 150.00M;
        public override void getBalance()
        {
           Console.WriteLine("your gtbank balance is " +"$"+ bal);
        }

        
    }
    public class BankC: Bank
    {
         public decimal bal  = 200.00M;
        public override void getBalance()
        {
           Console.WriteLine("your unionbank balance is "+"$" + bal);
        }

        
    }
}
