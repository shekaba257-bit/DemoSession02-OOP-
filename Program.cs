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
            #region Indexer Example01
            //ToDoList Test =new ToDoList(3);

            //Test[0] = "Sheka";
            //Test[1] = "Ali";
            //Test[2] = "";
            //Console.WriteLine(Test[0]);
            //Console.WriteLine(Test[1]);
            //Console.WriteLine(Test[2]);

            #endregion
            #region Indexer Example 02
            //Library lib=new Library("AlexLibrary");
            //lib.AddBook(new Books("123-45600", "oop"));
            //lib.AddBook(new Books("246-36900", "c#"));

            //Console.WriteLine(lib[0].Title);//oop




            #endregion
            #region Static Keyword

            #region Static Variables
            //called by NameOf Class

            //Student S1 = new Student("Ali");


            //Console.WriteLine($"After Creation Ahmed :Total Student = {Student.TotalStudent}"); //1

            //Student S = new Student("Mohamed");

            //Console.WriteLine($"After Creation Mohamed :Total Student = {Student.TotalStudent}"); // 2


            #endregion

            #region Static Method

            //Counter.Increment();
            //Counter.Decrement();

            //Counter C1 = new Counter();
            //C1.Increment() //Called ONLY BY ClassName
            #endregion

            #region Static Constructor
            //Class Name Product
            //Product P1 = new Product("Iphone",7888.25M);
            //Product P2 = new Product("Samsung",5225.25M);


            //Console.WriteLine(P1);
            //Console.WriteLine(P2);
            #endregion
            #endregion
        }
    }
}
