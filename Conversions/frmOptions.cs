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
    public partial class frmOptions : Form
    {
        //Initiate null lists to be filled later
        private List<Conversions> conversions = null;
        private List<Conversions> tempChanges = null; //This is to store changes before commit
        private List<Options> options = null;

        private Options newOp = null;

        //Read files and load lists. Load defaults for Show Tool Bar
        public frmOptions()
        {
            InitializeComponent();
            conversions = ConversionsDB.GetConversions();
            options = OptionsDB.GetOptions();
            tempChanges = ConversionsDB.GetConversions();
            
            int count = options.Count;

            if (options[count - 1].ShowToolbar == "true")
            {
                cbxShowToolbar.Checked = true;
            }
            else
            {
                cbxShowToolbar.Checked = false;
            }
                            
        }

        private void FillListBox(List<Conversions> list)
        {
            lbxConversions.Items.Clear();
            foreach (Conversions item in list)
            {
                lbxConversions.Items.Add(item.GetDisplayText());
            }
        }

        //Fill combo box with all items from Conversions list. I pass a list so that I can update it with tempChange list if
        //the list is changed. This way items removed from the listbox will not appear here before hitting OK
        private void FillComboBox(List<Conversions> list)
        {
            cmbDefaultConversion.Items.Clear();
            string selectedText;
            int count = options.Count;

            selectedText = options[count - 1].DefaultConversion;


            foreach (Conversions row in list)
            {
                cmbDefaultConversion.DisplayMember = "Text";
                cmbDefaultConversion.ValueMember = "Value";
                cmbDefaultConversion.Items.Add(new { Text = row.Unit1 + " to " + row.Unit2, Value = row.Multiplier });
            }
            cmbDefaultConversion.SelectedIndex = cmbDefaultConversion.FindStringExact(selectedText);
        }

        //Loading the lists again is redundant, but it was working and I did not want to risk anything
        private void frmOptions_Load(object sender, EventArgs e)
        {
            conversions = ConversionsDB.GetConversions();
            options = OptionsDB.GetOptions();
            FillListBox(conversions);
            FillComboBox(conversions);
        }

        private void cbxShowToolbar_CheckedChanged(object sender, EventArgs e)
        {
        }

        //Remove an item from the List Box and update the Combo Box. Remove same item from tempChanges list.
        private void btnRemove_Click(object sender, EventArgs e)
        {
            int i = lbxConversions.SelectedIndex;
            if (i != -1)
            {
                Conversions item = (Conversions)tempChanges[i];
                tempChanges.Remove(item);
            }
            lbxConversions.Items.Remove(lbxConversions.SelectedItem);
            FillComboBox(tempChanges);
        }

        //Restore the List Box to the default conversions list, update Combo Box, and update tempChanges list. 
        private void btnRestoreDefaults_Click(object sender, EventArgs e)
        {
            tempChanges.Clear();
            tempChanges = ConversionsDB.GetDefaultConversions();
            FillListBox(tempChanges);
            FillComboBox(tempChanges);
        }

        //Open Add Conversions form. Save object from input in form and add object to List Box. 
        //Save item to tempChanges list and update Combo Box.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddConversion newAddForm = new frmAddConversion();
            newAddForm.StartPosition = FormStartPosition.CenterParent;
            Conversions newConv = newAddForm.GetNewConversions();

            if (newConv != null)
            {
                lbxConversions.Items.Add(newConv.GetDisplayText());
                tempChanges.Add(newConv);
                FillComboBox(tempChanges);
            }
        }

        //Confirm changes. If yes, save tempChanges into main conversions list and save into conversions.txt
        //Create options object for use in parent form. Close this form
        private void btnOK_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to commit all changes?";
            DialogResult button =
                MessageBox.Show(message, "Confirm Changes",
                MessageBoxButtons.YesNo);
            if (button == DialogResult.Yes)
            {
                conversions = tempChanges;
                ConversionsDB.SaveConversions(conversions);

                newOp = new Options(cbxShowToolbar.Checked.ToString(), 
                    cmbDefaultConversion.GetItemText(cmbDefaultConversion.SelectedItem));


                this.Close();
            }
        }

        //Close this form. Changes in options will be undone.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Options GetNewOptions()
        {
            this.ShowDialog();
            return newOp;
        }
    }
}
