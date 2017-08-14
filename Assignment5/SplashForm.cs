using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Name: Nguyen Thi Kim Ngan
 * Student ID: 300922400
 * Description: This is splashform class
 * Version 2 - Create the splashform Timer - Tick event handler
 * 
 */
namespace Assignment5
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is event handler for the "Tick"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            DemoBMICalculator BMITCalculator = new DemoBMICalculator();
            BMITCalculator.Show();
            this.Hide();
            SplashFormTimer.Enabled = false;
        }
    }
}
