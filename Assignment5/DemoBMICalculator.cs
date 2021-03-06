﻿using System;
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
 * Description: This is  the BMI Calculator
 *Version 6 - Modify the event handler Calculatebutton_Click
 * to display the message of BMI 
 */

namespace Assignment5
{
    public partial class DemoBMICalculator : Form
    {
        // private instance variables
        private double _height;
        private double _weight;
        private double _result;
        // publish properties
        public double User_Height
        {
            get
            {
                return this._height;
            }
            set
            {
                this._height = value;
            }
        }
        public double User_Weight
        {
            get
            {
                return this._weight;
            }
            set
            {
                this._weight = value;
            }
        }
        public double User_Result
        {
            get
            {
                return this._result;
            }
            set
            {
                this._result = value;
            }
        }
        /// <summary>
        /// This is the main constructor for BMI Form
        /// </summary>
        public DemoBMICalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This default event is to indicate user input the proper value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (ImperialradioButton.Checked)
            {
                HeightChoiceLabel.Text = "In Inches";
                WeightChoicelabel.Text = "In Pounds";
            }
            else
            {
                HeightChoiceLabel.Text = "";
                WeightChoicelabel.Text = "";
            }
        }
        /// <summary>
        /// This method is to indicate the user input the proper value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void MetricradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MetricradioButton.Checked)
            {
                HeightChoiceLabel.Text = "In Metres";
                WeightChoicelabel.Text = "In Kilos";
            }
            else
            {
                HeightChoiceLabel.Text = "";
                WeightChoicelabel.Text = "";

            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void HeightInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
        //private void Check_User_Result()
        //{
        //    if (User_Result <= 18.5)
        //    {
        //        ResulttextBox.Text = "You are Underweight";
        //    }
        //    else if (User_Result >= 18.5 && User_Result <= 24.9)
        //    {
        //        ResulttextBox.Text = "You are Normal";
        //    }
        //    else if (User_Result >= 25 && User_Result <= 29.9)
        //    {
        //        ResulttextBox.Text = "You are Overweight";
        //    }
        //    else
        //    {
        //        ResulttextBox.Text = "You are Obese";
        //    }
        //}

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This is event handler to reset the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Resetbutton_Click(object sender, EventArgs e)
        {
            HeightBox.Clear();
            WeightBox.Clear();
            ResulttextBox.Text = "";
        }

        private void ResulttextBox_TextChanged(object sender, EventArgs e)
        {
           

        }

        /// <summary>
        /// This is the event handler to apply the approriate formula 
        /// and display the result on ResulttextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Calculatebutton_Click(object sender, EventArgs e)
        {
            User_Height = double.Parse(HeightBox.Text);
            User_Weight = double.Parse(WeightBox.Text);
            if (MetricradioButton.Checked)
            {
                User_Result = User_Weight / (User_Height * User_Height);
                if (User_Result <= 18.5)
                {
                    ResulttextBox.Text = String.Format("{0:f}_{1}", User_Result, "You are Underweight");
                }
                else if (User_Result >= 18.5 && User_Result <= 24.9)
                {
                    ResulttextBox.Text = String.Format("{0:f}_{1}", User_Result, "You are Normal");
                }
                else if (User_Result >= 25 && User_Result <= 29.9)
                {
                    ResulttextBox.Text = String.Format("{0:f}_{1}", User_Result, "You are Overweight");
                }
                else
                {
                    ResulttextBox.Text = String.Format("{0:f}_{1}", User_Result, "You are Obese");
                }

            }
            else if (ImperialradioButton.Checked)
            {
                User_Result = (User_Weight * 703) / (User_Height * User_Height);
                if (User_Result <= 18.5)
                {
                    ResulttextBox.Text = String.Format("{0:f}_{1}", User_Result, "You are Underweight");
                }
                else if (User_Result >= 18.5 && User_Result <= 24.9)
                {
                    ResulttextBox.Text = String.Format("{0:f}_{1}", User_Result, "You are Normal");
                }
                else if (User_Result >= 25 && User_Result <= 29.9)
                {
                    ResulttextBox.Text = String.Format("{0:f}_{1}", User_Result, "You are Overweight");
                }
                else
                {
                    ResulttextBox.Text = String.Format("{0:f}_{1}", User_Result, "You are Obese");
                }
            }
        }
            private void HeightChoiceLabel_Click(object sender, EventArgs e)
        {
          
        }
  /// <summary>
  /// this is event handler for form closing 
  /// </summary>
  /// <param name="sender"></param>
  /// <param name="e"></param>
        private void DemoBMICalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
