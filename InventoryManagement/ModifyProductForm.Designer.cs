namespace InventoryManagement
{
    partial class ModifyProductForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyProductForm));
            this.DeletePartButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddPartButtton = new System.Windows.Forms.Button();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.MinLabel = new System.Windows.Forms.Label();
            this.PriceCostLabel = new System.Windows.Forms.Label();
            this.InventoryLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.MaxTextBox = new System.Windows.Forms.TextBox();
            this.MinTextBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.AssociatedPartsTableSearchBar = new System.Windows.Forms.TextBox();
            this.CandidatePartsTableSearchBar = new System.Windows.Forms.TextBox();
            this.BottomTableLabel = new System.Windows.Forms.Label();
            this.TopTableLabel = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PartsTable = new System.Windows.Forms.ListView();
            this.PartID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PartName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PartInventory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PartPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PartMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PartMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WindowLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeletePartButton
            // 
            this.DeletePartButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DeletePartButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePartButton.Location = new System.Drawing.Point(713, 588);
            this.DeletePartButton.Name = "DeletePartButton";
            this.DeletePartButton.Size = new System.Drawing.Size(75, 23);
            this.DeletePartButton.TabIndex = 58;
            this.DeletePartButton.Text = "Delete";
            this.DeletePartButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SaveButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(187, 371);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 57;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CancelButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(106, 371);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 56;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddPartButtton
            // 
            this.AddPartButtton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddPartButtton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartButtton.Location = new System.Drawing.Point(713, 284);
            this.AddPartButtton.Name = "AddPartButtton";
            this.AddPartButtton.Size = new System.Drawing.Size(75, 23);
            this.AddPartButtton.TabIndex = 55;
            this.AddPartButtton.Text = "Add";
            this.AddPartButtton.UseVisualStyleBackColor = true;
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxLabel.Location = new System.Drawing.Point(164, 345);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(42, 16);
            this.MaxLabel.TabIndex = 54;
            this.MaxLabel.Text = "Max:";
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinLabel.Location = new System.Drawing.Point(63, 345);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(37, 16);
            this.MinLabel.TabIndex = 53;
            this.MinLabel.Text = "Min:";
            // 
            // PriceCostLabel
            // 
            this.PriceCostLabel.AutoSize = true;
            this.PriceCostLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceCostLabel.Location = new System.Drawing.Point(10, 319);
            this.PriceCostLabel.Name = "PriceCostLabel";
            this.PriceCostLabel.Size = new System.Drawing.Size(90, 16);
            this.PriceCostLabel.TabIndex = 52;
            this.PriceCostLabel.Text = "Price/Cost:";
            // 
            // InventoryLabel
            // 
            this.InventoryLabel.AutoSize = true;
            this.InventoryLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryLabel.Location = new System.Drawing.Point(16, 293);
            this.InventoryLabel.Name = "InventoryLabel";
            this.InventoryLabel.Size = new System.Drawing.Size(84, 16);
            this.InventoryLabel.TabIndex = 51;
            this.InventoryLabel.Text = "Inventory:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(46, 267);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(54, 16);
            this.NameLabel.TabIndex = 50;
            this.NameLabel.Text = "Name:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.Location = new System.Drawing.Point(72, 241);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(28, 16);
            this.IDLabel.TabIndex = 49;
            this.IDLabel.Text = "ID:";
            // 
            // MaxTextBox
            // 
            this.MaxTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxTextBox.Location = new System.Drawing.Point(208, 345);
            this.MaxTextBox.Name = "MaxTextBox";
            this.MaxTextBox.Size = new System.Drawing.Size(54, 20);
            this.MaxTextBox.TabIndex = 48;
            // 
            // MinTextBox
            // 
            this.MinTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MinTextBox.Location = new System.Drawing.Point(106, 345);
            this.MinTextBox.Name = "MinTextBox";
            this.MinTextBox.Size = new System.Drawing.Size(54, 20);
            this.MinTextBox.TabIndex = 47;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(106, 319);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(156, 20);
            this.textBox3.TabIndex = 46;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(106, 293);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 20);
            this.textBox2.TabIndex = 45;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(106, 267);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 44;
            // 
            // IDTextBox
            // 
            this.IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDTextBox.Location = new System.Drawing.Point(106, 241);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(156, 20);
            this.IDTextBox.TabIndex = 43;
            // 
            // AssociatedPartsTableSearchBar
            // 
            this.AssociatedPartsTableSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssociatedPartsTableSearchBar.Location = new System.Drawing.Point(632, 316);
            this.AssociatedPartsTableSearchBar.Name = "AssociatedPartsTableSearchBar";
            this.AssociatedPartsTableSearchBar.Size = new System.Drawing.Size(156, 20);
            this.AssociatedPartsTableSearchBar.TabIndex = 42;
            // 
            // CandidatePartsTableSearchBar
            // 
            this.CandidatePartsTableSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CandidatePartsTableSearchBar.Location = new System.Drawing.Point(632, 12);
            this.CandidatePartsTableSearchBar.Name = "CandidatePartsTableSearchBar";
            this.CandidatePartsTableSearchBar.Size = new System.Drawing.Size(156, 20);
            this.CandidatePartsTableSearchBar.TabIndex = 41;
            // 
            // BottomTableLabel
            // 
            this.BottomTableLabel.AutoSize = true;
            this.BottomTableLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomTableLabel.Location = new System.Drawing.Point(305, 321);
            this.BottomTableLabel.Name = "BottomTableLabel";
            this.BottomTableLabel.Size = new System.Drawing.Size(154, 18);
            this.BottomTableLabel.TabIndex = 40;
            this.BottomTableLabel.Text = "Associated Parts";
            // 
            // TopTableLabel
            // 
            this.TopTableLabel.AutoSize = true;
            this.TopTableLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopTableLabel.Location = new System.Drawing.Point(305, 17);
            this.TopTableLabel.Name = "TopTableLabel";
            this.TopTableLabel.Size = new System.Drawing.Size(149, 18);
            this.TopTableLabel.TabIndex = 39;
            this.TopTableLabel.Text = "Candidate Parts";
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(308, 342);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(480, 240);
            this.listView1.TabIndex = 38;
            this.listView1.TileSize = new System.Drawing.Size(228, 30);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Part ID";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Inventory";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Min";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Max";
            this.columnHeader6.Width = 80;
            // 
            // PartsTable
            // 
            this.PartsTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PartsTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PartID,
            this.PartName,
            this.PartInventory,
            this.PartPrice,
            this.PartMin,
            this.PartMax});
            this.PartsTable.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsTable.FullRowSelect = true;
            this.PartsTable.HideSelection = false;
            this.PartsTable.Location = new System.Drawing.Point(308, 38);
            this.PartsTable.MultiSelect = false;
            this.PartsTable.Name = "PartsTable";
            this.PartsTable.Size = new System.Drawing.Size(480, 240);
            this.PartsTable.TabIndex = 37;
            this.PartsTable.TileSize = new System.Drawing.Size(228, 30);
            this.PartsTable.UseCompatibleStateImageBehavior = false;
            this.PartsTable.View = System.Windows.Forms.View.Details;
            // 
            // PartID
            // 
            this.PartID.Text = "Part ID";
            this.PartID.Width = 80;
            // 
            // PartName
            // 
            this.PartName.Text = "Name";
            this.PartName.Width = 80;
            // 
            // PartInventory
            // 
            this.PartInventory.Text = "Inventory";
            this.PartInventory.Width = 80;
            // 
            // PartPrice
            // 
            this.PartPrice.Text = "Price";
            this.PartPrice.Width = 80;
            // 
            // PartMin
            // 
            this.PartMin.Text = "Min";
            this.PartMin.Width = 80;
            // 
            // PartMax
            // 
            this.PartMax.Text = "Max";
            this.PartMax.Width = 80;
            // 
            // WindowLabel
            // 
            this.WindowLabel.AutoSize = true;
            this.WindowLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowLabel.Location = new System.Drawing.Point(12, 9);
            this.WindowLabel.Name = "WindowLabel";
            this.WindowLabel.Size = new System.Drawing.Size(189, 25);
            this.WindowLabel.TabIndex = 36;
            this.WindowLabel.Text = "Modify Product";
            // 
            // ModifyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 621);
            this.Controls.Add(this.DeletePartButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddPartButtton);
            this.Controls.Add(this.MaxLabel);
            this.Controls.Add(this.MinLabel);
            this.Controls.Add(this.PriceCostLabel);
            this.Controls.Add(this.InventoryLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.MaxTextBox);
            this.Controls.Add(this.MinTextBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.AssociatedPartsTableSearchBar);
            this.Controls.Add(this.CandidatePartsTableSearchBar);
            this.Controls.Add(this.BottomTableLabel);
            this.Controls.Add(this.TopTableLabel);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.PartsTable);
            this.Controls.Add(this.WindowLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifyProductForm";
            this.Text = "Modify Product Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeletePartButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddPartButtton;
        private System.Windows.Forms.Label MaxLabel;
        private System.Windows.Forms.Label MinLabel;
        private System.Windows.Forms.Label PriceCostLabel;
        private System.Windows.Forms.Label InventoryLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox MaxTextBox;
        private System.Windows.Forms.TextBox MinTextBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox AssociatedPartsTableSearchBar;
        private System.Windows.Forms.TextBox CandidatePartsTableSearchBar;
        private System.Windows.Forms.Label BottomTableLabel;
        private System.Windows.Forms.Label TopTableLabel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView PartsTable;
        private System.Windows.Forms.ColumnHeader PartID;
        private System.Windows.Forms.ColumnHeader PartName;
        private System.Windows.Forms.ColumnHeader PartInventory;
        private System.Windows.Forms.ColumnHeader PartPrice;
        private System.Windows.Forms.ColumnHeader PartMin;
        private System.Windows.Forms.ColumnHeader PartMax;
        private System.Windows.Forms.Label WindowLabel;
    }
}