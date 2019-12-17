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
    class MenuViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public MenuViewModel()
        {
            FoodItems.Add(new Food());
            FoodItems.Add(new Food());
            FoodItems.Add(new Food());

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
        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
