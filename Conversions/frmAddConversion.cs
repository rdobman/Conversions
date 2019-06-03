using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversions
{
    public partial class frmAddConversion : Form
    {
        public frmAddConversion()
        {
            InitializeComponent();

        }

        public Conversions newCon = null;

        public Conversions GetNewConversions()
        {
            this.ShowDialog();
            return newCon;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                newCon = new Conversions(txtFrom.Text, txtTo.Text, Convert.ToDouble(txtMultiple.Text));

                this.Close();
            }
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtFrom) &&
                   Validator.IsPresent(txtTo) &&
                   Validator.IsPresent(txtMultiple) &&
                   Validator.IsDouble(txtMultiple);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
