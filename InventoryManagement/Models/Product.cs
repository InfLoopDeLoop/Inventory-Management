using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Models
{
    public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();

        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public void AddAssociatedPart(Part part)
        {
            if (AssociatedParts == null)
            {
                AssociatedParts = new BindingList<Part>();
            }
            AssociatedParts.Add(part);
        }

        public bool RemoveAssociatedPart(int partID) 
        {
            if (AssociatedParts == null || AssociatedParts.Count == 0)
            {
                return false;
            }
            var partToRemove = AssociatedParts.FirstOrDefault(p => p.PartID == partID);
            if (partToRemove != null)
            {
                AssociatedParts.Remove(partToRemove);
                return true;
            }
            return false;
        }

        public Part LookupAssociatedPart(int partID)
        {
            if (AssociatedParts == null || AssociatedParts.Count == 0)
            {
                return null;
            }
            return AssociatedParts.FirstOrDefault(p => p.PartID == partID);
        }
    }
}
