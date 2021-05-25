using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHolbrook___IMS___Task1.Forms
{
    public partial class Main : Form
    {
        public Main()
        {

            InitializeComponent();
            PartsDGV.DataSource = Classes.Inventory.AllParts;
            ProductsDGV.DataSource = Classes.Inventory.Products;


        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addPart_Click(object sender, EventArgs e)
        {
            Part part = new Part();
            
            part.idInput.Text = Convert.ToString(Classes.Inventory.GetNextPartID());
            part.ShowDialog();
            
        }

        private void modPart_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = PartsDGV.SelectedRows[0]; //  can i disable ctrl click so that multiple rows cant be slected?
                var partID = Convert.ToInt32(selectedRow.Cells["PartID"].Value);
                //Debug.WriteLine(Classes.Inventory.AllParts[currentIDX].Name);
                Classes.Part part = Classes.Inventory.lookupPart(partID);
                // Debug.WriteLine(part);
                Forms.Part partForm = new Part();
                partForm.idInput.Text = Convert.ToString(part.PartID);
                partForm.nameInput.Text = part.Name;
                partForm.inventoryInput.Text = Convert.ToString(part.InStock);
                partForm.priceInput.Text = Convert.ToString(part.Price);
                partForm.maxInput.Text = Convert.ToString(part.Max);
                partForm.minInput.Text = Convert.ToString(part.Min);
                partForm.machineIDinput.Text = Convert.ToString(part.PartID);


                partForm.ShowDialog();
            } catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select something to modify");
                return;
            }

            //if (PartsDGV.CurrentRow.Selected == false)

        }  

           
            
            

        

        private void delPart_Click(object sender, EventArgs e)
        {
            try {

                
                DataGridViewRow selectedRow = PartsDGV.SelectedRows[0];
                var toDelete = Convert.ToInt32(selectedRow.Cells["PartID"].Value);
                Classes.Part partToDelete = Classes.Inventory.lookupPart(toDelete);
                Debug.WriteLine(partToDelete);

               if (MessageBox.Show($"are you sure you want to delete {partToDelete.Name}?" , "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                    Classes.Inventory.deletePart(partToDelete);
                    // probably a hack -  DGV index errors after deleting a row so im rebuilding the DGV to reflect the changes
                    PartsDGV.DataSource = null;
                    PartsDGV.DataSource = Classes.Inventory.AllParts;

                    PartsDGV.Refresh();
                }
              
               
            } catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select something to delete.");
                return;
            }
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddProduct addproduct = new();
            addproduct.IDinput.Text = Convert.ToString(Classes.Inventory.GetNextProductID());
            addproduct.ShowDialog();
        }

        private void modifyProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = ProductsDGV.SelectedRows[0]; //  can i disable ctrl click so that multiple rows cant be slected?
                var productID = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);
                //Debug.WriteLine(Classes.Inventory.AllParts[currentIDX].Name);
                Classes.Product product = Classes.Inventory.lookupProduct(productID);
                // Debug.WriteLine(part);
                Forms.AddProduct productForm = new();
                productForm.IDinput.Text = Convert.ToString(product.ProductID);
                productForm.nameInput.Text = product.Name;
                productForm.inventoryInput.Text = Convert.ToString(product.InStock);
                productForm.priceInput.Text = Convert.ToString(product.Price);
                productForm.maxInput.Text = Convert.ToString(product.Max);
                productForm.minInput.Text = Convert.ToString(product.Min);


                productForm.ShowDialog();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select something to modify");
                return;
            }
        }
    }
}
