using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFrm.Framework.Common
{
    public class ValidateUtil
    {
        public static bool Validate(Control control)
        {
            if(control is TextBoxBase)
            {
                var textbox = control as TextBoxBase;
                if (!string.IsNullOrEmpty(textbox.Text))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }

    public enum ValidateType
    {
        Required
    }
}
