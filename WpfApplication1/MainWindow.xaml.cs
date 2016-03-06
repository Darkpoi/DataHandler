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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataHandler
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public static double[] tmpdouble = new double[96];
        static InputWindow tmpw = new InputWindow();
        static WindowB wb = new WindowB();
        static WindowC wc = new WindowC();
        public static Data tmpdata;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void To_InputPage(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow = tmpw;
            this.Hide();
            tmpw.Show();
            if (tmpw.Owner != this) tmpw.Owner = this;
            Output.Text = string.Empty;
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            Output.Text = string.Empty;
            Out_Ave.Text = string.Empty;
            Out_Sigma.Text = string.Empty;
            tmpdata = null;
            for (int i = 0; i < 96; i++) tmpdouble[i] = 0;
            tmpw.Clear();
        }

        public void ShowData()
        {
            for (int i = 0; i < tmpdata.Num; i++)
            {
                Output.Text += tmpdouble[i].ToString("0.000000") + " ";
                if (i % 3 == 2) Output.Text += "\n";
            }
        }

        private void GetAve(object sender, RoutedEventArgs e)
        {
            Out_Ave.Text = tmpdata.Ave.ToString("0.000000");
        }

        private void GetSigma(object sender, RoutedEventArgs e)
        {
            Out_Sigma.Text = tmpdata.Sigma.ToString("0.000000");
        }

        private void To_WindowB(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow = wb;
            this.Hide();
            wb.Show();
            if (wb.Owner != this) wb.Owner = this;
            wb.Out_N.Text = tmpdata.Num.ToString();
            wb.tmpdata = tmpdata;
        }

        private void To_WindowC(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow = wc;
            this.Hide();
            wc.Show();
            if (wc.Owner != this) wc.Owner = this;
            wc.tmpdata = tmpdata;
        }

        private void Get_Ua(object sender, RoutedEventArgs e)
        {
            Out_Ua.Text = tmpdata.Ua.ToString("0.000000");
        }
    }
}
