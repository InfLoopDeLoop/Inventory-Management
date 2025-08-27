namespace InventoryManagement
{
    partial class AddPartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPartForm));
            this.WindowLabel = new System.Windows.Forms.Label();
            this.InHouseButton = new System.Windows.Forms.RadioButton();
            this.OutsourcedButton = new System.Windows.Forms.RadioButton();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.InventoryTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.MinTextBox = new System.Windows.Forms.TextBox();
            this.MachineIDTextBox = new System.Windows.Forms.TextBox();
            this.MaxTextBox = new System.Windows.Forms.TextBox();
            this.MachineIDLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.InventoryLabel = new System.Windows.Forms.Label();
            this.PriceCostLabel = new System.Windows.Forms.Label();
            this.MinLabel = new System.Windows.Forms.Label();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.InHousePanel = new System.Windows.Forms.Panel();
            this.OutsourcedPanel = new System.Windows.Forms.Panel();
            this.CompanyNameTextBox = new System.Windows.Forms.TextBox();
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.CancelButtton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.InHousePanel.SuspendLayout();
            this.OutsourcedPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WindowLabel
            // 
            this.WindowLabel.AutoSize = true;
            this.WindowLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowLabel.Location = new System.Drawing.Point(12, 9);
            this.WindowLabel.Name = "WindowLabel";
            this.WindowLabel.Size = new System.Drawing.Size(114, 25);
            this.WindowLabel.TabIndex = 2;
            this.WindowLabel.Text = "Add Part";
            // 
            // InHouseButton
            // 
            this.InHouseButton.AutoSize = true;
            this.InHouseButton.Location = new System.Drawing.Point(142, 12);
            this.InHouseButton.Name = "InHouseButton";
            this.InHouseButton.Size = new System.Drawing.Size(68, 17);
            this.InHouseButton.TabIndex = 3;
            this.InHouseButton.TabStop = true;
            this.InHouseButton.Text = "In-House";
            this.InHouseButton.UseVisualStyleBackColor = true;
            this.InHouseButton.CheckedChanged += new System.EventHandler(this.InHouseButton_CheckedChanged);
            // 
            // OutsourcedButton
            // 
            this.OutsourcedButton.AutoSize = true;
            this.OutsourcedButton.Location = new System.Drawing.Point(216, 12);
            this.OutsourcedButton.Name = "OutsourcedButton";
            this.OutsourcedButton.Size = new System.Drawing.Size(80, 17);
            this.OutsourcedButton.TabIndex = 4;
            this.OutsourcedButton.Text = "Outsourced";
            this.OutsourcedButton.UseVisualStyleBackColor = true;
            this.OutsourcedButton.CheckedChanged += new System.EventHandler(this.OutsourcedButton_CheckedChanged);
            // 
            // IDTextBox
            // 
            this.IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDTextBox.Location = new System.Drawing.Point(140, 48);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(156, 20);
            this.IDTextBox.TabIndex = 14;
            // 
            // NameTextBox
            // 
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.Location = new System.Drawing.Point(140, 74);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(156, 20);
            this.NameTextBox.TabIndex = 15;
            // 
            // InventoryTextBox
            // 
            this.InventoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InventoryTextBox.Location = new System.Drawing.Point(140, 100);
            this.InventoryTextBox.Name = "InventoryTextBox";
            this.InventoryTextBox.Size = new System.Drawing.Size(156, 20);
            this.InventoryTextBox.TabIndex = 16;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceTextBox.Location = new System.Drawing.Point(140, 126);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(156, 20);
            this.PriceTextBox.TabIndex = 17;
            // 
            // MinTextBox
            // 
            this.MinTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MinTextBox.Location = new System.Drawing.Point(140, 152);
            this.MinTextBox.Name = "MinTextBox";
            this.MinTextBox.Size = new System.Drawing.Size(54, 20);
            this.MinTextBox.TabIndex = 18;
            // 
            // MachineIDTextBox
            // 
            this.MachineIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MachineIDTextBox.Location = new System.Drawing.Point(113, 3);
            this.MachineIDTextBox.Name = "MachineIDTextBox";
            this.MachineIDTextBox.Size = new System.Drawing.Size(156, 20);
            this.MachineIDTextBox.TabIndex = 19;
            // 
            // MaxTextBox
            // 
            this.MaxTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxTextBox.Location = new System.Drawing.Point(242, 152);
            this.MaxTextBox.Name = "MaxTextBox";
            this.MaxTextBox.Size = new System.Drawing.Size(54, 20);
            this.MaxTextBox.TabIndex = 20;
            // 
            // MachineIDLabel
            // 
            this.MachineIDLabel.AutoSize = true;
            this.MachineIDLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MachineIDLabel.Location = new System.Drawing.Point(15, 3);
            this.MachineIDLabel.Name = "MachineIDLabel";
            this.MachineIDLabel.Size = new System.Drawing.Size(92, 16);
            this.MachineIDLabel.TabIndex = 28;
            this.MachineIDLabel.Text = "Machine ID:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.Location = new System.Drawing.Point(106, 48);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(28, 16);
            this.IDLabel.TabIndex = 22;
            this.IDLabel.Text = "ID:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(80, 78);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(54, 16);
            this.NameLabel.TabIndex = 23;
            this.NameLabel.Text = "Name:";
            // 
            // InventoryLabel
            // 
            this.InventoryLabel.AutoSize = true;
            this.InventoryLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryLabel.Location = new System.Drawing.Point(50, 100);
            this.InventoryLabel.Name = "InventoryLabel";
            this.InventoryLabel.Size = new System.Drawing.Size(84, 16);
            this.InventoryLabel.TabIndex = 24;
            this.InventoryLabel.Text = "Inventory:";
            // 
            // PriceCostLabel
            // 
            this.PriceCostLabel.AutoSize = true;
            this.PriceCostLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceCostLabel.Location = new System.Drawing.Point(44, 126);
            this.PriceCostLabel.Name = "PriceCostLabel";
            this.PriceCostLabel.Size = new System.Drawing.Size(90, 16);
            this.PriceCostLabel.TabIndex = 25;
            this.PriceCostLabel.Text = "Price/Cost:";
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinLabel.Location = new System.Drawing.Point(97, 152);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(37, 16);
            this.MinLabel.TabIndex = 26;
            this.MinLabel.Text = "Min:";
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxLabel.Location = new System.Drawing.Point(194, 152);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(42, 16);
            this.MaxLabel.TabIndex = 27;
            this.MaxLabel.Text = "Max:";
            // 
            // InHousePanel
            // 
            this.InHousePanel.Controls.Add(this.MachineIDTextBox);
            this.InHousePanel.Controls.Add(this.MachineIDLabel);
            this.InHousePanel.Location = new System.Drawing.Point(27, 178);
            this.InHousePanel.Name = "InHousePanel";
            this.InHousePanel.Size = new System.Drawing.Size(296, 25);
            this.InHousePanel.TabIndex = 29;
            // 
            // OutsourcedPanel
            // 
            this.OutsourcedPanel.Controls.Add(this.CompanyNameTextBox);
            this.OutsourcedPanel.Controls.Add(this.CompanyNameLabel);
            this.OutsourcedPanel.Location = new System.Drawing.Point(1, 179);
            this.OutsourcedPanel.Name = "OutsourcedPanel";
            this.OutsourcedPanel.Size = new System.Drawing.Size(322, 25);
            this.OutsourcedPanel.TabIndex = 30;
            // 
            // CompanyNameTextBox
            // 
            this.CompanyNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompanyNameTextBox.Location = new System.Drawing.Point(139, 2);
            this.CompanyNameTextBox.Name = "CompanyNameTextBox";
            this.CompanyNameTextBox.Size = new System.Drawing.Size(156, 20);
            this.CompanyNameTextBox.TabIndex = 19;
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyNameLabel.Location = new System.Drawing.Point(6, 2);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(127, 16);
            this.CompanyNameLabel.TabIndex = 28;
            this.CompanyNameLabel.Text = "Company Name:";
            // 
            // CancelButtton
            // 
            this.CancelButtton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CancelButtton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButtton.Location = new System.Drawing.Point(140, 210);
            this.CancelButtton.Name = "CancelButtton";
            this.CancelButtton.Size = new System.Drawing.Size(75, 23);
            this.CancelButtton.TabIndex = 31;
            this.CancelButtton.Text = "Cancel";
            this.CancelButtton.UseVisualStyleBackColor = true;
            this.CancelButtton.Click += new System.EventHandler(this.CancelButtton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SaveButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(221, 210);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 32;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 241);
            this.Controls.Add(this.OutsourcedPanel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CancelButtton);
            this.Controls.Add(this.MaxLabel);
            this.Controls.Add(this.MinLabel);
            this.Controls.Add(this.PriceCostLabel);
            this.Controls.Add(this.InventoryLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.MaxTextBox);
            this.Controls.Add(this.MinTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.InventoryTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.OutsourcedButton);
            this.Controls.Add(this.InHouseButton);
            this.Controls.Add(this.WindowLabel);
            this.Controls.Add(this.InHousePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPartForm";
            this.Text = "Add Part Screen";
            this.InHousePanel.ResumeLayout(false);
            this.InHousePanel.PerformLayout();
            this.OutsourcedPanel.ResumeLayout(false);
            this.OutsourcedPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label WindowLabel;
        private System.Windows.Forms.RadioButton InHouseButton;
        private System.Windows.Forms.RadioButton OutsourcedButton;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox InventoryTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox MinTextBox;
        private System.Windows.Forms.TextBox MachineIDTextBox;
        private System.Windows.Forms.TextBox MaxTextBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label InventoryLabel;
        private System.Windows.Forms.Label PriceCostLabel;
        private System.Windows.Forms.Label MinLabel;
        private System.Windows.Forms.Label MaxLabel;
        private System.Windows.Forms.Label MachineIDLabel;
        private System.Windows.Forms.Panel InHousePanel;
        private System.Windows.Forms.Panel OutsourcedPanel;
        private System.Windows.Forms.TextBox CompanyNameTextBox;
        private System.Windows.Forms.Label CompanyNameLabel;
        private System.Windows.Forms.Button CancelButtton;
        private System.Windows.Forms.Button SaveButton;
    }
}