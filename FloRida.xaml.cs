using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Media.Playback;
using Windows.Media.Core;

namespace SoundOfMusic
{

    public sealed partial class FloRida : Page
    {
        MediaPlayer SoundOfMusic;
        public FloRida()
        {
            this.InitializeComponent();
            SoundOfMusic = new MediaPlayer();
            SoundOfMusic.Volume = 0.3;
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Artist_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Artists));
        }
        private async void Club_Cant_Handle_Me_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Flo-Rida");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Club Can't Handle Me.mp3");

            SoundOfMusic.AutoPlay = false;
            SoundOfMusic.Source = MediaSource.CreateFromStorageFile(file);

            SoundOfMusic.Play();
        }

        private async void Low_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Flo-Rida");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Low.mp3");

            SoundOfMusic.AutoPlay = false;
            SoundOfMusic.Source = MediaSource.CreateFromStorageFile(file);

            SoundOfMusic.Play();
        }

        private async void Right_Round_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Flo-Rida");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Right Round.mp3");

            SoundOfMusic.AutoPlay = false;
            SoundOfMusic.Source = MediaSource.CreateFromStorageFile(file);

            SoundOfMusic.Play();
        }

        private async void Whistle_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Flo-Rida");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Whistle.mp3");

            SoundOfMusic.AutoPlay = false;
            SoundOfMusic.Source = MediaSource.CreateFromStorageFile(file);

            SoundOfMusic.Play();
        }

        private async void Wild_Ones_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Flo-Rida");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Wild Ones.mp3");

            SoundOfMusic.AutoPlay = false;
            SoundOfMusic.Source = MediaSource.CreateFromStorageFile(file);

            SoundOfMusic.Play();
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            SoundOfMusic.Source = null;
        }
    }
}
