using Abc.Northwind.Entities.Concrete;

namespace Abc.WebUI.Models
{
    public class CartSummaryViewModel
    {
        public Cart _cartSessionService { get; set; }
        public Cart Cart { get; internal set; }
    }
}