using System;
using System.Threading;
using Avalonia.Controls;

namespace FlashingText;

public partial class MainWindow : Window
{
    private string text;
    private Thread thread;
    private int waitTime;

    private string test; 
    private string test2;
    
    
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ChangeLabel()
    {
        throw new NotImplementedException("This method is not yet implemented.");
    }
    
    
}