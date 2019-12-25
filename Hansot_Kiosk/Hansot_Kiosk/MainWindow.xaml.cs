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

namespace Hansot_Kiosk
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] images = new string[4];
        int imagesIdx = 0;
        public MainWindow()
        {
            InitializeComponent();

            images[0] = "\\Resource\\한솥이벤트1.png";
            images[1] = "\\Resource\\한솥이벤트2.jpg";
            images[2] = "\\Resource\\한솥이벤트3.jpg";
            images[3] = "\\Resource\\한솥이벤트4.jpg";
            eventImg.Source = new BitmapImage(new Uri(@images[0], UriKind.Relative));
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            if (++imagesIdx == 4)
            {
                imagesIdx = 0;
                orderBtn.Style = Application.Current.Resources["ButtonIndex0"] as Style;
            }
            else if (imagesIdx == 1)
                orderBtn.Style = Application.Current.Resources["ButtonIndex1"] as Style;
            else if (imagesIdx == 2)
                orderBtn.Style = Application.Current.Resources["ButtonIndex2"] as Style;
            else if (imagesIdx == 3)
                orderBtn.Style = Application.Current.Resources["BasicButton"] as Style;

            eventImg.Source = new BitmapImage(new Uri(@images[imagesIdx], UriKind.Relative));
        }

        private void beforeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (--imagesIdx == -1)
            {
                imagesIdx = 3;
                orderBtn.Style = Application.Current.Resources["BasicButton"] as Style;
            }
            else if (imagesIdx == 2)
                orderBtn.Style = Application.Current.Resources["ButtonIndex2"] as Style;
            else if(imagesIdx == 1)
                orderBtn.Style = Application.Current.Resources["ButtonIndex1"] as Style;
            else if(imagesIdx == 0)
                orderBtn.Style = Application.Current.Resources["ButtonIndex0"] as Style;

            eventImg.Source = new BitmapImage(new Uri(@images[imagesIdx], UriKind.Relative));
        }

        private void orderBtn_Click(object sender, RoutedEventArgs e)
        {
            new Order().Show();
            this.Close();
        }
    }   
}
