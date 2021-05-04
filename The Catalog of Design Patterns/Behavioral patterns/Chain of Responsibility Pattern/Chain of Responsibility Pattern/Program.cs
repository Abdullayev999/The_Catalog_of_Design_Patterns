using System;

namespace Chain_of_Responsibility_Pattern
{
    using System;

    namespace ChainOfResponsibility
    {

        class Program
        {
            static void Main(string[] args)
            {
                IMoneyOperationHandler verifyHandler = new VerifyAccountHandler();
                IMoneyOperationHandler checkHandler = new CheckMoneyHandler();
                IMoneyOperationHandler loggerHandler = new MoneyOperationLoggerHandler();
                IMoneyOperationHandler recieveHandler = new RecieveMoneyHandler();
                

                verifyHandler.Next = checkHandler;
                checkHandler.Next = loggerHandler;
                loggerHandler.Next = recieveHandler;

                string cardNumber;
                int pin;
                decimal money;

                Console.WriteLine("Enter card number: ");
                cardNumber = Console.ReadLine();
                Console.WriteLine("Enter pin: ");
                pin = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter amount: ");
                money = decimal.Parse(Console.ReadLine());

                verifyHandler.Handle(cardNumber, pin, money);
                
            }
        }
    }

}
