﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SG_Database.Model
{
    public class Tournaments
    {


        public int id { get; set; }
        public string name { get; set; }
        public string translation { get; set; }
        public int sportId { get; set; }
        public int countryId { get; set; }
        public int preMatch { get; set; }
        public int live { get; set; }
        public DateTime meetingDate { get; set; }
    }

}
