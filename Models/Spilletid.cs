using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Movies.Models
{
    public class Spilletid
    {
        public DayOfWeek Day { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        // Opsummering af spilletiden
        public string Summary => $"{Day} - {StartTime:HH:mm} til {EndTime:HH:mm}";
    }
}
