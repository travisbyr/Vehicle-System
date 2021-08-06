using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace VehicleSystem
{
    public partial class AddVehicle : Form
    {
        private static readonly AddVehicle _instance = new AddVehicle();
        public static AddVehicle Instance => _instance; // Create an instance

        static AddVehicle() { }

        public AddVehicle()
        {
            InitializeComponent();
        }

        private void AddVehicle_Load(object sender, EventArgs e)
        {
            saveFormButton.FlatAppearance.BorderColor = Color.Blue;

        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm.Form2.Show();
        }

        private void SaveVehicleButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you would like to create this vehicle? The registeration number cannot change.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                CreateVehicle(vehicleRegistrationInput.Text, vehicleMakeInput.Text, vehicleModelInput.Text, vehicleYearInput.Text, vehicleDailyChargeInput.Text);
            }
        }

        public void CreateVehicle(string _rego, string _make, string _model, string _year, string _dailycharge)
        {
            decimal number3 = 0;
            long number1 = 0;
            bool dailyChargeValue = long.TryParse(vehicleDailyChargeInput.Text, out number1);
            dailyChargeValue = decimal.TryParse(vehicleDailyChargeInput.Text, out number3);
            string[] inputs = { _rego, 
                                _make, 
                                _model,
                                _year, 
                                _dailycharge };
            bool status = true;
            foreach (Vehicle item in Business.VehicleList) // Check to see if the proposed registration exists, if so let user know.
            {
                if (item.Rego.ToString() == _rego)
                {
                    MessageBox.Show("Error! Registration number is already taken.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    status = false;
                    return;
                }
            }

            if (inputs.Any(x => string.IsNullOrWhiteSpace(x))) // Check for any whitespace
            {
                MessageBox.Show("Error! Fields cannot be empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (dailyChargeValue != true)
            {
                MessageBox.Show("Error! Invalid input for cost", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (_year.All(char.IsDigit) == false) // Checks to see if the year field contains only integers.
            {
                MessageBox.Show("Error! Invalid input for year", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Regex.Matches(_make, @"[a-zA-Z\s]").Count != _make.Length) // Checks to see if the make field contains only letters and spaces;
            {
                MessageBox.Show("Error! Invalid input for make", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Regex.Matches(_model, @"[a-zA-Z0-9\s]").Count != _model.Length)   // Checks to see if the model field contains only letyters, integers and spaces.
            {
                MessageBox.Show("Error! Invalid input for model", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Regex.Matches(_rego, @"[a-zA-Z0-9]").Count != _rego.Length) // Checks to see if the registration field contains only letters and numbers.
            {
                MessageBox.Show("Error! Invalid input for registration", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
            else if (Decimal.Parse(vehicleDailyChargeInput.Text) < 0)
            {
                MessageBox.Show("Error! Invalid input for daily charge", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (status == true)
            {
                Vehicle vehicle = new Vehicle();
                vehicle.Rego = Regex.Replace(vehicleRegistrationInput.Text, @"\s+", "").ToUpper(); // Changes text format
                vehicle.Make = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(vehicleMakeInput.Text.ToLower());
                vehicle.Model = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(vehicleModelInput.Text.ToLower());
                vehicle.Year = Int32.Parse(vehicleYearInput.Text);
                vehicle.DailyCharge = Decimal.Parse(vehicleDailyChargeInput.Text);

                Business.AddVehicle(vehicle); // Add vehicle to list
                MainForm.Form2.UpdateRegistrationList();
                Hide();
                return;
            }

        }

        public void EmptyFields()
        {
            vehicleRegistrationInput.Text = "";
            vehicleMakeInput.Text = "";
            vehicleModelInput.Text = "";
            vehicleYearInput.Text = "";
            vehicleDailyChargeInput.Text = "";
        }
    }
}