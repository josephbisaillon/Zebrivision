using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ApplicationSettings;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MultiplictionKangaroo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // You can put this event handler somewhere in a main class that runs your app.
            // I put it in may main view model.
            SettingsPane.GetForCurrentView().CommandsRequested += ShowPrivacyPolicy;
            //SettingsPane.GetForCurrentView().CommandsRequested += ShowAdditionalLicenseTerms;

            setField();
            levelTextBox.Text = level.ToString();
            scoreTextBox.Text = score.ToString();
            setMultiple();
            checkWin();
            testTextBlock.Text = "";

        }
       
        Player user = new Player();
        Random rand = new Random();
        Random multiRand = new Random();

        int multiple;
        int lives;
        int level = 1;
        int score = 0;
        
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void eraseBoardFox()
        {
            imageBox.Source = null;
            imageBox1.Source = null;
            imageBox2.Source = null;
            imageBox3.Source = null;
            imageBox4.Source = null;
            imageBox5.Source = null;
            imageBox6.Source = null;
            imageBox7.Source = null;
            imageBox8.Source = null;
            imageBox9.Source = null;
            imageBox10.Source = null;
            imageBox11.Source = null;
            imageBox12.Source = null;
            imageBox13.Source = null;
            imageBox14.Source = null;
            imageBox15.Source = null;
        }

        public static BitmapImage ImageFromRelativePath(FrameworkElement parent, string path)
        {
            var uri = new Uri(parent.BaseUri, path);
            BitmapImage bmp = new BitmapImage();
            bmp.UriSource = uri;
            return bmp;
        }

        private void checkNumberBox_Tapped(object sender, TappedRoutedEventArgs e)
        {
            int x;


             if (sender == checkerNumberBox)
            {
                int.TryParse(checkerNumberBox.Text, out x);
                if (x % multiple == 0)
                {
                    checkerNumberBox.Text = "";
                    eraseBoardFox();
                    imageBox.Source = ImageFromRelativePath(this, "Assets/fox.png");
                    checkWin();
                }
                else
                {
                    eraseBoardFox();
                    imageBox.Source = ImageFromRelativePath(this, "Assets/x.png");
                    user.lifeLoss();
                    lives = user.returnLives();
                    checkLives();
                
                }
            }
            else if (sender == checkerNumberBox1) 
            {
                int.TryParse(checkerNumberBox1.Text, out x);
                if (x % multiple == 0)
                {
                    checkerNumberBox1.Text = "";
                    eraseBoardFox();
                    imageBox1.Source = ImageFromRelativePath(this, "Assets/fox.png");
                    checkWin();
                }
                else
                {
                    eraseBoardFox();
                    imageBox1.Source = ImageFromRelativePath(this, "Assets/x.png");
                    user.lifeLoss();
                    lives = user.returnLives();
                    checkLives();
                }
            }
             else if (sender == checkerNumberBox2)
             {
                 int.TryParse(checkerNumberBox2.Text, out x);
                 if (x % multiple == 0)
                 {
                     checkerNumberBox2.Text = "";
                     eraseBoardFox();
                     imageBox2.Source = ImageFromRelativePath(this, "Assets/fox.png");
                     checkWin();
                 }
                 else
                 {
                     eraseBoardFox();
                     imageBox2.Source = ImageFromRelativePath(this, "Assets/x.png");
                     user.lifeLoss();
                     lives = user.returnLives();
                     checkLives();
                 }
             }
             else if (sender == checkerNumberBox3)
             {
                 int.TryParse(checkerNumberBox3.Text, out x);
                 if (x % multiple == 0)
                 {
                     checkerNumberBox3.Text = "";
                     eraseBoardFox();
                     imageBox3.Source = ImageFromRelativePath(this, "Assets/fox.png");
                     checkWin();
                 }
                 else
                 {
                     eraseBoardFox();
                     imageBox3.Source = ImageFromRelativePath(this, "Assets/x.png");
                     user.lifeLoss();
                     lives = user.returnLives();
                     checkLives();
                 }
             }
             else if (sender == checkerNumberBox4)
             {
                 int.TryParse(checkerNumberBox4.Text, out x);
                 if (x % multiple == 0)
                 {
                     checkerNumberBox4.Text = "";
                     eraseBoardFox();
                     imageBox4.Source = ImageFromRelativePath(this, "Assets/fox.png");
                     checkWin();
                 }
                 else
                 {
                     eraseBoardFox();
                     imageBox4.Source = ImageFromRelativePath(this, "Assets/x.png");
                     user.lifeLoss();
                     lives = user.returnLives();
                     checkLives();
                 }
             }
             else if (sender == checkerNumberBox5)
             {
                 int.TryParse(checkerNumberBox5.Text, out x);
                 if (x % multiple == 0)
                 {
                     checkerNumberBox5.Text = "";
                     eraseBoardFox();
                     imageBox5.Source = ImageFromRelativePath(this, "Assets/fox.png");
                     checkWin();
                 }
                 else
                 {
                     eraseBoardFox();
                     imageBox5.Source = ImageFromRelativePath(this, "Assets/x.png");
                     user.lifeLoss();
                     lives = user.returnLives();
                     checkLives();
                 }
             }
             else if (sender == checkerNumberBox6)
             {
                 int.TryParse(checkerNumberBox6.Text, out x);
                 if (x % multiple == 0)
                 {
                     checkerNumberBox6.Text = "";
                     eraseBoardFox();
                     imageBox6.Source = ImageFromRelativePath(this, "Assets/fox.png");
                     checkWin();
                 }
                 else
                 {
                     eraseBoardFox();
                     imageBox6.Source = ImageFromRelativePath(this, "Assets/x.png");
                     user.lifeLoss();
                     lives = user.returnLives();
                     checkLives();
                 }
             }
             else if (sender == checkerNumberBox7)
             {
                 int.TryParse(checkerNumberBox7.Text, out x);
                 if (x % multiple == 0)
                 {
                     checkerNumberBox7.Text = "";
                     eraseBoardFox();
                     imageBox7.Source = ImageFromRelativePath(this, "Assets/fox.png");
                     checkWin();
                 }
                 else
                 {
                     eraseBoardFox();
                     imageBox7.Source = ImageFromRelativePath(this, "Assets/x.png");
                     user.lifeLoss();
                     lives = user.returnLives();
                     checkLives();
                 }
             }
             else if (sender == checkerNumberBox8)
             {
                 int.TryParse(checkerNumberBox8.Text, out x);
                 if (x % multiple == 0)
                 {
                     checkerNumberBox8.Text = "";
                     eraseBoardFox();
                     imageBox8.Source = ImageFromRelativePath(this, "Assets/fox.png");
                     checkWin();
                 }
                 else
                 {
                     eraseBoardFox();
                     imageBox8.Source = ImageFromRelativePath(this, "Assets/x.png");
                     user.lifeLoss();
                     lives = user.returnLives();
                     checkLives();
                 }
             }
             else if (sender == checkerNumberBox9)
             {
                 int.TryParse(checkerNumberBox9.Text, out x);
                 if (x % multiple == 0)
                 {
                     checkerNumberBox9.Text = "";
                     eraseBoardFox();
                     imageBox9.Source = ImageFromRelativePath(this, "Assets/fox.png");
                     checkWin();
                 }
                 else
                 {
                     eraseBoardFox();
                     imageBox9.Source = ImageFromRelativePath(this, "Assets/x.png");
                     user.lifeLoss();
                     lives = user.returnLives();
                     checkLives();
                 }
             }
             else if (sender == checkerNumberBox10)
             {
                 int.TryParse(checkerNumberBox10.Text, out x);
                 if (x % multiple == 0)
                 {
                     checkerNumberBox10.Text = "";
                     eraseBoardFox();
                     imageBox10.Source = ImageFromRelativePath(this, "Assets/fox.png");
                     checkWin();
                 }
                 else
                 {
                     eraseBoardFox();
                     imageBox10.Source = ImageFromRelativePath(this, "Assets/x.png");
                     user.lifeLoss();
                     lives = user.returnLives();
                     checkLives();
                 }
             }
             else if (sender == checkerNumberBox11)
             {
                 int.TryParse(checkerNumberBox11.Text, out x);
                 if (x % multiple == 0)
                 {
                     checkerNumberBox11.Text = "";
                     eraseBoardFox();
                     imageBox11.Source = ImageFromRelativePath(this, "Assets/fox.png");
                     checkWin();
                 }
                 else
                 {
                     eraseBoardFox();
                     imageBox11.Source = ImageFromRelativePath(this, "Assets/x.png");
                     user.lifeLoss();
                     lives = user.returnLives();
                     checkLives();
                 }
             }
             else if (sender == checkerNumberBox12)
             {
                 int.TryParse(checkerNumberBox12.Text, out x);
                 if (x % multiple == 0)
                 {
                     checkerNumberBox12.Text = "";
                     eraseBoardFox();
                     imageBox12.Source = ImageFromRelativePath(this, "Assets/fox.png");
                     checkWin();
                 }
                 else
                 {
                     eraseBoardFox();
                     imageBox12.Source = ImageFromRelativePath(this, "Assets/x.png");
                     user.lifeLoss();
                     lives = user.returnLives();
                     checkLives();
                 }
             }
             else if (sender == checkerNumberBox13)
             {
                 int.TryParse(checkerNumberBox13.Text, out x);
                 if (x % multiple == 0)
                 {
                     checkerNumberBox13.Text = "";
                     eraseBoardFox();
                     imageBox13.Source = ImageFromRelativePath(this, "Assets/fox.png");
                     checkWin();
                 }
                 else
                 {
                     eraseBoardFox();
                     imageBox13.Source = ImageFromRelativePath(this, "Assets/x.png");
                     user.lifeLoss();
                     lives = user.returnLives();
                     checkLives();
                 }
             }
             else if (sender == checkerNumberBox14)
             {
                 int.TryParse(checkerNumberBox14.Text, out x);
                 if (x % multiple == 0)
                 {
                     checkerNumberBox14.Text = "";
                     eraseBoardFox();
                     imageBox14.Source = ImageFromRelativePath(this, "Assets/fox.png");
                     checkWin();
                 }
                 else
                 {
                     eraseBoardFox();
                     imageBox14.Source = ImageFromRelativePath(this, "Assets/x.png");
                     user.lifeLoss();
                     lives = user.returnLives();
                     checkLives();
                 }
             }
             else if (sender == checkerNumberBox15)
             {
                 int.TryParse(checkerNumberBox15.Text, out x);
                 if (x % multiple == 0)
                 {
                     checkerNumberBox15.Text = "";
                     eraseBoardFox();
                     imageBox15.Source = ImageFromRelativePath(this, "Assets/fox.png");
                     checkWin();
                 }
                 else
                 {
                     eraseBoardFox();
                     imageBox15.Source = ImageFromRelativePath(this, "Assets/x.png");
                     user.lifeLoss();
                     lives = user.returnLives();
                     checkLives();
                 }
             }
             
            
            
        }

        private void setMultiple()
        {
            multiple = multiRand.Next(10) + 1;
            multiplesTextBox.Text = multiple.ToString();
        }

        private void checkLives()
        {
            if (lives == 2)
            {
                life1Image.Source = null;
            }
            if (lives == 1)
            {
                life2Image.Source = null;
            }
            if (lives == 0)
            {
                life3Image.Source = null;
                //testTextBlock.Text = "loss!";
                disableAfterLoss();
                resetButton.Content = "Try again?";
                //newGame();
            }
        }

        private void newGame()
        {
            level = 1;
            levelTextBox.Text = level.ToString();
            setField();
            user.setLives(3);
            score = 0;
            scoreTextBox.Text = score.ToString();
            life1Image.Source = ImageFromRelativePath(this, "Assets/fox.png");
            life2Image.Source = ImageFromRelativePath(this, "Assets/fox.png");
            life3Image.Source = ImageFromRelativePath(this, "Assets/fox.png");
            setMultiple();

        }

        private void setField()
        {
            int x = 49;
            if (level > 10)
            {
                x = 99;
            }
            if (level > 15)
            {
                x = 199;
            }
            if (level > 30)
            {
                x = 499;
            }
            if (level > 50)
            {
                x = 999;
            }
            checkerNumberBox.Text = (rand.Next(x)+1).ToString();
            checkerNumberBox1.Text = (rand.Next(x)+1).ToString();
            checkerNumberBox2.Text = (rand.Next(x)+1).ToString();
            checkerNumberBox3.Text = (rand.Next(x)+1).ToString();
            checkerNumberBox4.Text = (rand.Next(x)+1).ToString();
            checkerNumberBox5.Text = (rand.Next(x)+1).ToString();
            checkerNumberBox6.Text = (rand.Next(x)+1).ToString();
            checkerNumberBox7.Text = (rand.Next(x)+1).ToString();
            checkerNumberBox8.Text = (rand.Next(x)+1).ToString();
            checkerNumberBox9.Text = (rand.Next(x)+1).ToString();
            checkerNumberBox10.Text = (rand.Next(x)+1).ToString();
            checkerNumberBox11.Text = (rand.Next(x)+1).ToString();
            checkerNumberBox12.Text = (rand.Next(x)+1).ToString();
            checkerNumberBox13.Text = (rand.Next(x)+1).ToString();
            checkerNumberBox14.Text = (rand.Next(x)+1).ToString();
            checkerNumberBox15.Text = (rand.Next(x)+1).ToString();
            setMultiple();
        }
        private void checkWin()
        {
            int [] a = new int[16];
            int count = 0;
           // testTextBlock.Text = count.ToString();
            int.TryParse(checkerNumberBox.Text, out a[0]);
            int.TryParse(checkerNumberBox1.Text, out a[1]);
            int.TryParse(checkerNumberBox2.Text, out a[2]);
            int.TryParse(checkerNumberBox3.Text, out a[3]);
            int.TryParse(checkerNumberBox4.Text, out a[4]);
            int.TryParse(checkerNumberBox5.Text, out a[5]);
            int.TryParse(checkerNumberBox6.Text, out a[6]);
            int.TryParse(checkerNumberBox7.Text, out a[7]);
            int.TryParse(checkerNumberBox8.Text, out a[8]);
            int.TryParse(checkerNumberBox9.Text,  out a[9]);
            int.TryParse(checkerNumberBox10.Text, out a[10]);
            int.TryParse(checkerNumberBox11.Text, out a[11]);
            int.TryParse(checkerNumberBox12.Text, out a[12]);
            int.TryParse(checkerNumberBox13.Text, out a[13]);
            int.TryParse(checkerNumberBox14.Text, out a[14]);
            int.TryParse(checkerNumberBox.Text, out a[15]);

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != 0 && a[i] % multiple == 0)
                {
                    count = count + 1;
                }
            }

            //testTextBlock.Text = count.ToString();
            if (count <= 0)
            {
                //testTextBlock.Text = "user has beaten level: " + level.ToString();
                level++;
                levelTextBox.Text = level.ToString();
                score = score + 10;
                scoreTextBox.Text = score.ToString();
                setField();
                eraseBoardFox();
                checkAccidentWin();
            }

            //count = 0;
        }

        private void checkAccidentWin()
        {
            int[] a = new int[16];
            int count = 0;
            // testTextBlock.Text = count.ToString();
            int.TryParse(checkerNumberBox.Text, out a[0]);
            int.TryParse(checkerNumberBox1.Text, out a[1]);
            int.TryParse(checkerNumberBox2.Text, out a[2]);
            int.TryParse(checkerNumberBox3.Text, out a[3]);
            int.TryParse(checkerNumberBox4.Text, out a[4]);
            int.TryParse(checkerNumberBox5.Text, out a[5]);
            int.TryParse(checkerNumberBox6.Text, out a[6]);
            int.TryParse(checkerNumberBox7.Text, out a[7]);
            int.TryParse(checkerNumberBox8.Text, out a[8]);
            int.TryParse(checkerNumberBox9.Text, out a[9]);
            int.TryParse(checkerNumberBox10.Text, out a[10]);
            int.TryParse(checkerNumberBox11.Text, out a[11]);
            int.TryParse(checkerNumberBox12.Text, out a[12]);
            int.TryParse(checkerNumberBox13.Text, out a[13]);
            int.TryParse(checkerNumberBox14.Text, out a[14]);
            int.TryParse(checkerNumberBox15.Text, out a[15]);

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != 0 && a[i] % multiple == 0)
                {
                    count = count + 1;
                }
            }

            //testTextBlock.Text = count.ToString();
            if (count <= 0)
            {
                level--;
                levelTextBox.Text = level.ToString();
                score = score - 10;
                scoreTextBox.Text = score.ToString();
                setField();
                eraseBoardFox();
            }
        }

        private void disableAfterLoss()
        {
             checkerNumberBox.IsTapEnabled = false;
             checkerNumberBox1.IsTapEnabled = false;
             checkerNumberBox2.IsTapEnabled = false;
             checkerNumberBox3.IsTapEnabled = false;
             checkerNumberBox4.IsTapEnabled = false;
             checkerNumberBox5.IsTapEnabled = false;
             checkerNumberBox6.IsTapEnabled = false;
             checkerNumberBox7.IsTapEnabled = false;
             checkerNumberBox8.IsTapEnabled = false;
             checkerNumberBox9.IsTapEnabled = false;
             checkerNumberBox10.IsTapEnabled = false;
             checkerNumberBox11.IsTapEnabled = false;
             checkerNumberBox12.IsTapEnabled = false;
             checkerNumberBox13.IsTapEnabled = false;
             checkerNumberBox14.IsTapEnabled = false;
             checkerNumberBox15.IsTapEnabled = false;
        }

        private void activateAfterReset()
        {
            checkerNumberBox.IsTapEnabled = true;
            checkerNumberBox1.IsTapEnabled = true;
            checkerNumberBox2.IsTapEnabled = true;
            checkerNumberBox3.IsTapEnabled = true;
            checkerNumberBox4.IsTapEnabled = true;
            checkerNumberBox5.IsTapEnabled = true;
            checkerNumberBox6.IsTapEnabled = true;
            checkerNumberBox7.IsTapEnabled = true;
            checkerNumberBox8.IsTapEnabled = true;
            checkerNumberBox9.IsTapEnabled = true;
            checkerNumberBox10.IsTapEnabled = true;
            checkerNumberBox11.IsTapEnabled = true;
            checkerNumberBox12.IsTapEnabled = true;
            checkerNumberBox13.IsTapEnabled = true;
            checkerNumberBox14.IsTapEnabled = true;
            checkerNumberBox15.IsTapEnabled = true;
        }                                  


        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            newGame();
            eraseBoardFox();
            activateAfterReset();
            resetButton.Content = "Reset";
        }

        // Method to add the privacy policy to the settings charm
        private void ShowPrivacyPolicy(SettingsPane sender, SettingsPaneCommandsRequestedEventArgs args)
        {
            SettingsCommand privacyPolicyCommand = new SettingsCommand("privacyPolicy", "Privacy Policy", (uiCommand) => { LaunchPrivacyPolicyUrl(); });
            args.Request.ApplicationCommands.Add(privacyPolicyCommand);
        }

        // Method to launch the url of the privacy policy
        async void LaunchPrivacyPolicyUrl()
        {
            Uri privacyPolicyUrl = new Uri("http://www.4jlabs.com/privacy.html");
            var result = await Windows.System.Launcher.LaunchUriAsync(privacyPolicyUrl);
        }


        //// Method to add the privacy policy to the settings charm
        //private void ShowAdditionalLicenseTerms(SettingsPane sender, SettingsPaneCommandsRequestedEventArgs args)
        //{
        //    SettingsCommand additionalLicenseTermsCommand = new SettingsCommand("additionalLicenseTerms", "License Terms", (uiCommand) => { LaunchAdditionalLicenseTermsUrl(); });
        //    args.Request.ApplicationCommands.Add(additionalLicenseTermsCommand);
        //}

        ////Method to launch the url of the privacy policy
        //private async void LaunchAdditionalLicenseTermsUrl()
        //{
        //    Uri additionalLicenseTermsUrl = new Uri("https://choice.microsoft.com/AdvertisementChoice/");
        //    var result = await Windows.System.Launcher.LaunchUriAsync(additionalLicenseTermsUrl);
        //}

    }
}
