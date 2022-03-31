namespace Accountant
{
    partial class MainForm
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
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.lbCustomerSelection = new System.Windows.Forms.Label();
            this.flpProductSelection = new System.Windows.Forms.FlowLayoutPanel();
            this.lbCompany = new System.Windows.Forms.Label();
            this.lbFirstAndLastname = new System.Windows.Forms.Label();
            this.lbStreetAndHousenumber = new System.Windows.Forms.Label();
            this.lbPostalcodeAndCity = new System.Windows.Forms.Label();
            this.gpCustomer = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.gpCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(15, 40);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(86, 20);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddInvoice_Click);
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(216, 41);
            this.cbCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(129, 23);
            this.cbCustomer.TabIndex = 1;
            this.cbCustomer.SelectedIndexChanged += new System.EventHandler(this.cbCustomer_SelectedIndexChanged);
            // 
            // lbCustomerSelection
            // 
            this.lbCustomerSelection.AutoSize = true;
            this.lbCustomerSelection.Location = new System.Drawing.Point(216, 11);
            this.lbCustomerSelection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCustomerSelection.Name = "lbCustomerSelection";
            this.lbCustomerSelection.Size = new System.Drawing.Size(110, 15);
            this.lbCustomerSelection.TabIndex = 2;
            this.lbCustomerSelection.Text = "Costumer Selection";
            // 
            // flpProductSelection
            // 
            this.flpProductSelection.AutoScroll = true;
            this.flpProductSelection.Location = new System.Drawing.Point(15, 94);
            this.flpProductSelection.Margin = new System.Windows.Forms.Padding(2);
            this.flpProductSelection.Name = "flpProductSelection";
            this.flpProductSelection.Size = new System.Drawing.Size(520, 164);
            this.flpProductSelection.TabIndex = 3;
            // 
            // lbCompany
            // 
            this.lbCompany.AutoSize = true;
            this.lbCompany.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCompany.Location = new System.Drawing.Point(10, 16);
            this.lbCompany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCompany.Name = "lbCompany";
            this.lbCompany.Size = new System.Drawing.Size(52, 14);
            this.lbCompany.TabIndex = 4;
            this.lbCompany.Text = "Company";
            // 
            // lbFirstAndLastname
            // 
            this.lbFirstAndLastname.AutoSize = true;
            this.lbFirstAndLastname.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFirstAndLastname.Location = new System.Drawing.Point(10, 27);
            this.lbFirstAndLastname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFirstAndLastname.Name = "lbFirstAndLastname";
            this.lbFirstAndLastname.Size = new System.Drawing.Size(99, 14);
            this.lbFirstAndLastname.TabIndex = 5;
            this.lbFirstAndLastname.Text = "First and Lastname";
            // 
            // lbStreetAndHousenumber
            // 
            this.lbStreetAndHousenumber.AutoSize = true;
            this.lbStreetAndHousenumber.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbStreetAndHousenumber.Location = new System.Drawing.Point(10, 38);
            this.lbStreetAndHousenumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStreetAndHousenumber.Name = "lbStreetAndHousenumber";
            this.lbStreetAndHousenumber.Size = new System.Drawing.Size(127, 14);
            this.lbStreetAndHousenumber.TabIndex = 6;
            this.lbStreetAndHousenumber.Text = "Street and Housenumber";
            // 
            // lbPostalcodeAndCity
            // 
            this.lbPostalcodeAndCity.AutoSize = true;
            this.lbPostalcodeAndCity.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPostalcodeAndCity.Location = new System.Drawing.Point(10, 49);
            this.lbPostalcodeAndCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPostalcodeAndCity.Name = "lbPostalcodeAndCity";
            this.lbPostalcodeAndCity.Size = new System.Drawing.Size(102, 14);
            this.lbPostalcodeAndCity.TabIndex = 7;
            this.lbPostalcodeAndCity.Text = "Postalcode and City";
            // 
            // gpCustomer
            // 
            this.gpCustomer.Controls.Add(this.lbPostalcodeAndCity);
            this.gpCustomer.Controls.Add(this.lbStreetAndHousenumber);
            this.gpCustomer.Controls.Add(this.lbFirstAndLastname);
            this.gpCustomer.Controls.Add(this.lbCompany);
            this.gpCustomer.Location = new System.Drawing.Point(390, 7);
            this.gpCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.gpCustomer.Name = "gpCustomer";
            this.gpCustomer.Padding = new System.Windows.Forms.Padding(2);
            this.gpCustomer.Size = new System.Drawing.Size(145, 65);
            this.gpCustomer.TabIndex = 8;
            this.gpCustomer.TabStop = false;
            this.gpCustomer.Visible = false;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(15, 64);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(86, 20);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create File";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Visible = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 270);
            this.Controls.Add(this.gpCustomer);
            this.Controls.Add(this.flpProductSelection);
            this.Controls.Add(this.lbCustomerSelection);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnAddProduct);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.gpCustomer.ResumeLayout(false);
            this.gpCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAddProduct;
        private ComboBox cbCustomer;
        private Label lbCustomerSelection;
        private FlowLayoutPanel flpProductSelection;
        private Label lbCompany;
        private Label lbFirstAndLastname;
        private Label lbStreetAndHousenumber;
        private Label lbPostalcodeAndCity;
        private GroupBox gpCustomer;
        private Button btnCreate;
    }
}