using System;
using System.Collections.Generic;
using System.Text;

namespace SG_Database.Model
{
    public class Team
    {
        public int id { get; set; }
        public string home { get; set; }
        public string homeTranslation { get; set; }
        public string away { get; set; }
        public string awayTranslation { get; set; }
    }
}

