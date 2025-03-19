namespace SynchronizationUsingMonitor;

public class AddAPennyTask
{
    Account account;

    public AddAPennyTask(Account account)
    {
        this.account = account;
    }

    public void Run()
    {
        account.Deposit(1);
    }
}