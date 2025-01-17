﻿namespace Business.Layer.Models
{
    public class Supplier : Entity
    {
        public string? Name { get; set; }
        public string? Document { get; set; }
        public bool Active { get; set; }
        public SupplierType SupplierType { get; set; }
        public Address? Address { get; set; }
        public IEnumerable<Product> Products { get; set; }

    }
    public enum SupplierType
    {
        individual = 1,
        corporation = 2,
    }
}
