namespace Chain_of_Responsibility_Pattern
{
    using System;
    using System.Linq;

    namespace ChainOfResponsibility
    {
        class CheckMoneyHandler : IMoneyOperationHandler
        {
            public IMoneyOperationHandler Next { get; set; }

            public void Handle(string cardNumber, int pin, decimal money)
            {
                var account = AccountDatabase.Accounts.FirstOrDefault(x => x.CardNumber == cardNumber && x.Pin == pin);
                if (account.Money >= money)
                    Next.Handle(cardNumber, pin, money);
                else
                    Console.WriteLine("Error! Not enough money!");
            }
        }
    }

}
