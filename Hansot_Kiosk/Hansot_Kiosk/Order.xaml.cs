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
        FoodViewModel foodViewModel = new FoodViewModel();
        int result = 0;
        public Order()
        {
            InitializeComponent();
            Loaded += Order_Loaded;
        }

        private void Order_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = foodViewModel;
            foodViewModel.LoadData();
            SetListViewMenu(ECategory.BEST);
        }

        private void SetListViewMenu(ECategory category)
        {
            lvMenu.ItemsSource = foodViewModel.Foods.Where(x => x.ECategory == category).ToList();
        }

        private void lvCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Category selectedCategory = (Category)lvCategory.SelectedItem;
            SetListViewMenu(selectedCategory.ECategory);
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Food selectedFood = ((ListViewItem)lvShoppingList.ContainerFromElement(sender as Button)).Content as Food;

            IncreaseCount(selectedFood);
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            Food selectedFood = ((ListViewItem)lvShoppingList.ContainerFromElement(sender as Button)).Content as Food;

            if (IsNeedToRemove(selectedFood, sender, e))
            {
                btnDel_Click(sender, e);
                return;
            }
            DecreaseCount(selectedFood);
        }

        private void btnCancle_Click(object sender, RoutedEventArgs e)
        {
            EndOrder("주문이 취소되었습니다.");
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        { 
            if(OrderedFoodIsNull())
            {
                return;
            }
            EndOrder("주문이 완료되었습니다.");
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            Food selectedFood = ((ListViewItem)lvShoppingList.ContainerFromElement(sender as Button)).Content as Food;

            DecreaseCountTo0(selectedFood);
            RemoveSelectedFood(selectedFood);
        }

        private void lvMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Food selectedFood = (Food)lvMenu.SelectedItem;

            if (selectedFood == null)
            {
                return;
            }
            IsOverlap(selectedFood);
            IncreaseCount(selectedFood);
            AddOrderedFoodItems(selectedFood);
        }

        private void IncreaseCount(Food selectedFood)
        {
            selectedFood.Count++;
            SetTextBlockTotal(selectedFood, '+');
        }

        private void DecreaseCount(Food selectedFood)
        {
            selectedFood.Count--;
            SetTextBlockTotal(selectedFood, '-');
        }

        private void SetTextBlockTotal(Food selectedFood, char sign)
        {
            switch (sign)
            {
                case '+':
                    tbTotal.Text = Convert.ToString(result += selectedFood.Price);
                    break;
                case '-':
                    tbTotal.Text = Convert.ToString(result -= selectedFood.Price);
                    break;
            }
        }

        private bool IsNeedToRemove(Food selectedFood, object sender, RoutedEventArgs e)
        {
            if (selectedFood.Count == 1)
            {
                return true;
            }
            return false;
        }

        private bool OrderedFoodIsNull()
        {
            if (foodViewModel.OrderedFoodItems.Count == 0)
            {
                MessageBox.Show("주문할 음식이 없습니다.");
                return true;
            }
            return false;
        }

        private void DecreaseCountTo0(Food selectedFood)
        {
            while (selectedFood.Count != 0)
            {
                DecreaseCount(selectedFood);
            }
        }

        private void RemoveSelectedFood(Food selectedFood)
        {
            foodViewModel.OrderedFoodItems.Remove(selectedFood);
        }

        private void IsOverlap(Food selectedFood)
        {
            foreach (Food lvMenu in lvShoppingList.Items)
            {
                if (selectedFood.Name.Equals(lvMenu.Name))
                {
                    MessageBox.Show("아래 수량을 조정해주세요.");
                    return;
                }
            }
        }
        private void AddOrderedFoodItems(Food selectedFood)
        {
            foodViewModel.OrderedFoodItems.Add(selectedFood);
        }

        private void EndOrder(string message)
        {
            MessageBox.Show(message);
            switchScreen();
        }

        private void switchScreen()
        {
            ResetOrderedFoodItems();
            new MainWindow().Show();
            this.Close();
        }

        private void ResetOrderedFoodItems()
        {
            foreach (Food item in foodViewModel.OrderedFoodItems)
            {
                item.Count = 0;
            }
            foodViewModel.OrderedFoodItems.Clear();
        }
    }
}