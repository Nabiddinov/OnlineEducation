﻿using OnlineEducation.Models;
using OnlineEducation.States;

namespace OnlineEducation.Interfaces
{
    interface IAccount
    {
        Guid Id { get; set; }
        string AccountNumber { get; set; }
        AccountStatus AccountStatus { get; set; }
        void RemoveAccount(Account account);
        //static Account AddAccount(string PersonId);

    }
}
