using System;

namespace MatrixBank1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Checking checking = new Checking("John", "Doe", 2500.0m);
            Savings saving = new Savings("Jane", "Doe", 0.025m, 1000.0m);

            Console.WriteLine($"Name: {checking.Name}\nSurname: {checking.Surname}\nBalance: {checking.Initial_balance}");
            Console.WriteLine($"Name: {saving.Name}\nSurname: {saving.Surname}\nInterest: {saving.Interest}\nBalance: {saving.Initial_balance}");


            Console.WriteLine($"Checking balance is {checking.Initial_balance:C2}");
            Console.WriteLine($"Savings balance is {saving.Initial_balance:C2}");


            Console.WriteLine($"Checking owner: {checking.AccountOwner("Jhon", "Doe")}");
            Console.WriteLine($"Savings owner: {saving.AccountOwner("Jane", "Doe")}");


            Console.WriteLine(checking.Deposit(200.0m));
            Console.WriteLine(saving.Deposit(150.0m));


            Console.WriteLine($"Checking balance is {checking.Initial_balance:C2}");
            Console.WriteLine($"Savings balance is {saving.Initial_balance:C2}");


            checking.Withdraw(50.0m);
            saving.Withdraw(125.0m);

            Console.WriteLine($"Checking balance is {checking.Initial_balance:C2}");
            Console.WriteLine($"Savings balance is {saving.Initial_balance:C2}");

            saving.ApplyInterest(1025);
            Console.WriteLine($"Savings balance is {saving.Initial_balance:C2}");

            saving.Withdraw(10.00m);
            saving.Withdraw(20.00m);
            saving.Withdraw(30.00m);


            Console.WriteLine($"Savings balance is {saving.Initial_balance:C2}");

            saving.Withdraw(2000.0m);
            checking.Withdraw(3000.0m);


            Console.WriteLine($"Checking balance is {checking.Initial_balance:C2}");
            Console.WriteLine($"Savings balance is {saving.Initial_balance:C2}");
        }
    }
}
