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

namespace Intro_git_opdracht
{
    public partial class MainWindow : Window
    {
        private double _lastValue;
        private string _lastOperation;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                if (Display.Text == "0" && button.Content.ToString() != ".")
                {
                    Display.Text = button.Content.ToString();
                }
                else
                {
                    Display.Text += button.Content.ToString();
                }
            }
        }

        private void Operation_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                _lastValue = double.Parse(Display.Text);
                _lastOperation = button.Content.ToString();
                Display.Text = "0";
            }
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            double newValue;
            if (double.TryParse(Display.Text, out newValue))
            {
                switch (_lastOperation)
                {
                    case "+":
                        Display.Text = (_lastValue + newValue).ToString();
                        break;
                    case "-":
                        Display.Text = (_lastValue - newValue).ToString();
                        break;
                    case "*":
                        Display.Text = (_lastValue * newValue).ToString();
                        break;
                    case "/":
                        Display.Text = (_lastValue / newValue).ToString();
                        break;
                }
            }

        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = "0";
            _lastValue = 0;
            _lastOperation = string.Empty;
        }


    }
}