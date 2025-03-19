namespace Misc;

public class PrintNum2
{
    private int lastNum;
    public PrintNum2(int n) {
        lastNum = n;
    }

    public void Run() {
        
        Thread thread1 = new Thread(new PrintChar('c', 40).Run);
        thread1.Start();
        try
        {
            for (int i = 1; i <= lastNum; i++)
            {
                Console.Write(" " + i);
                if (i == 50)
                {
                    thread1.Join();
                }
            }
        }
    
        catch (ThreadInterruptedException e)
        {
            Console.WriteLine(e.Message);
        } 
    }
}
