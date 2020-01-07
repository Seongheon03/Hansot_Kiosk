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
using Hansot_Kiosk.Common;
using Hansot_Kiosk.ViewModel;

namespace Hansot_Kiosk
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private int imagesIdx = 0;
        private PosterViewModel posterViewModel = new PosterViewModel();

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            posterViewModel.LoadData();
            ChangePoster(posterViewModel.PosterList[imagesIdx].ImageUrl);
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            IncreaseImagesIdx();
            ChangeButtonStyle();
            ChangePoster(posterViewModel.PosterList[imagesIdx].ImageUrl);
        }

        private void beforeBtn_Click(object sender, RoutedEventArgs e)
        {
            DecreaseImagesIdx();
            ChangeButtonStyle();
            ChangePoster(posterViewModel.PosterList[imagesIdx].ImageUrl);
        }

        private void orderBtn_Click(object sender, RoutedEventArgs e)
        {
            SwitchScreen();
        }


        private void IncreaseImagesIdx()
        {
            if (++imagesIdx == 4)
            {
                imagesIdx = 0;
            }
        }

        private void DecreaseImagesIdx()
        {
            if (--imagesIdx == -1)
            {
                imagesIdx = 3;
            }
        }
        private void ChangeButtonStyle()
        {
            orderBtn.Style = posterViewModel.PosterList[imagesIdx].BtnStyle;
        }

        private void ChangePoster(string image)
        {
            eventImg.Source = ComUtils.GetImage(image);
        }

        private void SwitchScreen()
        {
            new Order().Show();
            this.Close();
        }

    }   
}
