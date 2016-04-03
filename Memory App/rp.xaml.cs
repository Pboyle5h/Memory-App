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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Memory_App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class rp : Page
    {
        public rp()
        {
            this.InitializeComponent();
            level();
        }

       

        public void level()
        {
            switch (App.level)
            {
                case 1:                    
                    ImageBrush brush1 = new ImageBrush();
                    brush1.ImageSource = new BitmapImage(new Uri("ms-appx:///Pictures/cooltext174981939091066.png", UriKind.Absolute));
                    image1.Source = brush1.ImageSource;                    
                    ImageBrush brush2 = new ImageBrush();
                    brush2.ImageSource = new BitmapImage(new Uri("ms-appx:///Pictures/cooltext174877648874930.png", UriKind.Absolute));
                    image2.Source = brush2.ImageSource;
                    textBlock.Text = App.easyLevel.ToString();

                    break;
                case 2:
                    
                    break;
                case 3:
                    
                    break;

            }



        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }
    }
}