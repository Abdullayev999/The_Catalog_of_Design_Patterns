namespace Chain_of_Responsibility_Pattern
{
    using System;

    namespace ChainOfResponsibility
    {
        class MoneyOperationLoggerHandler : IMoneyOperationHandler
        {
            public IMoneyOperationHandler Next { get; set; }

            public void Handle(string cardNumber, int pin, decimal money)
            {
                Console.WriteLine($"[{DateTime.Now}] - Card number {cardNumber} - {money}");
                Next.Handle(cardNumber, pin, money);
            }
        }
    }

}
