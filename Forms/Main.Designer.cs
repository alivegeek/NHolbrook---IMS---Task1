﻿
namespace NHolbrook___IMS___Task1.Forms
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PartsDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.partsDGVlabel = new System.Windows.Forms.Label();
            this.Products = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.addPart = new System.Windows.Forms.Button();
            this.modPart = new System.Windows.Forms.Button();
            this.delPart = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.modifyProductButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.ProductsDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PartsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // PartsDGV
            // 
            this.PartsDGV.AllowUserToAddRows = false;
            this.PartsDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PartsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.PartsDGV.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.PartsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsDGV.Location = new System.Drawing.Point(12, 88);
            this.PartsDGV.MultiSelect = false;
            this.PartsDGV.Name = "PartsDGV";
            this.PartsDGV.ReadOnly = true;
            this.PartsDGV.RowHeadersVisible = false;
            this.PartsDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.PartsDGV.RowTemplate.Height = 25;
            this.PartsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PartsDGV.Size = new System.Drawing.Size(419, 326);
            this.PartsDGV.TabIndex = 0;
            this.PartsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventory Managment System";
            // 
            // partsDGVlabel
            // 
            this.partsDGVlabel.AutoSize = true;
            this.partsDGVlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partsDGVlabel.Location = new System.Drawing.Point(12, 64);
            this.partsDGVlabel.Name = "partsDGVlabel";
            this.partsDGVlabel.Size = new System.Drawing.Size(44, 21);
            this.partsDGVlabel.TabIndex = 3;
            this.partsDGVlabel.Text = "Parts";
            this.partsDGVlabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // Products
            // 
            this.Products.AutoSize = true;
            this.Products.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Products.Location = new System.Drawing.Point(437, 64);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(71, 21);
            this.Products.TabIndex = 4;
            this.Products.Text = "Products";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(807, 467);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(65, 37);
            this.exit.TabIndex = 5;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // addPart
            // 
            this.addPart.Location = new System.Drawing.Point(216, 420);
            this.addPart.Name = "addPart";
            this.addPart.Size = new System.Drawing.Size(67, 38);
            this.addPart.TabIndex = 6;
            this.addPart.Text = "Add";
            this.addPart.UseVisualStyleBackColor = true;
            this.addPart.Click += new System.EventHandler(this.addPart_Click);
            // 
            // modPart
            // 
            this.modPart.Location = new System.Drawing.Point(289, 420);
            this.modPart.Name = "modPart";
            this.modPart.Size = new System.Drawing.Size(67, 38);
            this.modPart.TabIndex = 7;
            this.modPart.Text = "Modify";
            this.modPart.UseVisualStyleBackColor = true;
            this.modPart.Click += new System.EventHandler(this.modPart_Click);
            // 
            // delPart
            // 
            this.delPart.Location = new System.Drawing.Point(362, 420);
            this.delPart.Name = "delPart";
            this.delPart.Size = new System.Drawing.Size(67, 38);
            this.delPart.TabIndex = 8;
            this.delPart.Text = "Delete";
            this.delPart.UseVisualStyleBackColor = true;
            this.delPart.Click += new System.EventHandler(this.delPart_Click);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(805, 420);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(67, 38);
            this.deleteProductButton.TabIndex = 11;
            this.deleteProductButton.Text = "Delete";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // modifyProductButton
            // 
            this.modifyProductButton.Location = new System.Drawing.Point(732, 420);
            this.modifyProductButton.Name = "modifyProductButton";
            this.modifyProductButton.Size = new System.Drawing.Size(67, 38);
            this.modifyProductButton.TabIndex = 10;
            this.modifyProductButton.Text = "Modify";
            this.modifyProductButton.UseVisualStyleBackColor = true;
            this.modifyProductButton.Click += new System.EventHandler(this.modifyProductButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(659, 420);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(67, 38);
            this.addProductButton.TabIndex = 9;
            this.addProductButton.Text = "Add";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // ProductsDGV
            // 
            this.ProductsDGV.AllowUserToAddRows = false;
            this.ProductsDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProductsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ProductsDGV.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.ProductsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDGV.Location = new System.Drawing.Point(437, 88);
            this.ProductsDGV.MultiSelect = false;
            this.ProductsDGV.Name = "ProductsDGV";
            this.ProductsDGV.ReadOnly = true;
            this.ProductsDGV.RowHeadersVisible = false;
            this.ProductsDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.ProductsDGV.RowTemplate.Height = 25;
            this.ProductsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsDGV.Size = new System.Drawing.Size(435, 326);
            this.ProductsDGV.TabIndex = 12;
            this.ProductsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsDGV_CellContentClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 516);
            this.Controls.Add(this.ProductsDGV);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.modifyProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.delPart);
            this.Controls.Add(this.modPart);
            this.Controls.Add(this.addPart);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.partsDGVlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PartsDGV);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PartsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView PartsDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label partsDGVlabel;
        private System.Windows.Forms.Label Products;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button addPart;
        private System.Windows.Forms.Button modPart;
        private System.Windows.Forms.Button delPart;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button modifyProductButton;
        private System.Windows.Forms.Button addProductButton;
        public System.Windows.Forms.DataGridView ProductsDGV;
    }
}