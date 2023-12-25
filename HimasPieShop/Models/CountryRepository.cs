namespace BethanysPieShop.Models
{
    public class CountryRepository: ICountryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CountryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Country> AllCountries => _appDbContext.Countries;
    }
}
