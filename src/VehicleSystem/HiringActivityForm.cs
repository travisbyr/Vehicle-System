using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace VehicleSystem
{
    public partial class HiringActivityForm : Form
    {
        public HiringActivityForm()
        {
            InitializeComponent();
        }

        private static readonly HiringActivityForm _instance = new HiringActivityForm();
        public static HiringActivityForm HiringForm => _instance;

        static HiringActivityForm() { }

        private Vehicle selectedVehicle;

        public Vehicle SelectedVehicle { get { return selectedVehicle; } set { selectedVehicle = value; } }

        private void SaveActivityButton_Click(object sender, EventArgs e)
        {
            AddHiringActivity();
        }

        private void HiringActivityForm_Load(object sender, EventArgs e)
        {
            hiringSaveButton.FlatAppearance.BorderColor = Color.Blue;
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            Hide();
            ViewVehicleForm.Form.Show();
        }

        public void UpdateHiringFormDisplay(DateTime date, string name, string customerName, DateTime start, DateTime end)
        {
            hiringTitle.Text = "Hiring Activity - " + selectedVehicle.Rego;
            hiringDate.Value = date;
            hiringNameInput.Text = name;
            hiringCustomerInput.Text = customerName;
            hiringStartDate.Value = start;
            hiringEndDate.Value = end;
        }

        public void EmptyFields()
        {
            hiringTitle.Text = "Hiring Activity - " + selectedVehicle.Rego;
            hiringDate.Value = System.DateTime.Today;
            hiringNameInput.Text = "";
            hiringCustomerInput.Text = "";
            hiringStartDate.Value = System.DateTime.Today;
            hiringEndDate.Value = System.DateTime.Today;
        }

        public void AddHiringActivity()
        {
            string[] inputs = { hiringNameInput.Text,
                                hiringCustomerInput.Text
                              };

            if (inputs.Any(x => string.IsNullOrWhiteSpace(x))) // Checks to see if input contains only whitespace
            {
                MessageBox.Show("Error! Fields cannot be empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Regex.Matches(hiringCustomerInput.Text, @"[a-zA-Z\s-']").Count != hiringCustomerInput.Text.Length) // Checks to see if input only contains letters, hyphons, commas.
            {
                MessageBox.Show("Error! Invalid input for customer name", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Regex.Matches(hiringNameInput.Text, @"[a-zA-Z\s-']").Count != hiringNameInput.Text.Length) //||  // Checks to see if input only contains letters, hyphons, commas.
            {
                MessageBox.Show("Error! Invalid input for activity name", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (hiringStartDate.Value > hiringEndDate.Value)
            {
                MessageBox.Show("Error! Invalid end date.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                DateTime date = hiringDate.Value; // Change datetime format for all datetime inputs.
                date.ToString("d");
                DateTime startDate = hiringStartDate.Value;
                startDate.ToString("d");
                DateTime endDate = hiringEndDate.Value;
                endDate.ToString("d");
                int diff;
                if (endDate == startDate)
                {
                    diff = 1;
                } else
                {
                    diff = (endDate - startDate).Days + 1;
                }
                selectedVehicle.ActivityList.Add(new Hiring() // Areate a hiring activity object and add it to the activity list.
                {
                    Date = date,
                    Name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(hiringNameInput.Text.ToLower()),
                    Type = "Hiring",
                    CustomerName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(hiringCustomerInput.Text.ToLower()),
                    StartHire = startDate,
                    EndHire = endDate,
                    Cost = diff * selectedVehicle.DailyCharge
                }); ;

                ViewVehicleForm.Form.UpdateViewVehicle();
                MainForm.Form2.UpdateFleetCashTotal();
                Hide();
                ViewVehicleForm.Form.Show();
                return;
            }

        }
    }
}

