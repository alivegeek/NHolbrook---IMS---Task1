
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PartsDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.partsDGVlabel = new System.Windows.Forms.Label();
            this.Products = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.addPart = new System.Windows.Forms.Button();
            this.modPart = new System.Windows.Forms.Button();
            this.delPart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PartsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PartsDGV
            // 
            this.PartsDGV.AllowUserToAddRows = false;
            this.PartsDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PartsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PartsDGV.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.PartsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsDGV.Location = new System.Drawing.Point(12, 88);
            this.PartsDGV.MultiSelect = false;
            this.PartsDGV.Name = "PartsDGV";
            this.PartsDGV.ReadOnly = true;
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
            // dataGridView1
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(437, 88);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(435, 326);
            this.dataGridView1.TabIndex = 2;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(805, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(732, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 38);
            this.button2.TabIndex = 10;
            this.button2.Text = "Modify";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(659, 420);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 38);
            this.button3.TabIndex = 9;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 516);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.delPart);
            this.Controls.Add(this.modPart);
            this.Controls.Add(this.addPart);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.partsDGVlabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PartsDGV);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PartsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView PartsDGV;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label partsDGVlabel;
        private System.Windows.Forms.Label Products;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button addPart;
        private System.Windows.Forms.Button modPart;
        private System.Windows.Forms.Button delPart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}