﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TRPO_8.Pages;
using TRPO_8.Service;

namespace TRPO_8
{
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new LoginPage());
        }

        private void ChangeThem(object sender, RoutedEventArgs e)
        {
            ThemeHelper.Toggle();
        }
    }
}