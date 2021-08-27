using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace BankSystemManagement
{
    public class Account : IAccount
    {
        public int AccountId { get; set; }
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public string Gender{ get; set; }
        public float Balance { get; set;}

        public float PayInto(float Amount)
        {
            return Balance += Amount;
        }

        public void ShowInfo()
        {
            Console.WriteLine( $"Account ID: {AccountId}, First Name: {FirstName}, Last Name: {LastName}, Gender: {Gender}, Balance: {Balance}");
        }

    }
}