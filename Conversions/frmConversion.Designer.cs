namespace Conversions
{
    partial class frmConversion
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
            this.lblConversion = new System.Windows.Forms.Label();
            this.lblUnit1 = new System.Windows.Forms.Label();
            this.lblUnit2 = new System.Windows.Forms.Label();
            this.txtUnit1 = new System.Windows.Forms.TextBox();
            this.txtUnit2 = new System.Windows.Forms.TextBox();
            this.cmbConversion = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConversion
            // 
            this.lblConversion.AutoSize = true;
            this.lblConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversion.Location = new System.Drawing.Point(12, 24);
            this.lblConversion.Name = "lblConversion";
            this.lblConversion.Size = new System.Drawing.Size(63, 13);
            this.lblConversion.TabIndex = 0;
            this.lblConversion.Text = "Conversion:";
            // 
            // lblUnit1
            // 
            this.lblUnit1.AutoSize = true;
            this.lblUnit1.Location = new System.Drawing.Point(27, 62);
            this.lblUnit1.Name = "lblUnit1";
            this.lblUnit1.Size = new System.Drawing.Size(35, 13);
            this.lblUnit1.TabIndex = 1;
            this.lblUnit1.Text = "Unit1:";
            // 
            // lblUnit2
            // 
            this.lblUnit2.AutoSize = true;
            this.lblUnit2.Location = new System.Drawing.Point(27, 100);
            this.lblUnit2.Name = "lblUnit2";
            this.lblUnit2.Size = new System.Drawing.Size(35, 13);
            this.lblUnit2.TabIndex = 2;
            this.lblUnit2.Text = "Unit2:";
            // 
            // txtUnit1
            // 
            this.txtUnit1.Location = new System.Drawing.Point(98, 59);
            this.txtUnit1.Name = "txtUnit1";
            this.txtUnit1.Size = new System.Drawing.Size(100, 20);
            this.txtUnit1.TabIndex = 3;
            // 
            // txtUnit2
            // 
            this.txtUnit2.Location = new System.Drawing.Point(98, 97);
            this.txtUnit2.Name = "txtUnit2";
            this.txtUnit2.ReadOnly = true;
            this.txtUnit2.Size = new System.Drawing.Size(100, 20);
            this.txtUnit2.TabIndex = 4;
            // 
            // cmbConversion
            // 
            this.cmbConversion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConversion.FormattingEnabled = true;
            this.cmbConversion.Location = new System.Drawing.Point(98, 21);
            this.cmbConversion.Name = "cmbConversion";
            this.cmbConversion.Size = new System.Drawing.Size(147, 21);
            this.cmbConversion.TabIndex = 5;
            this.cmbConversion.SelectedIndexChanged += new System.EventHandler(this.cmbConversion_SelectedIndexChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(15, 135);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(94, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(149, 135);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 176);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cmbConversion);
            this.Controls.Add(this.txtUnit2);
            this.Controls.Add(this.txtUnit1);
            this.Controls.Add(this.lblUnit2);
            this.Controls.Add(this.lblUnit1);
            this.Controls.Add(this.lblConversion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmConversion";
            this.Text = "Conversion";
            this.Load += new System.EventHandler(this.frmConversion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConversion;
        private System.Windows.Forms.Label lblUnit1;
        private System.Windows.Forms.Label lblUnit2;
        private System.Windows.Forms.TextBox txtUnit1;
        private System.Windows.Forms.TextBox txtUnit2;
        private System.Windows.Forms.ComboBox cmbConversion;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClose;
    }
}