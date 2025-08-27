using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class AddProductForm : Form
    {
        private BindingList<Part> CandidateParts = new BindingList<Part>(Inventory.AllParts.ToList());
        private Product NewProduct = new Product();
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void RefreshCandidateView()
        {
            CandidateTable.Items.Clear();
            foreach (var part in CandidateParts)
            {
                ListViewItem item = new ListViewItem(part.PartID.ToString());
                item.SubItems.Add(part.Name);
                item.SubItems.Add(part.InStock.ToString());
                item.SubItems.Add(part.Price.ToString("C"));
                item.SubItems.Add(part.Min.ToString());
                item.SubItems.Add(part.Max.ToString());
                CandidateTable.Items.Add(item);
            }
        }

        private void RefreshAssociatedView()
        {
            AssociatedTable.Items.Clear();
            foreach (var part in NewProduct.AssociatedParts)
            {
                ListViewItem item = new ListViewItem(part.PartID.ToString());
                item.SubItems.Add(part.Name);
                item.SubItems.Add(part.InStock.ToString());
                item.SubItems.Add(part.Price.ToString("C"));
                item.SubItems.Add(part.Min.ToString());
                item.SubItems.Add(part.Max.ToString());
                AssociatedTable.Items.Add(item);
            }
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            RefreshCandidateView();
            RefreshAssociatedView();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IDTextBox.Text) ||
                string.IsNullOrWhiteSpace(NameTextBox.Text) ||
                string.IsNullOrWhiteSpace(InventoryTextBox.Text) ||
                string.IsNullOrWhiteSpace(PriceTextBox.Text) ||
                string.IsNullOrWhiteSpace(MinTextBox.Text) ||
                string.IsNullOrWhiteSpace(MaxTextBox.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!int.TryParse(IDTextBox.Text, out int productID))
            {
                MessageBox.Show("Product ID must be a number.");
                return;
            }

            if (Inventory.Products != null && Inventory.Products.Any(p => p.ProductID == productID))
            {
                MessageBox.Show("Product ID must be unique.");
                return;
            }

            if (!int.TryParse(InventoryTextBox.Text, out int stock))
            {
                MessageBox.Show("Inventory must be a number.");
                return;
            }

            if (!decimal.TryParse(PriceTextBox.Text, out decimal price))
            {
                MessageBox.Show("Price must be a decimal value.");
                return;
            }

            if (!int.TryParse(MinTextBox.Text, out int min) || !int.TryParse(MaxTextBox.Text, out int max))
            {
                MessageBox.Show("Min and Max must be numbers.");
                return;
            }

            if (min > max)
            {
                MessageBox.Show("Min must be less than or equal to Max.");
                return;
            }

            if (stock < min || stock > max)
            {
                MessageBox.Show("Inventory must be between Min and Max.");
                return;
            }

            if (NewProduct.AssociatedParts.Count == 0 || NewProduct.AssociatedParts == null)
            {
                MessageBox.Show("A product must have at least one associated part.");
                return;
            }

            NewProduct.ProductID = productID;
            NewProduct.Name = NameTextBox.Text;
            NewProduct.InStock = stock;
            NewProduct.Price = price;
            NewProduct.Min = min;
            NewProduct.Max = max;

            Inventory.AddProduct(NewProduct);

            Inventory.OrderProducts();
            this.Close();
        }

        private void AddPartButtton_Click(object sender, EventArgs e)
        {
            if (CandidateTable.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a part to add");
                return;
            }
            ListViewItem selectedRow = CandidateTable.SelectedItems[0];
            int partID = int.Parse(selectedRow.SubItems[0].Text);
            Part selectedPart = Inventory.LookupPart(partID);
            NewProduct.AddAssociatedPart(selectedPart);
            CandidateParts.Remove(selectedPart);
            RefreshCandidateView();
            RefreshAssociatedView();
        }

        private void DeletePartButton_Click(object sender, EventArgs e)
        {
            if (AssociatedTable.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a part to delete.");
                return;
            }
            ListViewItem selectedRow = AssociatedTable.SelectedItems[0];
            int partID = int.Parse(selectedRow.SubItems[0].Text);
            Part selectedPart = Inventory.LookupPart(partID);
            CandidateParts.Add(selectedPart);
            NewProduct.RemoveAssociatedPart(selectedPart.PartID);
            RefreshCandidateView();
            RefreshAssociatedView();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
