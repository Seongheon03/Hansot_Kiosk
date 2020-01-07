using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Hansot_Kiosk.Common
{
    public class ComUtils
    {
        public static BitmapImage GetImage(string url)
        {
            return new BitmapImage(new Uri(url, UriKind.Relative));
        }
    }
}
