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
            BestItems.Add(new Food() { Name = "메가고기고기", ImageUrl = "\\Resource\\메가고기고기.png", Price = 7900 });
            BestItems.Add(new Food() { Name = "국화", ImageUrl = "\\Resource\\국화.png", Price = 4000 });
            BestItems.Add(new Food() { Name = "동백", ImageUrl = "\\Resource\\동백.png", Price = 5000 });
            BestItems.Add(new Food() { Name = "메가치킨제육", ImageUrl = "\\Resource\\메가치킨제육.png", Price = 6900 });
            BestItems.Add(new Food() { Name = "치킨마요", ImageUrl = "\\Resource\\치킨마요.png", Price = 2900 });
            BestItems.Add(new Food() { Name = "치킨 샐러드마요", ImageUrl = "\\Resource\\치킨 샐러드마요.png", Price = 3400 });
            BestItems.Add(new Food() { Name = "참치마요", ImageUrl = "\\Resource\\참치마요.png", Price = 2900 });
            BestItems.Add(new Food() { Name = "한솥 철판볶음밥", ImageUrl = "\\Resource\\한솥 철판볶음밥.png", Price = 3700 });
            DosilakItems.Add(new Food() { Name = "메가고기고기", ImageUrl = "\\Resource\\메가고기고기.png", Price = 7900 });
            DosilakItems.Add(new Food() { Name = "국화", ImageUrl = "\\Resource\\국화.png", Price = 4000 });
            DosilakItems.Add(new Food() { Name = "동백", ImageUrl = "\\Resource\\동백.png", Price = 5000 });
            DosilakItems.Add(new Food() { Name = "메가치킨제육", ImageUrl = "\\Resource\\메가치킨제육.png", Price = 6900 });
            DosilakItems.Add(new Food() { Name = "생선까스도련님", ImageUrl = "\\Resource\\생선까스도련님.png", Price = 5500 });
            DosilakItems.Add(new Food() { Name = "돈까스도련님고기고기", ImageUrl = "\\Resource\\돈까스도련님고기고기.png", Price = 5500 });
            DosilakItems.Add(new Food() { Name = "탕수육도련님고기고기", ImageUrl = "\\Resource\\탕수육도련님고기고기.png", Price = 5600 });
            DosilakItems.Add(new Food() { Name = "새치고기고기", ImageUrl = "\\Resource\\새치고기고기.png", Price = 6000 });
            DosilakItems.Add(new Food() { Name = "메가치킨제육", ImageUrl = "\\Resource\\메가치킨제육.png", Price = 6900 });
            DosilakItems.Add(new Food() { Name = "칠리 찹쌀탕수육도련님", ImageUrl = "\\Resource\\칠리 찹쌀탕수육도련님.png", Price = 3900 });
            DosilakItems.Add(new Food() { Name = "오리지널 찹쌀탕수육", ImageUrl = "\\Resource\\오리지널 찹쌀탕수육.png", Price = 3700 });
            CubbabItems.Add(new Food() { Name = "메가치킨마요", ImageUrl = "\\Resource\\메가치킨마요.png", Price = 5200 });
            CubbabItems.Add(new Food() { Name = "갈비치킨마요", ImageUrl = "\\Resource\\갈비치킨마요.png", Price = 3200 });
            CubbabItems.Add(new Food() { Name = "왕치킨마요", ImageUrl = "\\Resource\\왕치킨마요.png", Price = 4200 });
            CubbabItems.Add(new Food() { Name = "치킨마요", ImageUrl = "\\Resource\\치킨마요.png", Price = 2900 });
            CubbabItems.Add(new Food() { Name = "치킨 샐러드마요", ImageUrl = "\\Resource\\치킨 샐러드마요.png", Price = 3400 });
            CubbabItems.Add(new Food() { Name = "돈치마요", ImageUrl = "\\Resource\\돈치마요.png", Price = 3500 });
            CubbabItems.Add(new Food() { Name = "참치마요", ImageUrl = "\\Resource\\참치마요.png", Price = 2900 });
            CubbabItems.Add(new Food() { Name = "왕카레돈까스 덮밥", ImageUrl = "\\Resource\\왕카레돈까스 덮밥.png", Price = 5500 });
            CubbabItems.Add(new Food() { Name = "새우돈까스덮밥", ImageUrl = "\\Resource\\새우돈까스덮밥.png", Price = 3900 });
            CubbabItems.Add(new Food() { Name = "돈까스 덮밥", ImageUrl = "\\Resource\\돈까스 덮밥.png", Price = 3900 });
            CubbabItems.Add(new Food() { Name = "돈까스 카레", ImageUrl = "\\Resource\\돈까스 카레.png", Price = 3900 });
            CubbabItems.Add(new Food() { Name = "불닭비빔밥", ImageUrl = "\\Resource\\불닭비빔밥.png", Price = 4500 });
            CubbabItems.Add(new Food() { Name = "치즈불닭비빔밥", ImageUrl = "\\Resource\\치즈불닭비빔밥.png", Price = 5700 });
            CubbabItems.Add(new Food() { Name = "폴리 도시락", ImageUrl = "\\Resource\\폴리 도시락.png", Price = 3800 });
            SidedishItems.Add(new Food() { Name = "계란말이", ImageUrl = "\\Resource\\계란말이.png", Price = 2200 });
            SidedishItems.Add(new Food() { Name = "치즈계란말이", ImageUrl = "\\Resource\\치즈계란말이.png", Price = 2800 });
            SidedishItems.Add(new Food() { Name = "카레", ImageUrl = "\\Resource\\카레.png", Price = 2400 });
            SidedishItems.Add(new Food() { Name = "소불고기", ImageUrl = "\\Resource\\소불고기.png", Price = 3900 });
            SideItems.Add(new Food() { Name = "탕수 닭강정", ImageUrl = "\\Resource\\탕수 닭강정.png", Price = 3000 });
            SideItems.Add(new Food() { Name = "갈비 닭강정", ImageUrl = "\\Resource\\갈비 닭강정.png", Price = 3000 });
            SideItems.Add(new Food() { Name = "오리지널 닭강정", ImageUrl = "\\Resource\\오리지널 닭강정.png", Price = 2800 });
            SideItems.Add(new Food() { Name = "닭강정 트리플 콤보", ImageUrl = "\\Resource\\닭강정 트리플 콤보.png", Price = 8000 });
            SideItems.Add(new Food() { Name = "치킨 BOX", ImageUrl = "\\Resource\\치킨 BOX.png", Price = 10000 });
            DrinkItems.Add(new Food() { Name = "코카콜라", ImageUrl = "\\Resource\\코카콜라.jpg", Price = 1500 });
            DrinkItems.Add(new Food() { Name = "웰치스", ImageUrl = "\\Resource\\웰치스.jpg", Price = 1300 });
            DrinkItems.Add(new Food() { Name = "환타", ImageUrl = "\\Resource\\환타.jpg", Price = 1300 });
            DrinkItems.Add(new Food() { Name = "생수", ImageUrl = "\\Resource\\생수.jpg", Price = 500 });
        }

        private ObservableCollection<Food> _bestFoodItems = new ObservableCollection<Food>();
        public ObservableCollection<Food> BestItems
        {
            get
            {
                return _bestFoodItems;
            }
            set
            {
                _bestFoodItems = value;
                NotifyPropertyChanged(nameof(BestItems));
            }
        }

        private ObservableCollection<Food> _dosilakItems = new ObservableCollection<Food>();
        public ObservableCollection<Food> DosilakItems
        {
            get
            {
                return _dosilakItems;
            }
            set
            {
                _dosilakItems = value;
                NotifyPropertyChanged(nameof(DosilakItems));
            }
        }

        private ObservableCollection<Food> _cubbabItems = new ObservableCollection<Food>();
        public ObservableCollection<Food> CubbabItems
        {
            get
            {
                return _cubbabItems;
            }
            set
            {
                _cubbabItems = value;
                NotifyPropertyChanged(nameof(CubbabItems));
            }
        }

        private ObservableCollection<Food> _sidedishItems = new ObservableCollection<Food>();
        public ObservableCollection<Food> SidedishItems
        {
            get
            {
                return _sidedishItems;
            }
            set
            {
                _sidedishItems = value;
                NotifyPropertyChanged(nameof(SidedishItems));
            }
        }

        private ObservableCollection<Food> _sideItems = new ObservableCollection<Food>();
        public ObservableCollection<Food> SideItems
        {
            get
            {
                return _sideItems;
            }
            set
            {
                _sideItems = value;
                NotifyPropertyChanged(nameof(SideItems));
            }
        }

        private ObservableCollection<Food> _drinkItems = new ObservableCollection<Food>();
        public ObservableCollection<Food> DrinkItems
        {
            get
            {
                return _drinkItems;
            }
            set
            {
                _drinkItems = value;
                NotifyPropertyChanged(nameof(DrinkItems));
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
