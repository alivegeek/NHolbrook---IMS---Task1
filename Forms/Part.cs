using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHolbrook___IMS___Task1.Forms
{
    public partial class Part : Form
    {
        public Part()
        {

            InitializeComponent();

           
            buttonSave.Enabled = false;
          

        }



        public void SaveValidation(string s) {
            if (s.All(char.IsDigit) == false)
            {
                buttonSave.Enabled = false;

                return;
            }
        
            if (String.IsNullOrWhiteSpace(nameInput.Text) == false ||
               String.IsNullOrWhiteSpace(inventoryInput.Text) == false ||
                String.IsNullOrWhiteSpace(priceInput.Text) == false ||
                String.IsNullOrWhiteSpace(maxInput.Text) == false ||
                String.IsNullOrWhiteSpace(minInput.Text) == false ||
                String.IsNullOrWhiteSpace(machineIDinput.Text) == false 
)           
            {
               
                buttonSave.Enabled = true;
               
                return;
                
            }
            else
            {
                buttonSave.Enabled = false;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void radioInHouse_CheckedChanged(object sender, EventArgs e)
        {
            // set value = 1 
            // if value == 1 stuff.hide and otherstuff.show
            // else stuff.show and otherstuff.hide
            if (radioInHouse.Checked)
            {
                machineID.Text = "Machine ID";


            }

            //check to see if fields are blank

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
            if (String.IsNullOrWhiteSpace(machineIDinput.Text))
            {
                machineIDinput.BackColor = Color.Coral;
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void companyName_Click(object sender, EventArgs e)
        {

        }

        private void radioOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOutsourced.Checked)
            {
                machineID.Text = "Company Name";
            }

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

        private void inventoryInput_TextChanged(object sender, EventArgs e)
        {
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
            else if (priceInput.Text.All(char.IsDigit) == false)
            {
                buttonSave.Enabled = false;
                priceInput.BackColor = Color.Coral;
            }
            else
            {
                priceInput.BackColor = Color.White;
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

        private void machineIDinput_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(machineIDinput.Text))
            {
                machineIDinput.BackColor = Color.Coral;
                buttonSave.Enabled = false;

            }
            else if (machineIDinput.Text.All(char.IsDigit) == false)
            {
                buttonSave.Enabled = false;
                machineIDinput.BackColor = Color.Coral;
            }
            else
            {
                machineIDinput.BackColor = Color.White;
                SaveValidation(machineIDinput.Text);
            }
            

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (radioInHouse.Checked)
            {
                Classes.Inventory.addPart(new Classes.Inhouse(
                             //     12, //FIX THIS, need to get ID
                                  nameInput.Text,
                                  Convert.ToDouble(priceInput.Text),
                                  Convert.ToInt32(inventoryInput.Text),
                                  Convert.ToInt32(minInput.Text),
                                  Convert.ToInt32(maxInput.Text),
                                  Convert.ToInt32(machineIDinput.Text)));

            }
            //public Part(int partID, string name, double price, int inStock, int min, int max)
            //Inhouse(int partID, string name, double price, int inStock, int min, int max, int machineID)
           // :base(partID, name, price, inStock, min, max)
            else
            {

            }
           //fix this, i want to update the old form now show a new one.!
            Main main = new Main();
            main.ShowDialog();
            this.Close();

           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
