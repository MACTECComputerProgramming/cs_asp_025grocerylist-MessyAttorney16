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

namespace _025_challenge
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int itemNumber;
        
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            itemNumber = int.Parse(itemNumberBox.Text);
            string[] items = new string[itemNumber];





        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
