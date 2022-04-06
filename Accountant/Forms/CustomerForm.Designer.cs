namespace Accountant.Forms
{
    partial class CustomerForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbCity = new System.Windows.Forms.Label();
            this.lbPostelCode = new System.Windows.Forms.Label();
            this.lbHouseNumber = new System.Windows.Forms.Label();
            this.lbStreet = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbCompany = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.txtHouseNumber = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnSafe = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbTitel = new System.Windows.Forms.Label();
            this.rdB2C = new System.Windows.Forms.RadioButton();
            this.rdB2B = new System.Windows.Forms.RadioButton();
            this.grpBusinessRelation = new System.Windows.Forms.GroupBox();
            this.grpBusinessRelation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(214, 174);
            this.lbCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(34, 15);
            this.lbCity.TabIndex = 24;
            this.lbCity.Text = "Stadt";
            // 
            // lbPostelCode
            // 
            this.lbPostelCode.AutoSize = true;
            this.lbPostelCode.Location = new System.Drawing.Point(11, 174);
            this.lbPostelCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPostelCode.Name = "lbPostelCode";
            this.lbPostelCode.Size = new System.Drawing.Size(27, 15);
            this.lbPostelCode.TabIndex = 25;
            this.lbPostelCode.Text = "PLZ";
            // 
            // lbHouseNumber
            // 
            this.lbHouseNumber.AutoSize = true;
            this.lbHouseNumber.Location = new System.Drawing.Point(214, 141);
            this.lbHouseNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHouseNumber.Name = "lbHouseNumber";
            this.lbHouseNumber.Size = new System.Drawing.Size(80, 15);
            this.lbHouseNumber.TabIndex = 26;
            this.lbHouseNumber.Text = "Hausnummer";
            // 
            // lbStreet
            // 
            this.lbStreet.AutoSize = true;
            this.lbStreet.Location = new System.Drawing.Point(11, 143);
            this.lbStreet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStreet.Name = "lbStreet";
            this.lbStreet.Size = new System.Drawing.Size(40, 15);
            this.lbStreet.TabIndex = 27;
            this.lbStreet.Text = "Straße";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(214, 111);
            this.lbLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(65, 15);
            this.lbLastName.TabIndex = 28;
            this.lbLastName.Text = "Nachname";
            // 
            // lbCompany
            // 
            this.lbCompany.AutoSize = true;
            this.lbCompany.Location = new System.Drawing.Point(10, 69);
            this.lbCompany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCompany.Name = "lbCompany";
            this.lbCompany.Size = new System.Drawing.Size(37, 15);
            this.lbCompany.TabIndex = 29;
            this.lbCompany.Text = "Firma";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(11, 111);
            this.lbFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(54, 15);
            this.lbFirstName.TabIndex = 30;
            this.lbFirstName.Text = "Vorname";
            // 
            // txtHouseNumber
            // 
            this.txtHouseNumber.Location = new System.Drawing.Point(311, 143);
            this.txtHouseNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtHouseNumber.Name = "txtHouseNumber";
            this.txtHouseNumber.Size = new System.Drawing.Size(106, 23);
            this.txtHouseNumber.TabIndex = 5;
            this.txtHouseNumber.Enter += new System.EventHandler(this.txtHouseNumber_Enter);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(311, 111);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(106, 23);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.Enter += new System.EventHandler(this.txtLastName_Enter);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(311, 171);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(106, 23);
            this.txtCity.TabIndex = 7;
            this.txtCity.Enter += new System.EventHandler(this.txtCity_Enter);
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(90, 171);
            this.txtPostalCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(106, 23);
            this.txtPostalCode.TabIndex = 6;
            this.txtPostalCode.Enter += new System.EventHandler(this.txtPostalCode_Enter);
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(90, 141);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(2);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(106, 23);
            this.txtStreet.TabIndex = 4;
            this.txtStreet.Enter += new System.EventHandler(this.txtStreet_Enter);
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(90, 66);
            this.txtCompany.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(106, 23);
            this.txtCompany.TabIndex = 1;
            this.txtCompany.Enter += new System.EventHandler(this.txtCompany_Enter);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(90, 111);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(106, 23);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.Enter += new System.EventHandler(this.txtFirstName_Enter);
            // 
            // btnSafe
            // 
            this.btnSafe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSafe.Location = new System.Drawing.Point(337, 216);
            this.btnSafe.Margin = new System.Windows.Forms.Padding(2);
            this.btnSafe.Name = "btnSafe";
            this.btnSafe.Size = new System.Drawing.Size(79, 25);
            this.btnSafe.TabIndex = 8;
            this.btnSafe.Text = "Speichern";
            this.btnSafe.UseVisualStyleBackColor = true;
            this.btnSafe.Click += new System.EventHandler(this.btnSafe_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(10, 216);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 25);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbTitel
            // 
            this.lbTitel.AutoSize = true;
            this.lbTitel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitel.Location = new System.Drawing.Point(11, 15);
            this.lbTitel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitel.Name = "lbTitel";
            this.lbTitel.Size = new System.Drawing.Size(210, 18);
            this.lbTitel.TabIndex = 29;
            this.lbTitel.Text = "Lege einen neuen Kunden an";
            // 
            // rdB2C
            // 
            this.rdB2C.AutoSize = true;
            this.rdB2C.Checked = true;
            this.rdB2C.Location = new System.Drawing.Point(122, 21);
            this.rdB2C.Name = "rdB2C";
            this.rdB2C.Size = new System.Drawing.Size(78, 19);
            this.rdB2C.TabIndex = 32;
            this.rdB2C.TabStop = true;
            this.rdB2C.Text = "Endkunde";
            this.rdB2C.UseVisualStyleBackColor = true;
            // 
            // rdB2B
            // 
            this.rdB2B.AutoSize = true;
            this.rdB2B.Location = new System.Drawing.Point(6, 21);
            this.rdB2B.Name = "rdB2B";
            this.rdB2B.Size = new System.Drawing.Size(108, 19);
            this.rdB2B.TabIndex = 31;
            this.rdB2B.Text = "Zwischenkunde";
            this.rdB2B.UseVisualStyleBackColor = true;
            // 
            // grpBusinessRelation
            // 
            this.grpBusinessRelation.Controls.Add(this.rdB2C);
            this.grpBusinessRelation.Controls.Add(this.rdB2B);
            this.grpBusinessRelation.Location = new System.Drawing.Point(216, 49);
            this.grpBusinessRelation.Name = "grpBusinessRelation";
            this.grpBusinessRelation.Size = new System.Drawing.Size(201, 46);
            this.grpBusinessRelation.TabIndex = 33;
            this.grpBusinessRelation.TabStop = false;
            this.grpBusinessRelation.Text = "Geschäftsbeziehung";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpBusinessRelation);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbPostelCode);
            this.Controls.Add(this.lbHouseNumber);
            this.Controls.Add(this.lbStreet);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbTitel);
            this.Controls.Add(this.lbCompany);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.txtHouseNumber);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSafe);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerForm";
            this.Size = new System.Drawing.Size(423, 253);
            this.grpBusinessRelation.ResumeLayout(false);
            this.grpBusinessRelation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbCity;
        private Label lbPostelCode;
        private Label lbHouseNumber;
        private Label lbStreet;
        private Label lbLastName;
        private Label lbCompany;
        private Label lbFirstName;
        private TextBox txtHouseNumber;
        private TextBox txtLastName;
        private TextBox txtCity;
        private TextBox txtPostalCode;
        private TextBox txtStreet;
        private TextBox txtCompany;
        private TextBox txtFirstName;
        private Button btnSafe;
        private Button btnCancel;
        private Label lbTitel;
        private RadioButton rdB2C;
        private RadioButton rdB2B;
        private GroupBox grpBusinessRelation;
    }
}
