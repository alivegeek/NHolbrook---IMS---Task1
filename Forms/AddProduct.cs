using NHolbrook___IMS___Task1.Classes;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NHolbrook___IMS___Task1.Forms

{
    public partial class AddProduct : Form
    {
        public static int modifyOrNew = 0;
        public static int productID;
        private static BindingList<Classes.Part> holdingAreaParts = new BindingList<Classes.Part>();
        //  List<int> associatedPartIDs = new  List<int>();



        private BindingList<Classes.Part> DGVAssoParts = new BindingList<Classes.Part>();




        public AddProduct()

        {

            InitializeComponent();
            //populate DGV


            inventoryInput.Controls[0].Visible = false;

            allCandidatePartsDGV.DataSource = Inventory.AllParts;
            associatedPartsDGV.DataSource = holdingAreaParts;





            if (String.IsNullOrWhiteSpace(nameInput.Text))
            {
                nameInput.BackColor = Color.Coral;
            }
            if (String.IsNullOrWhiteSpace(inventoryInput.Text))
            {
                inventoryInput.BackColor = Color.Coral;
            }
            if (String.IsNullOrWhiteSpace(priceInput.Text.Replace("$", "")))
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


        // public void colorField(String inputName)
        //{
        //     // Turn blank field red

        //     switch (inputName)
        //     {
        //         case "Name":
        //        if (String.IsNullOrEmpty(nameInput.Text) || String.IsNullOrWhiteSpace(nameInput.Text))
        //                 nameInput.BackColor = Color.Coral;
        //             else
        //             {
        //                 nameInput.BackColor = Color.White;

        //             }
        //             break;

        //         case "Inventory":
        //             inventoryInput.BackColor = Color.Coral;
        //             break;

        //         case "Price":
        //             priceInput.BackColor = Color.Coral;
        //             break;


        //         case "Min":
        //             minInput.BackColor = Color.Coral;
        //             break;

        //         case "Max":
        //             maxInput.BackColor = Color.Coral;
        //             break;

        //         case "AssociatedParts":
        //             MessageBox.Show("Product must contain atleast one associated part.");
        //             break;
        //         default:
        //             buttonSave.Enabled = true;
        //             nameInput.BackColor = Color.White;
        //             inventoryInput.BackColor = Color.White;
        //             minInput.BackColor = Color.White;
        //             maxInput.BackColor = Color.White;

        //             break;
        //     }
        // }

        public bool CanSave()
        {
            //if all the things look good enable save button
            return true;
        }
        public bool InputValidation()
        {
            int total = 0;

            // name 
            if (String.IsNullOrEmpty(nameInput.Text) || String.IsNullOrWhiteSpace(nameInput.Text))
            {
                buttonSave.Enabled = false;
                nameInput.BackColor = Color.Coral;
            }
            else
            {
                nameInput.BackColor = Color.White;
                total++;

            }

            //inventory
            try
            {
                if (Enumerable.Range(Convert.ToInt32(minInput.Text), Convert.ToInt32(maxInput.Text)).Contains(Convert.ToInt32(inventoryInput.Value)))

                {
                    inventoryInput.BackColor = Color.White;
                    total++;


                }
                else if (String.IsNullOrEmpty(Convert.ToString(inventoryInput.Value)) || String.IsNullOrEmpty(Convert.ToString(inventoryInput.Value)))
                {
                    buttonSave.Enabled = false;
                    inventoryInput.BackColor = Color.Coral;

                }
                else
                {
                    inventoryInput.BackColor = Color.Coral;
                    buttonSave.Enabled = false;

                }
            }
            catch { }

            //Price is mostly handled in its changed event
            if (String.IsNullOrEmpty(priceInput.Text) || String.IsNullOrWhiteSpace(priceInput.Text))
            {
                buttonSave.Enabled = false;
                priceInput.BackColor = Color.Coral;

            }

            //Min and Max
            try
            {
                if (Convert.ToInt32(maxInput.Text) < Convert.ToInt32(minInput.Text))
                {
                    minInput.BackColor = Color.Coral;
                    maxInput.BackColor = Color.Coral;

                }
                else
                {
                    minInput.BackColor = Color.White;
                    maxInput.BackColor = Color.White;
                    total++;

                }
            }
            catch { }

            // Associated Parts cannot be blank
            if (holdingAreaParts.Count == 0)
            {
                associatedPartsDGV.BackgroundColor = Color.Coral;
            }
            else
            {
                associatedPartsDGV.BackgroundColor = Color.White;
               // total++;
            }

            CanSave();
            if (total == 3)
            {
                buttonSave.Enabled = true;
                return true;
            }
            else
            {
                buttonSave.Enabled = false;
                return false;
            }


            //// do not allow a part to be safed with associated parts and no name
            //if (String.IsNullOrEmpty(nameInput.Text) || String.IsNullOrWhiteSpace(nameInput.Text))
            //{
            //    buttonSave.Enabled = false;
            //}

            //Dictionary<string, string> data = new Dictionary<string, string>() { { "Name", nameInput.Text }, { "Inventory", inventoryInput.Text }, { "Price", priceInput.Text.Replace("$", "") }, { "Min", minInput.Text }, { "Max", maxInput.Text } };
            ////check for null blank and non alphanum characters
            //foreach (KeyValuePair<string, string> item in data)
            //{
            //    if (String.IsNullOrEmpty(item.Value) || String.IsNullOrWhiteSpace(item.Value))
            //    {
            //        buttonSave.Enabled = false;
            //        String field = item.Key;
            //        colorField(field);

            //    }
            //    //Check for non alphanum characters
            //    foreach (KeyValuePair<string, string> item2 in data)
            //    {
            //        foreach (Char x in item2.Value)
            //        {
            //            if (item2.Key == "Price")
            //            {

            //            }    
            //            else if (!Char.IsLetterOrDigit(x))
            //            {
            //                colorField(item2.Key);
            //            }
            //        }
            //    }


            //    //Switch statement for specifics of each input field.

            //    foreach (KeyValuePair<string, string> entry in data)
            //    {
            //        switch (entry.Key)
            //        {
            //            case "Name":
            //                goto case "Inventory";

            //            case "Inventory":
            //                try
            //                {
            //                    if (Convert.ToInt32(inventoryInput.Text) < Convert.ToInt32(minInput.Text) || Convert.ToInt32(inventoryInput.Value) > Convert.ToInt32(maxInput.Text))
            //                    {
            //                        colorField(entry.Value);
            //                        Debug.WriteLine(entry.Value);
            //                    }
            //                    goto case "Min";
            //                }
            //                catch
            //                {
            //                    goto case "Min";
            //                }



            //            case "Price":

            //                goto case "Min";
            //            //See Price event moved due to complexity (to be fancy)

            //            case "Min":
            //                try
            //                {
            //                    if (Convert.ToInt32(Convert.ToInt32(maxInput.Text)) < Convert.ToInt32(minInput.Text))
            //                    {
            //                        colorField(entry.Value);

            //                    }
            //                    goto case "AssociatedParts";
            //                }
            //                catch { goto case "AssociatedParts"; }
            //            case "Max":
            //                goto default;
            //            case "AssociatedParts":

            //                break;

            //            default:
            //                buttonSave.Enabled = true;


            //                    break;

            //        }
            //    }

            //switch (inputType)

            //{

            //    case "priceInput":

            //        return true;
            //        break

            //    case 'Inventory':



            //}
        }


        //public void SaveValidation(string s)
        //{
        //    if (s.All(char.IsDigit) == false)
        //    {
        //        buttonSave.Enabled = false;

        //        return;
        //    }

        //    if (String.IsNullOrWhiteSpace(nameInput.Text) == false ||
        //       String.IsNullOrWhiteSpace(inventoryInput.Text) == false ||
        //        String.IsNullOrWhiteSpace(priceInput.Text.Replace("$", "")) == false ||
        //        String.IsNullOrWhiteSpace(maxInput.Text) == false ||
        //        String.IsNullOrWhiteSpace(minInput.Text) == false)

        //    {

        //        buttonSave.Enabled = true;

        //        return;

        //    }
        //    else
        //    {
        //        buttonSave.Enabled = false;
        //    }

        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IDinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameInput_TextChanged(object sender, EventArgs e)
        {
            InputValidation();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //if (HasSpecialChars(priceInput.Text) is true)
            //{
            //    buttonSave.Enabled = false;
            //    priceInput.BackColor = Color.Coral;
            //    MessageBox.Show("The price input field must be in USD Currency Format and cannot contain any alpha or special characters");
            //    return;
            //}
            if (inventoryInput.Text == "")
            {
                // If the value in the numeric updown is an empty string, replace with 0.
                inventoryInput.Text = "0";
            }

            bool IV = InputValidation();
            if (IV is false)
            {
                MessageBox.Show("Please check that all fields are completed correctly and try again.");
                return;
            }
            this.Hide();

            // if its blank prompt user
            if (String.IsNullOrWhiteSpace(nameInput.Text) ||
                String.IsNullOrWhiteSpace(Convert.ToString(inventoryInput.Value)) ||
                String.IsNullOrWhiteSpace(priceInput.Text) ||
                String.IsNullOrWhiteSpace(minInput.Text) ||
                String.IsNullOrWhiteSpace(maxInput.Text) ||
                String.IsNullOrEmpty(nameInput.Text) ||
                String.IsNullOrEmpty(Convert.ToString(inventoryInput.Value)) ||
                String.IsNullOrEmpty(priceInput.Text) ||
                String.IsNullOrEmpty(minInput.Text) ||
                String.IsNullOrEmpty(maxInput.Text))
            {
                MessageBox.Show("Please fill out all fields. May not be empty.");
                InputValidation();
                return;
            }

            if (Convert.ToInt32(maxInput.Text) < Convert.ToInt32(minInput.Text))
            {
                MessageBox.Show("Max cannot be less than Min");
                this.Show();
                return;
            }
            else if (Enumerable.Range(Convert.ToInt32(minInput.Text), Convert.ToInt32(maxInput.Text)).Contains(Convert.ToInt32(inventoryInput.Text)) == false)
            {
                MessageBox.Show("Inventory must be between Min and Max values.");
                this.Show();
                return;
            }





            if (associatedPartsDGV.RowCount == 0 && modifyOrNew == 0) // and product is new
            {
                MessageBox.Show("Product must contain atleast one associated part.");
                this.Show();

                return;
            }

            else if (Convert.ToInt32(maxInput.Text) < Convert.ToInt32(minInput.Text))
            {
                MessageBox.Show("Max cannot be less than Min");
                this.Show();

                return;
            }


            else
            {
                Product updatedProduct = new Product(Convert.ToInt32(IDinput.Text), nameInput.Text, Convert.ToDouble(priceInput.Text.Replace("$", "").Replace("$", "")), Convert.ToInt32(inventoryInput.Text), Convert.ToInt32(minInput.Text), Convert.ToInt32(maxInput.Text));

                //foreach (Classes.Part part in DGVAssoParts)
                //{
                //    updatedProduct.AssociatedParts.Add(part);
                //}
                //   Classes.Product productObject = Classes.Inventory.lookupProduct(Convert.ToInt32(IDinput.Text));
                foreach (Classes.Part part in DGVAssoParts)
                {
                    Debug.WriteLine(part.Name);
                    updatedProduct.AddAssociatedPart(part);
                    Debug.WriteLine("Product name" + updatedProduct.Name);
                    foreach (Classes.Part x in updatedProduct.AssociatedParts)
                    {
                        Debug.WriteLine(x.Name);


                    }

                    // updatedProduct.AssociatedParts.Add(part);
                }
                Inventory.updateProduct(Convert.ToInt32(IDinput.Text), updatedProduct);

                if (Convert.ToInt32(maxInput.Text) < Convert.ToInt32(minInput.Text))
                {
                    MessageBox.Show("Your minimum exceeds your maximum.");
                }
                else if (modifyOrNew == 1) //modify
                {
                    //lookup the newly made product make a product object
                    Product thatNewProd = Inventory.lookupProduct(Convert.ToInt32(IDinput.Text));
                    //update that objects properties

                    //{
                    //    if (each.ProductID == Convert.ToInt32(IDinput.Text)) //was productID?
                    //    {
                    thatNewProd.Name = nameInput.Text;
                    thatNewProd.Price = Convert.ToDouble(priceInput.Text.Replace("$", ""));
                    thatNewProd.InStock = Convert.ToInt32(inventoryInput.Text);
                    thatNewProd.Min = Convert.ToInt32(minInput.Text);
                    thatNewProd.Max = Convert.ToInt32(maxInput.Text);

                    foreach (Classes.Part part in holdingAreaParts)
                    {
                        Classes.Product workingProduct = Inventory.lookupProduct(Convert.ToInt32(IDinput.Text));
                        workingProduct.AddAssociatedPart(part);

                    }
                    //    }
                    //}
                    //this.Hide();

                    Main main = new Main();
                    main.ShowDialog();
                    return;

                }


                else
                {
                    Inventory.addProduct(new Product(
                                      nameInput.Text,
                                      Convert.ToDouble(priceInput.Text.Replace("$", "")),
                                      Convert.ToInt32(inventoryInput.Text),
                                      Convert.ToInt32(minInput.Text),
                                      Convert.ToInt32(maxInput.Text)));
                    //commit parts from holding area
                    foreach (Classes.Part part in holdingAreaParts)
                    {
                        Classes.Product workingProduct = Inventory.lookupProduct(Convert.ToInt32(IDinput.Text));
                        workingProduct.AddAssociatedPart(part);

                    }

                    this.Close();

                    Main main = new Main();
                    main.Show();

                }
            }
        }



        //private void inventoryInput_TextChanged(object sender, EventArgs e)
        //{


        //    SaveValidation(Convert.ToString(inventoryInput));

        //    if (String.IsNullOrWhiteSpace(inventoryInput.Text))
        //    {
        //        inventoryInput.BackColor = Color.Coral;
        //        buttonSave.Enabled = false;

        //    }
        //    else if (inventoryInput.Text.All(char.IsDigit) == false)
        //    {
        //        buttonSave.Enabled = false;
        //        inventoryInput.BackColor = Color.Coral;
        //    }

        //    else if (Convert.ToInt32(inventoryInput.Value) > Convert.ToInt32(minInput.Text))
        //    {
        //        inventoryInput.BackColor = Color.White;
        //        buttonSave.Enabled = true;
        //    }


        //    else
        //    {
        //        inventoryInput.BackColor = Color.White;
        //        //   buttonSave.Enabled = true;
        //    }
        //}
        private bool HasSpecialChars(string aString)
        {
            var regexItem = new Regex("^[a-zA-Z0-9 ]*");

            if (regexItem.IsMatch(aString)) { return true; }
            else { return false; }
        }

        private bool TextisValid(string text) //Regex for USD Currenvy
        {
            Regex money = new Regex(@"^\$(\d{1,3}(\,\d{3})*|(\d+))(\.\d{2})?$");
            return money.IsMatch(text);
        }

        private void priceInput_TextChanged(object sender, EventArgs e)
        {
            if (HasSpecialChars(priceInput.Text) is true)
            {
                buttonSave.Enabled = false;
                priceInput.BackColor = Color.Coral;
            }
            //Remove previous formatting, or the decimal check will fail including leading zeros
            string value = priceInput.Text.Replace("$", "").Replace(",", "")
                .Replace("$", "").Replace(".", "").TrimStart('0');
            decimal ul;
            //Check we are indeed handling a number
            if (decimal.TryParse(value, out ul))
            {
                ul /= 100;
                //Unsub the event so we don't enter a loop
                priceInput.TextChanged -= priceInput_TextChanged;
                //Format the text as currency
                //priceInput.Text = string.Format(CultureInfo.CreateSpecificCulture("en-US"), "{0:C2}", ul);
               // priceInput.TextChanged += priceInput_TextChanged;
                //priceInput.Select(priceInput.Text.Replace("$", "").Length, 0);
            }
            bool goodToGo = TextisValid(priceInput.Text.Replace("$", ""));
            buttonSave.Enabled = goodToGo;
            if (!goodToGo)
            {
                // priceInput.Text = "$0.00";
                priceInput.Select(priceInput.Text.Replace("$", "").Length, 0);
            }



            buttonSave.Enabled = true;
            priceInput.BackColor = Color.White;
            //if (String.IsNullOrWhiteSpace(priceInput.Text.Replace("$", "")))
            //{
            //    priceInput.BackColor = Color.Coral;
            //    buttonSave.Enabled = false;

            //}
            ////else if (priceInput.Text.Replace("$", "").All(char.IsDigit) == false)
            //else if (double.TryParse(priceInput.Text.Replace("$", ""), out double x))
            //{
            //    buttonSave.Enabled = true;
            //    priceInput.BackColor = Color.White;

            //}
            //else
            //{
            //    priceInput.BackColor = Color.Coral;
            //    SaveValidation(priceInput.Text.Replace("$", ""));
            //}
            //if (Regex.IsMatch(priceInput.Text.Replace("$", ""), @"\.\d\d"))
            //{

            //}

        }

        private void maxInput_TextChanged(object sender, EventArgs e)
        {

            InputValidation();

        }

        private void minInput_TextChanged(object sender, EventArgs e)
        {

            InputValidation();


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
            Classes.Part part = Inventory.lookupPart(partID);
            //DGVAssoParts.Add(part);
            InputValidation();

            holdingAreaParts.Add(part); //in case of cancel, use this data to clean up DGVAssoParts (See CalcenButton)


        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {


                DataGridViewRow selectedRow = associatedPartsDGV.SelectedRows[0];
                var partID = Convert.ToInt32(selectedRow.Cells["PartID"].Value);
                var partToDelete = lookupPart(partID); //change to lookupAssoPart
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

            Debug.WriteLine("Here are some " + associatedPartsDGV);
            Debug.WriteLine(DGVAssoParts);
            associatedPartsDGV.Rows.Clear();
            associatedPartsDGV.Refresh();
            buttonSave.Enabled = false;
            if (modifyOrNew == 1)

            {

                Product prod = Inventory.lookupProduct(productID);
                Debug.WriteLine("There are " + prod.AssociatedParts.Count() + " associated parts with this product");
                foreach (Classes.Part part in prod.AssociatedParts)
                {
                    Debug.WriteLine("Loading Parts into AssociatedParts DGV");
                    holdingAreaParts.Add(part);
                    Debug.WriteLine(part.Name);

                }
            }
            else
            {
                minInput.Text = "0";
                maxInput.Text = "0";
                inventoryInput.Value = 0;
                priceInput.Text = "0";
                priceInput.SelectionStart = priceInput.Text.Replace("$", "").Length;


            }
            InputValidation();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            foreach (Classes.Part part in holdingAreaParts)
            {
                if (DGVAssoParts.Contains(part))
                {
                    Debug.WriteLine("Removing" + part.Name);
                    DGVAssoParts.Remove(part);

                }
            }
            this.Hide();
            Main main = new Main();

            main.ShowDialog();


        }

        private Classes.Part lookupPart(int partID)
        {
            foreach (Classes.Part x in holdingAreaParts)

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
                holdingAreaParts.Remove(lookupPart(part.PartID));

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            InputValidation();
            if (inventoryInput.Text == "")
            {
                // If the value in the numeric updown is an empty string, replace with 0.
                inventoryInput.Text = "0";
            }
        }
        //SaveValidation(Convert.ToString(inventoryInput));

        //if (String.IsNullOrWhiteSpace(inventoryInput.Text))
        //{
        //    inventoryInput.BackColor = Color.Coral;
        //    buttonSave.Enabled = false;

        //}
        //else if (inventoryInput.Text.All(char.IsDigit) == false)
        //{
        //    buttonSave.Enabled = false;
        //    inventoryInput.BackColor = Color.Coral;
        //}
        //}else if (Convert.ToInt32(inventoryInput.Value) < Convert.ToInt32(minInput.Text) || Convert.ToInt32(inventoryInput.Value) > Convert.ToInt32(maxInput.Text))
        //{
        //    inventoryInput.BackColor = Color.Coral;

        //}

        //else if (Convert.ToInt32(inventoryInput.Value) > Convert.ToInt32(minInput.Text))
        //{
        //    inventoryInput.BackColor = Color.White;
        //    buttonSave.Enabled = true;



        //    else
        //    {
        //        inventoryInput.BackColor = Color.White;
        //        buttonSave.Enabled = true;
        //    }
        //}
        private void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            InputValidation();
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            InputValidation();
        }

        private void associatedPartsDGV_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            InputValidation();
        }

        private void associatedPartsDGV_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            InputValidation();

        }
        private void DebugThis(Product product)
        {

            foreach (Classes.Part item in product.AssociatedParts)
            {
                Debug.WriteLine(item.Name);
            }
        }

        private void AddProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            //associatedPartsDGV.DataSource = null;
            //associatedPartsDGV.Rows.Clear();
            //associatedPartsDGV.Refresh();
        }

        private void AddProduct_Leave(object sender, EventArgs e)
        {
            modifyOrNew = 0;
            //associatedPartsDGV.DataSource = null;
            //associatedPartsDGV.Rows.Clear();
            //associatedPartsDGV.Refresh();
        }

        private void associatedPartsDGV_RowsRemoved_1(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            InputValidation();
        }

        private void associatedPartsDGV_RowsAdded_1(object sender, DataGridViewRowsAddedEventArgs e)
        {
            InputValidation();
        }

        private void inventoryInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation();
        }

        private void inventoryInput_MouseUp(object sender, MouseEventArgs e)
        {
            InputValidation();

        }

        private void inventoryInput_RightToLeftChanged(object sender, EventArgs e)
        {
            InputValidation();
        }

        private void AddProduct_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void AddProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void AddProduct_CursorChanged(object sender, EventArgs e)
        {
            InputValidation();
        }

        private void AddProduct_TextChanged(object sender, EventArgs e)
        {
            InputValidation();
        }
    }
}
