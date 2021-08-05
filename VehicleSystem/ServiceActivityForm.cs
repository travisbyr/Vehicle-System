using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace VehicleSystem
{
    public partial class ServiceActivityForm : Form
    {
        public ServiceActivityForm()
        {
            InitializeComponent();
        }

        private static readonly ServiceActivityForm _instance = new ServiceActivityForm();

        public static ServiceActivityForm ServiceForm => _instance;

        static ServiceActivityForm(){}

        private Vehicle selectedVehicle;

        public Vehicle SelectedVehicle { get { return selectedVehicle; } set { selectedVehicle = value; } }

        private void serviceActivityForm_Load(object sender, EventArgs e)
        {
            serviceSaveButton.FlatAppearance.BorderColor = Color.Blue;
        }

        private void CloseActivityButton_Click(object sender, EventArgs e)
        {
            Hide();
            ViewVehicleForm.Form.Show();
        }

        private void SaveActivityButton_Click(object sender, EventArgs e)
        {
            AddActivity();
        }

        public void AddActivity()
        {
            decimal number3 = 0;
            long number1 = 0;
            bool costValue = long.TryParse(serviceCostInput.Text, out number1);
            costValue = decimal.TryParse(serviceCostInput.Text, out number3);
            string[] inputs = { serviceNameInput.Text,
                                serviceWorkshopInput.Text,
                                serviceCostInput.Text
                               };

            if (inputs.Any(x => string.IsNullOrWhiteSpace(x)))  // Checks to see if input contains only whitespace
            {
                MessageBox.Show("Error! Fields cannot be empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Regex.Matches(serviceNameInput.Text, @"[a-zA-Z\s-']").Count != serviceNameInput.Text.Length)     // Checks to see if input only contains letters, hyphons, commas.
            {
                MessageBox.Show("Error! Invalid input for activity name", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (costValue != true)
            {
                MessageBox.Show("Error! Invalid input for cost", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Regex.Matches(serviceWorkshopInput.Text, @"[a-zA-Z\s-']").Count != serviceWorkshopInput.Text.Length)  // Checks to see if input only contains letters, hyphons, commas.
            {
                MessageBox.Show("Error! Invalid input for workshop", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Decimal.Parse(serviceCostInput.Text) < 0)
            {
                MessageBox.Show("Error! Invalid input for service cost", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (ViewVehicleForm.Form.editActivity == true)
                {
                    int x = ViewVehicleForm.Form.activityDGV.CurrentCell.RowIndex;
                    Activity a = (Activity)ViewVehicleForm.Form.activityDGV.Rows[x].DataBoundItem;
                    selectedVehicle.ActivityList.RemoveAt(selectedVehicle.ActivityList.IndexOf(a));
                    ViewVehicleForm.Form.editActivity = false;
                }

                DateTime date = serviceActivityDate.Value;
                date.ToString("d");

                selectedVehicle.ActivityList.Add(new Service() // Create a service activity object and add it to the activity list.
                {
                    Date = date,
                    Name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(serviceNameInput.Text.ToLower()),
                    Type = "Service",
                    Workshop = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(serviceWorkshopInput.Text.ToLower()),
                    Cost = Decimal.Parse(serviceCostInput.Text) * -1,
                    Description = serviceDescriptionInput.Text
                }); ;
                ViewVehicleForm.Form.UpdateViewVehicle();
                MainForm.Form2.UpdateFleetCashTotal();
                Hide();
                ViewVehicleForm.Form.Show();
                return;
            }
        }

        public void UpdateServiceFormDisplay(DateTime date, string name, string workshop, decimal cost, string description)
        {
            cost = System.Math.Abs(cost);
            serviceTitle.Text = "Service Activity - " + selectedVehicle.Rego;
            serviceActivityDate.Value = date;
            serviceNameInput.Text = name;
            serviceWorkshopInput.Text = workshop;
            serviceCostInput.Text = cost.ToString("N2");
            serviceDescriptionInput.Text = description;
        }

        public void EmptyFields()
        {
            serviceTitle.Text = "Service Activity - " + selectedVehicle.Rego;
            serviceActivityDate.Value = System.DateTime.Today;
            serviceNameInput.Text = "";
            serviceWorkshopInput.Text = "";
            serviceCostInput.Text = "";
            serviceDescriptionInput.Text = "";
        }
    }
}
