using Abc.Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace Abc.WebUI.Models
{
    public class ProductUpdateViewModel
    {
        public List<Category> Categories { get; set; }
        public Product Product { get; set; }
    }
}
 