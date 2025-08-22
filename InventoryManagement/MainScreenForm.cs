using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagement.Models;

namespace InventoryManagement
{

    public partial class MainScreenForm : Form
    {
        public MainScreenForm()
        {
            InitializeComponent();
        }

        private void RefreshPartsView()
        {
            if (Inventory.AllParts != null)
            {
                PartsTable.Items.Clear();

                foreach (var part in Inventory.AllParts)
                {
                    ListViewItem item = new ListViewItem(part.PartID.ToString());
                    item.SubItems.Add(part.Name);
                    item.SubItems.Add(part.InStock.ToString());
                    item.SubItems.Add(part.Price.ToString("C"));
                    item.SubItems.Add(part.Min.ToString());
                    item.SubItems.Add(part.Max.ToString());
                    PartsTable.Items.Add(item);
                }
            }
        }

        private void AddPartsButton_Click(object sender, EventArgs e)
        {
            AddPartForm addPartForm = new AddPartForm();
            addPartForm.ShowDialog();
            RefreshPartsView();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ModifyPartButton_Click(object sender, EventArgs e)
        {
            if (PartsTable.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a part to modify.");
                return;
            }
            ListViewItem selectedRow = PartsTable.SelectedItems[0];
            int partID = int.Parse(selectedRow.SubItems[0].Text);
            Part selectedPart = Inventory.LookupPart(partID);
            ModifyPartForm modifyPartForm = new ModifyPartForm(selectedPart);
            modifyPartForm.ShowDialog();
            RefreshPartsView();
        }

        private void DeletePartButtton_Click(object sender, EventArgs e)
        {
            if (PartsTable.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a part to delete.");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this part?",
                "Confirm Delete", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

            ListViewItem selectedRow = PartsTable.SelectedItems[0];
            int partID = int.Parse(selectedRow.SubItems[0].Text);
            Part selectedPart = Inventory.LookupPart(partID);

            if (Inventory.DeletePart(selectedPart))
            {
                MessageBox.Show("Part deleted successfully.");
                RefreshPartsView();
            }
            else
            {
                MessageBox.Show("Failed to delete part. It may be associated with a product.");
            }
        }

        private void PartsTableSearchBar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PartsTableSearchBar.Text))
            {
                RefreshPartsView();
                return;
            }
            string searchTerm = PartsTableSearchBar.Text.ToLower();
            var filteredParts = Inventory.AllParts.Where(p => p.Name.ToLower().Contains(searchTerm)).ToList();
            PartsTable.Items.Clear();
            foreach (var part in filteredParts)
            {
                ListViewItem item = new ListViewItem(part.PartID.ToString());
                item.SubItems.Add(part.Name);
                item.SubItems.Add(part.InStock.ToString());
                item.SubItems.Add(part.Price.ToString("C"));
                item.SubItems.Add(part.Min.ToString());
                item.SubItems.Add(part.Max.ToString());
                PartsTable.Items.Add(item);
            }
        }

        private void PoductsTableSearchBar_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
