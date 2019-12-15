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

    public sealed partial class DuaLipa : Page
    {
        MediaPlayer SoundOfMusic;
        public DuaLipa()
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

        private async void Be_The_One_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\Dua Lipa");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Be The One.mp3");

            SoundOfMusic.AutoPlay = false;
            SoundOfMusic.Source = MediaSource.CreateFromStorageFile(file);

            SoundOfMusic.Play();
        }

        private async void Dont_Start_Now_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\\Dua Lipa");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Dont Start Now.mp3");

            SoundOfMusic.AutoPlay = false;
            SoundOfMusic.Source = MediaSource.CreateFromStorageFile(file);

            SoundOfMusic.Play();
        }

        private async void Kiss_and_Makeup_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\\Dua Lipa");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Kiss and Makeup.mp3");

            SoundOfMusic.AutoPlay = false;
            SoundOfMusic.Source = MediaSource.CreateFromStorageFile(file);

            SoundOfMusic.Play();
        }

        private async void New_Rules_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\\Dua Lipa");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("New Rules.mp3");

            SoundOfMusic.AutoPlay = false;
            SoundOfMusic.Source = MediaSource.CreateFromStorageFile(file);

            SoundOfMusic.Play();
        }

        private async void Want_To_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\Musics\\Dua Lipa");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Want To.mp3");

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
