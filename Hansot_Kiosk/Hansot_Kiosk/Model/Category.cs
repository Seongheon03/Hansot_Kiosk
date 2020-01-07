using Hansot_Kiosk.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hansot_Kiosk.Model
{
    public enum ECategory
    {
        BEST,
        DOSILAK,
        CUBBAB,
        SIDEDISH,
        SIDE,
        DRINK
    };

    public class Category : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ECategory ECategory;

        #region Property
        private string _categoryName;
        public string CategoryName
        {
            get
            {
                return _categoryName;
            }
            set
            {
                _categoryName = value;
                NotifyPropertyChanged(nameof(CategoryName));
            }
        }

        private string _categoryImageUrl;
        public string CategoryImageUrl
        {
            get
            {
                return _categoryImageUrl;
            }
            set
            {
                _categoryImageUrl = value;
                NotifyPropertyChanged(nameof(CategoryImageUrl));
            }
        }
        #endregion
        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
