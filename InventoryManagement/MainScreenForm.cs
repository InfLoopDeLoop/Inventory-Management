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
    }


}
