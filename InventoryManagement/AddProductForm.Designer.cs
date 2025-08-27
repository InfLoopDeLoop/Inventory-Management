namespace InventoryManagement
{
    partial class AddProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            this.WindowLabel = new System.Windows.Forms.Label();
            this.CandidateTable = new System.Windows.Forms.ListView();
            this.TopID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TopName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TopInventory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TopPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TopMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TopMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AssociatedTable = new System.Windows.Forms.ListView();
            this.BottomID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BottomName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BottomInventory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BottomPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BottomMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BottomMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TopTableLabel = new System.Windows.Forms.Label();
            this.BottomTableLabel = new System.Windows.Forms.Label();
            this.CandidateTableSearchBar = new System.Windows.Forms.TextBox();
            this.AssociatedTableSearchBar = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.InventoryTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.MinTextBox = new System.Windows.Forms.TextBox();
            this.MaxTextBox = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.InventoryLabel = new System.Windows.Forms.Label();
            this.PriceCostLabel = new System.Windows.Forms.Label();
            this.MinLabel = new System.Windows.Forms.Label();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.AddPartButtton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeletePartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WindowLabel
            // 
            this.WindowLabel.AutoSize = true;
            this.WindowLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowLabel.Location = new System.Drawing.Point(12, 9);
            this.WindowLabel.Name = "WindowLabel";
            this.WindowLabel.Size = new System.Drawing.Size(156, 25);
            this.WindowLabel.TabIndex = 3;
            this.WindowLabel.Text = "Add Product";
            // 
            // CandidateTable
            // 
            this.CandidateTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CandidateTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TopID,
            this.TopName,
            this.TopInventory,
            this.TopPrice,
            this.TopMin,
            this.TopMax});
            this.CandidateTable.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CandidateTable.FullRowSelect = true;
            this.CandidateTable.HideSelection = false;
            this.CandidateTable.Location = new System.Drawing.Point(308, 38);
            this.CandidateTable.MultiSelect = false;
            this.CandidateTable.Name = "CandidateTable";
            this.CandidateTable.Size = new System.Drawing.Size(480, 240);
            this.CandidateTable.TabIndex = 9;
            this.CandidateTable.TileSize = new System.Drawing.Size(228, 30);
            this.CandidateTable.UseCompatibleStateImageBehavior = false;
            this.CandidateTable.View = System.Windows.Forms.View.Details;
            // 
            // TopID
            // 
            this.TopID.Text = "Part ID";
            this.TopID.Width = 80;
            // 
            // TopName
            // 
            this.TopName.Text = "Name";
            this.TopName.Width = 80;
            // 
            // TopInventory
            // 
            this.TopInventory.Text = "Inventory";
            this.TopInventory.Width = 80;
            // 
            // TopPrice
            // 
            this.TopPrice.Text = "Price";
            this.TopPrice.Width = 80;
            // 
            // TopMin
            // 
            this.TopMin.Text = "Min";
            this.TopMin.Width = 80;
            // 
            // TopMax
            // 
            this.TopMax.Text = "Max";
            this.TopMax.Width = 80;
            // 
            // AssociatedTable
            // 
            this.AssociatedTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssociatedTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BottomID,
            this.BottomName,
            this.BottomInventory,
            this.BottomPrice,
            this.BottomMin,
            this.BottomMax});
            this.AssociatedTable.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssociatedTable.FullRowSelect = true;
            this.AssociatedTable.HideSelection = false;
            this.AssociatedTable.Location = new System.Drawing.Point(308, 342);
            this.AssociatedTable.MultiSelect = false;
            this.AssociatedTable.Name = "AssociatedTable";
            this.AssociatedTable.Size = new System.Drawing.Size(480, 240);
            this.AssociatedTable.TabIndex = 10;
            this.AssociatedTable.TileSize = new System.Drawing.Size(228, 30);
            this.AssociatedTable.UseCompatibleStateImageBehavior = false;
            this.AssociatedTable.View = System.Windows.Forms.View.Details;
            // 
            // BottomID
            // 
            this.BottomID.Text = "Part ID";
            this.BottomID.Width = 80;
            // 
            // BottomName
            // 
            this.BottomName.Text = "Name";
            this.BottomName.Width = 80;
            // 
            // BottomInventory
            // 
            this.BottomInventory.Text = "Inventory";
            this.BottomInventory.Width = 80;
            // 
            // BottomPrice
            // 
            this.BottomPrice.Text = "Price";
            this.BottomPrice.Width = 80;
            // 
            // BottomMin
            // 
            this.BottomMin.Text = "Min";
            this.BottomMin.Width = 80;
            // 
            // BottomMax
            // 
            this.BottomMax.Text = "Max";
            this.BottomMax.Width = 80;
            // 
            // TopTableLabel
            // 
            this.TopTableLabel.AutoSize = true;
            this.TopTableLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopTableLabel.Location = new System.Drawing.Point(305, 17);
            this.TopTableLabel.Name = "TopTableLabel";
            this.TopTableLabel.Size = new System.Drawing.Size(149, 18);
            this.TopTableLabel.TabIndex = 16;
            this.TopTableLabel.Text = "Candidate Parts";
            // 
            // BottomTableLabel
            // 
            this.BottomTableLabel.AutoSize = true;
            this.BottomTableLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomTableLabel.Location = new System.Drawing.Point(305, 321);
            this.BottomTableLabel.Name = "BottomTableLabel";
            this.BottomTableLabel.Size = new System.Drawing.Size(154, 18);
            this.BottomTableLabel.TabIndex = 17;
            this.BottomTableLabel.Text = "Associated Parts";
            // 
            // CandidateTableSearchBar
            // 
            this.CandidateTableSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CandidateTableSearchBar.Location = new System.Drawing.Point(632, 12);
            this.CandidateTableSearchBar.Name = "CandidateTableSearchBar";
            this.CandidateTableSearchBar.Size = new System.Drawing.Size(156, 20);
            this.CandidateTableSearchBar.TabIndex = 18;
            // 
            // AssociatedTableSearchBar
            // 
            this.AssociatedTableSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssociatedTableSearchBar.Location = new System.Drawing.Point(632, 316);
            this.AssociatedTableSearchBar.Name = "AssociatedTableSearchBar";
            this.AssociatedTableSearchBar.Size = new System.Drawing.Size(156, 20);
            this.AssociatedTableSearchBar.TabIndex = 19;
            // 
            // IDTextBox
            // 
            this.IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDTextBox.Location = new System.Drawing.Point(106, 241);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(156, 20);
            this.IDTextBox.TabIndex = 20;
            // 
            // NameTextBox
            // 
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.Location = new System.Drawing.Point(106, 267);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(156, 20);
            this.NameTextBox.TabIndex = 21;
            // 
            // InventoryTextBox
            // 
            this.InventoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InventoryTextBox.Location = new System.Drawing.Point(106, 293);
            this.InventoryTextBox.Name = "InventoryTextBox";
            this.InventoryTextBox.Size = new System.Drawing.Size(156, 20);
            this.InventoryTextBox.TabIndex = 22;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceTextBox.Location = new System.Drawing.Point(106, 319);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(156, 20);
            this.PriceTextBox.TabIndex = 23;
            // 
            // MinTextBox
            // 
            this.MinTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MinTextBox.Location = new System.Drawing.Point(106, 345);
            this.MinTextBox.Name = "MinTextBox";
            this.MinTextBox.Size = new System.Drawing.Size(54, 20);
            this.MinTextBox.TabIndex = 24;
            // 
            // MaxTextBox
            // 
            this.MaxTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxTextBox.Location = new System.Drawing.Point(208, 345);
            this.MaxTextBox.Name = "MaxTextBox";
            this.MaxTextBox.Size = new System.Drawing.Size(54, 20);
            this.MaxTextBox.TabIndex = 25;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.Location = new System.Drawing.Point(72, 241);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(28, 16);
            this.IDLabel.TabIndex = 26;
            this.IDLabel.Text = "ID:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(46, 267);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(54, 16);
            this.NameLabel.TabIndex = 27;
            this.NameLabel.Text = "Name:";
            // 
            // InventoryLabel
            // 
            this.InventoryLabel.AutoSize = true;
            this.InventoryLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryLabel.Location = new System.Drawing.Point(16, 293);
            this.InventoryLabel.Name = "InventoryLabel";
            this.InventoryLabel.Size = new System.Drawing.Size(84, 16);
            this.InventoryLabel.TabIndex = 28;
            this.InventoryLabel.Text = "Inventory:";
            // 
            // PriceCostLabel
            // 
            this.PriceCostLabel.AutoSize = true;
            this.PriceCostLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceCostLabel.Location = new System.Drawing.Point(10, 319);
            this.PriceCostLabel.Name = "PriceCostLabel";
            this.PriceCostLabel.Size = new System.Drawing.Size(90, 16);
            this.PriceCostLabel.TabIndex = 29;
            this.PriceCostLabel.Text = "Price/Cost:";
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinLabel.Location = new System.Drawing.Point(63, 345);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(37, 16);
            this.MinLabel.TabIndex = 30;
            this.MinLabel.Text = "Min:";
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxLabel.Location = new System.Drawing.Point(164, 345);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(42, 16);
            this.MaxLabel.TabIndex = 31;
            this.MaxLabel.Text = "Max:";
            // 
            // AddPartButtton
            // 
            this.AddPartButtton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddPartButtton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartButtton.Location = new System.Drawing.Point(713, 284);
            this.AddPartButtton.Name = "AddPartButtton";
            this.AddPartButtton.Size = new System.Drawing.Size(75, 23);
            this.AddPartButtton.TabIndex = 32;
            this.AddPartButtton.Text = "Add";
            this.AddPartButtton.UseVisualStyleBackColor = true;
            this.AddPartButtton.Click += new System.EventHandler(this.AddPartButtton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CancelButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(106, 371);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 33;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SaveButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(187, 371);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 34;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeletePartButton
            // 
            this.DeletePartButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DeletePartButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePartButton.Location = new System.Drawing.Point(713, 588);
            this.DeletePartButton.Name = "DeletePartButton";
            this.DeletePartButton.Size = new System.Drawing.Size(75, 23);
            this.DeletePartButton.TabIndex = 35;
            this.DeletePartButton.Text = "Delete";
            this.DeletePartButton.UseVisualStyleBackColor = true;
            this.DeletePartButton.Click += new System.EventHandler(this.DeletePartButton_Click);
            // 
            // AddProductForm
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
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.InventoryTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.AssociatedTableSearchBar);
            this.Controls.Add(this.CandidateTableSearchBar);
            this.Controls.Add(this.BottomTableLabel);
            this.Controls.Add(this.TopTableLabel);
            this.Controls.Add(this.AssociatedTable);
            this.Controls.Add(this.CandidateTable);
            this.Controls.Add(this.WindowLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProductForm";
            this.Text = "Add Product Screen";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WindowLabel;
        private System.Windows.Forms.ListView CandidateTable;
        private System.Windows.Forms.ColumnHeader TopID;
        private System.Windows.Forms.ColumnHeader TopName;
        private System.Windows.Forms.ColumnHeader TopInventory;
        private System.Windows.Forms.ColumnHeader TopPrice;
        private System.Windows.Forms.ColumnHeader TopMin;
        private System.Windows.Forms.ColumnHeader TopMax;
        private System.Windows.Forms.ListView AssociatedTable;
        private System.Windows.Forms.ColumnHeader BottomID;
        private System.Windows.Forms.ColumnHeader BottomName;
        private System.Windows.Forms.ColumnHeader BottomInventory;
        private System.Windows.Forms.ColumnHeader BottomPrice;
        private System.Windows.Forms.ColumnHeader BottomMin;
        private System.Windows.Forms.ColumnHeader BottomMax;
        private System.Windows.Forms.Label TopTableLabel;
        private System.Windows.Forms.Label BottomTableLabel;
        private System.Windows.Forms.TextBox CandidateTableSearchBar;
        private System.Windows.Forms.TextBox AssociatedTableSearchBar;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox InventoryTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox MinTextBox;
        private System.Windows.Forms.TextBox MaxTextBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label InventoryLabel;
        private System.Windows.Forms.Label PriceCostLabel;
        private System.Windows.Forms.Label MinLabel;
        private System.Windows.Forms.Label MaxLabel;
        private System.Windows.Forms.Button AddPartButtton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DeletePartButton;
    }
}