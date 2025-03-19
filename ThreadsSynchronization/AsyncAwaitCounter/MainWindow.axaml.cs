using System;
using System.Threading;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Threading;

namespace AsyncAwaitCounter;

public partial class MainWindow : Window
{
    private int counter;
    private int waitTime=1000;
    private CancellationTokenSource cts;
    public MainWindow()
    {
        InitializeComponent();
    }
    private void StartHandler(object sender, RoutedEventArgs e)
    {
        cts = new CancellationTokenSource();
        IncrementCounter(cts.Token);
        
    }

    private async Task IncrementCounter(CancellationToken token)
    {
        try
        {
            while (!token.IsCancellationRequested)
            {
                string currentCounter = await Dispatcher.UIThread.InvokeAsync(() => counterText.Text);
                counter = int.Parse(currentCounter);
                counter++;

                Console.WriteLine("Counter: " + counter);

                await Dispatcher.UIThread.InvokeAsync(() => counterText.Text = counter.ToString());

                await Task.Delay(waitTime, token);
            }
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Counter Stopped.");
        }
    }

    private void StopHandler(object sender, RoutedEventArgs e)
    {
        cts.Cancel();
    }
}
