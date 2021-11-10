using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHolbrook___IMS___Task1.Classes
{
   public class Outsourced : Part
    {

        public Outsourced(int partID, string name, double price, int inStock, int min, int max, string companyName)
            : base(partID, name, price, inStock, min, max)
        {
            CompanyName = companyName;
        }
      
//        public string CompanyName { get; set; }


    }
}
