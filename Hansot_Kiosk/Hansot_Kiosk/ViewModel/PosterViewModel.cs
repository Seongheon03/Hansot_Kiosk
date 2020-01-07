using Hansot_Kiosk.Common;
using Hansot_Kiosk.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Hansot_Kiosk.ViewModel
{
    class PosterViewModel
    {
        public List<Poster> PosterList = new List<Poster>();
        public void LoadData()
        {
            PosterList.Add(new Poster() { ImageUrl = ComDef.ImageRootPath + "한솥이벤트1.png" , BtnStyle = App.Current.Resources["ButtonIndex0"] as Style});
            PosterList.Add(new Poster() { ImageUrl = ComDef.ImageRootPath + "한솥이벤트2.jpg" , BtnStyle = App.Current.Resources["ButtonIndex1"] as Style });
            PosterList.Add(new Poster() { ImageUrl = ComDef.ImageRootPath + "한솥이벤트3.jpg" , BtnStyle = App.Current.Resources["ButtonIndex2"] as Style });
            PosterList.Add(new Poster() { ImageUrl = ComDef.ImageRootPath + "한솥이벤트4.jpg" , BtnStyle = App.Current.Resources["ButtonIndex3"] as Style });
        }
    }
}
