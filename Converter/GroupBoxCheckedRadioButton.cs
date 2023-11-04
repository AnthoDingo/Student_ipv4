using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPv4.Converter
{
    internal static class GroupBoxCheckedRadioButton
    {
        internal static RadioButton? GetChecked(GroupBox group)
        {
            return group.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
        }
    }
}
