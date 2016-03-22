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
        public Boolean firstClick = true;
        public string img1, img2, butName;
       
        List<Button> butList = new List<Button>()
        {


        };

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
                "ms-appx:///Pictures/wine.png",
                "ms-appx:///Pictures/bell.png",
                "ms-appx:///Pictures/bottle.png",
                "ms-appx:///Pictures/cheese.png",
                "ms-appx:///Pictures/folder.png",
                "ms-appx:///Pictures/gauge.png",
                "ms-appx:///Pictures/hamburger.png",
                "ms-appx:///Pictures/watch.png",
                "ms-appx:///Pictures/wine.png"

            };

            List<Image> imgs = new List<Image>()
            {
                image0, image1, image2, image3, image4,
                image5, image6, image7, image8, image9,
                image10, image11, image12, image13, image14, image15
            };
           for (int i=15; i>=0; i--)
           {

                int randomNumber = rnd.Next(0, pics1.Count);

                ImageBrush brush1 = new ImageBrush();
                brush1.ImageSource = new BitmapImage(new Uri(pics1[randomNumber], UriKind.Absolute));

                imgs[i].Source = brush1.ImageSource;
                pics1.RemoveAt(randomNumber);
                imgs[i].Visibility = Visibility.Collapsed;
            }

            



        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            image0.Visibility = Visibility.Visible;
            button.Visibility = Visibility.Collapsed;
            if (firstClick)
            {

                img1 = ((BitmapImage)image0.Source).UriSource.ToString();
                butList.Add(button);
                firstClick = false;
            }
            else
            {
                img2 = ((BitmapImage)image0.Source).UriSource.ToString();
                if (img1 == img2)
                {


                }
                else
                {
                    button.Visibility = Visibility.Visible;
                    butList[0].Visibility = Visibility.Visible;
                    butList.RemoveAt(0);
                    firstClick = true;

                }

            }


        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            image1.Visibility = Visibility.Visible;
            button1.Visibility = Visibility.Collapsed;
            if (firstClick)
            {

                img1 = ((BitmapImage)image1.Source).UriSource.ToString();
                butList.Add(button1);
                firstClick = false;
            }
            else
            {
                img2 = ((BitmapImage)image1.Source).UriSource.ToString();
                if (img1 == img2)
                {


                }
                else
                {
                    button1.Visibility = Visibility.Visible;
                    butList[0].Visibility = Visibility.Visible;
                    butList.RemoveAt(0);
                    firstClick = true;

                }

            }
        }

        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
            image2.Visibility = Visibility.Visible;
            button2.Visibility = Visibility.Collapsed;
            if (firstClick)
            {

                img1 = ((BitmapImage)image2.Source).UriSource.ToString();
                butList.Add(button2);
                firstClick = false;
            }
            else
            {
                img2 = ((BitmapImage)image2.Source).UriSource.ToString();
                if (img1 == img2)
                {


                }
                else
                {
                    button2.Visibility = Visibility.Visible;
                    butList[0].Visibility = Visibility.Visible;
                    butList.RemoveAt(0);
                    firstClick = true;

                }

            }

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            image3.Visibility = Visibility.Visible;
            button3.Visibility = Visibility.Collapsed;
            if(firstClick)
            {
                
                img1 = ((BitmapImage)image3.Source).UriSource.ToString();
                butList.Add(button3);                    
                firstClick = false;
            }
            else
            {
                img2=((BitmapImage)image3.Source).UriSource.ToString();
                if(img1==img2)
                {
                                  
                
                }
                else
                {
                    button3.Visibility = Visibility.Visible;
                    butList[0].Visibility = Visibility.Visible;
                    butList.RemoveAt(0);
                    firstClick = true;

                }

            }

        }

        
    }
}
