using System;
using System.Collections.Generic;
using System.Text;

namespace DemoSession02_OOP_
{
    internal class BankAccount
    {
        #region Fields
        private int _AccountNumber;
        private decimal _Balance;

        private string _Name;

        #endregion
        #region Encapculation Using Setter And Getter


        #region Methods

        //public void SetBalance(decimal balance)
        //{
        //    if (balance < 0)
        //    {
        //        Console.WriteLine("Invalid Negative Number");
        //        return;
        //    }
        //    _Balance = balance;
        //}
        //public decimal GetBalance()
        //{
        //    return _Balance;
        //}
        //public int GetAccountNumber() //Read
        //{
        //    return _AccountNumber;
        //}

        //public void SetName(string value) 
        //{   
        //    _Name = value;
        //}
        #endregion
        #endregion


        #region Encapculation Using Properties

        //public string Name 
        //{
        //    get { return _Name; }
        //    set {
        //        if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
        //        {
        //            Console.WriteLine("Invalid Input ");
        //            return;
        //        }
        //        _Name = value;
                
                
        //         }

        
        
        //}

        #endregion
    }
}
