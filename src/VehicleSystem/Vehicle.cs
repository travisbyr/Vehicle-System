using System;
using System.Collections.Generic;

namespace VehicleSystem
{
    [Serializable]
    public class Vehicle
    {
        private Vehicle _selectedVehicle;
        public Vehicle SelectedVehicle { get { return _selectedVehicle; } set { _selectedVehicle = value; } }

        private decimal _dailyCharge;
        private int _year;
        private string _model;
        private string _make;
        private string _rego;
        private List<Activity> _activityList = new List<Activity>();

        public string Rego { get => _rego; set => _rego = value; }
        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }
        public int Year { get => _year; set => _year = value; }
        public decimal DailyCharge { get => _dailyCharge; set => _dailyCharge = value; }
        internal List<Activity> ActivityList { get => _activityList; set => _activityList = value; }

    }

}
