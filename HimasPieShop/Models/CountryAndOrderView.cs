namespace BethanysPieShop.Models
{
    public class CountryAndOrderView
    {
        public Order Order { get; set; }
        public IEnumerable<Country> Countries { get; set; } = Enumerable.Empty<Country>();
    }
}
