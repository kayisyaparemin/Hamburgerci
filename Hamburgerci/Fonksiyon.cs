using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburgerci
{
    public static class Fonksiyon
    {
        public static void Temizle(Control.ControlCollection collection)
        {
            foreach (Control item in collection)
            {
                if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedItem = 0;
                }
                else if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                else if (item is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)item;
                    if (radioButton.Name == "rbKucuk")
                    {
                        radioButton.Checked = true;
                    }
                    else
                    {
                        radioButton.Checked = false;
                    }
                }
                else if (item is NumericUpDown)
                {
                    ((NumericUpDown)item).Value = ((NumericUpDown)item).Minimum;
                }
                else if (item is CheckBox)
                {
                    ((CheckBox)item).Checked = false;
                }
                else if (item is GroupBox)
                {
                    Temizle(((GroupBox)item).Controls); 
                }
                else if (item is FlowLayoutPanel)
                {
                    Temizle(((FlowLayoutPanel)item).Controls);
                }
            }
        }
    }
}
