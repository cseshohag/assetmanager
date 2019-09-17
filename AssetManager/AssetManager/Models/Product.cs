using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AssetManager.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [DisplayName("Product Name: ")]
        public string Name { get; set; }

        public virtual ProductType ProductType { get; set; }

        [DisplayName("Type ID: ")]
        public int ProductTypeID { get; set; }

        [DisplayName("Purchase Date: ")]
        public DateTime ProductPurchaseDate { get; set; }

        [DisplayName("Delivery Date: ")]
        public DateTime ProductDeliveryDate { get; set; }

        [DisplayName("Expairy Date: ")]
        public DateTime ProductExpairyDate { get; set; }

        [DisplayName("Product Image: ")]
        public string ProductImageUrl { get; set; }
    }
}