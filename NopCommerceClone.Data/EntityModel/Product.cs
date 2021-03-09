using NopCommerceClone.Web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NopCommerceClone.Data.EntityModel
{
    public class Product
    {
        public int ID { get; set; }
        [Required,MaxLength(100),MinLength(4)]
        public string ProductName { get; set; }
        [Range(0,99999)]
        public double Price { get; set; }
        [Required]
        public DateTime AddedAt { get; set; }
        [Required]
        public int AdminID { get; set; }
        public virtual Admin Admin { get; set; }

        [Required]
        public int CatelogID { get; set; }
        public virtual Catelog Catelog { get; set; }


    }
}
