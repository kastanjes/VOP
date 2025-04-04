﻿// See https://aka.ms/new-console-template for more information

using SynchronizationUsingMonitor;

Account account = new Account();

// Create and launch 100 tasks
Task[] tasks = new Task[100];
AddAPennyTask addAPennyTask = new AddAPennyTask(account);

for (int i = 0; i < 100; i++)
{
    tasks[i] = Task.Run(() => addAPennyTask.Run());
}

Task.WaitAll(tasks); // Wait until all tasks are finished

Console.WriteLine("What is balance? " + account.GetBalance());

