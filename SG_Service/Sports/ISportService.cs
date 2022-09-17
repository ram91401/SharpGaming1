using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SG_Database.Model;
namespace SG_Service
{
    public interface ISportService
    {
        public Task InsertApiSportData();
        void InsertSportData(Sport sport);
    }
}
