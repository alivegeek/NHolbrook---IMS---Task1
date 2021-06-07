using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace NHolbrook___IMS___Task1.Classes

{
    public class Inventory
    {
        //create lists from Inventory UML
        public static List<Product> Products = new List<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();


        //Initalize variables for incrementing productIDs.


        private static int nextPartID = AllParts.Count;
        private static int nextProductID = 0; //Products.Count;



        public static int GetNextPartID() {
            return nextPartID++;
        }
        public static int GetNextProductID()
        {
            nextProductID = Products.Count;
            nextProductID++;
            return nextProductID;
        }

        public static void addProduct(Product product)
        {
            Products.Add(product);
        }

        public static bool removeProduct(int productID) {
            return true; //BANDAID! Fix later

            //Note to self: why are bools showing red underline?    
        }

        public static void updateProduct(int productID, Product updatedProduct)
        {

        }

        public static void addPart(Part part)
        {
            AllParts.Add(part);
        }

        public static bool deletePart(Part part)
        {
            try
            {
                AllParts.Remove(lookupPart(part.PartID));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Part lookupPart(int partID)
        {
            foreach (Part x in AllParts)
            {
                if (x.PartID == partID)
                {
                    return x;
                }
            }
            return null;
        }

        public static Product lookupProduct(int productID)
        {
            foreach (Product x in Products)
            {
                if (x.ProductID == productID)
                {
                    return x;
                }
            }
            return null;
        }
        public static void updatePart(int partID, Part part)
        {
            foreach (Part each in Inventory.AllParts)
            {
                if (each.PartID == partID)
                {
                    each.InStock = part.InStock;
                    each.MachineID = part.MachineID;
                    each.Max = part.Max;
                    each.Min = part.Min;
                    each.Name = part.Name;
                    each.Price = part.Price;

                }
            }
        }
        public static void changePartSource(int partID, Part part, bool inhouse) //1 for inhouse 0 for outsourced
        {
            if (inhouse)
            {
                foreach (Part each in Inventory.AllParts)

                {
                    if (each.PartID == partID)
                    {
                        part.CompanyName = null;
                        Debug.WriteLine("Nulling Name!!!");
                     /*   Forms.Main main = new Forms.Main();
                        main.ShowDialog();*/
                    }


                }
            }


            else
            {
                foreach (Part each in Inventory.AllParts)

                {
                    if (each.PartID == partID)
                    {
                        part.MachineID = null;
                    }

                }
            }
            }
        }
    }


