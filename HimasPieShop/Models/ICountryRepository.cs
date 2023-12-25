namespace BethanysPieShop.Models
{
    public interface ICountryRepository
    {
        IEnumerable<Country> AllCountries { get; }
    }
}
