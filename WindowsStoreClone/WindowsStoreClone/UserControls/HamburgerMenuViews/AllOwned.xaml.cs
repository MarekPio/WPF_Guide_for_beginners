﻿using System;
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

namespace WindowsStoreClone.UserControls.HamburgerMenuViews
{
    /// <summary>
    /// Interaction logic for AllOwned.xaml
    /// </summary>
    public partial class AllOwned : UserControl
    {
        //public delegate void OnFilterMenuItemClicked(object sender, RoutedEventArgs e);
        //public event OnFilterMenuItemClicked FilterMenuItemClicked;

        //public delegate void OnSortByMenuItemClicked(object sender, RoutedEventArgs e);
        //public event OnSortByMenuItemClicked SortByMenuItemClicked;

        public AllOwned()
        {
            InitializeComponent();

            HamHeader.FilterMenuItemClicked += HamHeader_FilterMenuItemClicked;
            HamHeader.SortByMenuItemClicked += HamHeader_SortByMenuItemClicked;
        }

        private void HamHeader_FilterMenuItemClicked(object sender, RoutedEventArgs e)
        {
            if((sender as MenuItem).Header.ToString().ToLower() == "all types")
            {
                HamAppList.AddAll();
            }
            else
            {
                HamAppList.FilterByType((sender as MenuItem).Header.ToString());
            }
        }

        private void HamHeader_SortByMenuItemClicked(object sender, RoutedEventArgs e)
        {
            if ((sender as MenuItem).Header.ToString().ToLower() == "sort by name")
            {
                HamAppList.SortByName();
            }
            else
            {
                HamAppList.SortByDate();
            }
        }
    }
}