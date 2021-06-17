using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210611carFixMgr.common
{
    class CommUtil
    {
        public static void initTheme(Form form)
        {
            //var 아무 타입 다 받을 수 있다. 
            var mgr = MaterialSkinManager.Instance;
            mgr.AddFormToManage(form as MaterialForm);
            mgr.Theme = MaterialSkinManager.Themes.LIGHT;
            mgr.ColorScheme = new ColorScheme(Primary.Indigo700, Primary.Indigo700, Primary.Indigo700, Accent.Indigo700,TextShade.WHITE);
        }
    }
}
