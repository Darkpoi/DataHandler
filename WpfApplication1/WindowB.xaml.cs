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
            ImageBrush tmp1 = new ImageBrush();
            tmp1.ImageSource = new BitmapImage(new Uri("按钮1.png", UriKind.Relative));
            ImageBrush tmp2 = new ImageBrush();
            tmp2.ImageSource = new BitmapImage(new Uri("按钮2.png", UriKind.Relative));
            ImageBrush tmp3 = new ImageBrush();
            tmp3.ImageSource = new BitmapImage(new Uri("按钮3.png", UriKind.Relative));
            ImageBrush tmp4 = new ImageBrush();
            tmp4.ImageSource = new BitmapImage(new Uri("按钮4.png", UriKind.Relative));

            ImageBrush tmp11 = new ImageBrush();
            tmp11.ImageSource = new BitmapImage(new Uri("按钮1改.png", UriKind.Relative));
            ImageBrush tmp22 = new ImageBrush();
            tmp22.ImageSource = new BitmapImage(new Uri("按钮2改.png", UriKind.Relative));
            ImageBrush tmp33 = new ImageBrush();
            tmp33.ImageSource = new BitmapImage(new Uri("按钮3改.png", UriKind.Relative));
            ImageBrush tmp44 = new ImageBrush();
            tmp44.ImageSource = new BitmapImage(new Uri("按钮4改.png", UriKind.Relative));

            InitializeComponent();
        }

        private void DClick99(object sender, MouseButtonEventArgs e)
        {
            reset();
            ImageBrush tmp = new ImageBrush();
            tmp.ImageSource = new BitmapImage(new Uri("按钮4改.png", UriKind.Relative));
        }

        private void DClick90(object sender, MouseButtonEventArgs e)
        {
            reset();
            ImageBrush tmp = new ImageBrush();
            tmp.ImageSource = new BitmapImage(new Uri("按钮2改.png", UriKind.Relative));
        }

        private void DClick68(object sender, MouseButtonEventArgs e)
        {
            reset();
            ImageBrush tmp = new ImageBrush();
            tmp.ImageSource = new BitmapImage(new Uri("按钮1改.png", UriKind.Relative));
        }

        private void DClick95(object sender, MouseButtonEventArgs e)
        {
            reset();
            ImageBrush tmp = new ImageBrush();
            tmp.ImageSource = new BitmapImage(new Uri("按钮3改.png", UriKind.Relative);
        }

        private void reset()
        {
            ImageBrush tmp = new ImageBrush();
            tmp.ImageSource = new BitmapImage()
        }
    }
}
