namespace Chain_of_Responsibility_Pattern
{
    using System.Collections.Generic;

    namespace ChainOfResponsibility
    {
        static class AccountDatabase
        {
            public static List<Account> Accounts;

            static AccountDatabase()
            {
                Accounts = new List<Account>
            {
                new Account { FullName = "Farid Abdullayev", CardNumber = "1234", Pin = 1122, Money = 1000 },
                new Account { FullName = "Cavid Abdullayev", CardNumber = "5678", Pin = 3344, Money = 2000 }
            };
            }
        }
    }

}
