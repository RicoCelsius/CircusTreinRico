using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    internal class Train
    {

        private List<Wagon> wagons = new List<Wagon>();
        public List<Wagon> Wagons { get { return wagons; } }

        public Train()
        {

        }

    }
}
