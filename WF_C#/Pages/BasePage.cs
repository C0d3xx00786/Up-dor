using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_C_.Pages
{
    public abstract class BasePage : UserControl
    {
        public abstract string PageTitle { get; }
        public abstract void LoadData();
        public abstract void RefreshData();

    }
}
