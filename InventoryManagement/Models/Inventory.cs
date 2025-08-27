using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.Models
{
    public static class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();
        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }
        public static bool DeleteProduct(int productID)
        {
            var productToRemove = LookupProduct(productID);
            return Products.Remove(productToRemove);
        }
        public static Product LookupProduct(int productID)
        {
            return Products.FirstOrDefault(p => p.ProductID == productID);
        }

        public static void UpdateProduct(int productID, Product newProduct)
        {
            var productToUpdate = LookupProduct(productID);
            DeleteProduct(productToUpdate.ProductID);
            AddProduct(newProduct);
        }

        public static void AddPart(Part part)
        {
            if (Inventory.AllParts == null)
            {
                Inventory.AllParts = new BindingList<Part>();
            }
            AllParts.Add(part);
        }

        public static bool DeletePart(Part part)
        {
            return AllParts.Remove(part);
        }

        public static Part LookupPart(int partID)
        {
            return AllParts.FirstOrDefault(p => p.PartID == partID);
        }

        public static void UpdatePart(int partID, Part newPart)
        {   
            var partToUpdate = LookupPart(partID);
            DeletePart(partToUpdate);
            AddPart(newPart);
        }

        public static void OrderParts()
        {
                AllParts = new BindingList<Part>(AllParts.OrderBy(p => p.PartID).ToList());
        }

        public static void OrderProducts()
        {
                Products = new BindingList<Product>(Products.OrderBy(p => p.ProductID).ToList());
        }
    }
}
