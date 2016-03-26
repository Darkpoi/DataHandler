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
    /// WindowC.xaml 的交互逻辑
    /// </summary>
    public partial class WindowC : Window
    {
        ImageBrush tmp1 = new ImageBrush();
        ImageBrush tmp2 = new ImageBrush();
        ImageBrush tmp3 = new ImageBrush();
        ImageBrush tmp4 = new ImageBrush();
        ImageBrush tmp5 = new ImageBrush();
        ImageBrush tmp11 = new ImageBrush();
        ImageBrush tmp22 = new ImageBrush();
        ImageBrush tmp33 = new ImageBrush();
        ImageBrush tmp44 = new ImageBrush();
        ImageBrush tmp55 = new ImageBrush();

        ImageBrush _tmp1 = new ImageBrush();
        ImageBrush _tmp2 = new ImageBrush();
        ImageBrush _tmp3 = new ImageBrush();
        ImageBrush _tmp4 = new ImageBrush();
        ImageBrush _tmp5 = new ImageBrush();
        ImageBrush _tmp6 = new ImageBrush();
        ImageBrush _tmp7 = new ImageBrush();
        ImageBrush _tmp8 = new ImageBrush();
        ImageBrush _tmp11 = new ImageBrush();
        ImageBrush _tmp22 = new ImageBrush();
        ImageBrush _tmp33 = new ImageBrush();
        ImageBrush _tmp44 = new ImageBrush();
        ImageBrush _tmp55 = new ImageBrush();
        ImageBrush _tmp66 = new ImageBrush();
        ImageBrush _tmp77 = new ImageBrush();
        ImageBrush _tmp88 = new ImageBrush();
        static WindowD wd = new WindowD();
        public Data tmpdata;
        public WindowC()
        {
            tmp1.ImageSource = new BitmapImage(new Uri("tempdata/米  尺 C=3.png", UriKind.Relative));
            tmp2.ImageSource = new BitmapImage(new Uri("tempdata/游标卡尺 C= √3.png", UriKind.Relative));
            tmp3.ImageSource = new BitmapImage(new Uri("tempdata/千分尺.png", UriKind.Relative));
            tmp4.ImageSource = new BitmapImage(new Uri("tempdata/物理天平.png", UriKind.Relative));
            tmp5.ImageSource = new BitmapImage(new Uri("tempdata/秒表.png", UriKind.Relative));

            tmp11.ImageSource = new BitmapImage(new Uri("tempdata/米  尺 C=3改.png", UriKind.Relative));
            tmp22.ImageSource = new BitmapImage(new Uri("tempdata/游标卡尺 C= √3改.png", UriKind.Relative));
            tmp33.ImageSource = new BitmapImage(new Uri("tempdata/千分尺改.png", UriKind.Relative));
            tmp44.ImageSource = new BitmapImage(new Uri("tempdata/物理天平改.png", UriKind.Relative));
            tmp55.ImageSource = new BitmapImage(new Uri("tempdata/秒表改.png", UriKind.Relative));

            _tmp1.ImageSource = new BitmapImage(new Uri("tempdata/0.500.png", UriKind.Relative));
            _tmp2.ImageSource = new BitmapImage(new Uri("tempdata/0.683.png", UriKind.Relative));
            _tmp3.ImageSource = new BitmapImage(new Uri("tempdata/0.900.png", UriKind.Relative));
            _tmp4.ImageSource = new BitmapImage(new Uri("tempdata/0.950.png", UriKind.Relative));
            _tmp5.ImageSource = new BitmapImage(new Uri("tempdata/0.955.png", UriKind.Relative));
            _tmp6.ImageSource = new BitmapImage(new Uri("tempdata/0.977.png", UriKind.Relative));
            _tmp7.ImageSource = new BitmapImage(new Uri("tempdata/0.990.png", UriKind.Relative));
            _tmp8.ImageSource = new BitmapImage(new Uri("tempdata/1.png", UriKind.Relative));

            _tmp11.ImageSource = new BitmapImage(new Uri("tempdata/0.500改.png", UriKind.Relative));
            _tmp22.ImageSource = new BitmapImage(new Uri("tempdata/0.683改.png", UriKind.Relative));
            _tmp33.ImageSource = new BitmapImage(new Uri("tempdata/0.900改.png", UriKind.Relative));
            _tmp44.ImageSource = new BitmapImage(new Uri("tempdata/0.950改.png", UriKind.Relative));
            _tmp55.ImageSource = new BitmapImage(new Uri("tempdata/0.955改.png", UriKind.Relative));
            _tmp66.ImageSource = new BitmapImage(new Uri("tempdata/0.977改.png", UriKind.Relative));
            _tmp77.ImageSource = new BitmapImage(new Uri("tempdata/0.990改.png", UriKind.Relative));
            //_tmp88.ImageSource = new BitmapImage(new Uri("1改.png", UriKind.Relative));

            InitializeComponent();
        }

        private void To_WindowD(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow = wd;
            wd.Show();
            this.Hide();
            if (wd.Owner != this) wd.Owner = this;
            wd.tmpdata = tmpdata;
        }

        private void reset()
        {
            LV1.Background = tmp1;
            LV2.Background = tmp2;
            LV3.Background = tmp3;
            LV4.Background = tmp4;
            LV5.Background = tmp5;
        }

        private void _reset()
        {
            LLV1.Background = _tmp1;
            LLV2.Background = _tmp2;
            LLV3.Background = _tmp3;
            LLV4.Background = _tmp4;
            LLV5.Background = _tmp5;
            LLV6.Background = _tmp6;
            LLV7.Background = _tmp7;
        }

        public void Judge()
        {
            if (tmpdata.flag != 0 && tmpdata.C != 0)
            {
                Out_Ub.Text = (tmpdata.Ub = tmpdata.Delta_Yi / tmpdata.C).ToString("0.000000");
                if (tmpdata.Kp != 0)
                    Out_B.Text = (tmpdata.B = tmpdata.Kp * tmpdata.Ub).ToString("0.000000");
                else
                {
                    Out_B.Text = string.Empty;
                    tmpdata.B = 0;
                }
            }
            else
            {
                Out_B.Text = string.Empty;
                Out_Ub.Text = string.Empty;
                tmpdata.Ub = tmpdata.B = 0;
            }
        }

        private void DClick1(object sender, MouseButtonEventArgs e)
        {
            reset();
            LV1.Background = tmp11;
            tmpdata.C = 3;
            Judge();
        }

        private void DClick2(object sender, MouseButtonEventArgs e)
        {
            reset();
            LV2.Background = tmp22;
            tmpdata.C = Math.Sqrt(3);
            Judge();
        }

        private void DClick3(object sender, MouseButtonEventArgs e)
        {
            reset();
            LV3.Background = tmp33;
            tmpdata.C = 3;
            Judge();
        }

        private void DClick4(object sender, MouseButtonEventArgs e)
        {
            reset();
            LV4.Background = tmp44;
            tmpdata.C = 3;
            Judge();
        }

        private void DClick5(object sender, MouseButtonEventArgs e)
        {
            reset();
            LV5.Background = tmp55;
            tmpdata.C = 3;
            Judge();
        }

        private void _DClick1(object sender, MouseButtonEventArgs e)
        {
            _reset();
            LLV1.Background = _tmp11;
            tmpdata.Kp = 0.675;
            Judge();
        }

        private void _DClick2(object sender, MouseButtonEventArgs e)
        {
            _reset();
            LLV2.Background = _tmp22;
            tmpdata.Kp = 1;
            Judge();
        }

        private void _DClick3(object sender, MouseButtonEventArgs e)
        {
            _reset();
            LLV3.Background = _tmp33;
            tmpdata.Kp = 1.65;
            Judge();
        }

        private void _DClick4(object sender, MouseButtonEventArgs e)
        {
            _reset();
            LLV4.Background = _tmp44;
            tmpdata.Kp = 1.96;
            Judge();
        }

        private void _DClick5(object sender, MouseButtonEventArgs e)
        {
            _reset();
            LLV5.Background = _tmp55;
            tmpdata.Kp = 2;
            Judge();
        }

        private void _DClick6(object sender, MouseButtonEventArgs e)
        {
            _reset();
            LLV6.Background = _tmp66;
            tmpdata.Kp = 2.58;
            Judge();
        }

        private void _DClick7(object sender, MouseButtonEventArgs e)
        {
            _reset();
            LLV7.Background = _tmp77;
            tmpdata.Kp = 3;
            Judge();
        }

        private void To_Back(object sender, RoutedEventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        public void Out_Clear()
        {
            reset();
            _reset();
            Out_B.Text = string.Empty;
            Out_Ub.Text = string.Empty;
            wd.Out_Clear();
            tmpdata = null;
        }
    }
}
