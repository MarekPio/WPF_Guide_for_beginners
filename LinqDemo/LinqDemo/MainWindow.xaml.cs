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

namespace LinqDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> myList;
        public MainWindow()
        {
            InitializeComponent();
            myList = new List<int>() { 4, 5, 6, 3, 2, 1, 7, 8, 9 };

        }

        public string StringifyList(List<int> inList)
        {
            string accum = "";
            foreach(int item in inList)
            {
                accum += item.ToString() + ",";
                if (item == inList.Last())
                    accum = accum.TrimEnd(',');
            }
            return accum;
        }

        public string FilterListOddNumbers(List<int> inList)
        {
                              /* Linq expression */
            return StringifyList(inList.Where(i => (i % 2) != 0).ToList());
        }

        public string FilterListEvenNumbers(List<int> inList)
        {
                              /* Linq expression */
            return StringifyList(inList.Where(i => (i % 2) == 0).ToList());
        }

        private void Odd_Click(object sender, RoutedEventArgs e)
        {
            MyTextBlock.Text = FilterListOddNumbers(myList);
        }

        private void Even_Click(object sender, RoutedEventArgs e)
        {
            MyTextBlock.Text = FilterListEvenNumbers(myList);
        }

        private void RemoveFilter_Click(object sender, RoutedEventArgs e)
        {
            MyTextBlock.Text = StringifyList(myList);
        }
    }
}
