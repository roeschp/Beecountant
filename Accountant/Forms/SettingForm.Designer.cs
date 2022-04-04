namespace Accountant.Forms
{
    partial class SettingForm
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.lbProduct = new System.Windows.Forms.Label();
            this.btnSafe = new System.Windows.Forms.Button();
            this.lbPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lbCurrency = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lbUnit = new System.Windows.Forms.Label();
            this.cbCapacity = new System.Windows.Forms.ComboBox();
            this.lbCapacity = new System.Windows.Forms.Label();
            this.cbCapacityS = new System.Windows.Forms.ComboBox();
            this.cbUnitS = new System.Windows.Forms.ComboBox();
            this.lbCurrencyS = new System.Windows.Forms.Label();
            this.txtPriceS = new System.Windows.Forms.TextBox();
            this.lbCapacityS = new System.Windows.Forms.Label();
            this.lbUnitS = new System.Windows.Forms.Label();
            this.lbPriceS = new System.Windows.Forms.Label();
            this.chbSmall = new System.Windows.Forms.CheckBox();
            this.grpSmall = new System.Windows.Forms.GroupBox();
            this.grpSmall.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbProduct
            // 
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(15, 49);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(121, 23);
            this.cbProduct.TabIndex = 0;
            this.cbProduct.SelectedIndexChanged += new System.EventHandler(this.cbProduct_SelectedIndexChanged);
            // 
            // lbProduct
            // 
            this.lbProduct.AutoSize = true;
            this.lbProduct.Location = new System.Drawing.Point(15, 31);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(54, 15);
            this.lbProduct.TabIndex = 1;
            this.lbProduct.Text = "Products";
            // 
            // btnSafe
            // 
            this.btnSafe.Location = new System.Drawing.Point(348, 137);
            this.btnSafe.Name = "btnSafe";
            this.btnSafe.Size = new System.Drawing.Size(53, 23);
            this.btnSafe.TabIndex = 2;
            this.btnSafe.Text = "Save";
            this.btnSafe.UseVisualStyleBackColor = true;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(151, 31);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(33, 15);
            this.lbPrice.TabIndex = 3;
            this.lbPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(151, 49);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(50, 23);
            this.txtPrice.TabIndex = 4;
            // 
            // lbCurrency
            // 
            this.lbCurrency.AutoSize = true;
            this.lbCurrency.Location = new System.Drawing.Point(207, 52);
            this.lbCurrency.Name = "lbCurrency";
            this.lbCurrency.Size = new System.Drawing.Size(13, 15);
            this.lbCurrency.TabIndex = 5;
            this.lbCurrency.Text = "€";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(327, 49);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(74, 23);
            this.comboBox2.TabIndex = 6;
            // 
            // lbUnit
            // 
            this.lbUnit.AutoSize = true;
            this.lbUnit.Location = new System.Drawing.Point(327, 31);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(29, 15);
            this.lbUnit.TabIndex = 3;
            this.lbUnit.Text = "Unit";
            // 
            // cbCapacity
            // 
            this.cbCapacity.FormattingEnabled = true;
            this.cbCapacity.Location = new System.Drawing.Point(236, 49);
            this.cbCapacity.Name = "cbCapacity";
            this.cbCapacity.Size = new System.Drawing.Size(74, 23);
            this.cbCapacity.TabIndex = 6;
            // 
            // lbCapacity
            // 
            this.lbCapacity.AutoSize = true;
            this.lbCapacity.Location = new System.Drawing.Point(236, 31);
            this.lbCapacity.Name = "lbCapacity";
            this.lbCapacity.Size = new System.Drawing.Size(53, 15);
            this.lbCapacity.TabIndex = 3;
            this.lbCapacity.Text = "Capacity";
            // 
            // cbCapacityS
            // 
            this.cbCapacityS.FormattingEnabled = true;
            this.cbCapacityS.Location = new System.Drawing.Point(93, 24);
            this.cbCapacityS.Name = "cbCapacityS";
            this.cbCapacityS.Size = new System.Drawing.Size(74, 23);
            this.cbCapacityS.TabIndex = 12;
            // 
            // cbUnitS
            // 
            this.cbUnitS.FormattingEnabled = true;
            this.cbUnitS.Location = new System.Drawing.Point(184, 24);
            this.cbUnitS.Name = "cbUnitS";
            this.cbUnitS.Size = new System.Drawing.Size(74, 23);
            this.cbUnitS.TabIndex = 13;
            // 
            // lbCurrencyS
            // 
            this.lbCurrencyS.AutoSize = true;
            this.lbCurrencyS.Location = new System.Drawing.Point(64, 27);
            this.lbCurrencyS.Name = "lbCurrencyS";
            this.lbCurrencyS.Size = new System.Drawing.Size(13, 15);
            this.lbCurrencyS.TabIndex = 11;
            this.lbCurrencyS.Text = "€";
            // 
            // txtPriceS
            // 
            this.txtPriceS.Location = new System.Drawing.Point(8, 24);
            this.txtPriceS.Name = "txtPriceS";
            this.txtPriceS.Size = new System.Drawing.Size(50, 23);
            this.txtPriceS.TabIndex = 10;
            // 
            // lbCapacityS
            // 
            this.lbCapacityS.AutoSize = true;
            this.lbCapacityS.Location = new System.Drawing.Point(93, 6);
            this.lbCapacityS.Name = "lbCapacityS";
            this.lbCapacityS.Size = new System.Drawing.Size(53, 15);
            this.lbCapacityS.TabIndex = 7;
            this.lbCapacityS.Text = "Capacity";
            // 
            // lbUnitS
            // 
            this.lbUnitS.AutoSize = true;
            this.lbUnitS.Location = new System.Drawing.Point(184, 6);
            this.lbUnitS.Name = "lbUnitS";
            this.lbUnitS.Size = new System.Drawing.Size(29, 15);
            this.lbUnitS.TabIndex = 8;
            this.lbUnitS.Text = "Unit";
            // 
            // lbPriceS
            // 
            this.lbPriceS.AutoSize = true;
            this.lbPriceS.Location = new System.Drawing.Point(8, 6);
            this.lbPriceS.Name = "lbPriceS";
            this.lbPriceS.Size = new System.Drawing.Size(33, 15);
            this.lbPriceS.TabIndex = 9;
            this.lbPriceS.Text = "Price";
            // 
            // chbSmall
            // 
            this.chbSmall.AutoSize = true;
            this.chbSmall.Location = new System.Drawing.Point(15, 81);
            this.chbSmall.Name = "chbSmall";
            this.chbSmall.Size = new System.Drawing.Size(96, 19);
            this.chbSmall.TabIndex = 14;
            this.chbSmall.Text = "Small Version";
            this.chbSmall.UseVisualStyleBackColor = true;
            // 
            // grpSmall
            // 
            this.grpSmall.Controls.Add(this.cbCapacityS);
            this.grpSmall.Controls.Add(this.cbUnitS);
            this.grpSmall.Controls.Add(this.lbCurrencyS);
            this.grpSmall.Controls.Add(this.txtPriceS);
            this.grpSmall.Controls.Add(this.lbCapacityS);
            this.grpSmall.Controls.Add(this.lbUnitS);
            this.grpSmall.Controls.Add(this.lbPriceS);
            this.grpSmall.Location = new System.Drawing.Point(143, 75);
            this.grpSmall.Name = "grpSmall";
            this.grpSmall.Size = new System.Drawing.Size(267, 54);
            this.grpSmall.TabIndex = 15;
            this.grpSmall.TabStop = false;
            this.grpSmall.Visible = false;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpSmall);
            this.Controls.Add(this.chbSmall);
            this.Controls.Add(this.cbCapacity);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lbCurrency);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lbCapacity);
            this.Controls.Add(this.lbUnit);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.btnSafe);
            this.Controls.Add(this.lbProduct);
            this.Controls.Add(this.cbProduct);
            this.Name = "SettingForm";
            this.Size = new System.Drawing.Size(423, 163);
            this.grpSmall.ResumeLayout(false);
            this.grpSmall.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbProduct;
        private Label lbProduct;
        private Button btnSafe;
        private Label lbPrice;
        private TextBox txtPrice;
        private Label lbCurrency;
        private ComboBox comboBox2;
        private Label lbUnit;
        private ComboBox cbCapacity;
        private Label lbCapacity;
        private ComboBox cbCapacityS;
        private ComboBox cbUnitS;
        private Label lbCurrencyS;
        private TextBox txtPriceS;
        private Label lbCapacityS;
        private Label lbUnitS;
        private Label lbPriceS;
        private CheckBox chbSmall;
        private GroupBox grpSmall;
    }
}
