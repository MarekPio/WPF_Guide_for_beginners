using MiscUtil;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WindowsStoreClone.UserControls
{
    /// <summary>
    /// Interaction logic for AnApp.xaml
    /// </summary>
    public partial class AnApp : UserControl
    {
        public string AppName;
        public ImageSource AppImageSource;

        public delegate void OnAppClicked(AnApp sender, RoutedEventArgs e);
        public event OnAppClicked AppClicked;

        public AnApp()
        {
            InitializeComponent();
            List<string> filepaths = Directory.GetFiles(Environment.CurrentDirectory
                + @"\..\..\Images", "*.png").ToList<string>();
            FileInfo myRandomFile = new FileInfo(filepaths[StaticRandom.Next(filepaths.Count)]);
            ProductImage.Source = new BitmapImage(new Uri(myRandomFile.FullName, UriKind.RelativeOrAbsolute));
            AppNameText.Text = (new CultureInfo("en-US", false).TextInfo).ToTitleCase(
                myRandomFile.FullName // C:\0git\WPF_Guide_for_beginners\WindowsStoreClone\WindowsStoreClone\Images\052-snapchat.png
                .Split('\\').Last()   // 052-snapchat.png
                .Split('-').Last()    // snapchat.png
                .Split('.').First()   // snapchat
                );
            AppName = AppNameText.Text.ToString();
            AppImageSource = ProductImage.Source;
        }

        public AnApp(string inAppName, ImageSource inImageSource)
        {
            InitializeComponent();

            ProductImage.Source = inImageSource;
            AppNameText.Text = inAppName;
            AppName = inAppName;
            AppImageSource = inImageSource;
        }

        private void ProductImage_MouseUp(object sender, MouseButtonEventArgs e)
        {
            AppClicked(this, e);
        }
    }
}
