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
            list.ItemsSource = App.menuViewModel.BestItems;
        }

        private void dosilakBtn_Click(object sender, RoutedEventArgs e)
        {
            list.ItemsSource = App.menuViewModel.DosilakItems;
        }

        private void cubbabBtn_Click(object sender, RoutedEventArgs e)
        {
            list.ItemsSource = App.menuViewModel.CubbabItems;
        }
        private void sidedishBtn_Click(object sender, RoutedEventArgs e)
        {
            list.ItemsSource = App.menuViewModel.SidedishItems;
        }
        private void sideBtn_Click(object sender, RoutedEventArgs e)
        {
            list.ItemsSource = App.menuViewModel.SideItems;
        }

        private void drinkBtn_Click(object sender, RoutedEventArgs e)
        {
            list.ItemsSource = App.menuViewModel.DrinkItems;
        }

        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Food selectedFood = (Food)list.SelectedItem;

            if (selectedFood == null)
                return;

            foreach (Food list in shoppingList.Items)
            {
                if (selectedFood.Name.Equals(list.Name))
                {
                    MessageBox.Show("아래 수량을 조정해주세요.");
                    return;
                }
            }

            selectedFood.Count++;
            App.menuViewModel.OrderedFoodItems.Add(selectedFood);
            total.Text = Convert.ToString(result += selectedFood.Price);
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            Food selectedFood = ((ListViewItem)shoppingList.ContainerFromElement(sender as Button)).Content as Food;
            
            selectedFood.Count++;
            total.Text = Convert.ToString(result += selectedFood.Price);
        }

        private void subBtn_Click(object sender, RoutedEventArgs e)
        {
            Food selectedFood = ((ListViewItem)shoppingList.ContainerFromElement(sender as Button)).Content as Food;

            if(selectedFood.Count == 1)
            {
                delBtn_Click(sender, e);
                return;
            }

            else 
                selectedFood.Count--;

            total.Text = Convert.ToString(result -= selectedFood.Price);
        }

        private void delBtn_Click(object sender, RoutedEventArgs e)
        {
            Food selectedFood = ((ListViewItem)shoppingList.ContainerFromElement(sender as Button)).Content as Food;

            while(selectedFood.Count != 0)
            {
                total.Text = Convert.ToString(result -= selectedFood.Price);
                selectedFood.Count--;
            }

            App.menuViewModel.OrderedFoodItems.Remove(selectedFood);
        }

        private void orderBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("주문이 완료되었습니다");

            switchScreen();
        }

        private void cancleBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("주문이 취소되었습니다");

            switchScreen();
        }

        private void switchScreen()
        {
            foreach (Food item in App.menuViewModel.OrderedFoodItems)
            {
                item.Count = 0;
            }

            App.menuViewModel.OrderedFoodItems.Clear();
            new MainWindow().Show();
            this.Close();
        }
    }
}