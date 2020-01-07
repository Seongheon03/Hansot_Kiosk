using Hansot_Kiosk.Common;
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
    public class FoodViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        #region Property

        private ObservableCollection<Category> _categories = new ObservableCollection<Category>();
        public ObservableCollection<Category> Categories
        {
            get
            {
                return _categories;
            }
            set
            {
                _categories = value;
                NotifyPropertyChanged(nameof(Categories));
            }
        }

        private ObservableCollection<Food> _foods = new ObservableCollection<Food>();
        public ObservableCollection<Food> Foods
        {
            get
            {
                return _foods;
            }
            set
            {
                _foods = value;
                NotifyPropertyChanged(nameof(Foods));
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

        #endregion

        public void LoadData()
        {
            Categories.Add(new Category() { CategoryName = "인기", CategoryImageUrl = ComDef.ImageRootPath + "인기.png", ECategory = ECategory.BEST});
            Categories.Add(new Category() { CategoryName = "도시락", CategoryImageUrl = ComDef.ImageRootPath + "도시락.png", ECategory = ECategory.DOSILAK});
            Categories.Add(new Category() { CategoryName = "컵밥", CategoryImageUrl = ComDef.ImageRootPath + "컵밥.png", ECategory = ECategory.CUBBAB });
            Categories.Add(new Category() { CategoryName = "반찬", CategoryImageUrl = ComDef.ImageRootPath + "반찬.png", ECategory = ECategory.SIDEDISH }) ;
            Categories.Add(new Category() { CategoryName = "사이드", CategoryImageUrl = ComDef.ImageRootPath + "사이드.png", ECategory = ECategory.SIDE });
            Categories.Add(new Category() { CategoryName = "음료", CategoryImageUrl = ComDef.ImageRootPath + "음료.png", ECategory = ECategory.DRINK });
            Foods.Add(new Food() { Name = "메가고기고기", ImageUrl = ComDef.ImageRootPath + "메가고기고기.png", Price = 7900, ECategory = ECategory.BEST});
            Foods.Add(new Food() { Name = "국화", ImageUrl = ComDef.ImageRootPath + "국화.png", Price = 4000, ECategory = ECategory.BEST });
            Foods.Add(new Food() { Name = "동백", ImageUrl = ComDef.ImageRootPath + "동백.png", Price = 5000, ECategory = ECategory.BEST });
            Foods.Add(new Food() { Name = "메가치킨제육", ImageUrl = ComDef.ImageRootPath + "메가치킨제육.png", Price = 6900, ECategory = ECategory.BEST });
            Foods.Add(new Food() { Name = "치킨마요", ImageUrl = ComDef.ImageRootPath + "치킨마요.png", Price = 2900, ECategory = ECategory.BEST });
            Foods.Add(new Food() { Name = "치킨 샐러드마요", ImageUrl = ComDef.ImageRootPath + "치킨 샐러드마요.png", Price = 3400, ECategory = ECategory.BEST });
            Foods.Add(new Food() { Name = "참치마요", ImageUrl = ComDef.ImageRootPath + "참치마요.png", Price = 2900, ECategory = ECategory.BEST });
            Foods.Add(new Food() { Name = "한솥 철판볶음밥", ImageUrl = ComDef.ImageRootPath + "한솥 철판볶음밥.png", Price = 3700, ECategory = ECategory.BEST });
            Foods.Add(new Food() { Name = "메가고기고기", ImageUrl = ComDef.ImageRootPath + "메가고기고기.png", Price = 7900, ECategory = ECategory.DOSILAK });
            Foods.Add(new Food() { Name = "국화", ImageUrl = ComDef.ImageRootPath + "국화.png", Price = 4000, ECategory = ECategory.DOSILAK });
            Foods.Add(new Food() { Name = "동백", ImageUrl = ComDef.ImageRootPath + "동백.png", Price = 5000, ECategory = ECategory.DOSILAK });
            Foods.Add(new Food() { Name = "메가치킨제육", ImageUrl = ComDef.ImageRootPath + "메가치킨제육.png", Price = 6900, ECategory = ECategory.DOSILAK });
            Foods.Add(new Food() { Name = "생선까스도련님", ImageUrl = ComDef.ImageRootPath + "생선까스도련님.png", Price = 5500, ECategory = ECategory.DOSILAK });
            Foods.Add(new Food() { Name = "돈까스도련님고기고기", ImageUrl = ComDef.ImageRootPath + "돈까스도련님고기고기.png", Price = 5500, ECategory = ECategory.DOSILAK });
            Foods.Add(new Food() { Name = "탕수육도련님고기고기", ImageUrl = ComDef.ImageRootPath + "탕수육도련님고기고기.png", Price = 5600, ECategory = ECategory.DOSILAK });
            Foods.Add(new Food() { Name = "새치고기고기", ImageUrl = ComDef.ImageRootPath + "새치고기고기.png", Price = 6000, ECategory = ECategory.DOSILAK });
            Foods.Add(new Food() { Name = "메가치킨제육", ImageUrl = ComDef.ImageRootPath + "메가치킨제육.png", Price = 6900, ECategory = ECategory.DOSILAK });
            Foods.Add(new Food() { Name = "칠리 찹쌀탕수육도련님", ImageUrl = ComDef.ImageRootPath + "칠리 찹쌀탕수육도련님.png", Price = 3900, ECategory = ECategory.DOSILAK });
            Foods.Add(new Food() { Name = "오리지널 찹쌀탕수육", ImageUrl = ComDef.ImageRootPath + "오리지널 찹쌀탕수육.png", Price = 3700, ECategory = ECategory.DOSILAK });
            Foods.Add(new Food() { Name = "메가치킨마요", ImageUrl = ComDef.ImageRootPath + "메가치킨마요.png", Price = 5200, ECategory = ECategory.CUBBAB });
            Foods.Add(new Food() { Name = "갈비치킨마요", ImageUrl = ComDef.ImageRootPath + "갈비치킨마요.png", Price = 3200, ECategory = ECategory.CUBBAB });
            Foods.Add(new Food() { Name = "왕치킨마요", ImageUrl = ComDef.ImageRootPath + "왕치킨마요.png", Price = 4200, ECategory = ECategory.CUBBAB });
            Foods.Add(new Food() { Name = "치킨마요", ImageUrl = ComDef.ImageRootPath + "치킨마요.png", Price = 2900, ECategory = ECategory.CUBBAB });
            Foods.Add(new Food() { Name = "치킨 샐러드마요", ImageUrl = ComDef.ImageRootPath + "치킨 샐러드마요.png", Price = 3400, ECategory = ECategory.CUBBAB });
            Foods.Add(new Food() { Name = "돈치마요", ImageUrl = ComDef.ImageRootPath + "돈치마요.png", Price = 3500, ECategory = ECategory.CUBBAB });
            Foods.Add(new Food() { Name = "참치마요", ImageUrl = ComDef.ImageRootPath + "참치마요.png", Price = 2900, ECategory = ECategory.CUBBAB });
            Foods.Add(new Food() { Name = "왕카레돈까스 덮밥", ImageUrl = ComDef.ImageRootPath + "왕카레돈까스 덮밥.png", Price = 5500, ECategory = ECategory.CUBBAB });
            Foods.Add(new Food() { Name = "새우돈까스덮밥", ImageUrl = ComDef.ImageRootPath + "새우돈까스덮밥.png", Price = 3900, ECategory = ECategory.CUBBAB });
            Foods.Add(new Food() { Name = "돈까스 덮밥", ImageUrl = ComDef.ImageRootPath + "돈까스 덮밥.png", Price = 3900, ECategory = ECategory.CUBBAB });
            Foods.Add(new Food() { Name = "돈까스 카레", ImageUrl = ComDef.ImageRootPath + "돈까스 카레.png", Price = 3900, ECategory = ECategory.CUBBAB });
            Foods.Add(new Food() { Name = "불닭비빔밥", ImageUrl = ComDef.ImageRootPath + "불닭비빔밥.png", Price = 4500, ECategory = ECategory.CUBBAB });
            Foods.Add(new Food() { Name = "치즈불닭비빔밥", ImageUrl = ComDef.ImageRootPath + "치즈불닭비빔밥.png", Price = 5700, ECategory = ECategory.CUBBAB });
            Foods.Add(new Food() { Name = "폴리 도시락", ImageUrl = ComDef.ImageRootPath + "폴리 도시락.png", Price = 3800, ECategory = ECategory.CUBBAB });
            Foods.Add(new Food() { Name = "계란말이", ImageUrl = ComDef.ImageRootPath + "계란말이.png", Price = 2200, ECategory = ECategory.SIDEDISH });
            Foods.Add(new Food() { Name = "치즈계란말이", ImageUrl = ComDef.ImageRootPath + "치즈계란말이.png", Price = 2800, ECategory = ECategory.SIDEDISH });
            Foods.Add(new Food() { Name = "카레", ImageUrl = ComDef.ImageRootPath + "카레.png", Price = 2400, ECategory = ECategory.SIDEDISH });
            Foods.Add(new Food() { Name = "소불고기", ImageUrl = ComDef.ImageRootPath + "소불고기.png", Price = 3900, ECategory = ECategory.SIDEDISH });
            Foods.Add(new Food() { Name = "탕수 닭강정", ImageUrl = ComDef.ImageRootPath + "탕수 닭강정.png", Price = 3000, ECategory = ECategory.SIDE });
            Foods.Add(new Food() { Name = "갈비 닭강정", ImageUrl = ComDef.ImageRootPath + "갈비 닭강정.png", Price = 3000, ECategory = ECategory.SIDE });
            Foods.Add(new Food() { Name = "오리지널 닭강정", ImageUrl = ComDef.ImageRootPath + "오리지널 닭강정.png", Price = 2800, ECategory = ECategory.SIDE });
            Foods.Add(new Food() { Name = "닭강정 트리플 콤보", ImageUrl = ComDef.ImageRootPath + "닭강정 트리플 콤보.png", Price = 8000, ECategory = ECategory.SIDE });
            Foods.Add(new Food() { Name = "치킨 BOX", ImageUrl = ComDef.ImageRootPath + "치킨 BOX.png", Price = 10000, ECategory = ECategory.SIDE });
            Foods.Add(new Food() { Name = "코카콜라", ImageUrl = ComDef.ImageRootPath + "코카콜라.jpg", Price = 1500, ECategory = ECategory.DRINK });
            Foods.Add(new Food() { Name = "웰치스", ImageUrl = ComDef.ImageRootPath + "웰치스.jpg", Price = 1300, ECategory = ECategory.DRINK });
            Foods.Add(new Food() { Name = "환타", ImageUrl = ComDef.ImageRootPath + "환타.jpg", Price = 1300, ECategory = ECategory.DRINK });
            Foods.Add(new Food() { Name = "생수", ImageUrl = ComDef.ImageRootPath + "생수.jpg", Price = 500, ECategory = ECategory.DRINK });
        }
        

        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
