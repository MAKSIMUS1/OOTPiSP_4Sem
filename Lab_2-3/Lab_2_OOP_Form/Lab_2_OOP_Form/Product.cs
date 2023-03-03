using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab_2_OOP_Form
{
    [Serializable]
    [XmlType("product")]

    public class Product
    {
        [XmlElement(ElementName = "title")]
        public string Title { get; set; }
        [XmlElement(ElementName = "id")]
        [IDAttribute]
        public Guid ID { get; set; }
        [XmlElement(ElementName = "size")]
        public int Size { get; set; }
        [XmlElement(ElementName = "weight")]
        public int Weight { get; set; }
        [XmlElement(ElementName = "type")]
        public ProductType Type { get; set; }
        [XmlElement(ElementName = "dateOfReceipt")]
        public DateTime DateOfReceipt { get; set; }
        [XmlElement(ElementName = "quantity")]
        public int Quantity { get; set; }
        [XmlElement(ElementName = "price")]
        [Range(0, 1000)]
        public float Price { get; set; }
        [XmlElement(ElementName = "manufacturer")]
        public Producer Manufacturer { get; set; }
        [XmlElement(ElementName = "storekeeper")]
        public Storekeeper Storekeeper { get; set; }
        public Product()
        {
            ID = Guid.NewGuid();
        }
        public Product(string Title, int Size, int Weight, ProductType Type, DateTime DateOfReceipt, int Quantity, float Price, Producer Manufactor, Storekeeper storekeeper) : this()
        {
            this.Title = Title;
            this.Size = Size;
            this.Weight = Weight;
            this.Type = Type;
            this.DateOfReceipt = DateOfReceipt;
            this.Quantity = Quantity;
            this.Price = Price;
            Manufacturer = Manufactor;
            Storekeeper = storekeeper;
        }
    }
    [Serializable]
    public enum ProductType
    {
        [XmlEnum("E")]
        Edible,
        [XmlEnum("I")]
        Inedible
    }
    public class IDAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value is Guid id)
            {
                if (id != new Guid("F9168C5E-CEB2-4faa-B6BF-329BF39FA1E4"))
                    return true;
                else
                    ErrorMessage = "Incorrect inventory number: admin";
            }
            return false;
        }
    }
}
