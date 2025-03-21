using System.IO;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Platform.Storage;

namespace Search_and_Replace.Search_and_Replace;

public partial class MainWindow : Window
{
    
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ReplaceButton_Click(object sender, RoutedEventArgs e)
    {
        string searchText = SearchTextBox.Text;
        string replaceText = ReplaceTextBox.Text;
        
        string contentTextBox = ContentTextBox.Text;
        
        string[] contentTextArray = contentTextBox.Split(" ");

        for (int i = 0; i < contentTextArray.Length; i++)
        {
            if (contentTextArray[i] == searchText)
            {
                contentTextArray[i] = replaceText;
            }
        }
        
        string updatedText = string.Join(" ", contentTextArray);
        ContentTextBox.Text = updatedText;
    }

    private void OpenFileButton_Click(object sender, RoutedEventArgs e)
    {
        string filePath = "C:\\Users\\Sarah\\OneDrive\\SDU\\Ny mappe\\test.txt";

        using (var reader = new StreamReader(filePath))
        {
            string fileContent = reader.ReadToEnd();
            ContentTextBox.Text = fileContent;
        }
    }
    private void SaveButton_Click(object sender, RoutedEventArgs e)
    {
        string filePath = "C:\\Users\\Sarah\\OneDrive\\SDU\\Ny mappe\\test.txt";
        
        using (var writer = new StreamWriter(filePath))
        {
            writer.Write(ContentTextBox.Text);
        }
    }

}