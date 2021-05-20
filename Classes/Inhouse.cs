using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHolbrook___IMS___Task1.Classes

{
    //Note to self - how do abstract classes work, what is the syntax to specify this is a subclass¿ of Part.cs
     class Inhouse : Part
    {
        public int MachineID { get; set; }

        public Inhouse(string name, double price, int inStock, int min, int max, int machineID) 
            :base(name, price, inStock, min, max)
        {
        
            MachineID = machineID;
        }

    }
}
