using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TextBlockDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //myTextBlock.Text = "Hello from the cs side!";
            //myTextBlock.Foreground = Brushes.Blue;

            TextBlock myTb = new TextBlock();
            myTb.Text = "Hello World";
            myTb.Inlines.Add(" this is added using Inlines!");
            myTb.Inlines.Add(new Run(" Run text that I added in Code behind")
            {
                Foreground = Brushes.Red,
                TextDecorations = TextDecorations.Underline
            });
            myTb.TextWrapping = TextWrapping.Wrap;
            myTb.Foreground = Brushes.BurlyWood;

            this.Content = myTb;


        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
        }
    }
}
