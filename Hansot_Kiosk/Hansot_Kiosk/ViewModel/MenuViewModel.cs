using Hansot_Kiosk.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hansot_Kiosk.ViewModel
{
    public class MenuViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public MenuViewModel()
        {
            FoodItems.Add(new Food() { Name = "치킨마요", ImageUrl = "\\Resource\\치킨마요.png", Price = 3000 });
            FoodItems.Add(new Food() { Name = "치킨 샐러드마요", ImageUrl = "\\Resource\\치킨 샐러드마요.png", Price = 5000 });
            FoodItems.Add(new Food() { Name = "한솥 철판볶음밥", ImageUrl = "\\Resource\\한솥 철판볶음밥.png", Price = 4000 });
        }

        private ObservableCollection<Food> _foodItems = new ObservableCollection<Food>();
        public ObservableCollection<Food> FoodItems
        {
            get
            {
                return _foodItems;
            }
            set
            {
                _foodItems = value;
                NotifyPropertyChanged(nameof(FoodItems));
            }
        }

        private ObservableCollection<Food> _orderedFoodItems = new ObservableCollection<Food>();
        public ObservableCollection<Food> OrderedFoodItems
        {
            get
            {
                return _orderedFoodItems;
            }
            set
            {
                _orderedFoodItems = value;
                NotifyPropertyChanged(nameof(OrderedFoodItems));
            }
        }

        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
