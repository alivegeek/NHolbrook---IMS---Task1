using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace NHolbrook___IMS___Task1.Classes
{
     public abstract class Part
      
    {
        private int partID;
        private string name;
        private double price;
        private int inStock;
        private int min;
        private int max;

        public int PartID { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public int InStock { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }

        public string CompanyName { get; set; }

        public int MachineID { get; set; }



        // public virtual Inhouse MachineID { get; set; }
        //  public virtual Outsourced CompanyName { get; set; }


        // public int? MachineID;
        // public string CompanyName; 

        //public Part(string name, double price, int inStock, int min, int max)
        //            : this(Inventory.GetNextPartID(), name, price, inStock, min, max)
        //{ 

        //}

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
