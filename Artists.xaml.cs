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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MusicWorlds
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Artists : Page
    {
        public Artists()
        {
            this.InitializeComponent();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void AlanWalker_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AlanWalker));
        }

        private void Marshmallow_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Marshmello));
        }

        private void JinYosef_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(JimYosef));
        }

        private void Tobu_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Tobu));
        }

        private void Artist_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Artists));
        }
    }
}
