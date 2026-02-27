namespace DemoSession02_OOP_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Encapculation Using Setter And Getter
            //BankAccount Acc01 = new BankAccount();
            //Acc01.SetName("Sheka");
            //Acc01.SetBalance(-50);
            //Console.WriteLine(Acc01.GetBalance());
            #endregion


            #region Encapculation Using Properties
            //BankAccount Acc01 = new BankAccount();
            //Acc01.Name = "ka";
            //Console.WriteLine(Acc01.Name);
            #endregion


            #region TypesProperty

            #region Read_WriteProperty
            //BankAccount account = new BankAccount();
            //account.AccountNumber = 151;
            //Console.WriteLine(account.AccountNumber);

            #endregion
            #region Read_OnlyProperty
            //BankAccount Acc02 = new BankAccount();
            //Console.WriteLine(Acc02.Balance);//ReadOnly
            #endregion
            #region Property With Private Setter
           /* Acc02.Pin = 122*/;//Set Only Inside Class (Modify ONly Inside Method)

            #endregion
            #region Property With Computed
            //Console.WriteLine(account.HasBalance);//false
            #endregion
            #region Init Property
            //BankAccount ACC02 = new BankAccount() { Pin=123};//Set only During creation
            // ACC02.Pin =123 //Error
            //Console.WriteLine(ACC02.Pin);

            #endregion
            #endregion
        }
    }
}
