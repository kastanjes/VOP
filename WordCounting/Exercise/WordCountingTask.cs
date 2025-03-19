namespace WordCounting;

public class WordCountingTask
{
    private string filename;

    public WordCountingTask(string aFilename)
    {
        filename = aFilename;
    }

    public void Run()
    {
        int wordCount = 0;
            
        if (string.IsNullOrWhiteSpace(filename) || filename.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
        {
            throw new NotSupportedException("The specified filename is not supported.");
        }
        
        using (StreamReader sr = new StreamReader(filename))
        {
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                wordCount += words.Length;
            }
        }
        Console.WriteLine("Filename: " + filename + " Wordcount: " + wordCount);
    }
    
    
}