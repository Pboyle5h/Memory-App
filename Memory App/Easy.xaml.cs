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
    public sealed partial class Easy : Page
    {
        public Random rnd = new Random();

        public Easy()
        {
            this.InitializeComponent();
            randomPic();
        }

        public void randomPic()
        {
            List<string> pics1 = new List<string>()
            {
                "ms-appx:///Pictures/bell.png",
                "ms-appx:///Pictures/bottle.png",
                "ms-appx:///Pictures/cheese.png",
                "ms-appx:///Pictures/folder.png",
                "ms-appx:///Pictures/gauge.png",
                "ms-appx:///Pictures/hamburger.png",
                "ms-appx:///Pictures/watch.png",
                "ms-appx:///Pictures/wine.png"
                //"ms-appx:///Pictures/bell2.png",
                //"ms-appx:///Pictures/bottle2.png",
                //"ms-appx:///Pictures/cheese2.png",
                //"ms-appx:///Pictures/folder2.png",
                //"ms-appx:///Pictures/gauge2.png",
                //"ms-appx:///Pictures/hamburger2.png",
                //"ms-appx:///Pictures/watch2.png",
                //"ms-appx:///Pictures/wine2.png"

            };
            List<Image> imgs = new List<Image>()
            {
                image1, image2, image3, image4, image5,
                image6, image7, image8, image9, image10,
                image11, image12, image13, image14, image15, image16
            };
           for (int i=0; i<=15; i++)
           {

                Image img = new Image();
                img.Name = "image" + i;
                ImageBrush brush1 = new ImageBrush();
                brush1.ImageSource = new BitmapImage(new Uri(pics1[rnd.Next(0, 7)], UriKind.Absolute));
                
                imgs[i].Source = brush1.ImageSource;
                //pics1.RemoveAt(i);
            }
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            image1.Visibility = Visibility.Collapsed;
        }

        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
            //button2.Opacity = 100;
            
        }
    }
}
