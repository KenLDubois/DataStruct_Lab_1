using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Lab1
{
    class CensusInfo
    {
        private int provID;
        private int regionID;
        private int population;

        public int ProvID
        {
            get { return provID; }
            set { provID = value; }
        }

        public int RegionID
        {
            get { return regionID; }
            set { regionID = value; }
        }

        public int Population
        {
            get { return population; }
            set { population = value; }
        }
    }
}
