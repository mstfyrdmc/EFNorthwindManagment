using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFNorthwindManagement.Models
{
    public static class FxFunction
    {
        public static void Temizle(Control.ControlCollection koleksiyon)
        {
            foreach (Control item in koleksiyon)
            {
                if (item is TextBox)
                    ((TextBox)item).Text = string.Empty;
                else if (item is NumericUpDown)
                    ((NumericUpDown)item).Value = 0;
                else if (item is ComboBox)
                    ((ComboBox)item).SelectedIndex = 0;
            }
        }
    }
}
