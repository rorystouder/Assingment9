using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Assignment_9
{
    static class Program
    {
        public static Inventory CurrentInventory;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CurrentInventory = new Inventory();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
