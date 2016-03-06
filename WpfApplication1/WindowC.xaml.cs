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

namespace DataHandler
{
    /// <summary>
    /// WindowC.xaml 的交互逻辑
    /// </summary>
    public partial class WindowC : Window
    {
        static WindowD wd = new WindowD();
        public Data tmpdata;
        public WindowC()
        {
            wd.Owner = this;
            InitializeComponent();
        }

        private void To_WindowD(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow = wd;
            wd.Show();
            this.Hide();
        }
    }
}
