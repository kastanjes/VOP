namespace NoSynchronization;

public class Account
{
    private int balance = 0;

    public int GetBalance()
    {
        return balance;
    }

    public void Deposit(int amount)
    {
        int newBalance = balance + amount;
        balance = newBalance;
    }
}
