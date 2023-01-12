using System;

namespace ProgChallenge
{
    // classes have a name, unique within the namespace
    class CheckingAcct : Accounts 
    {
        private const decimal OVERDRAW_CHARGE = 35.0m;
        public CheckingAcct (string firstName, string lastName, decimal balance) 
        : base (firstName, lastName, balance) {}

        public override decimal Withdraw(decimal requested)
        {
            if (requested > Balance) {
                Console.WriteLine("Overdraw Checking - penalty applied");
                // base.Withdraw(OVERDRAW_CHARGE);
                requested += OVERDRAW_CHARGE;
            }

            return base.Withdraw(requested);
        }
    }
}
