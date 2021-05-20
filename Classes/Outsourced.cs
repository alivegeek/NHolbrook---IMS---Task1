using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHolbrook___IMS___Task1.Classes
{
    class Outsourced : Part
    {

        public string CompanyName { get; set; }
            
        
        public Outsourced(string name, double price, int inStock, int min, int max, string companyName)
            : base(name, price, inStock, min, max)
        {
            CompanyName = companyName;
        }
    }

}
