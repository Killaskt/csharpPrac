using System;

namespace ProgChallenge
{
    // classes have a name, unique within the namespace
    class Accounts
    {
        // classes have instance variables to hold data
        private string _firstName;
        private string _lastName;
        private decimal _balance;

        public Accounts(string firstName, string lastName, decimal balance = 0.0m) {
            _firstName = firstName;
            _lastName = lastName;
            _balance = balance;
        }

        public string FirstName { 
            get => _firstName; 
            set => _firstName = value; 
        }
        public string LastName { 
            get => _lastName; 
            set => _lastName = value; 
        }
        public decimal Balance { 
            get => _balance; 
            set => _balance = value; 
        }

        public string AccountOwner { 
            get => $"{FirstName} {LastName}"; 
        }

        public virtual void Deposit (decimal funds) {
            Balance += funds;
        } 
        public virtual decimal Withdraw (decimal requested) {

            Balance -= requested;

            return requested;
        } 

    }
}
