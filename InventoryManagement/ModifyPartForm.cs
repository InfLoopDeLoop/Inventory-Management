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
        private Part selectedPart;
        public ModifyPartForm(Part part)
        {
            InitializeComponent();
            selectedPart = part;
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

        private void ModifyPartForm_Load(object sender, EventArgs e)
        {
            if (selectedPart != null)
            {
                IDTextBox.Text = selectedPart.PartID.ToString();
                NameTextBox.Text = selectedPart.Name;
                InventoryTextBox.Text = selectedPart.InStock.ToString();
                PriceTextBox.Text = selectedPart.Price.ToString("F2");
                MinTextBox.Text = selectedPart.Min.ToString();
                MaxTextBox.Text = selectedPart.Max.ToString();
                if (selectedPart is InHouse inHousePart)
                {
                    InHouseButton.Checked = true;
                    MachineIDTextBox.Text = inHousePart.MachineID.ToString();
                    InHousePanel.Visible = true;
                    OutsourcedPanel.Visible = false;
                }
                else if (selectedPart is Outsourced outsourcedPart)
                {
                    OutsourcedButton.Checked = true;
                    CompanyNameTextBox.Text = outsourcedPart.CompanyName;
                    OutsourcedPanel.Visible = true;
                    InHousePanel.Visible = false;
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IDTextBox.Text) ||
                string.IsNullOrWhiteSpace(NameTextBox.Text) ||
                string.IsNullOrWhiteSpace(InventoryTextBox.Text) ||
                string.IsNullOrWhiteSpace(PriceTextBox.Text) ||
                string.IsNullOrWhiteSpace(MinTextBox.Text) ||
                string.IsNullOrWhiteSpace(MaxTextBox.Text) ||
                (InHouseButton.Checked && string.IsNullOrWhiteSpace(MachineIDTextBox.Text)) ||
                (OutsourcedButton.Checked && string.IsNullOrWhiteSpace(CompanyNameTextBox.Text)))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!int.TryParse(IDTextBox.Text, out int partID))
            {
                MessageBox.Show("Part ID must be a number.");
                return;
            }

            if (selectedPart.PartID != partID &&
                Inventory.AllParts != null &&
                Inventory.AllParts.Any(p => p.PartID == partID))
            {
                MessageBox.Show("Part ID must be the same as before or unique.");
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

            if (InHouseButton.Checked)
            {
                if (!int.TryParse(MachineIDTextBox.Text, out int machineID))
                {
                    MessageBox.Show("Machine ID must be a number.");
                    return;
                }

                Inventory.UpdatePart(selectedPart.PartID, new InHouse()
                {
                    PartID = partID,
                    Name = NameTextBox.Text,
                    InStock = stock,
                    Price = price,
                    Min = min,
                    Max = max,
                    MachineID = machineID
                });
            }
            else if (OutsourcedButton.Checked)
            {
                Inventory.UpdatePart(selectedPart.PartID,

                    new Outsourced
                    {
                        PartID = partID,
                        Name = NameTextBox.Text,
                        InStock = stock,
                        Price = price,
                        Min = min,
                        Max = max,
                        CompanyName = CompanyNameTextBox.Text
                    });
            }

            Inventory.OrderParts();
            this.Close();
        }


        private void CancelButtton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
