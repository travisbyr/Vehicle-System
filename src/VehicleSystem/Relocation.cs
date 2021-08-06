using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem
{
    [Serializable]
    class Relocation : Activity
    {
        private string _start;
        private string _end;
        private int _distance;

        public string Start { get => _start; set => _start = value; }
        public string End { get => _end; set => _end = value; }
        public int Distance { get => _distance; set => _distance = value; }
    }
}
