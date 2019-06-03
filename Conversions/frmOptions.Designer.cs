namespace Conversions
{
    partial class frmOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxShowToolbar = new System.Windows.Forms.CheckBox();
            this.cmbDefaultConversion = new System.Windows.Forms.ComboBox();
            this.lblDefaultConversion = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbxConversions = new System.Windows.Forms.ListBox();
            this.btnRestoreDefaults = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxShowToolbar);
            this.groupBox1.Controls.Add(this.cmbDefaultConversion);
            this.groupBox1.Controls.Add(this.lblDefaultConversion);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // cbxShowToolbar
            // 
            this.cbxShowToolbar.AutoSize = true;
            this.cbxShowToolbar.Location = new System.Drawing.Point(20, 69);
            this.cbxShowToolbar.Name = "cbxShowToolbar";
            this.cbxShowToolbar.Size = new System.Drawing.Size(92, 17);
            this.cbxShowToolbar.TabIndex = 2;
            this.cbxShowToolbar.Text = "Show Toolbar";
            this.cbxShowToolbar.UseVisualStyleBackColor = true;
            this.cbxShowToolbar.CheckedChanged += new System.EventHandler(this.cbxShowToolbar_CheckedChanged);
            // 
            // cmbDefaultConversion
            // 
            this.cmbDefaultConversion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDefaultConversion.FormattingEnabled = true;
            this.cmbDefaultConversion.Location = new System.Drawing.Point(155, 27);
            this.cmbDefaultConversion.MaxDropDownItems = 16;
            this.cmbDefaultConversion.Name = "cmbDefaultConversion";
            this.cmbDefaultConversion.Size = new System.Drawing.Size(159, 21);
            this.cmbDefaultConversion.TabIndex = 1;
            // 
            // lblDefaultConversion
            // 
            this.lblDefaultConversion.AutoSize = true;
            this.lblDefaultConversion.Location = new System.Drawing.Point(17, 30);
            this.lblDefaultConversion.Name = "lblDefaultConversion";
            this.lblDefaultConversion.Size = new System.Drawing.Size(100, 13);
            this.lblDefaultConversion.TabIndex = 0;
            this.lblDefaultConversion.Text = "Default Conversion:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.lbxConversions);
            this.groupBox2.Location = new System.Drawing.Point(12, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 181);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conversions";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(239, 147);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(155, 147);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbxConversions
            // 
            this.lbxConversions.FormattingEnabled = true;
            this.lbxConversions.Location = new System.Drawing.Point(20, 20);
            this.lbxConversions.Name = "lbxConversions";
            this.lbxConversions.Size = new System.Drawing.Size(294, 121);
            this.lbxConversions.TabIndex = 0;
            // 
            // btnRestoreDefaults
            // 
            this.btnRestoreDefaults.Location = new System.Drawing.Point(45, 315);
            this.btnRestoreDefaults.Name = "btnRestoreDefaults";
            this.btnRestoreDefaults.Size = new System.Drawing.Size(116, 23);
            this.btnRestoreDefaults.TabIndex = 2;
            this.btnRestoreDefaults.Text = "Restore Defaults";
            this.btnRestoreDefaults.UseVisualStyleBackColor = true;
            this.btnRestoreDefaults.Click += new System.EventHandler(this.btnRestoreDefaults_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(167, 315);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(251, 315);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 372);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnRestoreDefaults);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOptions";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbxShowToolbar;
        private System.Windows.Forms.ComboBox cmbDefaultConversion;
        private System.Windows.Forms.Label lblDefaultConversion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lbxConversions;
        private System.Windows.Forms.Button btnRestoreDefaults;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}