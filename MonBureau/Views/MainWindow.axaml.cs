using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media.Imaging;
using Avalonia.Threading;
using System;
using System.Diagnostics;
using System.IO;


namespace MonBureau.Views
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
            timer.Tick += (_, _) => ClockText.Text = DateTime.Now.ToString("HH:mm  dd/MM/yyyy");
            timer.Start();
        }
        void OpenBrowser(object? s, RoutedEventArgs e)
            => Process.Start(new ProcessStartInfo("https://google.com") { UseShellExecute = true });

        void OpenVideo(object? s, RoutedEventArgs e)
        {
            var w = new VideoWindow(@"C:\Users\matis\Desktop\Perso\LearningC#\MonBureau\MonBureau\Videos\video.mp4");
            w.Show();
        }


        void OpenImage(object? s, RoutedEventArgs e)
        {
            var w = new ImageWindow(@"C:\Users\matis\Desktop\Perso\LearningC#\MonBureau\MonBureau\Images\image.png");
            w.Show();

        }

        void OpenSite(object? s, RoutedEventArgs e)
                => Process.Start(new ProcessStartInfo("https://www.artonik.com") { UseShellExecute = true });

    }
}