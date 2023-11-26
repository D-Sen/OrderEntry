using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Simple Class for handling items. Sorry about the class name! 
 * Programmer   Domonic Senesi
 * Date         December 2016
 * 
 */

namespace Order_Entry
{


    class Class1
    {
        private String _Item;
        private int _Quantity;
        private decimal _UnitPrice;

        public String Item
        {
            get { return _Item; }
            set { _Item = value; }
        }
        public int Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }
        public decimal UnitPrice
        {
            get { return _UnitPrice; }
            set { _UnitPrice = value; }
        }
        public decimal ExtendedPrice()
        {
            // Returns the Extended Price, which is Quantity times Unit Price
            return (Quantity * UnitPrice);

        }
    }
}
