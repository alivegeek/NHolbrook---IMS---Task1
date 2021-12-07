
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
            this.inventoryInput = new System.Windows.Forms.TextBox();
            this.priceInput = new System.Windows.Forms.TextBox();
            this.maxInput = new System.Windows.Forms.TextBox();
            this.machineIDinput = new System.Windows.Forms.TextBox();
            this.minInput = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
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
            this.labelID.Location = new System.Drawing.Point(150, 115);
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
            this.labelMax.Location = new System.Drawing.Point(150, 388);
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
            this.machineID.Location = new System.Drawing.Point(50, 449);
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
            this.labelMin.Location = new System.Drawing.Point(357, 388);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(46, 28);
            this.labelMin.TabIndex = 9;
            this.labelMin.Text = "Min";
            // 
            // idInput
            // 
            this.idInput.Location = new System.Drawing.Point(216, 117);
            this.idInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.idInput.Name = "idInput";
            this.idInput.ReadOnly = true;
            this.idInput.Size = new System.Drawing.Size(182, 27);
            this.idInput.TabIndex = 10;
            this.idInput.TextChanged += new System.EventHandler(this.idInput_TextChanged);
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(216, 192);
            this.nameInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(182, 27);
            this.nameInput.TabIndex = 11;
            this.nameInput.TextChanged += new System.EventHandler(this.nameInput_TextChanged);
            // 
            // inventoryInput
            // 
            this.inventoryInput.Location = new System.Drawing.Point(216, 263);
            this.inventoryInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inventoryInput.Name = "inventoryInput";
            this.inventoryInput.Size = new System.Drawing.Size(182, 27);
            this.inventoryInput.TabIndex = 12;
            this.inventoryInput.TextChanged += new System.EventHandler(this.inventoryInput_TextChanged);
            // 
            // priceInput
            // 
            this.priceInput.Location = new System.Drawing.Point(216, 331);
            this.priceInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(182, 27);
            this.priceInput.TabIndex = 13;
            this.priceInput.TextChanged += new System.EventHandler(this.priceInput_TextChanged);
            // 
            // maxInput
            // 
            this.maxInput.Location = new System.Drawing.Point(216, 385);
            this.maxInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maxInput.Name = "maxInput";
            this.maxInput.Size = new System.Drawing.Size(116, 27);
            this.maxInput.TabIndex = 14;
            this.maxInput.TextChanged += new System.EventHandler(this.maxInput_TextChanged);
            // 
            // machineIDinput
            // 
            this.machineIDinput.BackColor = System.Drawing.Color.White;
            this.machineIDinput.Location = new System.Drawing.Point(216, 447);
            this.machineIDinput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.machineIDinput.Name = "machineIDinput";
            this.machineIDinput.Size = new System.Drawing.Size(182, 27);
            this.machineIDinput.TabIndex = 15;
            this.machineIDinput.TextChanged += new System.EventHandler(this.machineIDinput_TextChanged);
            // 
            // minInput
            // 
            this.minInput.Location = new System.Drawing.Point(406, 385);
            this.minInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.minInput.Name = "minInput";
            this.minInput.Size = new System.Drawing.Size(116, 27);
            this.minInput.TabIndex = 16;
            this.minInput.TextChanged += new System.EventHandler(this.minInput_TextChanged);
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
            // Part
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 623);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.minInput);
            this.Controls.Add(this.machineIDinput);
            this.Controls.Add(this.maxInput);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.inventoryInput);
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
        public System.Windows.Forms.TextBox inventoryInput;
        public System.Windows.Forms.TextBox priceInput;
        public System.Windows.Forms.TextBox maxInput;
        public System.Windows.Forms.TextBox machineIDinput;
        public System.Windows.Forms.TextBox minInput;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}