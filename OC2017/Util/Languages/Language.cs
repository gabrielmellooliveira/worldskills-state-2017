using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OC2017.Util.Languages
{
    class Language
    {
        private static void AlteraThreadIdioma(string culture)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(culture, true);

            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture, true);
        }

        private static void AlteraCultura(Form frm, System.ComponentModel.ComponentResourceManager resx)
        {
            foreach (Control ctrl in frm.Controls)
            {
                resx.ApplyResources(ctrl, ctrl.Name, System.Threading.Thread.CurrentThread.CurrentCulture);
            }

        }

        public static void AjustaCultura(Form frm, string culture)
        {
            AlteraThreadIdioma(culture);

            System.ComponentModel.ComponentResourceManager resx = new System.ComponentModel.ComponentResourceManager(frm.GetType());

            AlteraCultura(frm, resx);
        }
    }
}
