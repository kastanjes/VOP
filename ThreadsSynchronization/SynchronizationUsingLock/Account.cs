namespace SynchronizationUsingLocks;

public class Account
{
    private int balance = 0;
    private Object myLock = new Object(); 
    public int GetBalance()
    {
        lock (myLock)
        {
            return balance;
        }
    }
    public void Deposit(int amount)
    {
        lock (myLock)
        {
            int newBalance = balance + amount;
            balance = newBalance;
        }
    }
}
