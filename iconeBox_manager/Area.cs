using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iconeBox_manager
{
    
    class Area
    {
        public Box box;
        public Rectangle area;

        public Area(Box b, Rectangle r)
        {
            box = b;
            area = r;
        }
    }
}
