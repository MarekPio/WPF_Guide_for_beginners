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
using SimpleNavigationDemo.Pages;

namespace SimpleNavigationDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Page1 FirstPage;
        public Page2 SecondPage;
        public Page3 ThirdPage;


        public MainWindow()
        {
            InitializeComponent();

            FirstPage = new Page1();
            SecondPage = new Page2();
            ThirdPage = new Page3();
            ThirdPage.GoToPage1ButtonClick += Button_Click1;
            SecondPage.GoToPage1ButtonClick += Button_Click1;
            SecondPage.GoToPage3ButtonClick += Button_Click3;
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = FirstPage;
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = SecondPage;
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = ThirdPage;
        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            if(MainWindowFrame.NavigationService.CanGoBack)
            {
                MainWindowFrame.NavigationService.GoBack();
            }
        }

        private void Button_Forward_Click(object sender, RoutedEventArgs e)
        {
            if (MainWindowFrame.NavigationService.CanGoForward)
            {
                MainWindowFrame.NavigationService.GoForward();
            }
        }
    }
}
