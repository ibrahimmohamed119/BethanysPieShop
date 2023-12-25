using BethanysPieShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;
        private readonly ICountryRepository _countryRepository;

        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart, ICountryRepository countryRepository)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
            _countryRepository = countryRepository;
        }

        public IActionResult Checkout()
        {
            CountryAndOrderView model = new CountryAndOrderView();
            model.Countries = _countryRepository.AllCountries;
            return View(model);
        }

        [HttpPost]
        public IActionResult Checkout(CountryAndOrderView model)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your cart is empty, add some pies first");
            }

            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(model.Order);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }

            model.Countries = _countryRepository.AllCountries;

            return View(model);
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Thanks for your order. You'll soon enjoy our delicious pies!";

            return View();
        }
    }
}
