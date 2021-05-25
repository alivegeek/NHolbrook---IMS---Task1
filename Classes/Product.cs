using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHolbrook___IMS___Task1.Classes
{
    public class Product
    {
        //Note to self - public list of type Part named AssociatedParts
        public List<Part> AssociatedParts;
        //associatedparts = new ArrayList();

        public int ProductID { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public int InStock { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }


        //Constructors
        public Product(string name, double price, int inStock, int min, int max, int associatedPartsID)
            : this(Inventory.GetNextProductID(), name, price, inStock, min, max, associatedPartsID) { }
        public Product(int productID, string name, double price, int inStock, int min, int max, int associatedPartsID)
        : this(productID, name, price, inStock, min, max)
        {
            Part refPart = LookupAssociatedPart(associatedPartsID);
            this.AssociatedParts = new List<Part>();
            AssociatedParts.Add(refPart);

            //this.AssociatedParts = AssociatedParts.Add(LookupAssociatedPart(associatedPartsID));
        }

        public Part LookupAssociatedPart(int partID)
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

        }

        public bool removeAssociatedPart(int part)
        {
            return true; //BANDAID
        }

      /*  public Part lokupAssociatedPart(int part)
        {
            return null; //BANDAID
        }
*/

    }
}
