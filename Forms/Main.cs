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
            PartsDGV.DataSource = Classes.Inventory.AllParts;
            formatDGV(ProductsDGV);
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
            this.Hide();
            Part part = new Part();
            Classes.Globals.partIsNew = true;
            part.idInput.Text = Convert.ToString(Classes.Inventory.GetNextPartID());
            part.ShowDialog();

        }


        private void buttonModifyPart_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (PartsDGV.CurrentRow.DataBoundItem.GetType() == typeof(Classes.Inhouse))
            {
                Classes.Inhouse inhouse = (Classes.Inhouse)PartsDGV.CurrentRow.DataBoundItem;
                new Part(inhouse).ShowDialog();
            }
            else
            {
                Classes.Outsourced outPart = (Classes.Outsourced)PartsDGV.CurrentRow.DataBoundItem;
                new Part().ShowDialog();
            }
        }



        private void modPart_Click(object sender, EventArgs e)
        {
            Classes.Globals.partIsNew = false;
            this.Hide();
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
                partForm.machineIDinput.Text = Convert.ToString(part.MachineID);


                partForm.ShowDialog();

                return;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select something to modify");
                return;
            }
            //if (PartsDGV.CurrentRow.Selected == false)

        }




        //private void modPart_Click(object sender, EventArgs e)
        //{
        //    Classes.Globals.partIsNew = false;

        //    {

        //        this.Hide();

        //        if (PartsDGV.CurrentRow.DataBoundItem.GetType() == typeof(Classes.Inhouse))
        //        {
        //            Classes.Inhouse inhouse = (Classes.Inhouse)PartsDGV.CurrentRow.DataBoundItem;
        //            DataGridViewRow selectedrow = PartsDGV.SelectedRows[0]; //  can i disable ctrl click so that multiple rows cant be slected?
        //            var partid = Convert.ToInt32(selectedrow.Cells["partid"].Value);
        //            Classes.Part part = Classes.Inventory.lookupPart(partid);
        //            Forms.Part partform = new Part();
        //            partform.idInput.Text = Convert.ToString(part.PartID);
        //            partform.nameInput.Text = part.Name;
        //            partform.inventoryInput.Text = Convert.ToString(part.InStock);
        //            partform.priceInput.Text = Convert.ToString(part.Price);
        //            partform.maxInput.Text = Convert.ToString(part.Max);
        //            partform.minInput.Text = Convert.ToString(part.Min);
        //           // partform.machineIDinput.Text = Classes.Inhouse.MachineID;
        //            new Part(inhouse).ShowDialog();

        //        }
        //        else
        //        {
        //            Classes.Outsourced outPart = (Classes.Outsourced)PartsDGV.CurrentRow.DataBoundItem;
        //            DataGridViewRow selectedrow = PartsDGV.SelectedRows[0]; //  can i disable ctrl click so that multiple rows cant be slected?
        //            var partid = Convert.ToInt32(selectedrow.Cells["partid"].Value);
        //            Classes.Part part = Classes.Inventory.lookupPart(partid);
        //            Forms.Part partform = new Part();
        //            partform.idInput.Text = Convert.ToString(part.PartID);
        //            partform.nameInput.Text = part.Name;
        //            partform.inventoryInput.Text = Convert.ToString(part.InStock);
        //            partform.priceInput.Text = Convert.ToString(part.Price);
        //            partform.maxInput.Text = Convert.ToString(part.Max);
        //            partform.minInput.Text = Convert.ToString(part.Min);
        //            new Part().ShowDialog();
        //        }
        //    }
        //}
        //        // this.Hide();



        //        //    partForm.ShowDialog();

        //        //    return;
        //        //} catch (ArgumentOutOfRangeException)
        //        //{
        //        //    MessageBox.Show("Please select something to modify");
        //        //    return;
        //        //}
        //        ////if (PartsDGV.CurrentRow.Selected == false)












        private void delPart_Click(object sender, EventArgs e)
        {
            try
            {


                DataGridViewRow selectedRow = PartsDGV.SelectedRows[0];
                var toDelete = Convert.ToInt32(selectedRow.Cells["PartID"].Value);
                Classes.Part partToDelete = Classes.Inventory.lookupPart(toDelete);

                if (MessageBox.Show($"are you sure you want to delete {partToDelete.Name}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Classes.Inventory.deletePart(partToDelete);
                    // probably a hack -  DGV index errors after deleting a row so im rebuilding the DGV to reflect the changes
                    PartsDGV.DataSource = null;
                    PartsDGV.DataSource = Classes.Inventory.AllParts;

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

        private void button3_Click(object sender, EventArgs e)
        {
            AddProduct addproduct = new();
            addproduct.IDinput.Text = Convert.ToString(Classes.Inventory.GetNextProductID());
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
            try
            {
                DataGridViewRow selectedRow = ProductsDGV.SelectedRows[0]; //  can i disable ctrl click so that multiple rows cant be slected?
                var productID = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);
                Forms.AddProduct.productID = productID;
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
                //  Debug.WriteLine(productForm.IDinput);
                // Classes.Globals.associatedPartsDGVIndex = Classes.Inventory.Products.IndexOf(product);
                //  Debug.WriteLine("Index is " + Classes.Globals.associatedPartsDGVIndex);
                Forms.AddProduct.modifyOrNew = 1;


                //foreach (Classes.Product each in Classes.Inventory.Products)
                //{
                //    Debug.WriteLine(each.Name);
                //    foreach (Classes.Part item in each.AssociatedParts)
                //    {
                //        Debug.WriteLine(item.Name);

                //    }
                //}

                // Debug.WriteLine("PRODUCT ID IS " + productForm.IDinput.Text);

                productForm.ShowDialog();
                this.Close();
                return;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select something to modify");
                return;
            }
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Parts Search Button
        {
            PartsDGV.ClearSelection();
            bool result = false;
        
            for (int i = 0; i < Classes.Inventory.AllParts.Count; i++)

            {
               
                if (Classes.Inventory.AllParts[i].Name.ToUpper().Contains(searchInput.Text.ToUpper())) //should this iterate over the DGV instead? https://www.youtube.com/watch?v=JL30gSE3WaQ
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

            for (int i = 0; i < Classes.Inventory.Products.Count; i++)

            {

                if (Classes.Inventory.Products[i].Name.ToUpper().Contains(prodSearchInput.Text.ToUpper())) 
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
    }
}
