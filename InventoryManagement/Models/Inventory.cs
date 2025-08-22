using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Models
{
    public static class Inventory
    {
        public static BindingList<Product> Products { get; set; }
        public static BindingList<Part> AllParts { get; set; }
        public static void AddProduct(Product product)
        {
            if (Products == null)
            {
                Products = new BindingList<Product>();
            }
            Products.Add(product);
        }
        public static bool DeleteProduct(int productID)
        {
            if (Products == null || Products.Count == 0)
            {
                return false;
            }
            var productToRemove = Products.FirstOrDefault(p => p.ProductID == productID);
            if (productToRemove != null)
            {
                Products.Remove(productToRemove);
                return true;
            }
            return false;
        }
        public static Product LookupProduct(int productID)
        {
             if (Products == null || Products.Count == 0)
            {
                return null;
            }
            return Products.FirstOrDefault(p => p.ProductID == productID);
        }

        public static void UpdateProduct(int productID, Product newProduct)
        {
            if (Products == null || Products.Count == 0)
            {
                return;
            }
            var productToUpdate = Products.FirstOrDefault(p => p.ProductID == productID);
            if (productToUpdate != null)
            {
                productToUpdate.Name = newProduct.Name;
                productToUpdate.Price = newProduct.Price;
                productToUpdate.InStock = newProduct.InStock;
                productToUpdate.Min = newProduct.Min;
                productToUpdate.Max = newProduct.Max;
            }
        }

        public static void AddPart(Part part)
        {
            if (AllParts == null)
            {
                AllParts = new BindingList<Part>();
            }
            AllParts.Add(part);
        }

        public static bool DeletePart(Part part)
        {
            if (AllParts == null || AllParts.Count == 0)
            {
                return false;
            }
            return AllParts.Remove(part);
        }

        public static Part LookupPart(int partID)
        {
            if (AllParts == null || AllParts.Count == 0)
            {
                return null;
            }
            return AllParts.FirstOrDefault(p => p.PartID == partID);
        }

        public static void UpdatePart(int partID, Part newPart)
        {
            if (AllParts == null || AllParts.Count == 0)
            {
                return;
            }
            var partToUpdate = AllParts.FirstOrDefault(p => p.PartID == partID);
            if (partToUpdate != null)
            {
                partToUpdate.PartID = newPart.PartID;
                partToUpdate.Name = newPart.Name;
                partToUpdate.Price = newPart.Price;
                partToUpdate.InStock = newPart.InStock;
                partToUpdate.Min = newPart.Min;
                partToUpdate.Max = newPart.Max;
            }
        }

        public static void OrderParts()
        {
            if (AllParts != null)
            {
                AllParts = new BindingList<Part>(AllParts.OrderBy(p => p.PartID).ToList());
            }
        }
    }
}
