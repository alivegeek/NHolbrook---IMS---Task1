using NHolbrook___IMS___Task1.Classes;
using NHolbrook___IMS___Task1.Forms;
using System;
using System.Windows.Forms;


namespace NHolbrook___IMS___Task1
{
    static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //populate sample data here
            Inhouse part = new Inhouse(Inventory.GetNextPartID(), "Power Converter", 100, 2, 1, 255, 22); ;
            Outsourced part2 = new Outsourced(Inventory.GetNextPartID(), "Warp core ejector coil", 1024, 1, 1, 25, "Academy surplus");
            Outsourced part3 = new Outsourced(Inventory.GetNextPartID(), "Litigating Ligature", 53.09, 1, 1, 8, "Johnnie Cochran Supply");
            Outsourced part4 = new Outsourced(Inventory.GetNextPartID(), "Redudant Rotating Oscillator", 3.50, 1, 1, 25, "redundundundancy inc.");
            Outsourced part5 = new Outsourced(Inventory.GetNextPartID(), "George bushing", 5309, 2005, 2001, 2009, "Whitehouse procurement co.");
            Outsourced part6 = new Outsourced(Inventory.GetNextPartID(), "Over-bearing", 5309, 99, 10, 250, "Inlaws R Us");

            //Inventory.AllParts.Add(part);
            Inventory.addPart(part);
            Inventory.addPart(part2);
            Inventory.addPart(part3);
            Inventory.addPart(part4);
            Inventory.addPart(part5);
            Inventory.addPart(part6);

            //Products sample data
            Product product1 = new Product(1, "Red Bicycle", 11.14, 15, 5, 25);
            Product product2 = new Product(2, "Yellow Bicycle", 9.66, 19, 1, 20);
            Product product3 = new Product(3, "Blue Bicycle", 12.77, 5, 1, 25);

            Inventory.addProduct(product1);
            Inventory.addProduct(product2);
            Inventory.addProduct(product3);

            //Asso Part
            product1.AssociatedParts.Add(part);
            product2.AssociatedParts.Add(part2);
            product3.AssociatedParts.Add(part3);


            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Main main = new Main();
            Application.Run(main);
        }


    }
}
