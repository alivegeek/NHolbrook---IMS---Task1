
namespace NHolbrook___IMS___Task1.Forms
{
    partial class AddProduct
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
            this.productTitleLabel = new System.Windows.Forms.Label();
            this.productLabelID = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productInventoryLabel = new System.Windows.Forms.Label();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.productMinLabel = new System.Windows.Forms.Label();
            this.productMaxLabel = new System.Windows.Forms.Label();
            this.IDinput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.inventoryInput = new System.Windows.Forms.TextBox();
            this.priceInput = new System.Windows.Forms.TextBox();
            this.minInput = new System.Windows.Forms.TextBox();
            this.maxInput = new System.Windows.Forms.TextBox();
            this.canidatePartsLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addPartsButtoni = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.associatedPartsLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // productTitleLabel
            // 
            this.productTitleLabel.AutoSize = true;
            this.productTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productTitleLabel.Location = new System.Drawing.Point(29, 21);
            this.productTitleLabel.Name = "productTitleLabel";
            this.productTitleLabel.Size = new System.Drawing.Size(96, 21);
            this.productTitleLabel.TabIndex = 0;
            this.productTitleLabel.Text = "Add Product";
            // 
            // productLabelID
            // 
            this.productLabelID.AutoSize = true;
            this.productLabelID.Location = new System.Drawing.Point(29, 190);
            this.productLabelID.Name = "productLabelID";
            this.productLabelID.Size = new System.Drawing.Size(18, 15);
            this.productLabelID.TabIndex = 1;
            this.productLabelID.Text = "ID";
            this.productLabelID.Click += new System.EventHandler(this.label1_Click);
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(29, 234);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(39, 15);
            this.productNameLabel.TabIndex = 2;
            this.productNameLabel.Text = "Name";
            // 
            // productInventoryLabel
            // 
            this.productInventoryLabel.AutoSize = true;
            this.productInventoryLabel.Location = new System.Drawing.Point(30, 271);
            this.productInventoryLabel.Name = "productInventoryLabel";
            this.productInventoryLabel.Size = new System.Drawing.Size(57, 15);
            this.productInventoryLabel.TabIndex = 3;
            this.productInventoryLabel.Text = "Inventory";
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Location = new System.Drawing.Point(30, 315);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(33, 15);
            this.productPriceLabel.TabIndex = 4;
            this.productPriceLabel.Text = "Price";
            // 
            // productMinLabel
            // 
            this.productMinLabel.AutoSize = true;
            this.productMinLabel.Location = new System.Drawing.Point(29, 364);
            this.productMinLabel.Name = "productMinLabel";
            this.productMinLabel.Size = new System.Drawing.Size(28, 15);
            this.productMinLabel.TabIndex = 5;
            this.productMinLabel.Text = "Min";
            // 
            // productMaxLabel
            // 
            this.productMaxLabel.AutoSize = true;
            this.productMaxLabel.Location = new System.Drawing.Point(193, 364);
            this.productMaxLabel.Name = "productMaxLabel";
            this.productMaxLabel.Size = new System.Drawing.Size(30, 15);
            this.productMaxLabel.TabIndex = 6;
            this.productMaxLabel.Text = "Max";
            // 
            // IDinput
            // 
            this.IDinput.Location = new System.Drawing.Point(102, 190);
            this.IDinput.Name = "IDinput";
            this.IDinput.ReadOnly = true;
            this.IDinput.Size = new System.Drawing.Size(212, 23);
            this.IDinput.TabIndex = 7;
            this.IDinput.TextChanged += new System.EventHandler(this.IDinput_TextChanged);
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(102, 226);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(212, 23);
            this.nameInput.TabIndex = 8;
            this.nameInput.TextChanged += new System.EventHandler(this.nameInput_TextChanged);
            // 
            // inventoryInput
            // 
            this.inventoryInput.Location = new System.Drawing.Point(102, 268);
            this.inventoryInput.Name = "inventoryInput";
            this.inventoryInput.Size = new System.Drawing.Size(212, 23);
            this.inventoryInput.TabIndex = 9;
            this.inventoryInput.TextChanged += new System.EventHandler(this.inventoryInput_TextChanged);
            // 
            // priceInput
            // 
            this.priceInput.Location = new System.Drawing.Point(102, 315);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(212, 23);
            this.priceInput.TabIndex = 10;
            this.priceInput.TextChanged += new System.EventHandler(this.priceInput_TextChanged);
            // 
            // minInput
            // 
            this.minInput.Location = new System.Drawing.Point(102, 364);
            this.minInput.Name = "minInput";
            this.minInput.Size = new System.Drawing.Size(85, 23);
            this.minInput.TabIndex = 11;
            this.minInput.TextChanged += new System.EventHandler(this.minInput_TextChanged);
            // 
            // maxInput
            // 
            this.maxInput.Location = new System.Drawing.Point(229, 364);
            this.maxInput.Name = "maxInput";
            this.maxInput.Size = new System.Drawing.Size(85, 23);
            this.maxInput.TabIndex = 12;
            this.maxInput.TextChanged += new System.EventHandler(this.maxInput_TextChanged);
            // 
            // canidatePartsLabel
            // 
            this.canidatePartsLabel.AutoSize = true;
            this.canidatePartsLabel.Location = new System.Drawing.Point(379, 81);
            this.canidatePartsLabel.Name = "canidatePartsLabel";
            this.canidatePartsLabel.Size = new System.Drawing.Size(105, 15);
            this.canidatePartsLabel.TabIndex = 13;
            this.canidatePartsLabel.Text = "All candidate parts";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(379, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(621, 207);
            this.dataGridView1.TabIndex = 14;
            // 
            // addPartsButtoni
            // 
            this.addPartsButtoni.Location = new System.Drawing.Point(918, 315);
            this.addPartsButtoni.Name = "addPartsButtoni";
            this.addPartsButtoni.Size = new System.Drawing.Size(66, 44);
            this.addPartsButtoni.TabIndex = 15;
            this.addPartsButtoni.Text = "Add";
            this.addPartsButtoni.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(379, 381);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(621, 207);
            this.dataGridView2.TabIndex = 16;
            // 
            // associatedPartsLabel
            // 
            this.associatedPartsLabel.AutoSize = true;
            this.associatedPartsLabel.Location = new System.Drawing.Point(379, 363);
            this.associatedPartsLabel.Name = "associatedPartsLabel";
            this.associatedPartsLabel.Size = new System.Drawing.Size(186, 15);
            this.associatedPartsLabel.TabIndex = 17;
            this.associatedPartsLabel.Text = "Parts Associated with this Product";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(918, 594);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(66, 46);
            this.deleteButton.TabIndex = 18;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(848, 648);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(66, 45);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(920, 648);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(64, 45);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 705);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.associatedPartsLabel);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.addPartsButtoni);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.canidatePartsLabel);
            this.Controls.Add(this.maxInput);
            this.Controls.Add(this.minInput);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.inventoryInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.IDinput);
            this.Controls.Add(this.productMaxLabel);
            this.Controls.Add(this.productMinLabel);
            this.Controls.Add(this.productPriceLabel);
            this.Controls.Add(this.productInventoryLabel);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.productLabelID);
            this.Controls.Add(this.productTitleLabel);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productTitleLabel;
        private System.Windows.Forms.Label productLabelID;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label productInventoryLabel;
        private System.Windows.Forms.Label productPriceLabel;
        private System.Windows.Forms.Label productMinLabel;
        private System.Windows.Forms.Label productMaxLabel;
        public System.Windows.Forms.TextBox IDinput;
        public System.Windows.Forms.TextBox nameInput;
        public System.Windows.Forms.TextBox inventoryInput;
        public System.Windows.Forms.TextBox priceInput;
        public System.Windows.Forms.TextBox minInput;
        public System.Windows.Forms.TextBox maxInput;
        private System.Windows.Forms.Label canidatePartsLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addPartsButtoni;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label associatedPartsLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button cancelButton;
    }
}