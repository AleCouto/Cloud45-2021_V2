using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC_ADM.Models
{
    public class Category
    {
        [Key]
        [Display(Name = "Categoria ID")]
        public int CategoryId { get; set; }

        [Display(Name = "Categoria")]
        public string CategoryName { get; set; }

        public IList<Product> Product { get; set; }

        public Category()
        {
        }

        public Category(int categoryid, string categoryname)
        {
            CategoryId = categoryid;
            CategoryName = categoryname;
        }
    }
}
