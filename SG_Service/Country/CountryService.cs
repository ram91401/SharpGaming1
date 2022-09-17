using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SG_Database.Model;
using SG_Database.ViewModel;
using SharpGaming;

namespace SG_Service
{
    public class CountryService : GenericRepository<Country>, ICountryService
    {
        private readonly ApplicationDbContext _context;
        public CountryService(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task InsertApiCountryData()
        {
            string url = "countries?languageCode=en";
            string result = await GetApiData.GetApiAsync(url);

            if (!string.IsNullOrEmpty(result))
            {
                ResCountry lstSport = JsonConvert.DeserializeObject<ResCountry>(result);

                foreach (var item in lstSport.countries)
                {
                    Country sport = new Country
                    {

                        id = item.id,
                        name = item.name,
                        translation = item.translation
                    };

                    InsertCountryData(sport);
                }
            }
        }

        public void InsertCountryData(Country country)
        {
            throw new NotImplementedException();
        }
    }
}
