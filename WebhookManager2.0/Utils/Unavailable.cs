using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebhookManager2._0.Utils
{
    class Unavailable
    {
        public static void SetUnavailable(SiticoneTextBox target)
        {
            target.BorderColor = Color.Gray;
            target.HoverState.BorderColor = Color.Gray;
            target.FocusedState.BorderColor = Color.Gray;
        }
    }
}
