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
    /// WindowD.xaml 的交互逻辑
    /// </summary>
    public partial class WindowD : Window
    {
        public Data tmpdata;
        ImageBrush tmp1 = new ImageBrush();
        ImageBrush tmp2 = new ImageBrush();
        ImageBrush tmp3 = new ImageBrush();
        ImageBrush tmp4 = new ImageBrush();
        ImageBrush tmp5 = new ImageBrush();
        ImageBrush tmp6 = new ImageBrush();
        ImageBrush tmp7 = new ImageBrush();
        ImageBrush tmp8 = new ImageBrush();
        ImageBrush tmp9 = new ImageBrush();
        ImageBrush tmp10 = new ImageBrush();
        ImageBrush tmp11 = new ImageBrush();
        ImageBrush tmp12 = new ImageBrush();
        ImageBrush tmp13 = new ImageBrush();
        ImageBrush tmp14 = new ImageBrush();
        ImageBrush tmp15 = new ImageBrush();
        ImageBrush tmp16 = new ImageBrush();
        ImageBrush tmp17 = new ImageBrush();
        ImageBrush tmp18 = new ImageBrush();
        public WindowD()
        {
            tmp1.ImageSource = new BitmapImage(new Uri("±1.00  mm (30-50).png", UriKind.Relative));
            tmp2.ImageSource = new BitmapImage(new Uri("±1.5  mm (60-100).png", UriKind.Relative));
            tmp3.ImageSource = new BitmapImage(new Uri("±0.10  mm (150).png", UriKind.Relative));
            tmp4.ImageSource = new BitmapImage(new Uri("±0.15 mm (500).png", UriKind.Relative));
            tmp5.ImageSource = new BitmapImage(new Uri("±0.20 mm （1000）.png", UriKind.Relative));
            tmp6.ImageSource = new BitmapImage(new Uri("±0.08 mm ( 1m ).png", UriKind.Relative));
            tmp7.ImageSource = new BitmapImage(new Uri("±1.2 mm( 2m ).png", UriKind.Relative));
            tmp8.ImageSource = new BitmapImage(new Uri("±1.00  mm (30-50).png", UriKind.Relative));
            tmp9.ImageSource = new BitmapImage(new Uri("±1.00  mm (30-50).png", UriKind.Relative));
            tmp10.ImageSource = new BitmapImage(new Uri("±1.00  mm (30-50).png", UriKind.Relative));
            tmp11.ImageSource = new BitmapImage(new Uri("±1.00  mm (30-50).png", UriKind.Relative));
            tmp12.ImageSource = new BitmapImage(new Uri("±1.00  mm (30-50).png", UriKind.Relative));
            tmp13.ImageSource = new BitmapImage(new Uri("±1.00  mm (30-50).png", UriKind.Relative));
            tmp14.ImageSource = new BitmapImage(new Uri("±1.00  mm (30-50).png", UriKind.Relative));
            tmp15.ImageSource = new BitmapImage(new Uri("±1.00  mm (30-50).png", UriKind.Relative));
            tmp16.ImageSource = new BitmapImage(new Uri("±1.00  mm (30-50).png", UriKind.Relative));
            tmp17.ImageSource = new BitmapImage(new Uri("±1.00  mm (30-50).png", UriKind.Relative));
            tmp18.ImageSource = new BitmapImage(new Uri("±1.00  mm (30-50).png", UriKind.Relative));

            InitializeComponent();
        }
    }
}
