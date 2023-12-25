using BethanysPieShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Components
{
    public class CountryMenu: ViewComponent
    {
        private readonly ICountryRepository _countryRepository;

        public CountryMenu(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var countries = _countryRepository.AllCountries.OrderBy(c => c.CountryName);
            return View(countries);
        }
    }
}
