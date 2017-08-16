using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Name: Nguyen Thi Kim Ngan
 * Student ID: 300922400
 * Description: This is the driven class
 * Version 1 - Adjust to display the splashform
 * 
 */
namespace Assignment5
{
    public static class Program
    {
        // Create reference to forms
        public static DemoBMICalculator BMITCalculator;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //instantiate new object of BMI calculator
            BMITCalculator = new DemoBMICalculator();
            Application.Run(new SplashForm());
        }
    }
}
