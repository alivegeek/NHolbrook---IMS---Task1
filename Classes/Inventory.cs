using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;


namespace NHolbrook___IMS___Task1.Classes

{
    public class Inventory
    {
        //create lists from Inventory UML
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();
        public BindingSource source = new BindingSource(AllParts, null);


        //Initalize variables for incrementing productIDs.


        private static int nextPartID = AllParts.Count;
        private static int nextProductID = 0; //Products.Count;



        public static int GetNextPartID()
        {
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


        
        public static bool removeProduct(int id)
        {
            {
                Product product = lookupProduct(id);
                try
                {
                    Products.Remove(product);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

        }

        public static void updateProduct(int productID, Product updatedProduct)
        {
            foreach (Product p in Products)
            {
                if (p.ProductID == productID)
                {
                    removeProduct(p.ProductID);
                    addProduct(updatedProduct);
                }
            }
        }

        public static void updatePart(int id, Part part)
        {
            foreach( Part p in AllParts)
            {
                if(p.PartID == id)
                {
                    deletePart(p);
                    addPart(part);
                }
            }
        }

        public static void addPart(Part part)
        {
            AllParts.Add(part);
        }
        public static void addPart(Part part, int index)
        {
            AllParts[index] = part;
          //  AllParts.Insert(index, part);  
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


        public static void UpdateProduct(int productID, Product updatedProduct)
        {
            foreach (Product currentProd in Products)
            {
                if (currentProd.ProductID == productID)
                {
                    currentProd.Name = updatedProduct.Name;
                    currentProd.InStock = updatedProduct.InStock;
                    currentProd.Price = updatedProduct.Price;
                    currentProd.Min = updatedProduct.Min;
                    currentProd.Max = updatedProduct.Max;
                    currentProd.AssociatedParts = updatedProduct.AssociatedParts;
                    return;
                }
            }
        }
        public static void UpdateInHouse(int partID, Inhouse inPart)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].GetType() == typeof(Classes.Inhouse))
                {
                    Inhouse newPart = (Inhouse)AllParts[i];

                    if (newPart.PartID == partID)
                    {
                        newPart.Name = inPart.Name;
                        newPart.InStock = inPart.InStock;
                        newPart.Price = inPart.Price;
                        newPart.Min = inPart.Min;
                        newPart.Max = inPart.Max;
                        newPart.MachineID = inPart.MachineID;
                    }
                }
            }
        }
        public static void UpdateOutsourced(int partID, Outsourced outPart)
        {
                for (int i = 0; i < AllParts.Count; i++)
                {
                    if (AllParts[i].GetType() == typeof(Classes.Outsourced))
                    {
                        Outsourced newPart = (Outsourced)AllParts[i];


                        if (newPart.PartID == partID)
                        {

                            newPart.Name = outPart.Name;
                            newPart.InStock = outPart.InStock;
                            newPart.Price = outPart.Price;
                            newPart.Min = outPart.Min;
                            newPart.Max = outPart.Max;
                            newPart.CompanyName = outPart.CompanyName;
                        }
                        
                    }
                }
        }

       
        public static bool SourceChange(int partID)
        {
            Part partToCheck = lookupPart(partID);
            if (partToCheck.GetType() == typeof(Classes.Outsourced))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        


    }

}
