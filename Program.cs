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

    public abstract class Bank
    {
       public abstract void  getBalance();
    }

    public class BankA :Bank
    {
        public override void getBalance()
        {
          
        Console.WriteLine("your  firstbank balance is $100");
        }


    }
    public class BankB :Bank
    {
        public override void getBalance()
        {
           Console.WriteLine("your gtbank balance is $150");
        }

        
    }
    public class BankC: Bank
    {
        public override void getBalance()
        {
           Console.WriteLine("your unionbank balance is $200");
        }

        
    }
}
