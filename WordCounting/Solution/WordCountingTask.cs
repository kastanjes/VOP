namespace Solution;

public class WordCountingTask
{
    private string filename;

    public WordCountingTask(string aFilename)
    {
        filename = aFilename;
    }

    public void Run()
    {
        int count = 0;
        try
        {
            using (StreamReader reader= new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries); // remove empty entries
                    count += words.Length;
                }
            }
            Console.WriteLine(filename + ": " + count);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(filename + " not found!");
        }
    }
}