using System;
using System.Collections.Generic;
using System.Text;
using SharpGaming;
using SG_Database.Model;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SG_Database.ViewModel;
namespace SG_Service
{
    public class SportService : GenericRepository<Sport>, ISportService
    {
        private readonly ApplicationDbContext _context;
        public SportService(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task InsertApiSportData()
        {
            string url = "sports?languageCode=en";
            string result = await GetApiData.GetApiAsync(url);

            if (!string.IsNullOrEmpty(result))
            {
                ResSport lstSport = JsonConvert.DeserializeObject<ResSport>(result);

                foreach (var item in lstSport.sports)
                {
                    Sport sport = new Sport
                    {

                        id = item.id,
                        name = item.name,
                        translation = item.translation                       
                    };

                    InsertSportData(sport);
                }
            }
        }

        public async void InsertSportData(Sport sport)
        {
            _context.Sports.Add(sport);
            await _context.SaveChangesAsync();
        }
    }
}
