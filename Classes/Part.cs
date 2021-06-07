using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHolbrook___IMS___Task1.Classes
{
     public abstract class Part
      
    {
        public int PartID { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public int InStock { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }

        public virtual int? MachineID { get; set; }
        
        public virtual string CompanyName { get; set; }
        //Constructor>> gets called to add data to list >> used to populate dataframe in GUI 

        public Part(string name, double price, int inStock, int min, int max)
                    : this(Inventory.GetNextPartID(), name, price, inStock, min, max)
        { 

        }

        public Part(int partID, string name, double price, int inStock, int min, int max)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }
        //Note to self - need virtual method? Read this later https://www.c-sharpcorner.com/UploadFile/3d39b4/virtual-method-in-C-Sharp/
       // public virtual int GetMachineID() { return 0; }
       // public virtual string GetCompanyName() { return ""; }
    }
}
