using System;
using System.Threading;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Threading;

namespace FlashingText;

public partial class MainWindow : Window
{
    private string text;
    private Thread thread;
    private int waitTime;
    
    public MainWindow()
    {
        InitializeComponent();
    }
    
    private void ChangeLabel()
    {
        try
        {
            while (true)
            {
                string currentContent = "";

                // Get the label's current content on the UI thread
                Dispatcher.UIThread.InvokeAsync(() =>
                {
                    currentContent = FlashingLabel.Content?.ToString() ?? "";
                }).Wait(); // Wait for the UI thread to complete this

                // Toggle the label text
                if (string.IsNullOrEmpty(currentContent))
                {
                    text = "Programming is fun";
                }
                else
                {
                    text = "";
                }

                Console.WriteLine(text); // Write to console

                // Set the new label content on the UI thread
                Dispatcher.UIThread.InvokeAsync(() =>
                {
                    FlashingLabel.Content = text;
                }).Wait();

                // Wait for the selected delay
                Thread.Sleep(waitTime);
            }
        }
        catch (ThreadInterruptedException)
        {
            Console.WriteLine("Interrupted");
        }
    }

    

    public void StartButtonClicked(object sender, RoutedEventArgs e)
    {
        thread = new Thread(ChangeLabel);
        thread.IsBackground = true;
        thread.Start();
        
    }

    public void StopButtonClicked(object sender, RoutedEventArgs e)
    {
        thread.Interrupt();
    }

    public void RadioButtonHandler(object sender, RoutedEventArgs e)
    {
        if (sender is RadioButton radioButton && radioButton.IsChecked == true)
        {
            switch (radioButton.Content?.ToString())
            {
                case "100 ms":
                    waitTime = 100;
                    break;
                case "200 ms":
                    waitTime = 200;
                    break;
                case "400 ms":
                    waitTime = 400;
                    break;
            }
        }
    }
}