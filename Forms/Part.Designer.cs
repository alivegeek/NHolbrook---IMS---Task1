
namespace NHolbrook___IMS___Task1.Forms
{
    partial class Part
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
            this.partLabel = new System.Windows.Forms.Label();
            this.radioInHouse = new System.Windows.Forms.RadioButton();
            this.radioOutsourced = new System.Windows.Forms.RadioButton();
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelInventory = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.machineID = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.idInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.machineIDinput = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.inventoryInput = new System.Windows.Forms.NumericUpDown();
            this.priceInput = new System.Windows.Forms.NumericUpDown();
            this.maxInput = new System.Windows.Forms.NumericUpDown();
            this.minInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minInput)).BeginInit();
            this.SuspendLayout();
            // 
            // partLabel
            // 
            this.partLabel.AutoSize = true;
            this.partLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.partLabel.Location = new System.Drawing.Point(14, 12);
            this.partLabel.Name = "partLabel";
            this.partLabel.Size = new System.Drawing.Size(96, 28);
            this.partLabel.TabIndex = 0;
            this.partLabel.Text = "Add Part";
            // 
            // radioInHouse
            // 
            this.radioInHouse.AutoSize = true;
            this.radioInHouse.Location = new System.Drawing.Point(174, 16);
            this.radioInHouse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioInHouse.Name = "radioInHouse";
            this.radioInHouse.Size = new System.Drawing.Size(90, 24);
            this.radioInHouse.TabIndex = 1;
            this.radioInHouse.TabStop = true;
            this.radioInHouse.Text = "In-House";
            this.radioInHouse.UseVisualStyleBackColor = true;
            this.radioInHouse.CheckedChanged += new System.EventHandler(this.radioInHouse_CheckedChanged);
            // 
            // radioOutsourced
            // 
            this.radioOutsourced.AutoSize = true;
            this.radioOutsourced.Location = new System.Drawing.Point(339, 16);
            this.radioOutsourced.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioOutsourced.Name = "radioOutsourced";
            this.radioOutsourced.Size = new System.Drawing.Size(106, 24);
            this.radioOutsourced.TabIndex = 2;
            this.radioOutsourced.TabStop = true;
            this.radioOutsourced.Text = "Outsourced";
            this.radioOutsourced.UseVisualStyleBackColor = true;
            this.radioOutsourced.CheckedChanged += new System.EventHandler(this.radioOutsourced_CheckedChanged);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelID.Location = new System.Drawing.Point(179, 116);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(31, 28);
            this.labelID.TabIndex = 3;
            this.labelID.Text = "ID";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(150, 195);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(64, 28);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name";
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInventory.Location = new System.Drawing.Point(122, 265);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(95, 28);
            this.labelInventory.TabIndex = 5;
            this.labelInventory.Text = "Inventory";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(107, 333);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(111, 28);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "Price / Cost";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMax.Location = new System.Drawing.Point(165, 385);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(49, 28);
            this.labelMax.TabIndex = 7;
            this.labelMax.Text = "Max";
            // 
            // machineID
            // 
            this.machineID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.machineID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.machineID.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.machineID.Location = new System.Drawing.Point(55, 447);
            this.machineID.Name = "machineID";
            this.machineID.Size = new System.Drawing.Size(159, 28);
            this.machineID.TabIndex = 8;
            this.machineID.Text = "Machine ID";
            this.machineID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.machineID.Click += new System.EventHandler(this.label6_Click);
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMin.Location = new System.Drawing.Point(297, 384);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(46, 28);
            this.labelMin.TabIndex = 9;
            this.labelMin.Text = "Min";
            // 
            // idInput
            // 
            this.idInput.Location = new System.Drawing.Point(223, 117);
            this.idInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.idInput.Name = "idInput";
            this.idInput.ReadOnly = true;
            this.idInput.Size = new System.Drawing.Size(175, 27);
            this.idInput.TabIndex = 10;
            this.idInput.TextChanged += new System.EventHandler(this.idInput_TextChanged);
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(223, 192);
            this.nameInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(175, 27);
            this.nameInput.TabIndex = 11;
            this.nameInput.TextChanged += new System.EventHandler(this.nameInput_TextChanged);
            // 
            // machineIDinput
            // 
            this.machineIDinput.BackColor = System.Drawing.Color.White;
            this.machineIDinput.Location = new System.Drawing.Point(223, 447);
            this.machineIDinput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.machineIDinput.Name = "machineIDinput";
            this.machineIDinput.Size = new System.Drawing.Size(175, 27);
            this.machineIDinput.TabIndex = 15;
            this.machineIDinput.TextChanged += new System.EventHandler(this.machineIDinput_TextChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(353, 527);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(72, 61);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(450, 527);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(72, 61);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // inventoryInput
            // 
            this.inventoryInput.Hexadecimal = true;
            this.inventoryInput.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.inventoryInput.Location = new System.Drawing.Point(223, 270);
            this.inventoryInput.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.inventoryInput.Name = "inventoryInput";
            this.inventoryInput.Size = new System.Drawing.Size(180, 27);
            this.inventoryInput.TabIndex = 19;
            this.inventoryInput.ValueChanged += new System.EventHandler(this.inventoryInput_ValueChanged);
            // 
            // priceInput
            // 
            this.priceInput.DecimalPlaces = 2;
            this.priceInput.Location = new System.Drawing.Point(224, 333);
            this.priceInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(179, 27);
            this.priceInput.TabIndex = 20;
            this.priceInput.ThousandsSeparator = true;
            this.priceInput.ValueChanged += new System.EventHandler(this.priceInput_ValueChanged);
            // 
            // maxInput
            // 
            this.maxInput.Location = new System.Drawing.Point(223, 385);
            this.maxInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.maxInput.Name = "maxInput";
            this.maxInput.Size = new System.Drawing.Size(68, 27);
            this.maxInput.TabIndex = 21;
            this.maxInput.ValueChanged += new System.EventHandler(this.maxInput_ValueChanged);
            // 
            // minInput
            // 
            this.minInput.Location = new System.Drawing.Point(339, 385);
            this.minInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.minInput.Name = "minInput";
            this.minInput.Size = new System.Drawing.Size(64, 27);
            this.minInput.TabIndex = 22;
            this.minInput.ThousandsSeparator = true;
            this.minInput.ValueChanged += new System.EventHandler(this.minInput_ValueChanged);
            // 
            // Part
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 623);
            this.Controls.Add(this.minInput);
            this.Controls.Add(this.maxInput);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.inventoryInput);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.machineIDinput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.idInput);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.machineID);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelInventory);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.radioOutsourced);
            this.Controls.Add(this.radioInHouse);
            this.Controls.Add(this.partLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Part";
            this.Text = "Part";
            this.Load += new System.EventHandler(this.Part_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label partLabel;
        public System.Windows.Forms.RadioButton radioInHouse;
        public System.Windows.Forms.RadioButton radioOutsourced;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelInventory;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelMax;
        public System.Windows.Forms.Label machineID;
        private System.Windows.Forms.Label labelMin;
        public System.Windows.Forms.TextBox idInput;
        public System.Windows.Forms.TextBox nameInput;
        public System.Windows.Forms.TextBox machineIDinput;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.NumericUpDown inventoryInput;
        public System.Windows.Forms.NumericUpDown priceInput;
        public System.Windows.Forms.NumericUpDown maxInput;
        public System.Windows.Forms.NumericUpDown minInput;
    }
}