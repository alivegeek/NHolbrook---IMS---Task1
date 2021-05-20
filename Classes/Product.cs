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

        public int ProductID;

        public string Name;

        public double Price;

        public int InStock;

        public int Min;

        public int Max;

        public void addAssociatedPart(Part part)
        {

        }

        public bool removeAssociatedPart(int part)
        {
            return true; //BANDAID
        }

        public Part lokupAssociatedPart(int part)
        {
            return null; //BANDAID
        }


    }
}
