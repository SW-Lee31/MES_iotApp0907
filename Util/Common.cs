using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iotApp0907.Util
{
    class Common
    {
        public static void InitTheme(MaterialForm form)
        {
            var skin = MaterialSkinManager.Instance;
            skin.AddFormToManage(form);
            skin.Theme = MaterialSkinManager.Themes.DARK;
            skin.ColorScheme = new ColorScheme(
                Primary.Grey600,
                Primary.Grey600,
                Primary.Grey600,
                Accent.Teal700,
                TextShade.BLACK);
        }
    }
}
