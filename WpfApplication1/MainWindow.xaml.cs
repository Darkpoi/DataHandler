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
        public static Data tmpdata;
        public MainWindow()
        {
            //tmpw.Owner = this;
            InitializeComponent();
        }

        private void To_InputPage(object sender, RoutedEventArgs e)
        {
            //InputWindow tmpw = new InputWindow();
            Application.Current.MainWindow = wb;//tmpw;
            this.Hide();
            //tmpw.Show();
            wb.Show();
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

        private void GetFunc(object sender, RoutedEventArgs e)
        {
            //if (In_Delta.Text == string.Empty || In_Xi.Text == string.Empty) throw new Exception("Lack of Data");
            //tmpdata.Xi = Convert.ToDouble(In_Xi.Text);
            //tmpdata.Delta = Convert.ToDouble(In_Delta.Text);
            //Out_Func.Text = (Math.Exp(-tmpdata.Delta * tmpdata.Delta / (2 * tmpdata.Xi * tmpdata.Xi)) / (Math.Sqrt(2 * Math.PI) * tmpdata.Xi)).ToString("0.000000");
        }

        private void GetUa(object sender, RoutedEventArgs e)
        {
            //Out_Ua.Text = tmpdata.Ua.ToString("0.000000");
        }
    }
}
