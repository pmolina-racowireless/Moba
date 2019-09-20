using System;

namespace MobaShared
{
    public class Team
    {
        public string Name { get; set; }

        public string ShortName { get; set; }

        public DateTime StartDate { get; set; }

        public int RegionID { get; set; }

        public double RegionPopularity { get; set; }

        public double GlobalPopularity { get; set; }
    }
}