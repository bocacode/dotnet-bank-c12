public class SavingsAccount : BankAccount {

    //constructor
    public SavingsAccount(string NewOwnersName, double InitialBalance) 
    : base(NewOwnersName, InitialBalance)
    {
        this.Deposit(100); // give extra $100
    }
}

public class CheckingAccount : BankAccount {

    //constructor
    public CheckingAccount(string NewOwnersName, double InitialBalance) 
    : base(NewOwnersName, InitialBalance)
    {
        
    }
}