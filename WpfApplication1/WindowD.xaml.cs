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

        ImageBrush _tmp1 = new ImageBrush();
        ImageBrush _tmp2 = new ImageBrush();
        ImageBrush _tmp3 = new ImageBrush();
        ImageBrush _tmp4 = new ImageBrush();
        ImageBrush _tmp5 = new ImageBrush();
        ImageBrush _tmp6 = new ImageBrush();
        ImageBrush _tmp7 = new ImageBrush();
        ImageBrush _tmp8 = new ImageBrush();
        ImageBrush _tmp9 = new ImageBrush();
        ImageBrush _tmp10 = new ImageBrush();
        ImageBrush _tmp11 = new ImageBrush();
        ImageBrush _tmp12 = new ImageBrush();
        ImageBrush _tmp13 = new ImageBrush();
        ImageBrush _tmp14 = new ImageBrush();
        ImageBrush _tmp15 = new ImageBrush();
        ImageBrush _tmp16 = new ImageBrush();
        ImageBrush _tmp17 = new ImageBrush();
        ImageBrush _tmp18 = new ImageBrush();
        public WindowD()
        {
            tmp1.ImageSource = new BitmapImage(new Uri("±1.00  mm (30-50).png", UriKind.Relative));
            tmp2.ImageSource = new BitmapImage(new Uri("±1.5  mm (60-100).png", UriKind.Relative));
            tmp3.ImageSource = new BitmapImage(new Uri("±0.10  mm (150).png", UriKind.Relative));
            tmp4.ImageSource = new BitmapImage(new Uri("±0.15 mm (500).png", UriKind.Relative));
            tmp5.ImageSource = new BitmapImage(new Uri("±0.20 mm （1000）.png", UriKind.Relative));
            tmp6.ImageSource = new BitmapImage(new Uri("±0.08 mm ( 1m ).png", UriKind.Relative));
            tmp7.ImageSource = new BitmapImage(new Uri("±1.2 mm( 2m ).png", UriKind.Relative));
            tmp8.ImageSource = new BitmapImage(new Uri("±0.02 mm (125).png", UriKind.Relative));
            tmp9.ImageSource = new BitmapImage(new Uri("±0.05 mm (300).png", UriKind.Relative));
            tmp10.ImageSource = new BitmapImage(new Uri("± 0004  mm.png", UriKind.Relative));
            tmp11.ImageSource = new BitmapImage(new Uri("0.08 g （近满）.png", UriKind.Relative));
            tmp12.ImageSource = new BitmapImage(new Uri("0.06 g （1_2）.png", UriKind.Relative));
            tmp13.ImageSource = new BitmapImage(new Uri("0.04 g （1_3及以下）.png", UriKind.Relative));
            tmp14.ImageSource = new BitmapImage(new Uri("1.3 mg （近满）.png", UriKind.Relative));
            tmp15.ImageSource = new BitmapImage(new Uri("1.0 mg （1_2）.png", UriKind.Relative));
            tmp16.ImageSource = new BitmapImage(new Uri("0.7mg （1_3及以下）.png", UriKind.Relative));
            tmp17.ImageSource = new BitmapImage(new Uri("± 1  ℃.png", UriKind.Relative));
            tmp18.ImageSource = new BitmapImage(new Uri("± 0.2  ℃.png", UriKind.Relative));

            _tmp1.ImageSource = new BitmapImage(new Uri("±1.00  mm (30-50)改.png", UriKind.Relative));
            _tmp2.ImageSource = new BitmapImage(new Uri("±1.5  mm (60-100)改.png", UriKind.Relative));
            _tmp3.ImageSource = new BitmapImage(new Uri("±0.10  mm (150)改.png", UriKind.Relative));
            _tmp4.ImageSource = new BitmapImage(new Uri("±0.15 mm (500)改.png", UriKind.Relative));
            _tmp5.ImageSource = new BitmapImage(new Uri("±0.20 mm （1000）改.png", UriKind.Relative));
            _tmp6.ImageSource = new BitmapImage(new Uri("±0.08 mm ( 1m )改.png", UriKind.Relative));
            _tmp7.ImageSource = new BitmapImage(new Uri("±1.2 mm( 2m )改.png", UriKind.Relative));
            _tmp8.ImageSource = new BitmapImage(new Uri("±0.02 mm (125)改.png", UriKind.Relative));
            _tmp9.ImageSource = new BitmapImage(new Uri("±0.05 mm (300)改.png", UriKind.Relative));
            _tmp10.ImageSource = new BitmapImage(new Uri("± 0004  mm改.png", UriKind.Relative));
            _tmp11.ImageSource = new BitmapImage(new Uri("0.08 g （近满）改.png", UriKind.Relative));
            _tmp12.ImageSource = new BitmapImage(new Uri("0.06 g （1_2）改.png", UriKind.Relative));
            _tmp13.ImageSource = new BitmapImage(new Uri("0.04 g （1_3及以下）改.png", UriKind.Relative));
            _tmp14.ImageSource = new BitmapImage(new Uri("1.3 mg （近满）改.png", UriKind.Relative));
            _tmp15.ImageSource = new BitmapImage(new Uri("1.0 mg （1_2）改.png", UriKind.Relative));
            _tmp16.ImageSource = new BitmapImage(new Uri("0.7mg （1_3及以下）改.png", UriKind.Relative));
            _tmp17.ImageSource = new BitmapImage(new Uri("± 1  ℃改.png", UriKind.Relative));
            _tmp18.ImageSource = new BitmapImage(new Uri("± 0.2  ℃改.png", UriKind.Relative));

            InitializeComponent();
        }

        private void reset()
        {

        }

        private void DClick1(object sender, MouseButtonEventArgs e)
        {
            reset();
            LV1.Background = _tmp1;
        }

        private void DClick2(object sender, MouseButtonEventArgs e)
        {
            reset();
            LV2.Background = _tmp2;
        }

        private void DClick3(object sender, MouseButtonEventArgs e)
        {
            reset();
            LV3.Background = _tmp3;
        }

        private void DClick4(object sender, MouseButtonEventArgs e)
        {
            reset();
            LV4.Background = _tmp4;
        }

        private void DClick5(object sender, MouseButtonEventArgs e)
        {
            reset();
            LV5.Background = _tmp5;
        }

        private void DClick6(object sender, MouseButtonEventArgs e)
        {
            reset();
            LV6.Background = _tmp6;
        }

        private void DClick7(object sender, MouseButtonEventArgs e)
        {
            reset();
            LV7.Background = _tmp7;
        }

        private void DClick8(object sender, MouseButtonEventArgs e)
        {
            reset();
            LV8.Background = _tmp8;
        }

        private void DClick9(object sender, MouseButtonEventArgs e)
        {
            reset();
            LV9.Background = _tmp9;
        }

        private void DClick10(object sender, MouseButtonEventArgs e)
        {
            reset();
            LV10.Background = _tmp10;
        }

        private void DClick11(object sender, MouseButtonEventArgs e)
        {
            reset();
            LV11.Background = _tmp11;
        }

        private void DClick12(object sender, MouseButtonEventArgs e)
        {
            reset();
            LV12.Background = _tmp12;
        }

        private void DClick13(object sender, MouseButtonEventArgs e)
        {
            reset();
            LV13.Background = _tmp13;
        }

        private void DClick14(object sender, MouseButtonEventArgs e)
        {
            reset();
            LV14.Background = _tmp14;
        }

        private void DClick15(object sender, MouseButtonEventArgs e)
        {
            reset();
            LV15.Background = _tmp15;
        }

        private void DClick16(object sender, MouseButtonEventArgs e)
        {
            reset();
            LV16.Background = _tmp16;
        }

        private void DClick17(object sender, MouseButtonEventArgs e)
        {
            reset();
            LV17.Background = _tmp17;
        }

        private void DClick18(object sender, MouseButtonEventArgs e)
        {
            reset();
            LV18.Background = _tmp18;
        }

        private void To_Back(object sender, RoutedEventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
    }
}
