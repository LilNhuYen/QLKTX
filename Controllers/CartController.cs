using Microsoft.AspNetCore.Mvc;
using QLKTX.Models;

namespace QLKTX.Controllers
{
    public class CartController : Controller
    {
        static Cart cart = new Cart();

        public IActionResult Index()
        {
            return View(cart);
        }

        public IActionResult Add(int id, string name, decimal price)
        {
            CartItem item = new CartItem
            {
                ProductId = id,
                ProductName = name,
                Price = price,
                Quantity = 1
            };

            cart.AddItem(item);

            return RedirectToAction("Index");
        }

        public IActionResult Remove(int id)
        {
            cart.RemoveItem(id);

            return RedirectToAction("Index");
        }
    }
}