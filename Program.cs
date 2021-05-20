using NHolbrook___IMS___Task1.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            // Classes.Part p = new Classes.Part(1, "Double Helix Doohickey", 5309, 1, 10, 25);
            //Note to self: Abstract classes cant be instantiated.. oops
            Classes.Outsourced part =  new Classes.Outsourced("Power Converter", 100, 1, 1, 255, "Tashi Station");
            Classes.Outsourced part2 = new Classes.Outsourced("Warp core ejector coil", 1024, 1, 10, 25, "Academy surplus");
            Classes.Outsourced part3 = new Classes.Outsourced("Litigating Ligature", 53.09, 1, 2, 8, "Johnnie Cochran Supply");
            Classes.Outsourced part4 = new Classes.Outsourced("Redudant Rotating Oscillator", 3.50, 1, 10, 25, "redundundundancy inc.");
            Classes.Outsourced part5 = new Classes.Outsourced("George bushing", 5309, 43, 2001, 2009, "Whitehouse procurement co.");
            Classes.Outsourced part6 = new Classes.Outsourced("Over-bearing", 5309, 99, 10, 25, "Inlaws R Us");

            //Classes.Inventory.AllParts.Add(part);
            Classes.Inventory.addPart(part);
            Classes.Inventory.addPart(part2);
            Classes.Inventory.addPart(part3);
            Classes.Inventory.addPart(part4);
            Classes.Inventory.addPart(part5);
            Classes.Inventory.addPart(part6);

            //if (Forms.Main.PartsDGV == null || PartsDGV.Rows.Count == 0)
            //{
            //    MessageBox.Show("Its blank!");
            //}
            //else MessageBox.Show("Its not!");


            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Main main = new Main();
            Application.Run(main);
        }
    }
}
