﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ATM
{
    //Account class
    public class Account
    {
        //the attributes for the account
        private int balance;
        private int pin;
        private int accountNum;

        // a constructor that takes initial values for each of the attributes (balance, pin, accountNumber)
        public Account(int balance, int pin, int accountNum)
        {
            this.balance = balance;
            this.pin = pin;
            this.accountNum = accountNum;
        }

        //getter and setter functions for balance
        public int getBalance()
        {
            return balance;
        }
        public void setBalance(int newBalance)
        {
            this.balance = newBalance;
        }

        /*
         *   This funciton allows us to decrement the balance of an account
         *   it perfomes a simple check to ensure the balance is greater tha
         *   the amount being debeted
         *   
         *   returns:
         *   true if the transactions if possible
         *   false if there are insufficent funds in the account
         */
        public Boolean decrementBalance(int amount)
        {
            if (this.balance > amount)
            {
                //includes artificial delays
                Thread.Sleep(3000);
                balance -= amount;
                Thread.Sleep(3000);
                return true;
            }
            else
            {
                return false;
            }
        }

        /*
         * This funciton check the account pin against the argument passed to it
         *
         * returns:
         * true if they match
         * false if they do not
         */
        public Boolean checkPin(int pinEntered)
        {
            if (pinEntered == pin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int getAccountNum()
        {
            return accountNum;
        }
    }
    //Bank class
    public class Bank
    {
        //initializes account array
        private Account[] accounts = new Account[3];

        //constructor
        public Bank()
        {
            //Accounts given from code template
            accounts[0] = new Account(300, 1111, 111111);
            accounts[1] = new Account(750, 2222, 222222);
            accounts[2] = new Account(3000, 3333, 333333);

        }

        /*
         * This function returns all the accounts
         *
         * returns:
         * the accounts
         */
        public Account[] getAccounts()
        {
            return accounts;
        }

    }

}
