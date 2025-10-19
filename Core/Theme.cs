using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock.Core
{
    public class Theme
    {
        public Color primaryColor;
        public Color secondaryColor;

        public Theme(Color primary_color, Color secondary_color)
        {
            primaryColor = primary_color;
            secondaryColor = secondary_color;
        }
    }
}
