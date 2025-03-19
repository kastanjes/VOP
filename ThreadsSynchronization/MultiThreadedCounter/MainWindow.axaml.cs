using System;
using System.Threading;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Threading;

namespace MultiThreadedCounter;

public partial class MainWindow : Window
{
    
    private int counter;
    private Thread thread;
    private int waitTime=1000;
    public MainWindow()
    {
        InitializeComponent();
    }
    
    private void StartHandler(object sender, RoutedEventArgs e)
    {
        thread = new Thread(IncrementCounter);
        thread.IsBackground = true;
        thread.Start();
    }
    
    private void IncrementCounter()
    {
        try
        {
            while (true)
            {
                string currentCounter = "";
                Dispatcher.UIThread.InvokeAsync(() => currentCounter = counterText.Text).Wait();

                counter=int.Parse(currentCounter);
                counter = counter + 1;

                Console.WriteLine("Counter: " + counter);

                Dispatcher.UIThread.InvokeAsync(() => counterText.Text = counter.ToString()).Wait();

                Thread.Sleep(waitTime);
            }
        }
        catch (ThreadInterruptedException ex)
        {
            Console.WriteLine("Interrupted");
        }
    }
    private void StopHandler(object sender, RoutedEventArgs e)
    {
        
        thread.Interrupt();
    }
}