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
    public partial class frmConversion : Form
    {
        List<Conversions> conversions = null;
        List<Options> options = null;

        public frmConversion()
        {
            options = OptionsDB.GetOptions();
            conversions = ConversionsDB.GetConversions();
            int count = options.Count;
            string selectedText = options[count - 1].DefaultConversion;

            InitializeComponent();

            foreach (Conversions row in conversions)
            {
                cmbConversion.DisplayMember = "Text";
                cmbConversion.ValueMember = "Value";
                cmbConversion.Items.Add(new { Text = row.Unit1 + " to " + row.Unit2, Value = row.Multiplier } );

            }
            cmbConversion.SelectedIndex = cmbConversion.FindStringExact(selectedText);
        }

        // Validation method
        private bool IsValidData()
        {
            return Validator.IsPresent(txtUnit1) &&
                   Validator.IsDouble(txtUnit1);
        }

        private void frmConversion_Load(object sender, EventArgs e)
        {
        }
        //Dynamic worked great for me, but I read that it requires .NET 4.5 or higher. If this is a problem, I can go another route
        private void cmbConversion_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Conversions row in conversions)
            {
                if(row.Multiplier == (cmbConversion.SelectedItem as dynamic).Value)
                {
                    lblUnit1.Text = row.Unit1 + ":";
                    lblUnit2.Text = row.Unit2 + ":";
                    txtUnit1.Tag = row.Unit1;
                    txtUnit1.Text = "";
                    txtUnit2.Text = "";
                }
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                double multiplier = Convert.ToDouble(txtUnit1.Text) * (cmbConversion.SelectedItem as dynamic).Value;
                txtUnit2.Text = multiplier.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
