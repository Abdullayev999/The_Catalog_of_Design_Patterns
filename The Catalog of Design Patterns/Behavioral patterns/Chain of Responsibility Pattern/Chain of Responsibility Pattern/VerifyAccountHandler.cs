namespace Chain_of_Responsibility_Pattern
{
    using System;
    using System.Linq;

    namespace ChainOfResponsibility
    {
        class VerifyAccountHandler : IMoneyOperationHandler
        {
            public IMoneyOperationHandler Next { get; set; }

            public void Handle(string cardNumber, int pin, decimal money)
            {
                if (AccountDatabase.Accounts.Any(x => x.CardNumber == cardNumber && x.Pin == pin))
                    Next.Handle(cardNumber, pin, money);
                else
                    Console.WriteLine("Error! Invalid account!");
            }
        }
    }

}
