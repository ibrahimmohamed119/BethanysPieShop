namespace BethanysPieShop.Models
{
    public class OrderRepository: IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;
        private readonly ICountryRepository _countryRepository;

        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart, ICountryRepository countryRepository)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
            _countryRepository = countryRepository;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();

            order.Country = _countryRepository.AllCountries.FirstOrDefault(c => c.CountryId == order.CountryId);

            order.OrderDetails = new List<OrderDetail>();

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    Amount = shoppingCartItem.Amount,
                    PieId = shoppingCartItem.Pie.PieId,
                    OrderId = order.OrderId,
                    Price = shoppingCartItem.Pie.Price
                };

                order.OrderDetails.Add(orderDetail);
            }

            _appDbContext.Orders.Add(order);

            _appDbContext.SaveChanges();
        }
    }
}
