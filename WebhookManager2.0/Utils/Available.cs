using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebhookManager2._0.Utils
{
    class Available
    {
        public static void SetAvailable(SiticoneTextBox target)
        {
            Color color = Color.FromArgb(131, 8, 255);
            target.BorderColor = color;
            target.HoverState.BorderColor = color;
            target.FocusedState.BorderColor = color;
        }
    }
}
