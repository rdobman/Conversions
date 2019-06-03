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
    public partial class frmStartUp : Form
    {
        public frmStartUp()
        {
            InitializeComponent();
        }

        public List<Conversions> conversions = null;
        public List<Options> options = null;

        int childFormNum = 1; //Keep up with how many child forms there have been. Added to title box of each child

        private void msbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        //Load application, read files, and fill lists. Open a child form
        private void frmStartUp_Load(object sender, EventArgs e)
        {
            conversions = ConversionsDB.GetConversions();
            ConversionsDB.SaveConversions(conversions);

            options = OptionsDB.GetOptions();

            int count = options.Count;

            if (options[count - 1].ShowToolbar == "true")
            {
                toolStrip1.Visible = true;
            }
            else
            {
                toolStrip1.Visible = false;
            }

            frmConversion newConversionForm = new frmConversion();
            newConversionForm.MdiParent = this;
            newConversionForm.Text = "Conversion " + childFormNum;
            newConversionForm.Show();
            childFormNum++;
        }

        //Open new conversion child form.
        private void msbNewConversion_Click(object sender, EventArgs e)
        {

            frmConversion newConversionForm = new frmConversion();
            newConversionForm.MdiParent = this;
            newConversionForm.Text = "Conversion " + childFormNum;
            newConversionForm.Show();
            childFormNum++;
        }

        //Close active child form
        private void msbClose_Click(object sender, EventArgs e)
        {
            Form activeForm = this.ActiveMdiChild;
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        //These organize child forms in the parent window
        private void msbCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void msbVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void msbHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        //Open options form and grabs the options object to write to file. Also changes toolStrip1 visibility if changed
        private void msbOptions_Click(object sender, EventArgs e)
        {
            frmOptions optionsForm = new frmOptions();
            optionsForm.StartPosition = FormStartPosition.CenterParent;
            Options newOp = optionsForm.GetNewOptions();

            if (newOp != null)
            {
                if (newOp.ShowToolbar == "True")
                {
                    this.toolStrip1.Visible = true;
                }
                else
                {
                    this.toolStrip1.Visible = false;
                }
                options.Add(newOp);
                OptionsDB.SaveOptions(options);
            }
            
        }
    }
}
