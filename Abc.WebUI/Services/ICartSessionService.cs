using Abc.Northwind.Entities.Concrete;

namespace Abc.WebUI.Services
{
    public interface ICartSessionService
    {
        Cart GetCart();
        void SetCart(Cart cart);

    }
}
