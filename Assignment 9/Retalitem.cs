using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_9
{
    // Add a class, RetailItem, to the project.
    public class Retalitem
    {
        // Include the following private member variables:
        // id number (int), units (int), price (double), and description(string).
        private int _idnumber;
        private int _units;
        private double _price;
        private string _description;

        // Include the following read-only properties: Description, IdNumber
        public int IdNumber
        {
            get { return _idnumber; }
        }

        public string Description
        {
            get { return _description; }
        }

        //Include the following properties: Units, Price
        public int Units
        {
            get { return _units; }
            set { _units = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        // The constructor assigns member variables the appropriate parameter value.
        public Retalitem(int partId, string partDescription, int partsOnHand, double partCost)
        {
            _idnumber = partId;
            _description = partDescription;
            Units = partsOnHand;
            Price = partCost;
        } 
    }
}
