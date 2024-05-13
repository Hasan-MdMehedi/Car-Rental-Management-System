using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new design1());
            //Application.Run(new User());
           //  Application.Run(new car());
            // Application.Run(new Customer());
            //Application.Run(new Rental());
           // Application.Run(new Return());
        }
    }
}
