using System;
using System.Collections.Generic;
using System.Text;

namespace SG_Database.Model
{
    class Events
    {

        public int id { get; set; }
        public string name { get; set; }
        public int TeamId { get; set; }
        public int sportId { get; set; }
        public int tournamentId { get; set; }
        public int countryId { get; set; }
        public DateTime dateStart { get; set; }
        public bool isLive { get; set; }
        public bool isRacingEvent { get; set; }
        public object[] participantInfo { get; set; }
        public object raceInfo { get; set; }
        public bool outright { get; set; }
    }   
}

