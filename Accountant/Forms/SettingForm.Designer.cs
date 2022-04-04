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
            this.lbCapacity = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbTitel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbProduct
            // 
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(15, 62);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(121, 23);
            this.cbProduct.TabIndex = 0;
            this.cbProduct.SelectedIndexChanged += new System.EventHandler(this.cbProduct_SelectedIndexChanged);
            // 
            // lbProduct
            // 
            this.lbProduct.AutoSize = true;
            this.lbProduct.Location = new System.Drawing.Point(15, 44);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(55, 15);
            this.lbProduct.TabIndex = 1;
            this.lbProduct.Text = "Produkte";
            // 
            // btnSafe
            // 
            this.btnSafe.Location = new System.Drawing.Point(316, 101);
            this.btnSafe.Name = "btnSafe";
            this.btnSafe.Size = new System.Drawing.Size(77, 23);
            this.btnSafe.TabIndex = 2;
            this.btnSafe.Text = "Speichern";
            this.btnSafe.UseVisualStyleBackColor = true;
            this.btnSafe.Click += new System.EventHandler(this.btnSafe_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(173, 44);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(32, 15);
            this.lbPrice.TabIndex = 3;
            this.lbPrice.Text = "Preis";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(173, 62);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(50, 23);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.Enter += new System.EventHandler(this.txtPrice_Enter);
            // 
            // lbCurrency
            // 
            this.lbCurrency.AutoSize = true;
            this.lbCurrency.Location = new System.Drawing.Point(229, 65);
            this.lbCurrency.Name = "lbCurrency";
            this.lbCurrency.Size = new System.Drawing.Size(13, 15);
            this.lbCurrency.TabIndex = 5;
            this.lbCurrency.Text = "€";
            // 
            // lbCapacity
            // 
            this.lbCapacity.AutoSize = true;
            this.lbCapacity.Location = new System.Drawing.Point(273, 44);
            this.lbCapacity.Name = "lbCapacity";
            this.lbCapacity.Size = new System.Drawing.Size(43, 15);
            this.lbCapacity.TabIndex = 3;
            this.lbCapacity.Text = "Einheit";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(273, 62);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.ReadOnly = true;
            this.txtCapacity.Size = new System.Drawing.Size(71, 23);
            this.txtCapacity.TabIndex = 15;
            this.txtCapacity.Enter += new System.EventHandler(this.txtCapacity_Enter);
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(350, 62);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.ReadOnly = true;
            this.txtUnit.Size = new System.Drawing.Size(43, 23);
            this.txtUnit.TabIndex = 16;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(15, 101);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbTitel
            // 
            this.lbTitel.AutoSize = true;
            this.lbTitel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitel.Location = new System.Drawing.Point(15, 11);
            this.lbTitel.Name = "lbTitel";
            this.lbTitel.Size = new System.Drawing.Size(135, 18);
            this.lbTitel.TabIndex = 17;
            this.lbTitel.Text = "Preiseinstellungen";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbTitel);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.lbCurrency);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lbCapacity);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSafe);
            this.Controls.Add(this.lbProduct);
            this.Controls.Add(this.cbProduct);
            this.Name = "SettingForm";
            this.Size = new System.Drawing.Size(433, 141);
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
        private Label lbCapacity;
        private TextBox txtCapacity;
        private TextBox txtUnit;
        private Button btnCancel;
        private Label lbTitel;
    }
}
