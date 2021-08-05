using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem
{
    [Serializable]
    class Hiring : Activity
    {
        private string _customerName;
        private DateTime _startHire;
        private DateTime _endHire;

        public string CustomerName { get => _customerName; set => _customerName = value; }
        public DateTime StartHire { get => _startHire; set => _startHire = value; }
        public DateTime EndHire { get => _endHire; set => _endHire = value; }
    }
}
