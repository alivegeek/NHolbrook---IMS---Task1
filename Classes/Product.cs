using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections;
namespace NHolbrook___IMS___Task1.Classes
{
    public class Product
    {
        
        public BindingList<Part> AssociatedParts = new BindingList<Part>();

        public int ProductID { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public int InStock { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }


        //Constructors
        public Product(string name, double price, int inStock, int min, int max, ArrayList associatedPart)
            : this(Inventory.GetNextProductID(), name, price, inStock, min, max, associatedPart) {

        }

        public Product(string name, double price, int inStock, int min, int max)
            : this(Inventory.GetNextProductID(), name, price, inStock, min, max) { }
        public Product(int productID, string name, double price, int inStock, int min, int max, ArrayList associatedPart)
        : this(productID, name, price, inStock, min, max)
        {
           


        }

        public static Part LookupAssociatedPart(int partID)
        {
            foreach (Part part in Classes.Inventory.AllParts)
            {
                if(part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
        }

        public Product(int productID, string name, double price, int inStock, int min, int max)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        public void addAssociatedPart(Part part)
        { 
            AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(int part)
        {
            var part2 = LookupAssociatedPart(part);
            AssociatedParts.Remove(part2);
           

            
            return true; 
        }

    

    }
}
