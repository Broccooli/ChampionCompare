using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChampionCompare
{
    class ComboBoxChampItem
    {
        string name;
        double[] stats;

        public ComboBoxChampItem(string name, double[] s)
        {
            this.name = name;
            this.stats = s;
        }

        public double[] Stats
        {
            get { return stats; }
        }

        public override string ToString()
        {
            return name;
        }
    }

}
