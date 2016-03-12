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

        ImageBrush tmp1 = new ImageBrush();
        ImageBrush tmp2 = new ImageBrush();
        ImageBrush tmp3 = new ImageBrush();
        ImageBrush tmp4 = new ImageBrush();
        ImageBrush tmp11 = new ImageBrush();
        ImageBrush tmp22 = new ImageBrush();
        ImageBrush tmp33 = new ImageBrush();
        ImageBrush tmp44 = new ImageBrush();
        double[,] tmpdoubles = new[,] { { 1.32, 1.20, 1.14, 1.11, 1.09, 1.08, 1.07, 1.06, 1.04, 1.03, 1},
        { 2.92, 2.35, 2.13, 2.02, 1.94, 1.86, 1.83, 1.76, 1.73, 1.71, 1.65},
        { 4.30, 3.18, 2.78, 2.57, 2.46, 2.37, 2.31, 2.26, 2.15, 2.09, 1.96},
        { 9.93, 5.84, 4.60, 4.03, 3.71, 3.50, 3.36, 3.25, 2.98, 2.86, 2.58} };
        public Data tmpdata;
        public int chosen;

        public WindowB()
        {
            tmp1.ImageSource = new BitmapImage(new Uri("tempdata/按钮1.png", UriKind.Relative));
            tmp2.ImageSource = new BitmapImage(new Uri("tempdata/按钮2.png", UriKind.Relative));
            tmp3.ImageSource = new BitmapImage(new Uri("tempdata/按钮3.png", UriKind.Relative));
            tmp4.ImageSource = new BitmapImage(new Uri("tempdata/按钮4.png", UriKind.Relative));
            tmp11.ImageSource = new BitmapImage(new Uri("tempdata/按钮1改.png", UriKind.Relative));
            tmp22.ImageSource = new BitmapImage(new Uri("tempdata/按钮2改.png", UriKind.Relative));
            tmp33.ImageSource = new BitmapImage(new Uri("tempdata/按钮3改.png", UriKind.Relative));
            tmp44.ImageSource = new BitmapImage(new Uri("tempdata/按钮4改.png", UriKind.Relative));

            InitializeComponent();
        }

        private void DClick99(object sender, MouseButtonEventArgs e)
        {
            reset();
            LV4.Background = tmp44;
            chosen = 4;
            Judge_T(4);
        }

        private void DClick90(object sender, MouseButtonEventArgs e)
        {
            reset();
            LV2.Background = tmp22;
            chosen = 2;
            Judge_T(2);
        }

        private void DClick68(object sender, MouseButtonEventArgs e)
        {
            reset();
            LV1.Background = tmp11;
            chosen = 1;
            Judge_T(1);
        }

        private void DClick95(object sender, MouseButtonEventArgs e)
        {
            reset();
            LV3.Background = tmp33;
            chosen = 3;
            Judge_T(3);
        }

        private void reset()
        {
            LV1.Background = tmp1;
            LV2.Background = tmp2;
            LV3.Background = tmp3;
            LV4.Background = tmp4;
        }

        public void Judge_T(int k)
        {
            //This should be rewritten by back-end
            double tmp;
            if (tmpdata.Num < 11) tmp = tmpdoubles[tmpdata.Num - 3, k];
            else if (tmpdata.Num < 16) tmp = tmpdoubles[8, k];
            else if (tmpdata.Num < 21) tmp = tmpdoubles[9, k];
            else tmp = tmpdoubles[10, k];
            Out_T.Text = tmp.ToString();
            tmpdata.T = tmp;
            tmp *= tmpdata.Ua;
            Out_A.Text = tmp.ToString();
            tmpdata.A = tmp;
        }

        private void To_Back(object sender, RoutedEventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        public void Out_Clear()
        {
            reset();
            Out_T.Text = string.Empty;
            Out_N.Text = string.Empty;
            Out_A.Text = string.Empty;
            tmpdata = null;
        }
    }
}
