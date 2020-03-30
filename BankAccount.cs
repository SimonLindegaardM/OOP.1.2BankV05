namespace BankV05
{
    /// <summary>
    /// This class represents a very simple bank account.
    /// Only the amount of money on the account is represented.
    /// </summary>
    public class BankAccount
    {
        private double _balance;
        private string _Name;
        private double _age;

        public BankAccount(string Name)
        {
            _balance = 0.0;
            _Name = Name;
            _age = 23;
        }

        public double Balance
        {
            get { return _balance;}
        }

        public void Deposit(double amount)
        {
            _balance = _balance + amount;
        }

        public void Withdraw(double amount)
        {
            _balance = _balance - amount;
        }
        public string Name
        {
            get { return _Name;}
        } 
        public double Age
        {
            get { return _age;}
        }
    }
}