using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetflixShows.Model
{
    public class Series
    {
        public Guid Guid { get; set; }
        public DateTime Date { get; set; }
        public bool IsSeries { get; set; }
        public string Name { get; set; }
        public int ScreeningHours { get; set; }
        public string MyProperty { get; set; }


    }
}
