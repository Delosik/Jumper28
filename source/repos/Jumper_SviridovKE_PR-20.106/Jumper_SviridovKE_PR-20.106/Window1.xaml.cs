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
using System.Windows.Shapes;

namespace Jumper_SviridovKE_PR_20._106
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1(int pr)
        {
            InitializeComponent();
            priorety.Text = pr.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            helper.flag = true;
            helper.prioritet = Convert.ToInt32(priorety.Text);
            this.Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
