using NopCommerceClone.Data.EntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NopCommerceClone.Web.Models
{
    public class Catelog
    {
        public int ID { get; set; }
        [Required,MaxLength(100),MinLength(4)]
        public string CatelogName { get; set; }
        [Required]
        public DateTime AddedAt { get; set; }
        [Required]
        public int AdminID { get; set; }
        public Admin Admin { get; set; }

        public  ICollection<Product> Products { get; set; }

    }
}
