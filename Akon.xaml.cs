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

    public sealed partial class Akon : Page
    {
        MediaPlayer SoundOfMusic;
        public Akon()
        {
            this.InitializeComponent();
            SoundOfMusic = new MediaPlayer();
            SoundOfMusic.Volume = 0.3;
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private async void Blame_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Akon");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Blame-It-On-Me.mp3");

            SoundOfMusic.AutoPlay = false;
            SoundOfMusic.Source = MediaSource.CreateFromStorageFile(file);

            SoundOfMusic.Play();
        }

        private async void Lonely_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Akon");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Lonely.mp3");

            SoundOfMusic.AutoPlay = false;
            SoundOfMusic.Source = MediaSource.CreateFromStorageFile(file);

            SoundOfMusic.Play();
        }

        private async void Beautiful_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Akon");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Beautiful.mp3");

            SoundOfMusic.AutoPlay = false;
            SoundOfMusic.Source = MediaSource.CreateFromStorageFile(file);

            SoundOfMusic.Play();
        }

        private async void Lonely_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Akon");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Lonely.mp3");

            SoundOfMusic.AutoPlay = false;
            SoundOfMusic.Source = MediaSource.CreateFromStorageFile(file);

            SoundOfMusic.Play();
        }

        private async void Right_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Akon");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Right-Now.mp3");

            SoundOfMusic.AutoPlay = false;
            SoundOfMusic.Source = MediaSource.CreateFromStorageFile(file);

            SoundOfMusic.Play();
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            SoundOfMusic.Source = null;
        }

        private void Artist_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Artists));
        }
    }
}
