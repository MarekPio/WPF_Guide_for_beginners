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

namespace DelegatesAndEventsDemo
{
    /// <summary>
    /// Interaction logic for ValueUC.xaml
    /// </summary>
    public partial class ValueUC : UserControl
    {
        public delegate void OnMinThresholdReached(object sender, RoutedEventArgs e);
        public event OnMinThresholdReached MinThresholdReached;

        public delegate void OnMaxThresholdReached(object sender, RoutedEventArgs e);
        public event OnMaxThresholdReached MaxThresholdReached;

        public ValueUC()
        {
            InitializeComponent();
        }

        private void Button_Plus_Click(object sender, RoutedEventArgs e)
        {
            ValueLabel.Text = (Int32.Parse(ValueLabel.Text) + 10).ToString();
        }

        private void Button_Minus_Click(object sender, RoutedEventArgs e)
        {
            ValueLabel.Text = (Int32.Parse(ValueLabel.Text) - 10).ToString();
        }

        private void ValueLabel_TextChanged(object sender, TextChangedEventArgs e)
        {
            //MessageBox.Show("Text changed");

            if(Int32.Parse((sender as TextBox).Text) < 0)
            {
                (sender as TextBox).Text = "0";
                MinThresholdReached(sender, e);
            }
            else if (Int32.Parse((sender as TextBox).Text) > 100)
            {
                (sender as TextBox).Text = "100";
                MaxThresholdReached(sender, e);
            }

        }
    }
}
