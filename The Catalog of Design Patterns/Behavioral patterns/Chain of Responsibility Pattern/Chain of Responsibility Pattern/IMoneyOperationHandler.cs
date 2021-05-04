namespace Chain_of_Responsibility_Pattern
{
    namespace ChainOfResponsibility
    {
        interface IMoneyOperationHandler
        {
            IMoneyOperationHandler Next { get; set; }
            void Handle(string cardNumber, int pin, decimal money);
        }
    }

}
