using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iconeBox_manager
{
    public class GlobalMouseHandler : IMessageFilter
    {

        private const int WM_LBUTTONDOWN = 0x201;
        private const int WM_LBUTTONUP = 0x202;
        BoxManager boxManager;

        public GlobalMouseHandler(BoxManager b)
        {
            boxManager = b;
        }

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_LBUTTONUP)
            {
                boxManager.isApercuClickDown = false;
                boxManager.updateApercu();
            }
            return false;
        }
    }
}
