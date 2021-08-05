using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem
{
    [Serializable]
    class Service : Activity
    {
        private string _workshop;
        private string _description;

        public string Description { get => _description; set => _description = value; }
        public string Workshop { get => _workshop; set => _workshop = value; }
    }
}
