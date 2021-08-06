using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem
{
    [Serializable]
    public class Activity
    {
        private DateTime _date;
        private string _name;
        private string _type;
        private decimal _cost;

        public string Name { get => _name; set => _name = value; }
        public string Type { get => _type; set => _type = value; }
        public decimal Cost { get => _cost; set => _cost = value; }
        public DateTime Date { get => _date; set => _date = value; }
    }
}

