## Word Counting Program Instructions

**Objective:**

Write a C# program that counts number the words in three text files using 3 separate threads which are executed in parallel. You are provided with a project structure and some starter code.

**Steps:**

1.  **WordCounting Project Setup:**

You are provided with a project named "Exercise". This project contains:
 
- `Program.cs` (Take a look: main class, fully implemented and responsible for threads creation and execution. Pay attention to how threads are created and executed)
- `WordCountingTask.cs` (Take a look: partially implemented)
- Text files: `alice30.txt`, `Boscombe.txt`, and `Snow White.txt`

2.  **Implement the `Run()` method of`WordCountingTask.cs`:**

The `run()` method should perform the following actions:

- Use the `SteamReader` class to open and read a file, which is initialised in the `WordCountingTask` constructor.
- Read the file line by line and split into words using the `Split()` method. 
- Increment a counter variable for each word read.
- After reading the entire file, print the file name and the total word count to the console.
- Handle potential `FileNotFoundException`.
- Resource should be disposed automatically. Hint: Use `using` statement.

**Output:**
    The output of the program should be similar to the following: The order of text files could be different depending on which thread finished its execution first.

    ```
    Snow White.txt: 1293
    Boscombe.txt: 9674
    alice30.txt: 26467
    ```



