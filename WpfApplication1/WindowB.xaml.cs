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
    /// WindowB.xaml 的交互逻辑
    /// </summary>
    public partial class WindowB : Window
    {
        public WindowB()
        {
            InitializeComponent();
        }

        private void DClick(object sender, MouseButtonEventArgs e)
        {
            //show.Background = 
            ImageBrush tmp = new ImageBrush();
            tmp.ImageSource = new BitmapImage(new Uri("按钮4 拷贝.png", UriKind.Relative));
        }

    }
}
