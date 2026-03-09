using Avalonia.Controls;
using Avalonia.Media.Imaging;
using System;
using System.IO;

namespace MonBureau.Views;

public partial class ImageWindow : Window
{
    public int ImageWidth { get; private set; }  
    public int ImageHeight { get; private set; } 

    public ImageWindow(string imagePath)
    {
        DataContext = this;

        if (File.Exists(imagePath))
        {
            var bitmap = new Bitmap(imagePath); 
            ImageWidth = bitmap.PixelSize.Width;
            ImageHeight = bitmap.PixelSize.Height;
            Console.WriteLine($"Loaded image: {imagePath} (Width: {ImageWidth}px, Height: {ImageHeight}px)");

            InitializeComponent();
            Content = new Image { Source = bitmap };
        }
        else
        {
            InitializeComponent();
            Console.WriteLine("Image file not found: " + imagePath);
        }
    }
}
