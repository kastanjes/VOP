// See https://aka.ms/new-console-template for more information

using Solution;

string[] fileNames = { "alice30.txt", "Boscombe.txt", "Snow White.txt" };

Thread[] threads = new Thread[fileNames.Length];

for (int i = 0; i < fileNames.Length; i++)
{
    WordCountingTask wct = new WordCountingTask(fileNames[i]);
    threads[i] = new Thread((wct.Run));
    threads[i].Start();
}