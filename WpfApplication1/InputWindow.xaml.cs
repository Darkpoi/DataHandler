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
    /// InputWindow.xaml 的交互逻辑
    /// </summary>
    public partial class InputWindow : Window
    {
        MainWindow tmpw = new MainWindow();
        public InputWindow()
        {
            InitializeComponent();
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            int i = 0;
            while (true)
            {
                if (_1.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_1.Text);
                if (_2.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_2.Text);
                if (_3.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_3.Text);
                if (_4.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_4.Text);
                if (_5.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_5.Text);
                if (_6.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_6.Text);
                if (_7.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_7.Text);
                if (_8.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_8.Text);
                if (_9.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_9.Text);
                if (_10.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_10.Text);

                if (_11.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_11.Text);
                if (_12.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_12.Text);
                if (_13.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_13.Text);
                if (_14.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_14.Text);
                if (_15.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_15.Text);
                if (_16.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_16.Text);
                if (_17.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_17.Text);
                if (_18.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_18.Text);
                if (_19.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_19.Text);
                if (_20.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_20.Text);

                if (_21.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_21.Text);
                if (_22.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_22.Text);
                if (_23.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_23.Text);
                if (_24.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_24.Text);
                if (_25.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_25.Text);
                if (_26.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_26.Text);
                if (_27.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_27.Text);
                if (_28.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_28.Text);
                if (_29.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_29.Text);
                if (_30.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_30.Text);

                if (_31.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_31.Text);
                if (_32.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_32.Text);
                if (_33.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_33.Text);
                if (_34.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_34.Text);
                if (_35.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_35.Text);
                if (_36.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_36.Text);
                if (_37.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_37.Text);
                if (_38.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_38.Text);
                if (_39.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_39.Text);
                if (_40.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_40.Text);

                if (_41.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_41.Text);
                if (_42.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_42.Text);
                if (_43.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_43.Text);
                if (_44.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_44.Text);
                if (_45.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_45.Text);
                if (_46.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_46.Text);
                if (_47.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_47.Text);
                if (_48.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_48.Text);
                if (_49.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_49.Text);
                if (_50.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_50.Text);

                if (_51.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_51.Text);
                if (_52.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_52.Text);
                if (_53.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_53.Text);
                if (_54.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_54.Text);
                if (_55.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_55.Text);
                if (_56.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_56.Text);
                if (_57.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_57.Text);
                if (_58.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_58.Text);
                if (_59.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_59.Text);
                if (_60.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_60.Text);

                if (_61.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_61.Text);
                if (_62.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_62.Text);
                if (_63.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_63.Text);
                if (_64.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_64.Text);
                if (_65.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_65.Text);
                if (_66.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_66.Text);
                if (_67.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_67.Text);
                if (_68.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_68.Text);
                if (_69.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_69.Text);
                if (_70.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_70.Text);

                if (_71.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_71.Text);
                if (_72.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_72.Text);
                if (_73.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_73.Text);
                if (_74.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_74.Text);
                if (_75.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_75.Text);
                if (_76.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_76.Text);
                if (_77.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_77.Text);
                if (_78.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_78.Text);
                if (_79.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_79.Text);
                if (_80.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_80.Text);

                if (_81.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_81.Text);
                if (_82.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_82.Text);
                if (_83.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_83.Text);
                if (_84.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_84.Text);
                if (_85.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_85.Text);
                if (_86.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_86.Text);
                if (_87.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_87.Text);
                if (_88.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_88.Text);
                if (_89.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_89.Text);
                if (_90.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_90.Text);

                if (_91.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_91.Text);
                if (_92.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_92.Text);
                if (_93.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_93.Text);
                if (_94.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_94.Text);
                if (_95.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_95.Text);
                if (_96.Text == string.Empty) break;
                MainWindow.tmpdouble[i++] = Convert.ToDouble(_96.Text);
            }
            MainWindow.tmpdata = new Data(i, MainWindow.tmpdouble, 0, 0);
            Application.Current.MainWindow = this.Owner;
            this.Hide();
            this.Owner.Show();
            tmpw = (MainWindow)this.Owner;
            tmpw.ShowData();
            tmpw = null;
        }
        public void Clear()
        {
            _1.Text = string.Empty;
            _2.Text = string.Empty;
            _3.Text = string.Empty;
            _4.Text = string.Empty;
            _5.Text = string.Empty;
            _6.Text = string.Empty;
            _7.Text = string.Empty;
            _8.Text = string.Empty;
            _9.Text = string.Empty;
            _10.Text = string.Empty;

            _11.Text = string.Empty;
            _12.Text = string.Empty;
            _13.Text = string.Empty;
            _14.Text = string.Empty;
            _15.Text = string.Empty;
            _16.Text = string.Empty;
            _17.Text = string.Empty;
            _18.Text = string.Empty;
            _19.Text = string.Empty;
            _20.Text = string.Empty;

            _21.Text = string.Empty;
            _22.Text = string.Empty;
            _23.Text = string.Empty;
            _24.Text = string.Empty;
            _25.Text = string.Empty;
            _26.Text = string.Empty;
            _27.Text = string.Empty;
            _28.Text = string.Empty;
            _29.Text = string.Empty;
            _30.Text = string.Empty;

            _31.Text = string.Empty;
            _32.Text = string.Empty;
            _33.Text = string.Empty;
            _34.Text = string.Empty;
            _35.Text = string.Empty;
            _36.Text = string.Empty;
            _37.Text = string.Empty;
            _38.Text = string.Empty;
            _39.Text = string.Empty;
            _40.Text = string.Empty;

            _41.Text = string.Empty;
            _42.Text = string.Empty;
            _43.Text = string.Empty;
            _44.Text = string.Empty;
            _45.Text = string.Empty;
            _46.Text = string.Empty;
            _47.Text = string.Empty;
            _48.Text = string.Empty;
            _49.Text = string.Empty;
            _50.Text = string.Empty;

            _51.Text = string.Empty;
            _52.Text = string.Empty;
            _53.Text = string.Empty;
            _54.Text = string.Empty;
            _55.Text = string.Empty;
            _56.Text = string.Empty;
            _57.Text = string.Empty;
            _58.Text = string.Empty;
            _59.Text = string.Empty;
            _60.Text = string.Empty;

            _61.Text = string.Empty;
            _62.Text = string.Empty;
            _63.Text = string.Empty;
            _64.Text = string.Empty;
            _65.Text = string.Empty;
            _66.Text = string.Empty;
            _67.Text = string.Empty;
            _68.Text = string.Empty;
            _69.Text = string.Empty;
            _70.Text = string.Empty;

            _71.Text = string.Empty;
            _72.Text = string.Empty;
            _73.Text = string.Empty;
            _74.Text = string.Empty;
            _75.Text = string.Empty;
            _76.Text = string.Empty;
            _77.Text = string.Empty;
            _78.Text = string.Empty;
            _79.Text = string.Empty;
            _80.Text = string.Empty;

            _81.Text = string.Empty;
            _82.Text = string.Empty;
            _83.Text = string.Empty;
            _84.Text = string.Empty;
            _85.Text = string.Empty;
            _86.Text = string.Empty;
            _87.Text = string.Empty;
            _88.Text = string.Empty;
            _89.Text = string.Empty;
            _90.Text = string.Empty;

            _91.Text = string.Empty;
            _92.Text = string.Empty;
            _93.Text = string.Empty;
            _94.Text = string.Empty;
            _95.Text = string.Empty;
            _96.Text = string.Empty;
        }
    }
}
