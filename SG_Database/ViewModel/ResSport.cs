using System;
using System.Collections.Generic;
using System.Text;

namespace SG_Database.ViewModel
{
    public class ResSport
    {
        public List<SportvM> sports { get; set; }
    }

    public class SportvM
    {
        public int id { get; set; }
        public string name { get; set; }
        public string translation { get; set; }
    }


    public class ResCountry
    {
        public List<SportvM> countries { get; set; }
    }

}