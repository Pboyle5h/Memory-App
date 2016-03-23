using System;
using System.Collections.Generic;
using System.Threading;
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
using System.Threading.Tasks;

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
        List<Image> imgList = new List<Image>()
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

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            image0.Visibility = Visibility.Visible;
            button.Visibility = Visibility.Collapsed;
            if (firstClick)
            {

                img1 = ((BitmapImage)image0.Source).UriSource.ToString();
                butList.Add(button);
                imgList.Add(image0);
                firstClick = false;
            }
            else
            {
                img2 = ((BitmapImage)image0.Source).UriSource.ToString();
                if (img1 == img2)
                {
                    image0.Visibility = Visibility.Visible;
                    button.Visibility = Visibility.Collapsed;
                    butList[0].Visibility = Visibility.Collapsed;
                    imgList[0].Visibility = Visibility.Visible;
                    imgList.RemoveAt(0);
                    butList.RemoveAt(0);
                    firstClick = true;

                }
                else
                {
                    await Task.Delay(1000);
                    image0.Visibility = Visibility.Collapsed;
                    button.Visibility = Visibility.Visible;
                    butList[0].Visibility = Visibility.Visible;
                    imgList[0].Visibility = Visibility.Collapsed;
                    imgList.RemoveAt(0);
                    butList.RemoveAt(0);
                    firstClick = true;

                }

            }


        }

        private async void button1_Click(object sender, RoutedEventArgs e)
        {
            image1.Visibility = Visibility.Visible;
            button1.Visibility = Visibility.Collapsed;
            if (firstClick)
            {

                img1 = ((BitmapImage)image1.Source).UriSource.ToString();
                butList.Add(button1);
                imgList.Add(image1);
                firstClick = false;
            }
            else
            {
                img2 = ((BitmapImage)image1.Source).UriSource.ToString();
                if (img1 == img2)
                {
                    image1.Visibility = Visibility.Visible;
                    button1.Visibility = Visibility.Collapsed;
                    butList[0].Visibility = Visibility.Collapsed;
                    imgList[0].Visibility = Visibility.Visible;
                    imgList.RemoveAt(0);
                    butList.RemoveAt(0);
                    firstClick = true;

                }
                else
                {
                    await Task.Delay(1000);
                    image1.Visibility = Visibility.Collapsed;
                    button1.Visibility = Visibility.Visible;
                    butList[0].Visibility = Visibility.Visible;
                    imgList[0].Visibility = Visibility.Collapsed;
                    imgList.RemoveAt(0);
                    butList.RemoveAt(0);
                    firstClick = true;

                }

            }
        }

        private async void button4_Click(object sender, RoutedEventArgs e)
        {
            image4.Visibility = Visibility.Visible;
            button4.Visibility = Visibility.Collapsed;
            if (firstClick)
            {

                img1 = ((BitmapImage)image4.Source).UriSource.ToString();
                butList.Add(button4);
                imgList.Add(image4);
                firstClick = false;
            }
            else
            {
                img2 = ((BitmapImage)image4.Source).UriSource.ToString();
                if (img1 == img2)
                {
                    image4.Visibility = Visibility.Visible;
                    button4.Visibility = Visibility.Collapsed;
                    butList[0].Visibility = Visibility.Collapsed;
                    imgList[0].Visibility = Visibility.Visible;
                    imgList.RemoveAt(0);
                    butList.RemoveAt(0);
                    firstClick = true;

                }

                else
                {
                    await Task.Delay(2000);
                    image4.Visibility = Visibility.Collapsed;
                    button4.Visibility = Visibility.Visible;
                    butList[0].Visibility = Visibility.Visible;
                    imgList[0].Visibility = Visibility.Collapsed;
                    imgList.RemoveAt(0);
                    butList.RemoveAt(0);
                    firstClick = true;

                }

            }

        }



        private async void button2_Click_1(object sender, RoutedEventArgs e)
        {
            image2.Visibility = Visibility.Visible;
            button2.Visibility = Visibility.Collapsed;
            if (firstClick)
            {

                img1 = ((BitmapImage)image2.Source).UriSource.ToString();
                butList.Add(button2);
                imgList.Add(image2);
                firstClick = false;
            }
            else
            {
                img2 = ((BitmapImage)image2.Source).UriSource.ToString();
                if (img1 == img2)
                {
                    image2.Visibility = Visibility.Visible;
                    button2.Visibility = Visibility.Collapsed;
                    butList[0].Visibility = Visibility.Collapsed;
                    imgList[0].Visibility = Visibility.Visible;
                    imgList.RemoveAt(0);
                    butList.RemoveAt(0);
                    firstClick = true;

                }
                else
                {
                    await Task.Delay(1000);
                    button2.Visibility = Visibility.Visible;
                    image2.Visibility = Visibility.Collapsed;
                    butList[0].Visibility = Visibility.Visible;
                    imgList[0].Visibility = Visibility.Collapsed;
                    imgList.RemoveAt(0);
                    butList.RemoveAt(0);
                    firstClick = true;

                }

            }

        }


        private async void button3_Click(object sender, RoutedEventArgs e)
        {
            image3.Visibility = Visibility.Visible;
            button3.Visibility = Visibility.Collapsed;
            if (firstClick)
            {

                img1 = ((BitmapImage)image3.Source).UriSource.ToString();
                butList.Add(button3);
                imgList.Add(image3);
                firstClick = false;
            }
            else
            {
                img2 = ((BitmapImage)image3.Source).UriSource.ToString();
                if (img1 == img2)
                {
                    image3.Visibility = Visibility.Visible;
                    button3.Visibility = Visibility.Collapsed;
                    butList[0].Visibility = Visibility.Collapsed;
                    imgList[0].Visibility = Visibility.Visible;
                    imgList.RemoveAt(0);
                    butList.RemoveAt(0);
                    firstClick = true;

                }
                else
                {
                    await Task.Delay(1000);
                    button3.Visibility = Visibility.Visible;
                    image3.Visibility = Visibility.Collapsed;
                    butList[0].Visibility = Visibility.Visible;
                    imgList[0].Visibility = Visibility.Collapsed;
                    imgList.RemoveAt(0);
                    butList.RemoveAt(0);
                    firstClick = true;

                }

            }

        }



        private async void button5_Click(object sender, RoutedEventArgs e)
        {
            image5.Visibility = Visibility.Visible;
            button5.Visibility = Visibility.Collapsed;
            if (firstClick)
            {

                img1 = ((BitmapImage)image5.Source).UriSource.ToString();
                butList.Add(button5);
                imgList.Add(image5);
                firstClick = false;
            }
            else
            {
                img2 = ((BitmapImage)image5.Source).UriSource.ToString();
                if (img1 == img2)
                {
                    image5.Visibility = Visibility.Visible;
                    button5.Visibility = Visibility.Collapsed;
                    butList[0].Visibility = Visibility.Collapsed;
                    imgList[0].Visibility = Visibility.Visible;
                    imgList.RemoveAt(0);
                    butList.RemoveAt(0);
                    firstClick = true;

                }
                else
                {
                    await Task.Delay(1000);
                    button5.Visibility = Visibility.Visible;
                    image5.Visibility = Visibility.Collapsed;
                    butList[0].Visibility = Visibility.Visible;
                    imgList[0].Visibility = Visibility.Collapsed;
                    imgList.RemoveAt(0);
                    butList.RemoveAt(0);
                    firstClick = true;

                }

            }

        }

        private async void button8_Click(object sender, RoutedEventArgs e)
        {
            image8.Visibility = Visibility.Visible;
            button8.Visibility = Visibility.Collapsed;
            if (firstClick)
            {

                img1 = ((BitmapImage)image8.Source).UriSource.ToString();
                butList.Add(button8);
                imgList.Add(image8);
                firstClick = false;
            }
            else
            {
                img2 = ((BitmapImage)image8.Source).UriSource.ToString();
                if (img1 == img2)
                {
                    image8.Visibility = Visibility.Visible;
                    button8.Visibility = Visibility.Collapsed;
                    butList[0].Visibility = Visibility.Collapsed;
                    imgList[0].Visibility = Visibility.Visible;
                    imgList.RemoveAt(0);
                    butList.RemoveAt(0);
                    firstClick = true;

                }
                else
                {
                    await Task.Delay(1000);
                    button8.Visibility = Visibility.Visible;
                    image8.Visibility = Visibility.Collapsed;
                    butList[0].Visibility = Visibility.Visible;
                    imgList[0].Visibility = Visibility.Collapsed;
                    imgList.RemoveAt(0);
                    butList.RemoveAt(0);
                    firstClick = true;

                }

            }


        }

        private async void button9_Click(object sender, RoutedEventArgs e)
        {
            image9.Visibility = Visibility.Visible;
            button9.Visibility = Visibility.Collapsed;
            if (firstClick)
            {

                img1 = ((BitmapImage)image9.Source).UriSource.ToString();
                butList.Add(button9);
                imgList.Add(image9);
                firstClick = false;
            }
            else
            {
                img2 = ((BitmapImage)image9.Source).UriSource.ToString();
                if (img1 == img2)
                {
                    image9.Visibility = Visibility.Visible;
                    button9.Visibility = Visibility.Collapsed;
                    butList[0].Visibility = Visibility.Collapsed;
                    imgList[0].Visibility = Visibility.Visible;
                    imgList.RemoveAt(0);
                    butList.RemoveAt(0);
                    firstClick = true;

                }
                else
                {
                    await Task.Delay(1000);
                    image9.Visibility = Visibility.Collapsed;                  
                    button9.Visibility = Visibility.Visible;
                    butList[0].Visibility = Visibility.Visible;
                    imgList[0].Visibility = Visibility.Collapsed;
                    imgList.RemoveAt(0);
                    butList.RemoveAt(0);
                    firstClick = true;

                }

            }


        }

        private async void button10_Click(object sender, RoutedEventArgs e)
        {
            image10.Visibility = Visibility.Visible;
            button10.Visibility = Visibility.Collapsed;
            if (firstClick)
            {

                img1 = ((BitmapImage)image10.Source).UriSource.ToString();
                butList.Add(button10);
                imgList.Add(image10);
                firstClick = false;
            }
            else
            {
                img2 = ((BitmapImage)image10.Source).UriSource.ToString();
                if (img1 == img2)
                {
                    image10.Visibility = Visibility.Visible;
                    button10.Visibility = Visibility.Collapsed;
                    butList[0].Visibility = Visibility.Collapsed;
                    imgList[0].Visibility = Visibility.Visible;
                    imgList.RemoveAt(0);
                    butList.RemoveAt(0);
                    firstClick = true;


                }
                else
                {
                    await Task.Delay(1000);
                    button10.Visibility = Visibility.Visible;
                    image10.Visibility = Visibility.Collapsed;
                    butList[0].Visibility = Visibility.Visible;
                    imgList[0].Visibility = Visibility.Collapsed;
                    imgList.RemoveAt(0);
                    butList.RemoveAt(0);
                    firstClick = true;

                }

            }


        }

        private async void button11_Click(object sender, RoutedEventArgs e)
        {
            image11.Visibility = Visibility.Visible;
            button11.Visibility = Visibility.Collapsed;
            if (firstClick)
            {

                img1 = ((BitmapImage)image11.Source).UriSource.ToString();
                butList.Add(button11);
                imgList.Add(image11);
                firstClick = false;
            }
            else
            {
                img2 = ((BitmapImage)image11.Source).UriSource.ToString();
                if (img1 == img2)
                {
                    image11.Visibility = Visibility.Visible;
                    button11.Visibility = Visibility.Collapsed;
                    butList[0].Visibility = Visibility.Collapsed;
                    imgList[0].Visibility = Visibility.Visible;
                    imgList.RemoveAt(0);
                    butList.RemoveAt(0);
                    firstClick = true;

                }
                else
                {
                    await Task.Delay(1000);
                    image11.Visibility = Visibility.Collapsed;
                    button11.Visibility = Visibility.Visible;
                    butList[0].Visibility = Visibility.Visible;
                    imgList[0].Visibility = Visibility.Collapsed;
                    imgList.RemoveAt(0);
                    butList.RemoveAt(0);
                    firstClick = true;

                }

            }


        }

        private async void button12_Click(object sender, RoutedEventArgs e)
        {
            image12.Visibility = Visibility.Visible;
            button12.Visibility = Visibility.Collapsed;
            if (firstClick)
            {

                img1 = ((BitmapImage)image12.Source).UriSource.ToString();
                butList.Add(button12);
                imgList.Add(image12);
                firstClick = false;
            }
            else
            {
                img2 = ((BitmapImage)image12.Source).UriSource.ToString();
                if (img1 == img2)
                {
                    image12.Visibility = Visibility.Visible;
                    button12.Visibility = Visibility.Collapsed;
                    butList[0].Visibility = Visibility.Collapsed;
                    imgList[0].Visibility = Visibility.Visible;
                    imgList.RemoveAt(0);
                    butList.RemoveAt(0);
                    firstClick = true;

                }
                else
                {
                    await Task.Delay(1000);
                    image12.Visibility = Visibility.Collapsed;
                    button12.Visibility = Visibility.Visible;
                    butList[0].Visibility = Visibility.Visible;
                    imgList[0].Visibility = Visibility.Collapsed;
                    imgList.RemoveAt(0);
                    butList.RemoveAt(0);
                    firstClick = true;

                }

            }


        }

        private async void button13_Click(object sender, RoutedEventArgs e)
        {
            image13.Visibility = Visibility.Visible;
            button13.Visibility = Visibility.Collapsed;
            if (firstClick)
            {

                img1 = ((BitmapImage)image13.Source).UriSource.ToString();
                butList.Add(button13);
                imgList.Add(image13);
                firstClick = false;
            }
            else
            {
                img2 = ((BitmapImage)image13.Source).UriSource.ToString();
                if (img1 == img2)
                {
                    image13.Visibility = Visibility.Visible;
                    button13.Visibility = Visibility.Collapsed;
                    butList[0].Visibility = Visibility.Collapsed;
                    imgList[0].Visibility = Visibility.Visible;
                    imgList.RemoveAt(0);
                    butList.RemoveAt(0);
                    firstClick = true;

                }
                else
                {
                    await Task.Delay(1000);
                    image13.Visibility = Visibility.Collapsed;
                    button13.Visibility = Visibility.Visible;
                    butList[0].Visibility = Visibility.Visible;
                    imgList[0].Visibility = Visibility.Collapsed;
                    imgList.RemoveAt(0);
                    butList.RemoveAt(0);
                    firstClick = true;

                }

            }


        }

        private async void button14_Click(object sender, RoutedEventArgs e)
        {
            image14.Visibility = Visibility.Visible;
            button14.Visibility = Visibility.Collapsed;
            if (firstClick)
            {

                img1 = ((BitmapImage)image14.Source).UriSource.ToString();
                butList.Add(button14);
                imgList.Add(image14);
                firstClick = false;
            }
            else
            {
                img2 = ((BitmapImage)image14.Source).UriSource.ToString();
                if (img1 == img2)
                {
                    image14.Visibility = Visibility.Visible;
                    button14.Visibility = Visibility.Collapsed;
                    butList[0].Visibility = Visibility.Collapsed;
                    imgList[0].Visibility = Visibility.Visible;
                    imgList.RemoveAt(0);
                    butList.RemoveAt(0);
                    firstClick = true;

                }
                else
                {
                    await Task.Delay(1000);
                    image14.Visibility = Visibility.Collapsed;
                    button14.Visibility = Visibility.Visible;
                    butList[0].Visibility = Visibility.Visible;
                    imgList[0].Visibility = Visibility.Collapsed;
                    imgList.RemoveAt(0);
                    butList.RemoveAt(0);
                    firstClick = true;

                }

            }

        }

        private async void button15_Click(object sender, RoutedEventArgs e)
        {
            image15.Visibility = Visibility.Visible;
            button15.Visibility = Visibility.Collapsed;
            if (firstClick)
            {

                img1 = ((BitmapImage)image15.Source).UriSource.ToString();
                butList.Add(button15);
                imgList.Add(image15);
                firstClick = false;
            }
            else
            {
                img2 = ((BitmapImage)image15.Source).UriSource.ToString();
                if (img1 == img2)
                {
                    image15.Visibility = Visibility.Visible;
                    button15.Visibility = Visibility.Collapsed;
                    butList[0].Visibility = Visibility.Collapsed;
                    imgList[0].Visibility = Visibility.Visible;
                    imgList.RemoveAt(0);
                    butList.RemoveAt(0);
                    firstClick = true;

                }
                else
                {
                    await Task.Delay(1000);
                    image15.Visibility = Visibility.Collapsed;
                    button15.Visibility = Visibility.Visible;
                    butList[0].Visibility = Visibility.Visible;
                    imgList[0].Visibility = Visibility.Collapsed;
                    imgList.RemoveAt(0);
                    butList.RemoveAt(0);
                    firstClick = true;

                }

            }


        }

        private async void button6_Click(object sender, RoutedEventArgs e)
        {

            image6.Visibility = Visibility.Visible;
            button6.Visibility = Visibility.Collapsed;
            if (firstClick)
            {

                img1 = ((BitmapImage)image6.Source).UriSource.ToString();
                butList.Add(button6);
                imgList.Add(image6);
                firstClick = false;
            }
            else
            {
                img2 = ((BitmapImage)image6.Source).UriSource.ToString();
                if (img1 == img2)
                {
                    image6.Visibility = Visibility.Visible;
                    button6.Visibility = Visibility.Collapsed;
                    butList[0].Visibility = Visibility.Collapsed;
                    imgList[0].Visibility = Visibility.Visible;
                    imgList.RemoveAt(0);
                    butList.RemoveAt(0);
                    firstClick = true;

                }
                else
                {
                    await Task.Delay(1000);
                    image6.Visibility = Visibility.Collapsed;
                    button6.Visibility = Visibility.Visible;
                    butList[0].Visibility = Visibility.Visible;
                    imgList[0].Visibility = Visibility.Collapsed;
                    imgList.RemoveAt(0);
                    butList.RemoveAt(0);
                    firstClick = true;

                }

            }

        }

        private async void button7_Click(object sender, RoutedEventArgs e)
        {
            image7.Visibility = Visibility.Visible;
            button7.Visibility = Visibility.Collapsed;
            if (firstClick)
            {

                img1 = ((BitmapImage)image7.Source).UriSource.ToString();
                butList.Add(button7);
                imgList.Add(image7);
                firstClick = false;
            }
            else
            {
                img2 = ((BitmapImage)image7.Source).UriSource.ToString();
                if (img1 == img2)
                {
                    image7.Visibility = Visibility.Visible;
                    button7.Visibility = Visibility.Collapsed;
                    butList[0].Visibility = Visibility.Collapsed;
                    imgList[0].Visibility = Visibility.Visible;
                    imgList.RemoveAt(0);
                    butList.RemoveAt(0);
                    firstClick = true;

                }
                else
                {
                    await Task.Delay(1000);
                    image7.Visibility = Visibility.Collapsed;
                    button7.Visibility = Visibility.Visible;
                    butList[0].Visibility = Visibility.Visible;
                    imgList[0].Visibility = Visibility.Collapsed;
                    imgList.RemoveAt(0);
                    butList.RemoveAt(0);
                    firstClick = true;

                }

            }
        }


    }
}
