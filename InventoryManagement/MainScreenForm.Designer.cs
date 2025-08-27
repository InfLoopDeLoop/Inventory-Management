using System.Windows.Forms;

namespace InventoryManagement
{
    partial class MainScreenForm : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreenForm));
            this.WindowLabel = new System.Windows.Forms.Label();
            this.AddPartButton = new System.Windows.Forms.Button();
            this.ModifyPartButton = new System.Windows.Forms.Button();
            this.DeletePartButtton = new System.Windows.Forms.Button();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.ModifyProductButton = new System.Windows.Forms.Button();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.PartsTable = new System.Windows.Forms.ListView();
            this.PartID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PartName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PartInventory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PartPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PartMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PartMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductsTable = new System.Windows.Forms.ListView();
            this.ProductID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductInventory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LeftTableLabel = new System.Windows.Forms.Label();
            this.RightTableLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PartsTableSearchBar = new System.Windows.Forms.TextBox();
            this.PoductsTableSearchBar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WindowLabel
            // 
            this.WindowLabel.AutoSize = true;
            this.WindowLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowLabel.Location = new System.Drawing.Point(7, 9);
            this.WindowLabel.Name = "WindowLabel";
            this.WindowLabel.Size = new System.Drawing.Size(383, 25);
            this.WindowLabel.TabIndex = 1;
            this.WindowLabel.Text = "Inventory Management System";
            // 
            // AddPartButton
            // 
            this.AddPartButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddPartButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartButton.Location = new System.Drawing.Point(255, 366);
            this.AddPartButton.Name = "AddPartButton";
            this.AddPartButton.Size = new System.Drawing.Size(75, 23);
            this.AddPartButton.TabIndex = 2;
            this.AddPartButton.Text = "Add";
            this.AddPartButton.UseVisualStyleBackColor = true;
            this.AddPartButton.Click += new System.EventHandler(this.AddPartsButton_Click);
            // 
            // ModifyPartButton
            // 
            this.ModifyPartButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ModifyPartButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyPartButton.Location = new System.Drawing.Point(336, 366);
            this.ModifyPartButton.Name = "ModifyPartButton";
            this.ModifyPartButton.Size = new System.Drawing.Size(75, 23);
            this.ModifyPartButton.TabIndex = 3;
            this.ModifyPartButton.Text = "Modify";
            this.ModifyPartButton.UseVisualStyleBackColor = true;
            this.ModifyPartButton.Click += new System.EventHandler(this.ModifyPartButton_Click);
            // 
            // DeletePartButtton
            // 
            this.DeletePartButtton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DeletePartButtton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePartButtton.Location = new System.Drawing.Point(417, 366);
            this.DeletePartButtton.Name = "DeletePartButtton";
            this.DeletePartButtton.Size = new System.Drawing.Size(75, 23);
            this.DeletePartButtton.TabIndex = 4;
            this.DeletePartButtton.Text = "Delete";
            this.DeletePartButtton.UseVisualStyleBackColor = true;
            this.DeletePartButtton.Click += new System.EventHandler(this.DeletePartButtton_Click);
            // 
            // AddProductButton
            // 
            this.AddProductButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddProductButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductButton.Location = new System.Drawing.Point(747, 366);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(75, 23);
            this.AddProductButton.TabIndex = 5;
            this.AddProductButton.Text = "Add";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // ModifyProductButton
            // 
            this.ModifyProductButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ModifyProductButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductButton.Location = new System.Drawing.Point(828, 366);
            this.ModifyProductButton.Name = "ModifyProductButton";
            this.ModifyProductButton.Size = new System.Drawing.Size(75, 23);
            this.ModifyProductButton.TabIndex = 6;
            this.ModifyProductButton.Text = "Modify";
            this.ModifyProductButton.UseVisualStyleBackColor = true;
            this.ModifyProductButton.Click += new System.EventHandler(this.ModifyProductButton_Click);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DeleteProductButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteProductButton.Location = new System.Drawing.Point(909, 366);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteProductButton.TabIndex = 7;
            this.DeleteProductButton.Text = "Delete";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
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
            this.PartsTable.Location = new System.Drawing.Point(12, 120);
            this.PartsTable.MultiSelect = false;
            this.PartsTable.Name = "PartsTable";
            this.PartsTable.Size = new System.Drawing.Size(480, 240);
            this.PartsTable.TabIndex = 8;
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
            // ProductsTable
            // 
            this.ProductsTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductsTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductID,
            this.ProductName,
            this.ProductInventory,
            this.ProductPrice,
            this.ProductMin,
            this.ProductMax});
            this.ProductsTable.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsTable.HideSelection = false;
            this.ProductsTable.Location = new System.Drawing.Point(504, 120);
            this.ProductsTable.Name = "ProductsTable";
            this.ProductsTable.Size = new System.Drawing.Size(480, 240);
            this.ProductsTable.TabIndex = 9;
            this.ProductsTable.UseCompatibleStateImageBehavior = false;
            this.ProductsTable.View = System.Windows.Forms.View.Details;
            // 
            // ProductID
            // 
            this.ProductID.Text = "Product ID";
            this.ProductID.Width = 80;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Name";
            this.ProductName.Width = 80;
            // 
            // ProductInventory
            // 
            this.ProductInventory.Text = "Inventory";
            this.ProductInventory.Width = 80;
            // 
            // ProductPrice
            // 
            this.ProductPrice.Text = "Price";
            this.ProductPrice.Width = 80;
            // 
            // ProductMin
            // 
            this.ProductMin.Text = "Min";
            this.ProductMin.Width = 80;
            // 
            // ProductMax
            // 
            this.ProductMax.Text = "Max";
            this.ProductMax.Width = 80;
            // 
            // LeftTableLabel
            // 
            this.LeftTableLabel.AutoSize = true;
            this.LeftTableLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftTableLabel.Location = new System.Drawing.Point(12, 99);
            this.LeftTableLabel.Name = "LeftTableLabel";
            this.LeftTableLabel.Size = new System.Drawing.Size(55, 18);
            this.LeftTableLabel.TabIndex = 10;
            this.LeftTableLabel.Text = "Parts";
            // 
            // RightTableLabel
            // 
            this.RightTableLabel.AutoSize = true;
            this.RightTableLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightTableLabel.Location = new System.Drawing.Point(501, 99);
            this.RightTableLabel.Name = "RightTableLabel";
            this.RightTableLabel.Size = new System.Drawing.Size(86, 18);
            this.RightTableLabel.TabIndex = 11;
            this.RightTableLabel.Text = "Products";
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ExitButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(909, 9);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PartsTableSearchBar
            // 
            this.PartsTableSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PartsTableSearchBar.Location = new System.Drawing.Point(336, 94);
            this.PartsTableSearchBar.Name = "PartsTableSearchBar";
            this.PartsTableSearchBar.Size = new System.Drawing.Size(156, 20);
            this.PartsTableSearchBar.TabIndex = 13;
            this.PartsTableSearchBar.TextChanged += new System.EventHandler(this.PartsTableSearchBar_TextChanged);
            // 
            // PoductsTableSearchBar
            // 
            this.PoductsTableSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PoductsTableSearchBar.Location = new System.Drawing.Point(828, 94);
            this.PoductsTableSearchBar.Name = "PoductsTableSearchBar";
            this.PoductsTableSearchBar.Size = new System.Drawing.Size(156, 20);
            this.PoductsTableSearchBar.TabIndex = 14;
            this.PoductsTableSearchBar.TextChanged += new System.EventHandler(this.PoductsTableSearchBar_TextChanged);
            // 
            // MainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 401);
            this.Controls.Add(this.PoductsTableSearchBar);
            this.Controls.Add(this.PartsTableSearchBar);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RightTableLabel);
            this.Controls.Add(this.LeftTableLabel);
            this.Controls.Add(this.ProductsTable);
            this.Controls.Add(this.PartsTable);
            this.Controls.Add(this.DeleteProductButton);
            this.Controls.Add(this.ModifyProductButton);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.DeletePartButtton);
            this.Controls.Add(this.ModifyPartButton);
            this.Controls.Add(this.AddPartButton);
            this.Controls.Add(this.WindowLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreenForm";
            this.Text = "Main Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label WindowLabel;
        private Button AddPartButton;
        private Button ModifyPartButton;
        private Button DeletePartButtton;
        private Button AddProductButton;
        private Button ModifyProductButton;
        private Button DeleteProductButton;
        private ListView PartsTable;
        private ListView ProductsTable;
        private Label LeftTableLabel;
        private Label RightTableLabel;
        private Button ExitButton;
        private TextBox PartsTableSearchBar;
        private TextBox PoductsTableSearchBar;
        private ColumnHeader PartID;
        private ColumnHeader PartName;
        private ColumnHeader PartInventory;
        private ColumnHeader PartPrice;
        private ColumnHeader PartMin;
        private ColumnHeader PartMax;
        private ColumnHeader ProductID;
        private ColumnHeader ProductName;
        private ColumnHeader ProductInventory;
        private ColumnHeader ProductPrice;
        private ColumnHeader ProductMin;
        private ColumnHeader ProductMax;
    }
}

