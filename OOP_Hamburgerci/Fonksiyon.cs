using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Hamburgerci
{
    public class Fonksiyon
    {

        public static void Temizle(Control.ControlCollection koleksiyon)
        {
            foreach (Control item in koleksiyon)
            {

                if (item is ComboBox)
                    ((ComboBox)item).SelectedIndex = -1;

                else if (item is RadioButton)
                    ((RadioButton)item).Checked = false;

                else if (item is CheckBox)
                    ((CheckBox)item).Checked = false;
                else if (item is NumericUpDown)
                    ((NumericUpDown)item).Value = 1;
                else if (item is TextBox)
                    ((TextBox)item).Clear();


                else if (item is GroupBox)
                    Temizle(((GroupBox)item).Controls);
                else if (item is Panel)
                    Temizle(((Panel)item).Controls);
            }

        }
    }
}
