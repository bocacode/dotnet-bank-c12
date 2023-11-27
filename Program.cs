// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int age = 50;
// age = "fifty"; // can't do this

string name = "Damian";
 
//Console.WriteLine($"your name is  {name} and you're {age} years old");

try {

    CheckingAccount newAccount = new CheckingAccount("Bobby",100.99);

    //newAccount.Balance = -100.99;
    // newAccount.Balance = newAccount.Balance + 100;

    newAccount.Deposit(50.00);

    newAccount.Withdraw(40.00);

    Console.WriteLine($"{newAccount.OwnersName} balance is {newAccount.getBalance()}");
} catch (Exception err) {
    Console.WriteLine($" you got an error: {err.Message}");
}
