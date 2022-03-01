using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DatabindingnoODP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<int> AvailableNumbers { get; set; }

        public MainWindow()
        {
            
            AvailableNumbers = new ObservableCollection<int>();
            int counter = 0;
            for (int i = 0; i < 10; i++)
            {
                AvailableNumbers.Add(i);
            }

            /* ObservableCollection need to be ready before InitializeComponent() */
            InitializeComponent();

            //this.DataContext = this; /* MainWindow.xaml DataContext="{Binding RelativeSource={RelativeSource Self}}" */
        }

        private void Button_AddNumber_Click(object sender, RoutedEventArgs e)
        {
            AvailableNumbers.Add(1);
        }

        private void Button_DeleteNumber_Click(object sender, RoutedEventArgs e)
        {
            AvailableNumbers.RemoveAt(0);
        }
    }
}
