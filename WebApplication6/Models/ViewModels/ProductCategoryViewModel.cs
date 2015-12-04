using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication6.Models.ViewModels
{
    public class ProductCategoryViewModel
    {
        public string Name { get; set; }
        public string Book { get; set; }
        public IEnumerable<Product> Product {get; set;}
        public IEnumerable<Category>Category { get; set; }



    }
}
