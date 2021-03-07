using Microsoft.EntityFrameworkCore;
using NopCommerceClone.Data.EntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace NopCommerceClone.Web.Models
{
    public class Admin
    {
        public int ID { get; set; }
        [Required, MaxLength(100), MinLength(4)]
        
        public string Username { get; set; }
        [Required,MaxLength(100),MinLength(4)]
        public string Password { get; set; }
        [Required]
        public DateTime RegisteredAt { get; set; }

        public  ICollection<Catelog> CatelogItems { get; set; }
        public  ICollection<Product> Products { get; set; }
    }
}
