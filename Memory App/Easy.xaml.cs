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
        public int moves = 15;
        public int eScore = 0;
        public int Score = 0;
        public TextBox txtBox;
        public int time = 31;
        public DispatcherTimer Timer;



        List<Button> butList = new List<Button>()
        {
        };
        List<Image> imgList = new List<Image>()
        {
        };


        public Easy()
        {
            this.InitializeComponent();
            score.Visibility = Visibility.Collapsed;
            eScoreTxt.Visibility = Visibility.Collapsed;
            randomPic();
            level();



        }

        private void countdownTimer(object sender, object e)
        {

            if (time > 0)
            {
                if (time <= 10)
                {
                    time--;
                    countdown.Text = string.Format("{1}", time / 60, time % 60);
                }
                else
                {
                    time--;
                    countdown.Text = string.Format("{1}", time / 60, time % 60);
                }
            }
            else
            {
                Timer.Stop();

            }


        }



        public void level()
        {
            switch (App.level)
            {
                case 1:
                    eScoreTxt.Visibility = Visibility.Visible;
                    eScoreTxt.Text = eScore.ToString();
                    ImageBrush brush1 = new ImageBrush();
                    brush1.ImageSource = new BitmapImage(new Uri("ms-appx:///Pictures/cooltext174877648874930.png", UriKind.Absolute));
                    image12.Source = brush1.ImageSource;
                    break;
                case 2:
                    score.Visibility = Visibility.Visible;
                    score.Text = moves.ToString();
                    ImageBrush brush2 = new ImageBrush();
                    brush2.ImageSource = new BitmapImage(new Uri("ms-appx:///Pictures/cooltext174907777842293.png", UriKind.Absolute));
                    image13.Source = brush2.ImageSource;
                    break;
                case 3:
                    Timer = new DispatcherTimer();
                    Timer.Interval = new TimeSpan(0, 0, 1);
                    Timer.Tick += countdownTimer;
                    Timer.Start();
                    break;

            }



        }
        public async void gameOver()
        {

            switch (App.level)
            {
                case 1:
                    if (Score == 6)
                    {
                        await Task.Delay(500);
                        App.easyLevel = eScore;
                        this.Frame.Navigate(typeof(MainPage), null);
                    }
                    break;
                case 2:
                    if (Score == 6)
                    {
                        await Task.Delay(500);
                        App.mediumLevel = moves;
                        this.Frame.Navigate(typeof(MainPage), null);
                    }

                    break;
                case 3:
                    if (Score == 6)
                    {
                        await Task.Delay(500);
                        App.hardLevel = time;
                        this.Frame.Navigate(typeof(MainPage), null);
                    }

                    break;

            }
        }
        public async void test(Button but, Image img)
        {
            img.Visibility = Visibility.Visible;
            but.Visibility = Visibility.Collapsed;
            if (firstClick)
            {

                img1 = ((BitmapImage)img.Source).UriSource.ToString();
                butList.Add(but);
                imgList.Add(img);
                firstClick = false;
            }
            else
            {
                img2 = ((BitmapImage)img.Source).UriSource.ToString();
                if (img1 == img2)
                {
                    disableButtons();
                    img.Visibility = Visibility.Visible;
                    but.Visibility = Visibility.Collapsed;
                    butList[0].Visibility = Visibility.Collapsed;
                    imgList[0].Visibility = Visibility.Visible;
                    imgList.RemoveAt(0);
                    butList.RemoveAt(0);
                    firstClick = true;
                    moves--;
                    eScore++;
                    eScoreTxt.Text = eScore.ToString();
                    score.Text = moves.ToString();
                    Score++;
                    gameOver();
                    enableButtons();


                }

                else
                {
                    disableButtons();
                    await Task.Delay(1000);
                    img.Visibility = Visibility.Collapsed;
                    but.Visibility = Visibility.Visible;
                    butList[0].Visibility = Visibility.Visible;
                    imgList[0].Visibility = Visibility.Collapsed;
                    butList.RemoveAt(0);
                    imgList.RemoveAt(0);
                    firstClick = true;
                    moves--;
                    eScore++;
                    eScoreTxt.Text = eScore.ToString();
                    score.Text = moves.ToString();
                    enableButtons();

                }

            }

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
                "ms-appx:///Pictures/bell.png",
                "ms-appx:///Pictures/bottle.png",
                "ms-appx:///Pictures/cheese.png",
                "ms-appx:///Pictures/folder.png",
                "ms-appx:///Pictures/gauge.png",
                "ms-appx:///Pictures/hamburger.png"

            };

            List<Image> imgs = new List<Image>()
            {
                image0, image1, image2, image3, image4,
                image5, image6, image7, image8, image9,
                image10, image11
            };
            for (int i = 11; i >= 0; i--)
            {

                int randomNumber = rnd.Next(0, pics1.Count);

                ImageBrush brush1 = new ImageBrush();
                brush1.ImageSource = new BitmapImage(new Uri(pics1[randomNumber], UriKind.Absolute));

                imgs[i].Source = brush1.ImageSource;
                pics1.RemoveAt(randomNumber);
                imgs[i].Visibility = Visibility.Collapsed;
            }
        }

        public void disableButtons()
        {
            List<Button> buttons = new List<Button>()
            {
                button, button1, button2, button3, button4,
                button5, button6, button7, button8, button9,
                button10, button11
            };

            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].IsEnabled = false;

            }
        }

        public void enableButtons()
        {
            List<Button> buttons = new List<Button>()
            {
                button, button1, button2, button3, button4,
                button5, button6, button7, button8, button9,
                button10, button11
            };

            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].IsEnabled = true;
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            test(button, image0);

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            test(button1, image1);
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            test(button4, image4);

        }



        private void button2_Click(object sender, RoutedEventArgs e)
        {
            test(button2, image2);

        }


        private void button3_Click(object sender, RoutedEventArgs e)
        {
            test(button3, image3);

        }



        private void button5_Click(object sender, RoutedEventArgs e)
        {
            test(button5, image5);

        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            test(button6, image6);
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            test(button7, image7);
        }
        private void button8_Click(object sender, RoutedEventArgs e)
        {
            test(button8, image8);


        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            test(button9, image9);


        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            test(button10, image10);

        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            test(button11, image11);

        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }






    }
}