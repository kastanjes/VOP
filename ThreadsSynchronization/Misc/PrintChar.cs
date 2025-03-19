namespace Misc;

public class PrintChar
{
    private char charToPrint; // The character to print
    private int times; // The times to repeat

    public PrintChar(char c, int t) 
    { 
        charToPrint = c;
        times = t;
    }
    
public void Run() {
        for (int i = 0; i < times; i++) 
        {
            Console.Write(charToPrint);
            
        }
    }
}
