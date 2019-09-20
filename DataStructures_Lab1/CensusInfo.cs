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

        public int ProvID
        {
            get { return provID; }
            set { provID = value; }
        }

        private int regionID;

        public int RegionID
        {
            get { return regionID; }
            set { regionID = value; }
        }

        private int population;

        public int Population
        {
            get { return population; }
            set { population = value; }
        }

    }
}
