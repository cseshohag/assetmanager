using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AssetManager.Models
{
    public class Maintenance
    {
        [Key]
        [DisplayName("Maintaince ID: ")]
        public int MaintainceID { get; set; }

        public virtual Product Product { get; set; }

        public int ProductID { get; set; }

        [DisplayName("Discription: ")]
        public string MaintainceDiscription { get; set; }

        [DisplayName("Maintaince Date: ")]
        public DateTime MaintainceDate { get; set; }

        [DisplayName("Delivery Date: ")]
        public DateTime DeliveryDate { get; set; }

        [DisplayName("Maintaince Request Date: ")]
        public DateTime MaintainceRequestDate { get; set; }
    }
}