using Abc.Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace Abc.WebUI.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; internal set; }
    }
}
