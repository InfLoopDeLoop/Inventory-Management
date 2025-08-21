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
    public partial class ModifyPartForm : Form
    {
        public ModifyPartForm()
        {
            InitializeComponent();
            InHouseButton.Checked = true;
            InHousePanel.Visible = true;
            OutsourcedPanel.Visible = false;
        }

        private void InHouseButton_CheckedChanged(object sender, EventArgs e)
        {
            if (InHouseButton.Checked)
            {
                OutsourcedButton.Checked = false;
                OutsourcedPanel.Visible = false;
                InHousePanel.Visible = true;
            }
        }

        private void OutsourcedButton_CheckedChanged(object sender, EventArgs e)
        {
            if (OutsourcedButton.Checked)
            {
                InHouseButton.Checked = false;
                InHousePanel.Visible = false;
                OutsourcedPanel.Visible = true;
            }
        }

        private void CancelButtton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (InHouseButton.Checked)
            {
                if (string.IsNullOrWhiteSpace(IDTextBox.Text) || string.IsNullOrWhiteSpace(NameTextBox.Text) || string.IsNullOrWhiteSpace(InventoryTextBox.Text) ||
                string.IsNullOrWhiteSpace(PriceTextBox.Text) || string.IsNullOrWhiteSpace(MinTextBox.Text) || string.IsNullOrWhiteSpace(MaxTextBox.Text) ||
                string.IsNullOrWhiteSpace(MachineIDTextBox.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                if (!int.TryParse(IDTextBox.Text, out int partID))
                {
                    MessageBox.Show("Part ID must be a number.");
                    return;
                }

                if (!int.TryParse(InventoryTextBox.Text, out int inventory))
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

                if (inventory < min || inventory > max)
                {
                    MessageBox.Show("Inventory must be between Min and Max.");
                    return;
                }

                if (!int.TryParse(MachineIDTextBox.Text, out int machineID))
                {
                    MessageBox.Show("Machine ID must be a number.");
                    return;
                }

                InHouse NewPart = new InHouse
                {
                    PartID = partID,
                    Name = NameTextBox.Text,
                    InStock = inventory,
                    Price = price,
                    Min = min,
                    Max = max,
                    MachineID = machineID
                };



            }
            else if (OutsourcedButton.Checked)
            {
                if (string.IsNullOrWhiteSpace(IDTextBox.Text) || string.IsNullOrWhiteSpace(NameTextBox.Text) || string.IsNullOrWhiteSpace(InventoryTextBox.Text) ||
                string.IsNullOrWhiteSpace(PriceTextBox.Text) || string.IsNullOrWhiteSpace(MinTextBox.Text) || string.IsNullOrWhiteSpace(MaxTextBox.Text) ||
                string.IsNullOrWhiteSpace(CompanyNameTextBox.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }
            }
            
        }
    }
}
