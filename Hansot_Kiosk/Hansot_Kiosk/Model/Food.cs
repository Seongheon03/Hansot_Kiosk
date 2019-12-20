using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hansot_Kiosk.Model
{
    public class Food : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                NotifyPropertyChanged(nameof(Name));
            }
        }

        private string _imageUrl;
        public string ImageUrl
        {
            get
            {
                return _imageUrl;
            }
            set
            {
                _imageUrl = value;
                NotifyPropertyChanged(nameof(ImageUrl));
            }
        }

        private int _count = 0;
        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
                NotifyPropertyChanged(nameof(Count));
            }
        }
        private int _price;

        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
                NotifyPropertyChanged(nameof(Price));
            }
        }

        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
