using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversions
{
    public static class Validator
    {
        private static string title = "Entry Error";

        public static string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public static bool IsPresent(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(textBox.Tag + ": This is a required field.", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsDouble(TextBox textBox)
        {
            double number = 0.0;
            if (Double.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + ": You must enter a number", Title);
                textBox.Focus();
                return false;
            }
        }
    }
}
