using System;

namespace BankV05
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            BankAccount myAccount = new BankAccount("Simon Mathiasen");
            BankAccount myAccount2= new BankAccount("Bo");
            BankAccount myAccount3= new BankAccount("Per");
            BankAccount myAccount4= new BankAccount("Lars");

            System.Console.WriteLine($"{myAccount.Name} account is {myAccount.Age} years old");
            myAccount.Deposit(2000);
            myAccount2.Deposit(15000);
            myAccount3.Deposit(5000);
            myAccount4.Deposit(45000);
            myAccount.Deposit(565000);
            Console.WriteLine($"The balance on {myAccount.Name} is : {myAccount.Balance}");
            Console.WriteLine($"The balance on {myAccount2.Name} is : {myAccount2.Balance}");
            Console.WriteLine($"The balance on {myAccount3.Name} is : {myAccount3.Balance}");
            Console.WriteLine($"The balance on {myAccount4.Name} is : {myAccount4.Balance}");

            myAccount.Withdraw(1500);
            Console.WriteLine($"The balance is : {myAccount.Balance}");

            // The LAST line of code should be ABOVE this line
        }
    }
}