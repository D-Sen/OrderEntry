using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/*
  Project      Order Entry
  Programmer   Domonic Senesi
  Date         December 2016
                
               Lets a user enter a Item name, quantity and Unit Price. Creates a class for each item, 
                then displays the extended price in a preset results text box.
  */

namespace Order_Entry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Validate Text Boxes, then create a class and use the Text boxes' values to fill the class.

            if (itemValidation(itemTextBox.Text) == true)
            {
                if (quanValidation(quanTextBox.Text) == true)
                {
                    if (unitPriValidation(unitPriTextBox.Text) == true)
                    {
                        Class1 myItem = new Class1();

                        myItem.Item = itemTextBox.Text;
                        myItem.Quantity = int.Parse(quanTextBox.Text);
                        myItem.UnitPrice = decimal.Parse(unitPriTextBox.Text);
                        resultsLabel.Text = myItem.ExtendedPrice().ToString("c");
                    }
                    else
                    {
                        unitPriTextBox.Focus();
                        unitPriTextBox.SelectAll();
                        MessageBox.Show("Please enter a number between 0 and 100.");
                    }
                }
                else
                {
                    quanTextBox.Focus();
                    quanTextBox.SelectAll();
                    MessageBox.Show("Please enter a whole number between 1 and 1000.");
                }
            }
            else
            {        
                itemTextBox.Focus();
                itemTextBox.SelectAll();
                MessageBox.Show("Please enter item whose length is between 3 and 15.");
            }
            
        }


        public bool unitPriValidation(String unitPriText)
        {
            //Attempts to validate type for unit Price, then check value for within constraints

            decimal uniPriTemp =0;
            bool found = false;
            if (decimal.TryParse(unitPriText, out uniPriTemp))
            {
                if ((uniPriTemp >= 0) && (uniPriTemp <= 100))
                {
                   found = true;
                }
            }
            return (found);
        }
        public bool itemValidation(String acctText)
        {
           //Attempts to validate length for Item Name within constraints

           bool found = false;           
           if ((acctText.Length >= 3) && (acctText.Length <= 15))
           {
               found = true;
           }
           return (found);        
        }
        //----------------------------------------------------------
        public bool quanValidation(String quanText )
        {
            //Attempts to validate type for Quantity, then check value for within constraints

            bool found = false;
            int quanTemp = 0;
            if (int.TryParse(quanText, out quanTemp))
            {
                if ((quanTemp >= 1) && (quanTemp <= 1000))
                {
                    found = true;
                }
            }
            return (found);              
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clears all values from text fields, labels, and resets focus

            itemTextBox.Clear();
            quanTextBox.Clear();
            unitPriTextBox.Clear();
            itemTextBox.Focus();
            resultsLabel.Text = "Waiting for input.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Test form on load

            //Class1 myClass = new Class1();

            //myClass.Item = "Test";
            //myClass.Quantity = 5;
            //myClass.UnitPrice = 10;
            //resultsLabel.Text = myItem.ExtendedPrice().ToString("c");
            //MessageBox.Show(myItem.Item + " " + myItem.Quantity + " " + myItem.UnitPrice + " " + myItem.ExtendedPrice());

        }
    }
}
