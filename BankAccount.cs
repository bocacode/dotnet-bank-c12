using System.Runtime.InteropServices;

public class BankAccount {

    private  double Balance = 0;
    public string OwnersName = "";

    // constructor
    public BankAccount(string NewOwnersName,double initialBalance) {

        this.OwnersName = NewOwnersName;
        this.Deposit(initialBalance);
        //dethis.Deposit(100); // for new account
    }

    public double Deposit(double amount ) {
        if (amount < 0.00 )
            {
                throw new Exception("Nope");
            }
        this.Balance += amount; 
        return this.Balance;
    }

    public double Withdraw(double amount ) {

        if (amount < 0  ) {
            throw new Exception("No negativity");
        }

        if (amount > this.Balance) {
            throw new Exception("You don't have that much! hahaha");
        }
        
        // todo send money out atm door
        this.Balance -= amount;
        return this.Balance;

    }

    public double getBalance() {
        return this.Balance;
    }

}