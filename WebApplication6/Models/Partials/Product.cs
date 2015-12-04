using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
    [MetadataType(typeof(ProductMD))]
    public partial class Product
    {
        public class ProductMD
        {
            [ScaffoldColumn(false)]
            public int ProductID { get; set; }
            [Required]
            [Display(Name ="產品名稱")]
            public string ProductName { get; set; }
            [Required]
            public string QuantityPerUnit { get; set; }
            [Required]
            public bool Discontinued { get; set; }


        }
    }
}
