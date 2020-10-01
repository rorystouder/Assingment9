using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_9
{
    // Add a class, Inventory
    class Inventory
    {
        // Include the following member variable: items (List of RetailItem)
        private List<Retalitem> items;


		public Inventory ()
		{
			items = new List<Retalitem> ();
		}

        // Include a string property, LastStatus
        private string _lastStatus;

        public string LastStatus
        {
            get { return _lastStatus; }
        }

        // Add a method, Items, that returns a List of RetailItem.
        public List<Retalitem> Items()
        {
			return items;
        }

        // Add a method, TotalCostOfGoods, that returns the sum of each RetailItem’s price * units
        public double TotalCostOfGoods()
        {
			double totalCost = 0;
			foreach (Retalitem item in items) 
			{
				totalCost += item.Units * item.Price;
			}
			return totalCost;
        }

        /*Add a method, AddItem, that uses a RetailItem as a parameter. The method should check if the id 
         * number of the parameter is already in the list (set last status to “ID number already exists”). 
         * Otherwise, add the item to the list and set last status to “Item added to inventory”.
         */ 
		public void AddItem(Retalitem item)
        {
			Retalitem match = items.Find (x => x.IdNumber == item.IdNumber);
			if (match != null)
				{
				    // check out Project 2 override contains
				    _lastStatus = "ID number already exists";
				}
				else
				{
					items.Add(item);
				    _lastStatus = "Item added to inventory";
				}
				
        }

        /* Add a method, DeleteItem, that uses an id number as a parameter. If the id number is in the list, 
         * check if the units is 0. Only delete items that have 0 units (set last status to “Item deleted”). 
         * Otherwise, set last status to “Item cannot be deleted”.
         */ 
        public void DeleteItem(int id)
        {
			Retalitem match = items.Find (x => x.IdNumber == id);
			if (match != null && match.Units == 0) 
			{
				items.Remove (match);
				_lastStatus = "Item deleted";
			}
			else 
			{
				_lastStatus = "item cannot be deleted";
			}

		}

        /* Add a method, UpdateItem, that uses a RetailItem parameter. The method updates the RetailItem in 
         * the list with the matching parameter id number (set last status to “Item updated”. Otherwise, set last 
         * status to “No matching item with ID Number xxxx” (where xxxx is the id parameter).
         */ 
        public void UpdateItem(Retalitem item)
        {
			Retalitem match = items.Find (x => x.IdNumber == item.IdNumber);
			if (match != null)
            {
				match.Price = item.Price;
				match.Units = item.Units;
				_lastStatus = "Item Updated";
			} 
			else 
			{
				_lastStatus = "No matching item with ID Number " + item.IdNumber;
			}
        }

        /* Add a method, GetItem, that uses id as a parameter. 
         */ 
		public Retalitem GetItem(int id)
        {
			return items.Find (x => x.IdNumber == id);
        }
    }
}
