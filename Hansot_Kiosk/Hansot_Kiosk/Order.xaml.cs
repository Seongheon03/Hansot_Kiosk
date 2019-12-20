using Hansot_Kiosk.Model;
using Hansot_Kiosk.ViewModel;
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

namespace Hansot_Kiosk
{
    /// <summary>
    /// Order.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Order : Window
    {
        int result = 0;
        public Order()
        {
            InitializeComponent();
            this.DataContext = App.menuViewModel;
        }
        private void bestBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("인기 메뉴");
        }

        private void orderBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("주문이 완료되었습니다");
            new MainWindow().Show();
            this.Close();
        }

        private void cancleBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("주문이 취소되었습니다");
            App.menuViewModel.OrderedFoodItems.Clear();
            new MainWindow().Show();
            this.Close();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Food selectedFood = (Food)list.SelectedItem;
            if(selectedFood.Count > 0)
            {
                MessageBox.Show("아래 수량을 조정해주세요.");
                return;
            }
            selectedFood.Count++;
            App.menuViewModel.OrderedFoodItems.Add(selectedFood);
            result += selectedFood.Price;
            total.Text = Convert.ToString(result);
        }

        private void ListView_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}