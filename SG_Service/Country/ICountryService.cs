using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SG_Database.Model;

namespace SG_Service
{
    public interface ICountryService
    {
        public Task InsertApiCountryData();
        void InsertCountryData(Country country);
    }
}
