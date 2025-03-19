// See https://aka.ms/new-console-template for more information

using Misc;


Thread thread1 = new Thread(new PrintChar('a', 100).Run);
Thread thread2 = new Thread(new PrintChar('b', 100).Run);
Thread thread3 = new Thread(new PrintNum(100).Run);
Console.WriteLine("Thread 1"+ thread1.IsAlive);
//Thread thread4 = new Thread(new PrintNum2(100).Run);
thread1.IsBackground = true;
thread2.Priority = ThreadPriority.Highest;
Console.WriteLine(thread1.Priority);
Console.WriteLine(thread2.Priority);
Console.WriteLine(thread3.Priority);
Console.WriteLine(Thread.CurrentThread.Priority);



// Start threads
thread1.Start();
Console.WriteLine("Thread 1 After start"+ thread1.IsAlive);
thread2.Start();
thread3.Start();
//thread4.Start();
