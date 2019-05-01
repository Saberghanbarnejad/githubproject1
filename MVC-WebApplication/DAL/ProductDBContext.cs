using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Configuration;
using System.Data.Entity;
using WebApplication_MVC.Models;

namespace WebApplication_MVC.DAL
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext()
            :base("name=ProductDBContext")
        {

        }
        public DbSet<Product> Product { get; set; }
    }
}