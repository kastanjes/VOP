namespace Misc;

public class PrintNum
{
    private int lastNum;
    public PrintNum(int n) {
        lastNum = n;
    }

    public void Run() {
        for (int i = 1; i <= lastNum; i++) 
        {
            Console.Write(" " + i);
            Thread.Yield();

            if (i > 50)
            {
                Thread.Sleep(500);
            }
        }
    }
}
