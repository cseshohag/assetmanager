using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AssetManager.Models
{
    public class ProductType
    {
        [Key]
        [DisplayName("ID: ")]
        public int ProductTypeID { get; set; }
        [DisplayName("Product Type: ")]
        public string TypeName { get; set; }
    }
}