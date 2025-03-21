using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media.Imaging;
using Avalonia.Platform;

namespace AvaloniaExercises;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        this.Width = 600; 
        this.Height = 500;
    }
    private void Exercise2ShowOutput_Click(object sender, RoutedEventArgs e)
    {
        var textBox = this.FindControl<TextBox>("Exercise2TextBox");
        var comboBox = this.FindControl<ComboBox>("Exercise2ComboBox");
        var outputTextBlock = this.FindControl<TextBlock>("OutputTextBlock");
        var checkBox = this.FindControl<CheckBox>("Exercise2CheckBox");

        string output = $"TextBox: {textBox.Text}, ComboBox: {comboBox.SelectionBoxItem}, CheckBox: {checkBox.IsChecked}";
        outputTextBlock.Text = output;
    }
    
    private void Exercise3ShowImage_Click(object sender, RoutedEventArgs e)
    { 
        var catRadioButton = this.FindControl<RadioButton>("CatRadioButton");
        var dogRadioButton = this.FindControl<RadioButton>("DogRadioButton");
        var birdRadioButton = this.FindControl<RadioButton>("BirdRadioButton");
        
        var animalImage = this.FindControl<Image>("AnimalImage");
        
        var catImage = this.FindControl<Image>("AnimalImage");
        var dogImage = this.FindControl<Image>("AnimalImage");
        var birdImage = this.FindControl<Image>("AnimalImage");

        if (catRadioButton.IsChecked == true)
        {
            AnimalImage.Source =  new Bitmap(AssetLoader.Open(new Uri("avares://AvaloniaExercises/Assets/cat.jpg")));
        }
        else if (DogRadioButton.IsChecked == true)
        {
            AnimalImage.Source =  new Bitmap(AssetLoader.Open(new Uri("avares://AvaloniaExercises/Assets/dog.jpg")));
        }
        else if (BirdRadioButton.IsChecked == true)
        {
            AnimalImage.Source =  new Bitmap(AssetLoader.Open(new Uri("avares://AvaloniaExercises/Assets/bird.jpg")));
        }
     
    }

    private void Add_Click(object sender, RoutedEventArgs e)
    {
        double num1 = double.Parse(TextBoxNumber1.Text);
        double num2 = double.Parse(TextBoxNumber2.Text);
    
        Result.Text = (num1 + num2).ToString();
    }

    private void Subtract_Click(object sender, RoutedEventArgs e)
    {
        double num1 = double.Parse(TextBoxNumber1.Text);
        double num2 = double.Parse(TextBoxNumber2.Text);
    
        Result.Text = (num1 - num2).ToString();
    }

    private void Multiply_Click(object sender, RoutedEventArgs e)
    {
        double num1 = double.Parse(TextBoxNumber1.Text);
        double num2 = double.Parse(TextBoxNumber2.Text);
    
        Result.Text = (num1 * num2).ToString();
    }


}
