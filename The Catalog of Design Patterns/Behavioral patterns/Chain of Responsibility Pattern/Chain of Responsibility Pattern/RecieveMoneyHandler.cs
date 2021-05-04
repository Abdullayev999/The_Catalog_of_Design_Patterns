namespace Chain_of_Responsibility_Pattern
{
    using System.Linq;

    namespace ChainOfResponsibility
    {
        class RecieveMoneyHandler : IMoneyOperationHandler
        {
            public IMoneyOperationHandler Next { get; set; }

            public void Handle(string cardNumber, int pin, decimal money)
            {
                var account = AccountDatabase.Accounts.FirstOrDefault(x => x.CardNumber == cardNumber && x.Pin == pin);
                account.Money -= money;
            }
        }
    }

}
