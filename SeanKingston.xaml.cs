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

    public sealed partial class SeanKingston : Page
    {
        MediaPlayer SoundOfMusic;
        public SeanKingston()
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

        private async void Beautiful_Girls_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\SeanKingston");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Beautiful Girls.mp3");

            SoundOfMusic.AutoPlay = false;
            SoundOfMusic.Source = MediaSource.CreateFromStorageFile(file);

            SoundOfMusic.Play();
        }

        private async void Dumb_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\SeanKingston");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Dumb.mp3");

            SoundOfMusic.AutoPlay = false;
            SoundOfMusic.Source = MediaSource.CreateFromStorageFile(file);

            SoundOfMusic.Play();
        }

        private async void Fire_Burning_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\SeanKingston");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Fire_Burning.mp3");

            SoundOfMusic.AutoPlay = false;
            SoundOfMusic.Source = MediaSource.CreateFromStorageFile(file);

            SoundOfMusic.Play();
        }

        private async void Me_Love_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\SeanKingston");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Me Love.mp3");

            SoundOfMusic.AutoPlay = false;
            SoundOfMusic.Source = MediaSource.CreateFromStorageFile(file);

            SoundOfMusic.Play();
        }

        private async void Take_You_There_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\SeanKingston");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Take You There.mp3");

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
