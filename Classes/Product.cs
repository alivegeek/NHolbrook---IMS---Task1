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

      //  public BindingList<Part> associatedParts { get; set; }


        //Constructors
        public Product(string name, double price, int inStock, int min, int max)
            : this(Inventory.GetNextProductID(), name, price, inStock, min, max)
        {

        }

        //public Product(int productID, string name, double price, int inStock, int min, int max)
        //    : this(productID, name, price, inStock, min, max)

        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }





        public Product(int productID, string name, double price, int inStock, int min, int max)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;

            BindingList<Part> associatedParts = new BindingList<Part>();
        }

    }

}

      
