using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace NHolbrook___IMS___Task1.Forms
{
    public partial class Part : Form
    {

        public Part()
        {
            
            InitializeComponent();

         
            buttonSave.Enabled = false;


        }

        public Part(Classes.Inhouse inPart)
        {
            InitializeComponent();

            idInput.Text = inPart.PartID.ToString();
            nameInput.Text = inPart.Name;
            inventoryInput.Text = inPart.InStock.ToString();
            priceInput.Text = inPart.Price.ToString();
            maxInput.Text = inPart.Max.ToString();
            minInput.Text = inPart.Min.ToString();
            machineIDinput.Text = inPart.MachineID.ToString();
        }

        public Part(Classes.Outsourced outsourced)
        {
            InitializeComponent();

            idInput.Text = outsourced.PartID.ToString(); ;
            nameInput.Text = outsourced.Name;
            inventoryInput.Text = outsourced.InStock.ToString(); ;
            priceInput.Text = outsourced.Price.ToString(); ;
            maxInput.Text = outsourced.Max.ToString(); ;
            minInput.Text = outsourced.Min.ToString(); ;
            machineIDinput.Text = outsourced.CompanyName;

            radioOutsourced.Checked = true;
        }
        public void SaveValidation(string s) {
            if (s.All(char.IsDigit) && (machineID.Text == "Machine ID") == false)
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
            new Main().ShowDialog();
        }

        private void radioInHouse_CheckedChanged(object sender, EventArgs e)
        {
    
            if (radioInHouse.Checked)
            {
                machineID.Text = "Machine ID";

            }
            else
            {
                machineIDinput.Clear();
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
            else {
                machineIDinput.Clear();

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
            //Debug.WriteLine(Convert.ToInt32(inventoryInput.Text));
            //if (String.IsNullOrWhiteSpace(inventoryInput.Text))
            //{
            //    inventoryInput.BackColor = Color.Coral;
            //    buttonSave.Enabled = false;

            //}
            
            
            if (inventoryInput.Text.All(char.IsDigit) == false)
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

            }else if (Convert.ToInt32(minInput.Text) > Convert.ToInt32(maxInput.Text)){
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
            else if (machineID.Text == "Machine ID")
            {
                if (machineIDinput.Text.All(char.IsDigit) == false)
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

            else
            {
                machineIDinput.BackColor = Color.White;
                SaveValidation(machineIDinput.Text);
            }


        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.Hide();
       
        

            if (Classes.Globals.partIsNew)
            {
                if (radioInHouse.Checked)
                {
                    Classes.Inventory.addPart(new Classes.Inhouse(
                                      (Classes.Inventory.AllParts.Count + 1),
                                      nameInput.Text,
                                      Convert.ToDouble(priceInput.Text),
                                      Convert.ToInt32(inventoryInput.Text),
                                      Convert.ToInt32(minInput.Text),
                                      Convert.ToInt32(maxInput.Text),
                                      Convert.ToInt32(machineIDinput.Text)));
                                      
                }
  
                else
                {
                    if (radioOutsourced.Checked)
                    {
                        Classes.Inventory.addPart(new Classes.Outsourced(
                                          (Classes.Inventory.AllParts.Count + 1),
                                          nameInput.Text,
                                          Convert.ToDouble(priceInput.Text),
                                          Convert.ToInt32(inventoryInput.Text),
                                          Convert.ToInt32(minInput.Text),
                                          Convert.ToInt32(maxInput.Text),
                                          machineIDinput.Text));

                    }
                }
            } else

            {
                bool isChangingType = Classes.Inventory.SourceChange(Convert.ToInt32(idInput.Text));
                if (radioInHouse.Checked & isChangingType == true)
                {
                    int index = Convert.ToInt32(idInput.Text);

                    Classes.Inhouse replacementObject = new Classes.Inhouse(
                                        Convert.ToInt32(idInput.Text),
                                       nameInput.Text,
                                       Convert.ToDouble(priceInput.Text),
                                       Convert.ToInt32(inventoryInput.Text),
                                       Convert.ToInt32(minInput.Text),
                                       Convert.ToInt32(maxInput.Text),
                                       Convert.ToInt32(machineIDinput.Text));


                    Classes.Inventory.addPart(replacementObject, index );
                                       
           
                }

                else if (radioOutsourced.Checked & isChangingType == false){
                    int index = Convert.ToInt32(idInput.Text);

                    Classes.Outsourced replacementObject = new Classes.Outsourced(
                                        Convert.ToInt32(idInput.Text),
                                       nameInput.Text,
                                       Convert.ToDouble(priceInput.Text),
                                       Convert.ToInt32(inventoryInput.Text),
                                       Convert.ToInt32(minInput.Text),
                                       Convert.ToInt32(maxInput.Text),
                                       machineIDinput.Text);

                    Classes.Inventory.addPart(replacementObject, index);
                }
              



                {
                    if (radioOutsourced.Checked)
                    {
                        Classes.Inventory.UpdateOutsourced(Convert.ToInt32(idInput.Text), new Classes.Outsourced(
                                         (Classes.Inventory.AllParts.Count),
                                          nameInput.Text,
                                          Convert.ToDouble(priceInput.Text),
                                          Convert.ToInt32(inventoryInput.Text),
                                          Convert.ToInt32(minInput.Text),
                                          Convert.ToInt32(maxInput.Text),
                                          machineIDinput.Text)
                                          );

          
                   
                    }
                }

                

            }

            if (Convert.ToInt32(minInput.Text) > Convert.ToInt32(maxInput.Text))
            {
                MessageBox.Show("Error: Minimum cannot exceed maximum");
                this.Show();
            }
            else if (Convert.ToInt32(inventoryInput.Text) < Convert.ToInt32(minInput.Text))
            {
                MessageBox.Show("Inventory value must be between Min and Max values");
                this.Show();
            }


            else
            {
                Main main = new Main();
                main.Refresh();
                main.Show();
            }

               


        }

        private void idInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Part_Load(object sender, EventArgs e)
        {
            if (Classes.Inventory.SourceChange(Convert.ToInt32(idInput.Text)) is true) //TRUE FOR OUTSOURCED
            {
                radioOutsourced.Checked = true;
                machineID.Text = "Company Name";
                
                machineIDinput.BackColor = Color.White;
                
            }
        }
    }
}
