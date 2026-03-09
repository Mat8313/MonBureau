using Avalonia.Controls;
using LibVLCSharp.Avalonia;
using LibVLCSharp.Shared;
using System;

namespace MonBureau.Views;

public partial class VideoWindow : Window
{
    private LibVLC _libVlc;
    private MediaPlayer _player;

    public VideoWindow(string videoPath)
    {
        InitializeComponent();
        Core.Initialize();

        _libVlc = new LibVLC();
        _player = new MediaPlayer(_libVlc);
        _player.Media = new Media(_libVlc, videoPath, FromType.FromPath);

        Opened += (_, _) =>
        {
            VideoView.MediaPlayer = _player;
            _player.Play();
        };

        Closed += (_, _) =>
        {
            try
            {
                _player.Stop();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur fermeture vidéo : " + ex.Message);
            }
        };

    }
}

