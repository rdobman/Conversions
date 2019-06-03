using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
    public class Options
    {
        //I did this entire project with showToolBar as a boolean value, but it ended up giving me errors, so I adjusted
        private string showToolbar;
        private string defaultConversion;

        public Options() { }

        public Options(string showToolbar, string defaultConversion)
        {
            this.showToolbar = showToolbar;
            this.defaultConversion = defaultConversion;
        }

        public string ShowToolbar
        {
            get
            {
                return showToolbar;
            }
            set
            {
                showToolbar = value;
            }
        }

        public string DefaultConversion
        {
            get
            {
                return defaultConversion;
            }
            set
            {
                defaultConversion = value;
            }
        }
    }
}
