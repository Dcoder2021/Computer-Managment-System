using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Managment_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //  Application.Run(new view_Order(25));
            // Application.Run(new order_CreateOrder());
            Application.Run(new Login());
           //Application.Run(new SellerDashboard("Savendra"));
          // Application.Run(new AdminDashboard("Savendra"));

             //  Application.Run(new Dashboard("Savendra"));



        }
    }
}
