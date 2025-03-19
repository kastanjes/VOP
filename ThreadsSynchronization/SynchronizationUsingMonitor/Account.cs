namespace SynchronizationUsingMonitor;

public class Account
{
    private int balance = 0;
    private Object myLock = new Object(); 
    public int GetBalance()
    {
        try
        {
            Monitor.Enter(myLock);
            return balance;
        }
        finally
        {
            Monitor.Exit(myLock);
        }
    }
    public void Deposit(int amount)
    {
        try
        {
            Monitor.Enter(myLock);
            int newBalance = balance + amount;
            balance = newBalance;
        }
        finally
        {
            Monitor.Exit(myLock);
        }
    }
}
