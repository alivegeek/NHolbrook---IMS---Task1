using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;
namespace NHolbrook___IMS___Task1.Forms

{
    public partial class AddProduct : Form
    {
        public static int modifyOrNew = 0;
        public static int productID;
        private static List<Classes.Part> holdingAreaParts = new List<Classes.Part>();
        //  List<int> associatedPartIDs = new  List<int>();
        private static BindingList<Classes.Part> DGVAssoParts = new BindingList<Classes.Part>();
        public AddProduct()

        {

            InitializeComponent();



            allCandidatePartsDGV.DataSource = Classes.Inventory.AllParts;
            associatedPartsDGV.DataSource = DGVAssoParts;


            if (String.IsNullOrWhiteSpace(nameInput.Text))
            {
                nameInput.BackColor = Color.Coral;
            }
            if (String.IsNullOrWhiteSpace(inventoryInput.Text))
            {
                inventoryInput.BackColor = Color.Coral;
            }
            if (String.IsNullOrWhiteSpace(priceInput.Text))
            {
                priceInput.BackColor = Color.Coral;
            }
            if (String.IsNullOrWhiteSpace(minInput.Text))
            {
                minInput.BackColor = Color.Coral;
            }
            if (String.IsNullOrWhiteSpace(maxInput.Text))
            {
                maxInput.BackColor = Color.Coral;
            }


        }
    

        public void SaveValidation(string s)
        {
            if (s.All(char.IsDigit) == false)
            {
                buttonSave.Enabled = false;

                return;
            }

            if (String.IsNullOrWhiteSpace(nameInput.Text) == false ||
               String.IsNullOrWhiteSpace(inventoryInput.Text) == false ||
                String.IsNullOrWhiteSpace(priceInput.Text) == false ||
                String.IsNullOrWhiteSpace(maxInput.Text) == false ||
                String.IsNullOrWhiteSpace(minInput.Text) == false) 

            {

                buttonSave.Enabled = true;

                return;

            }
            else
            {
                buttonSave.Enabled = false;
            }
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IDinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameInput_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(nameInput.Text))
            {
                nameInput.BackColor = Color.Coral;
                buttonSave.Enabled = false;

            }
            else
            {
                nameInput.BackColor = Color.White;
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (associatedPartsDGV.RowCount == 0)
            {
                MessageBox.Show("Product must contain atleast one associated part.");
                return;
            }

            else if (Convert.ToInt32(maxInput.Text) < Convert.ToInt32(minInput.Text)) 
            {
                MessageBox.Show("Max cannot be less than Min");
                return;
            }
            
          
            else
            {
                Classes.Product updatedProduct = new Classes.Product(Convert.ToInt32(IDinput.Text), nameInput.Text, Convert.ToDouble(priceInput.Text), Convert.ToInt32(inventoryInput.Text), Convert.ToInt32(minInput.Text), Convert.ToInt32(maxInput.Text));

                foreach (Classes.Part part in DGVAssoParts)
                {
                    updatedProduct.AssociatedParts.Add(part);
                }
                Classes.Product productObject = Classes.Inventory.lookupProduct(Convert.ToInt32(IDinput.Text));
                foreach (Classes.Part part in DGVAssoParts)
                {
                    productObject.AssociatedParts.Add(part);
                }
                this.Hide();
                if (Convert.ToInt32(maxInput.Text) < Convert.ToInt32(minInput.Text))
                {
                    MessageBox.Show("Your minimum exceeds your maximum.");
                }
                else if (modifyOrNew == 1) //modify
                {
                    foreach (var each in Classes.Inventory.Products)
                    {
                        if (each.ProductID == productID)
                        {
                            each.Name = nameInput.Text;
                            each.Price = Convert.ToDouble(priceInput.Text);
                            each.InStock = Convert.ToInt32(inventoryInput.Text);
                            each.Min = Convert.ToInt32(minInput.Text);
                            each.Max = Convert.ToInt32(maxInput.Text);


                        }
                    }
                    this.Hide();

                    Main main = new Main();
                    main.ShowDialog();
                    return;

                }


                else
                {
                    Classes.Inventory.addProduct(new Classes.Product(
                                      nameInput.Text,
                                      Convert.ToDouble(priceInput.Text),
                                      Convert.ToInt32(inventoryInput.Text),
                                      Convert.ToInt32(minInput.Text),
                                      Convert.ToInt32(maxInput.Text)));
                    this.Close();

                    Main main = new Main();


                }
            }
        }

        private void inventoryInput_TextChanged(object sender, EventArgs e)
        {
            SaveValidation(Convert.ToString(inventoryInput));
            if (String.IsNullOrWhiteSpace(inventoryInput.Text))
            {
                inventoryInput.BackColor = Color.Coral;
                buttonSave.Enabled = false;

            }
            else if (inventoryInput.Text.All(char.IsDigit) == false)
            {
                buttonSave.Enabled = false;
                inventoryInput.BackColor = Color.Coral;
            }



            else
            {
                inventoryInput.BackColor = Color.White;
            }



        }

        private void priceInput_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(priceInput.Text))
            {
                priceInput.BackColor = Color.Coral;
                buttonSave.Enabled = false;

            }
            //else if (priceInput.Text.All(char.IsDigit) == false)
            else if (double.TryParse(priceInput.Text, out double x))
            {
                buttonSave.Enabled = true;
                priceInput.BackColor = Color.White;

            }
            else
            {
                priceInput.BackColor = Color.Coral;
                SaveValidation(priceInput.Text);
            }

        }

        private void maxInput_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(maxInput.Text))
            {
                maxInput.BackColor = Color.Coral;
                buttonSave.Enabled = false;

            }
            else if (maxInput.Text.All(char.IsDigit) == false)
            {
                buttonSave.Enabled = false;
                maxInput.BackColor = Color.Coral;
            }
            else
            {
                maxInput.BackColor = Color.White;
                SaveValidation(maxInput.Text);
            }


        }

        private void minInput_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(minInput.Text))
            {
                minInput.BackColor = Color.Coral;
                buttonSave.Enabled = false;

            }
            else if (minInput.Text.All(char.IsDigit) == false)
            {
                buttonSave.Enabled = false;
                minInput.BackColor = Color.Coral;
            }
            else
            {
                minInput.BackColor = Color.White;
                SaveValidation(minInput.Text);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            return;
        }

        private void associatedPartsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
            
        }

        private void addPartsButtoni_Click(object sender, EventArgs e)
        {

           // Classes.Product prodToAsso = AssociatedPartsDGVhelper();
                DataGridViewRow selectedRow = allCandidatePartsDGV.SelectedRows[0];
                var partID = Convert.ToInt32(selectedRow.Cells["PartID"].Value);
            Classes.Part part = Classes.Inventory.lookupPart(partID);
            DGVAssoParts.Add(part);
            holdingAreaParts.Add(part);

     
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {


                DataGridViewRow selectedRow = associatedPartsDGV.SelectedRows[0]; //  can i disable ctrl click so that multiple rows cant be slected?
                var partID = Convert.ToInt32(selectedRow.Cells["PartID"].Value);
                var partToDelete = lookupPart(partID);
                if (MessageBox.Show($"are you sure you want to delete {partToDelete.Name}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    deletePart(partToDelete);
                }


            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select something to delete.");
                return;
            }
           
          
            
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            foreach(Classes.Part part in holdingAreaParts)
            {    
                if (DGVAssoParts.Contains(part)){
                    DGVAssoParts.Remove(part);
                }
            }
            this.Hide();
            Main main = new Main();

            main.ShowDialog();


        }

        private  Classes.Part lookupPart(int partID)
        {
            foreach (Classes.Part x in DGVAssoParts)

            {
                if (x.PartID == partID)
                {
                    return x;
                }
            }
            return null;
        }

        private bool deletePart(Classes.Part part)
        {
            try
            {
                DGVAssoParts.Remove(lookupPart(part.PartID));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
