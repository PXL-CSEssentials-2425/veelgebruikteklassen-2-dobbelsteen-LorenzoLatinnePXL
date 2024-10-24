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

namespace Dobbelsteen
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

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();
            const int WinningNumber = 6;
            int tries = 0;
            int thrownNumber;

            do
            {
                tries++;
                thrownNumber = rnd.Next(1, 7);
                sb.AppendLine($"Try {tries} gives {thrownNumber}");
                resultTextBox.Text = sb.ToString();
            }
            while (thrownNumber != WinningNumber);

            sb.Clear();
        }


        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
