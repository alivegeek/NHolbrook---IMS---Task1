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
            Classes.Inhouse part = new Classes.Inhouse(Classes.Inventory.GetNextPartID(), "Power Converter", 100, 2, 1, 255, 22); ;
            Classes.Outsourced part2 = new Classes.Outsourced(Classes.Inventory.GetNextPartID(), "Warp core ejector coil", 1024, 1, 10, 25, "Academy surplus");
            Classes.Outsourced part3 = new Classes.Outsourced(Classes.Inventory.GetNextPartID(), "Litigating Ligature", 53.09, 1, 2, 8, "Johnnie Cochran Supply");
            Classes.Outsourced part4 = new Classes.Outsourced(Classes.Inventory.GetNextPartID(), "Redudant Rotating Oscillator", 3.50, 1, 10, 25, "redundundundancy inc.");
            Classes.Outsourced part5 = new Classes.Outsourced(Classes.Inventory.GetNextPartID(), "George bushing", 5309, 43, 2001, 2009, "Whitehouse procurement co.");
            Classes.Outsourced part6 = new Classes.Outsourced(Classes.Inventory.GetNextPartID(), "Over-bearing", 5309, 99, 10, 25, "Inlaws R Us");

            //Classes.Inventory.AllParts.Add(part);
            Classes.Inventory.addPart(part);
            Classes.Inventory.addPart(part2);
            Classes.Inventory.addPart(part3);
            Classes.Inventory.addPart(part4);
            Classes.Inventory.addPart(part5);
            Classes.Inventory.addPart(part6);

            //Products sample data
            Classes.Product product1 = new Classes.Product(1, "Red Bicycle", 11.14, 15, 5, 25);
            Classes.Product product2 = new Classes.Product(2, "Yellow Bicycle", 9.66, 19, 1, 20);
            Classes.Product product3 = new Classes.Product(3, "Blue Bicycle", 12.77, 5, 1, 25);

            Classes.Inventory.addProduct(product1);
            Classes.Inventory.addProduct(product2);
            Classes.Inventory.addProduct(product3);

            //Asso Part
            product1.AssociatedParts.Add(part);
            product2.AssociatedParts.Add(part2);

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Main main = new Main();
            Application.Run(main);
        }


    }
}
