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
        #region PropertyTypes


        #region Read_Write_Property
        //public int AccountNumber
        //{
        //    get { return _AccountNumber; }
        //     set { _AccountNumber = value; }


        //}

        #region Read_OnlyProperty
        //public decimal Balance
        //{
        //    get { return _Balance; }
        //}
        #endregion

        #region WriteProperty
        // No Get (Can't Read)
        //public string Name
        //{
        //    set { _Name =  value; }
        //}

        //Hash => is a helper Method That encrypts the name (تشفير) 
        #endregion
        #region AutomaticeProperty
        //CLR Will Create Backing Field For ==> Name Don't Need private string Name ; 
        //public int Name { get; set; }

        // FulProperty
        //private int myVar;

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}



        #endregion
        #region Property With Private Setter
        //public int Pin { get;private set; }

        #endregion
        #region ComputedProperty
        //No Stored Value
        //computed And Fly
        //public bool HasBalance
        //{
        //    get {  return _Balance > 0 ; }
        //}
        #endregion

        #region Init Property
        //Set only During Creation(object create)
        //only get
        //public int? Pin { get; init; }
        #endregion




        #endregion
        #endregion
    }
}
