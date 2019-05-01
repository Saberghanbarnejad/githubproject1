using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication_MVC.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name = "Brand Name")]
        [Required]
        public string BrandName { get; set; }
        [Display(Name ="Model Number")]
        [Required]
        public String ModelNo { get; set; }
        [Display(Name ="Description")]
        public String Description { get; set; }
    }
}