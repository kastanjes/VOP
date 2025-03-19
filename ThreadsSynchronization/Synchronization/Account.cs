using System.Runtime.CompilerServices;

namespace Synchronization;

public class Account
{
    private int balance = 0;

    [MethodImpl(MethodImplOptions.Synchronized)]
    public int GetBalance()
    {
        return balance;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void Deposit(int amount)
    {
        int newBalance = balance + amount;
        balance = newBalance;
    }
}
