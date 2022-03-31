namespace Accountant
{
    partial class ufProductSelection
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
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.nrProductCount = new System.Windows.Forms.NumericUpDown();
            this.txtSingleProductPrice = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbUnit = new System.Windows.Forms.Label();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.lbEuro = new System.Windows.Forms.Label();
            this.txtTotalProductPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nrProductCount)).BeginInit();
            this.SuspendLayout();
            // 
            // cbProducts
            // 
            this.cbProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(3, 18);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(174, 33);
            this.cbProducts.TabIndex = 0;
            this.cbProducts.SelectedIndexChanged += new System.EventHandler(this.cbProducts_SelectedIndexChanged);
            // 
            // nrProductCount
            // 
            this.nrProductCount.Location = new System.Drawing.Point(484, 19);
            this.nrProductCount.Name = "nrProductCount";
            this.nrProductCount.Size = new System.Drawing.Size(63, 31);
            this.nrProductCount.TabIndex = 1;
            this.nrProductCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nrProductCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nrProductCount.ValueChanged += new System.EventHandler(this.nrProductCount_ValueChanged);
            // 
            // txtSingleProductPrice
            // 
            this.txtSingleProductPrice.Location = new System.Drawing.Point(365, 19);
            this.txtSingleProductPrice.Name = "txtSingleProductPrice";
            this.txtSingleProductPrice.Size = new System.Drawing.Size(75, 31);
            this.txtSingleProductPrice.TabIndex = 2;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(686, 18);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(52, 31);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "X";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbUnit
            // 
            this.lbUnit.AutoSize = true;
            this.lbUnit.Location = new System.Drawing.Point(302, 22);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(44, 25);
            this.lbUnit.TabIndex = 4;
            this.lbUnit.Text = "Unit";
            // 
            // cbUnit
            // 
            this.cbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Location = new System.Drawing.Point(183, 18);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(113, 33);
            this.cbUnit.TabIndex = 0;
            this.cbUnit.SelectedIndexChanged += new System.EventHandler(this.cbUnit_SelectedIndexChanged);
            // 
            // lbEuro
            // 
            this.lbEuro.AutoSize = true;
            this.lbEuro.Location = new System.Drawing.Point(630, 22);
            this.lbEuro.Name = "lbEuro";
            this.lbEuro.Size = new System.Drawing.Size(22, 25);
            this.lbEuro.TabIndex = 5;
            this.lbEuro.Text = "€";
            // 
            // txtTotalProductPrice
            // 
            this.txtTotalProductPrice.Location = new System.Drawing.Point(553, 19);
            this.txtTotalProductPrice.Name = "txtTotalProductPrice";
            this.txtTotalProductPrice.Size = new System.Drawing.Size(71, 31);
            this.txtTotalProductPrice.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "€";
            // 
            // ufProductSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotalProductPrice);
            this.Controls.Add(this.lbEuro);
            this.Controls.Add(this.lbUnit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtSingleProductPrice);
            this.Controls.Add(this.nrProductCount);
            this.Controls.Add(this.cbUnit);
            this.Controls.Add(this.cbProducts);
            this.Name = "ufProductSelection";
            this.Size = new System.Drawing.Size(753, 64);
            ((System.ComponentModel.ISupportInitialize)(this.nrProductCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbProducts;
        private NumericUpDown nrProductCount;
        private TextBox txtSingleProductPrice;
        private Button btnRemove;
        private Label lbUnit;
        private ComboBox cbUnit;
        private Label lbEuro;
        private TextBox txtTotalProductPrice;
        private Label label1;
    }
}
