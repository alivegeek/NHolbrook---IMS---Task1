using NHolbrook___IMS___Task1.Classes;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace NHolbrook___IMS___Task1.Forms
{
    public partial class Main : Form
    {

        public static bool sourcedType { get; set; }

        public void formatDGV(DataGridView dgv) //not neccessary? Could set in properties GUI?
        {
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            dgv.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

        }

        public Main()
        {
            InitializeComponent();
            formatDGV(PartsDGV);
            PartsDGV.DataSource = Inventory.AllParts;
            formatDGV(ProductsDGV);
            ProductsDGV.DataSource = Inventory.Products;
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
            this.Hide();
            Part part = new Part();
            Globals.partIsNew = true;
            part.idInput.Text = Convert.ToString(Inventory.GetNextPartID());
            part.ShowDialog();

        }



        private void modPart_Click(object sender, EventArgs e)
        {
            Globals.partIsNew = false;
            this.Hide();
            try
            {
                DataGridViewRow selectedRow = PartsDGV.SelectedRows[0]; //  can i disable ctrl click so that multiple rows cant be slected?
                var partID = Convert.ToInt32(selectedRow.Cells["PartID"].Value);
                //Debug.WriteLine(Classes.Inventory.AllParts[currentIDX].Name);
                Classes.Part part = Inventory.lookupPart(partID);
                // Debug.WriteLine(part);
                Part partForm = new Part();
                partForm.idInput.Text = Convert.ToString(part.PartID);
                partForm.nameInput.Text = part.Name;
                partForm.inventoryInput.Text = Convert.ToString(part.InStock);
                partForm.priceInput.Text = Convert.ToString(part.Price);
                partForm.maxInput.Text = Convert.ToString(part.Max);
                partForm.minInput.Text = Convert.ToString(part.Min);
                partForm.machineIDinput.Text = Convert.ToString(part.MachineID);

                if (Inventory.SourceChange(part.PartID, partForm.radioOutsourced.Checked) is true && part.GetType() == typeof(Outsourced))  //TRUE FOR OUTSOURCED
                {
                    partForm.machineIDinput.Text = part.CompanyName;
                }

                partForm.ShowDialog();


                //if (selectedRow.Cells["PartID"].Value is null)
                //{
                //    partForm.machineID.Text = "Company Name";
                //}
                //else if (Convert.ToInt32(selectedRow.Cells["PartID"].Value) == 0)
                //{
                //    partForm.machineID.Text = "Company Name";
                //    Debug.WriteLine("This is it!");
                //}
                //else if (selectedRow.Cells["PartID"].Value.Equals("0"))
                //{
                //    partForm.machineID.Text = "Company Name";

                //}
                return;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select something to modify");
                return;
            }
            //if (PartsDGV.CurrentRow.Selected == false)

        }








        private void delPart_Click(object sender, EventArgs e)
        {
            try
            {


                DataGridViewRow selectedRow = PartsDGV.SelectedRows[0];
                var toDelete = Convert.ToInt32(selectedRow.Cells["PartID"].Value);
                Classes.Part partToDelete = Inventory.lookupPart(toDelete);

                if (MessageBox.Show($"are you sure you want to delete {partToDelete.Name}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Inventory.deletePart(partToDelete);
                    // probably a hack -  DGV index errors after deleting a row so im rebuilding the DGV to reflect the changes
                    PartsDGV.DataSource = null;
                    PartsDGV.DataSource = Inventory.AllParts;

                    PartsDGV.Refresh();
                }


            }
            catch (ArgumentOutOfRangeException)
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
        //Add Product Button
        private void button3_Click(object sender, EventArgs e)
        {
            AddProduct.modifyOrNew = 0;

            this.Hide();
            AddProduct addproduct = new();
            addproduct.IDinput.Text = Convert.ToString(Inventory.GetNextProductID());
            try
            {
                addproduct.ShowDialog();
            }
            catch (IndexOutOfRangeException)
            {
                return;
            }
        }

        public void modifyProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            try
            {
                DataGridViewRow selectedRow = ProductsDGV.SelectedRows[0]; //  can i disable ctrl click so that multiple rows cant be slected?
                var productID = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);
                AddProduct.productID = productID;
                //Debug.WriteLine(Classes.Inventory.AllParts[currentIDX].Name);
                Product product = Inventory.lookupProduct(productID);
                // Debug.WriteLine(part);
                AddProduct productForm = new();
                productForm.IDinput.Text = Convert.ToString(product.ProductID);
                productForm.nameInput.Text = product.Name;
                productForm.inventoryInput.Value = product.InStock;
                productForm.priceInput.Text = Convert.ToString(product.Price);
                productForm.maxInput.Text = Convert.ToString(product.Max);
                productForm.minInput.Text = Convert.ToString(product.Min);

                AddProduct.modifyOrNew = 1;




                productForm.ShowDialog();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select something to modify");

            }
            //  this.Close();

        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            try
            {


                DataGridViewRow selectedRow = ProductsDGV.SelectedRows[0];
                var toDelete = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);
                Product prodToDelete = Inventory.lookupProduct(toDelete);
                Debug.WriteLine(prodToDelete.AssociatedParts.Count);
                if (prodToDelete.AssociatedParts.Count() > 0)
                {
                    MessageBox.Show("Cannot delete a product with associated Parts. Please remove them first.");

                    return;
                }
                else if (MessageBox.Show($"are you sure you want to delete {prodToDelete.Name}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Inventory.removeProduct(toDelete);
                    PartsDGV.DataSource = null;
                    PartsDGV.DataSource = Inventory.AllParts;

                    PartsDGV.Refresh();
                }


            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select something to delete.");
                return;
            }

        }
        private void button1_Click(object sender, EventArgs e) //Parts Search Button
        {
            PartsDGV.ClearSelection();
            bool result = false;

            for (int i = 0; i < Inventory.AllParts.Count; i++)

            {

                if (Inventory.AllParts[i].Name.ToUpper().Contains(searchInput.Text.ToUpper())) //should this iterate over the DGV instead? https://www.youtube.com/watch?v=JL30gSE3WaQ
                {
                    PartsDGV.Rows[i].Selected = true;
                    result = true;
                }



            }

            if (!result)
            {
                MessageBox.Show("Search returned no results.");
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void partsSearchButton_Click(object sender, EventArgs e)
        {
            ProductsDGV.ClearSelection();
            bool result = false;

            for (int i = 0; i < Inventory.Products.Count; i++)

            {

                if (Inventory.Products[i].Name.ToUpper().Contains(prodSearchInput.Text.ToUpper()))
                {
                    ProductsDGV.Rows[i].Selected = true;
                    result = true;
                }



            }

            if (!result)
            {
                MessageBox.Show("Search returned no results.");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
