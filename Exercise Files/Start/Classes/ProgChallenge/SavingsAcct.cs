using System;

namespace ProgChallenge
{
    // classes have a name, unique within the namespace
    class SavingsAcct : Accounts
    {
        public decimal _interest;
        public int _withdrawCount = 0;

        private const int WITHDRAW_LIMIT = 3;
        private const decimal WITHDRAW_CHARGE = 2.0m;

        public SavingsAcct (string firstName, string lastName, decimal interest, decimal balance) 
        : base(firstName, lastName, balance) {
            _interest = interest;
        }

        public decimal Interest {
            get => _interest;
            set => _interest = value;
        }
        
        public int WithdrawCount {
            get => _withdrawCount;
            set => _withdrawCount = value;
        }

        public override decimal Withdraw(decimal requested)
        {
            if (requested > Balance) {
                Console.WriteLine("Attempt to overdraw savings - denied");
                return 0;
            }

            WithdrawCount++;

            if (WithdrawCount > WITHDRAW_LIMIT) {
                Console.WriteLine("More than 3 withdrawls - extra charge penalty");
                base.Withdraw(WITHDRAW_CHARGE); // 2 dollar charge
            }

            return base.Withdraw(requested);
        }

        public void ApplyInterest () {
            base.Deposit(Balance * Interest);
        }
    }
}
