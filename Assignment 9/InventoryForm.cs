using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment_9
{
    public partial class InventoryForm : Form
    {
        private Retalitem _currentItem;

        public Retalitem CurrentItem
        {
            set { _currentItem = value; }
        }
        private Retalitem _newItem;

        public Retalitem NewItem
        {
            get { return _newItem; }
            set { _newItem = value; }
        }

        public InventoryForm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            errProvider.Clear();
            double newPrice;
            int newUnits;

            if (!double.TryParse(txtPrice.Text, out newPrice) || newPrice < 0)
            {
                errProvider.SetError(txtPrice, "Price is not valid");
                return;
            }
            if (!int.TryParse(txtUnits.Text, out newUnits) || newUnits < 0)
            {
                errProvider.SetError(txtUnits, "Units not valid");
                return;
            }
            _currentItem.Units = newUnits;
            _currentItem.Price = newPrice;
            this.Close();

        }

        public void UpdateSettings()
        {
            this.Text = "Update Form";
            txtDescription.Enabled = false;
            txtIdNumber.Enabled = false;
            btnUpdate.Visible = true;
            btnAdd.Visible = false;
            txtIdNumber.Text = _currentItem.IdNumber.ToString();
            txtDescription.Text = _currentItem.Description;
            txtUnits.Text = _currentItem.Units.ToString();
            txtPrice.Text = _currentItem.Price.ToString();

        }

        public void AddSettings()
        {
            this.Text = "Add Form";
            txtDescription.Enabled = true;
            txtIdNumber.Enabled = true;
            btnAdd.Visible = true;
            btnUpdate.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            errProvider.Clear();
            double newPrice;
            int newUnits;
            string newDescription = txtDescription.Text;
            int newIdNumber;

            if (!double.TryParse(txtPrice.Text, out newPrice) || newPrice < 0)
            {
                errProvider.SetError(txtPrice, "Price is not valid");
                return;
            }
            if (!int.TryParse(txtUnits.Text, out newUnits) || newUnits < 0)
            {
                errProvider.SetError(txtUnits, "Units not valid");
                return;
            }
            if (!int.TryParse(txtIdNumber.Text, out newIdNumber) || newIdNumber < 0)
            {
                errProvider.SetError(txtIdNumber, "Id Number not valid");
                return;
            }
            if (newDescription == "")
            {
                errProvider.SetError(txtDescription, "Description is blank");
                return;
            }

            Retalitem item = new Retalitem(newIdNumber, newDescription, newUnits, newPrice);
            _newItem = item;
            this.Close();

        }
    }
}
