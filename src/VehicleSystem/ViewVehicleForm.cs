using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace VehicleSystem
{
    public partial class ViewVehicleForm : VehicleSystem.AddVehicle
    {
        private static readonly ViewVehicleForm _instance = new ViewVehicleForm();
        public static ViewVehicleForm Form => _instance;

        public bool editActivity = false;

        static ViewVehicleForm(){ }

        private Vehicle selectedVehicle;

        public Vehicle SelectedVehicle { get { return selectedVehicle; } set { selectedVehicle = value; } }

        public ViewVehicleForm()
        { 
            InitializeComponent();
            this.activityComboBox.DataSource = new object[3] {"Relocation Activity", "Hiring Activity", "Service Activity" };
            viewActivityButton.FlatAppearance.BorderColor = Color.Blue;
            addActivityButton.FlatAppearance.BorderColor = Color.Blue;
            deleteActivityButton.FlatAppearance.BorderColor = Color.Blue;
        }

        private void SaveFormButton_Click(object sender, EventArgs e)
        {
            UpdateVehicleFieldsDisplay();
            Hide();
        }

        private void ViewVehicleForm_Load(object sender, EventArgs e)
        {
            UpdateViewVehicle();

            panel1.Enabled = false;
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            vehicleRegistrationInput.BackColor = Color.FromArgb(224, 224, 224);
            vehicleRegistrationInput.ForeColor = SystemColors.ControlDark;
        }

        public void UpdateViewVehicle()
        {

            this.Text = "Vehicle System - " + selectedVehicle.Rego;

            vehicleRegistrationInput.Text = selectedVehicle.Rego;
            vehicleMakeInput.Text = selectedVehicle.Make;
            vehicleModelInput.Text = selectedVehicle.Model;
            vehicleYearInput.Text = selectedVehicle.Year.ToString();
            vehicleDailyChargeInput.Text = selectedVehicle.DailyCharge.ToString("N2");

            activityDGV.DataSource = null; // Create a datasource and bind the activity list data to it.
            activityDGV.DataSource = new BindingSource(selectedVehicle.ActivityList, "");

            if (selectedVehicle.ActivityList.Count >= 1)
            {
                viewActivityButton.Enabled = true;
                deleteActivityButton.Enabled = true;
            } else
            {
                viewActivityButton.Enabled = false;
                deleteActivityButton.Enabled = false;
            }
            // Create data grid view columns
            activityDGV.Columns["Date"].DisplayIndex = 0;
            activityDGV.Columns["Date"].Width = 135;
            activityDGV.Columns["Name"].DisplayIndex = 1;
            activityDGV.Columns["Name"].Width = 380;
            activityDGV.Columns["Type"].DisplayIndex = 2;
            activityDGV.Columns["Type"].Width = 193;
            activityDGV.Columns["Cost"].DisplayIndex = 3;
            activityDGV.Columns["Cost"].Width = 138;
            activityDGV.Columns["Cost"].DefaultCellStyle.Format = "c2";

            CalculateVehicleCashTotal();
        }

        private void CalculateVehicleCashTotal()
        {// Calculate cash total of the vehicle using the value of the activities, income - expenses.
            decimal cashFlow = 0;

            foreach (DataGridViewRow row in activityDGV.Rows)
            {
                cashFlow = cashFlow + Decimal.Parse(row.Cells[2].Value.ToString());
            }


            if (cashFlow < 0)
            {
                decimal a = +System.Math.Abs(cashFlow);
                vehicleCashFlowLabel.Text = "Vehicle Cash-Flow: -$" + a.ToString("#,##0.00"); // Change display format
                vehicleCashFlowLabel.ForeColor = Color.Red;
            }
            else
            {
                vehicleCashFlowLabel.Text = "Vehicle Cash-Flow: $" + cashFlow.ToString("#,##0.00");
                vehicleCashFlowLabel.ForeColor = Color.Green;
            }
        }

        private void ViewActivityButton_Click(object sender, EventArgs e)
        {
            ViewActivity();
            editActivity = true;
        }

        private void AddActivityButton_Click(object sender, EventArgs e)
        {
            UpdateVehicleFieldsDisplay();
            switch (activityComboBox.SelectedItem.ToString())
            {
                case "Relocation Activity":
                    RelocationActivityForm.RelocateForm.SelectedVehicle = selectedVehicle;
                    RelocationActivityForm.RelocateForm.Show();
                    RelocationActivityForm.RelocateForm.EmptyFields();
                    break;
                case "Service Activity":
                    ServiceActivityForm.ServiceForm.SelectedVehicle = selectedVehicle;
                    ServiceActivityForm.ServiceForm.Show();
                    ServiceActivityForm.ServiceForm.EmptyFields();
                    break;
                case "Hiring Activity":
                    HiringActivityForm.HiringForm.SelectedVehicle = selectedVehicle;
                    HiringActivityForm.HiringForm.Show();
                    HiringActivityForm.HiringForm.EmptyFields();
                    break;
                default:
                    string message = "Please select an activity";
                    string title = "Error!";
                    MessageBox.Show(message, title);
                    break;
            }
        }

        private void UpdateVehicleFieldsDisplay()
        {
            decimal number3 = 0;
            long number1 = 0;
            bool dailyChargeValue = long.TryParse(vehicleDailyChargeInput.Text, out number1);
            dailyChargeValue = decimal.TryParse(vehicleDailyChargeInput.Text, out number3);

            string[] inputs = { vehicleYearInput.Text.ToString(),
                                vehicleDailyChargeInput.Text.ToString(),
                                 vehicleMakeInput.Text,
                                 vehicleModelInput.Text};

            if (inputs.Any(x => string.IsNullOrWhiteSpace(x))) // Check for any whitespace
            {
                MessageBox.Show("Error! Fields cannot be empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (vehicleYearInput.Text.All(char.IsDigit) == false) // Checks to see if the daily charge field contains only integers.
            {
                MessageBox.Show("Error! Invalid input for year", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (dailyChargeValue != true)
            {
                MessageBox.Show("Error! Invalid input for daily charge", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Regex.Matches(vehicleMakeInput.Text, @"[a-zA-Z\s]").Count != vehicleMakeInput.Text.Length) // Checks to see if the make field contains only letters and spaces;
            {
                MessageBox.Show("Error! Invalid input for make", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Regex.Matches(vehicleModelInput.Text, @"[a-zA-Z0-9\s]").Count != vehicleModelInput.Text.Length)   // Checks to see if the model field contains only letyters, integers and spaces.
            {
                MessageBox.Show("Error! Invalid input for model", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Decimal.Parse(vehicleDailyChargeInput.Text) < 0)
            {
                MessageBox.Show("Error! Invalid input for daily charge", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                selectedVehicle.Make = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(vehicleMakeInput.Text.ToLower());
                selectedVehicle.Model = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(vehicleModelInput.Text.ToLower());
                selectedVehicle.Year = Int32.Parse(vehicleYearInput.Text);
                selectedVehicle.DailyCharge = Decimal.Parse(vehicleDailyChargeInput.Text);

                MainForm.Form2.UpdateFleetCashTotal();
                MainForm.Form2.UpdateMainFormFieldsDisplay();
            }

        }

        private void DeleteActivityButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you would like to delete this activity?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int x = activityDGV.CurrentCell.RowIndex;
                Activity a = (Activity)activityDGV.Rows[x].DataBoundItem;
                selectedVehicle.ActivityList.RemoveAt(selectedVehicle.ActivityList.IndexOf(a)); // Remove activity object from activity list using given index
                MainForm.Form2.UpdateFleetCashTotal();
                UpdateViewVehicle();
            }
        }

        bool name = true;
        private void NameSortButton_Click(object sender, EventArgs e)
        {
            if(!name)
            {
                activityDGV.DataSource = selectedVehicle.ActivityList.OrderBy(a => a.Name).ToList();
            } else 
            {
                activityDGV.DataSource = selectedVehicle.ActivityList.OrderByDescending(a => a.Name).ToList();
            }
            name = !name;
        }

        bool date = true;
        private void DateSortButton_Click(object sender, EventArgs e)
        {
            if (!date)
            {
                activityDGV.DataSource = selectedVehicle.ActivityList.OrderBy(a => a.Date).ToList();
            }
            else
            {
                activityDGV.DataSource = selectedVehicle.ActivityList.OrderByDescending(a => a.Date).ToList();
            }
            date = !date;
        }

        private void ActivityData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(selectedVehicle.ActivityList.Count() != 0 )
            {
                ViewActivity();
            }          
        }

        private void ViewActivity()
        {
            ViewVehicleForm.Form.editActivity = true;
            int x = activityDGV.CurrentCell.RowIndex;
            Activity a = (Activity)activityDGV.Rows[x].DataBoundItem;
            DateTime date = a.Date;
            string name = a.Name;
            string type = a.Type;
            decimal cost = a.Cost;

            if (type == "Relocation")
            {
                Relocation r = (Relocation)activityDGV.Rows[x].DataBoundItem; // View activity from datasource
                RelocationActivityForm.RelocateForm.SelectedVehicle = selectedVehicle;
                RelocationActivityForm.RelocateForm.Show(); // Show form while updating its form display with activity data
                RelocationActivityForm.RelocateForm.UpdateRelocationFormDisplay(date, cost, r.Start, r.End, r.Distance); 
            }
            else if (type == "Hiring")
            {
                Hiring h = (Hiring)activityDGV.Rows[x].DataBoundItem;
                HiringActivityForm.HiringForm.SelectedVehicle = selectedVehicle;
                HiringActivityForm.HiringForm.Show();
                HiringActivityForm.HiringForm.UpdateHiringFormDisplay(date, name, h.CustomerName, h.StartHire, h.EndHire);
            }
            else if (type == "Service")
            {
                Service s = (Service)activityDGV.Rows[x].DataBoundItem;
                ServiceActivityForm.ServiceForm.SelectedVehicle = selectedVehicle;
                ServiceActivityForm.ServiceForm.Show();
                ServiceActivityForm.ServiceForm.UpdateServiceFormDisplay(date, name, s.Workshop, cost, s.Description);

            }
        }
    }
}
