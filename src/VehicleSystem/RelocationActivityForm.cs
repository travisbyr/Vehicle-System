using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace VehicleSystem
{
    public partial class RelocationActivityForm : Form
    {
        public RelocationActivityForm()
        {
            InitializeComponent();
        }

        private static readonly RelocationActivityForm _instance = new RelocationActivityForm();

        public static RelocationActivityForm RelocateForm => _instance;

        static RelocationActivityForm(){}

        private Vehicle selectedVehicle;

        public Vehicle SelectedVehicle { get { return selectedVehicle; } set { selectedVehicle = value; } }

        private void SaveActivityButton_Click(object sender, EventArgs e)
        {
            AddRelocationActivity();
        }

        public void AddRelocationActivity()
        {
            decimal number3 = 0;
            long number1 = 0;
            bool dailyChargeValue = long.TryParse(relocationCostInput.Text, out number1);
            dailyChargeValue = decimal.TryParse(relocationCostInput.Text, out number3);
            string[] inputs = { relocationStartInput.Text, 
                                relocationEndInput.Text, 
                                relocationDistanceInput.Text, 
                                relocationCostInput.Text 
                               };

            if (inputs.Any(x => string.IsNullOrWhiteSpace(x))) // Check input to see if it contains only whitespace.
            {
                MessageBox.Show("Error! Fields cannot be empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (dailyChargeValue != true)
            {
                MessageBox.Show("Error! Invalid input for cost", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (relocationDistanceInput.Text.All(char.IsDigit) == false) // Checks to see if input field contains only integers.
            {
                MessageBox.Show("Error! Invalid input for distance", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Regex.Matches(relocationStartInput.Text, @"[a-zA-Z\s-']").Count != relocationStartInput.Text.Length)  // Checks to see if input only contains letters, hyphons, commas.
            {
                MessageBox.Show("Error! Invalid input for start location", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Regex.Matches(relocationEndInput.Text, @"[a-zA-Z\s-']").Count != relocationEndInput.Text.Length)     // Checks to see if input only contains letters, hyphons, commas
            {
                MessageBox.Show("Error! Invalid input for end location", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Decimal.Parse(relocationCostInput.Text) < 0)
            {
                MessageBox.Show("Error! Invalid input for relocation cost", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                DateTime date = relocationActivityDate.Value;
                date.ToString("d");

                string start = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(relocationStartInput.Text.ToLower());
                string end = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(relocationEndInput.Text.ToLower());

                selectedVehicle.ActivityList.Add(new Relocation() // Create a relocation activity object and add it to the activity list
                {
                    Date = date,
                    Name = start + " → " + end,
                    Type = "Relocation",
                    Start = start,
                    End = end,
                     Distance = Int32.Parse(relocationDistanceInput.Text),
                    Cost = Decimal.Parse(relocationCostInput.Text) * -1
                });
                ViewVehicleForm.Form.UpdateViewVehicle();
                MainForm.Form2.UpdateFleetCashTotal();
                Hide();
                ViewVehicleForm.Form.Show();
                return;
            }
        }

        private void RelocationActivityForm_Load(object sender, EventArgs e)
        {
            saveFormButton.FlatAppearance.BorderColor = Color.Blue;
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            Hide();
            ViewVehicleForm.Form.Show();
        }

        public void UpdateRelocationFormDisplay(DateTime date, decimal cost, string start, string end, int distance)
        {
            cost = System.Math.Abs(cost);
            relocationTitle.Text = "Relocation Activity - " + selectedVehicle.Rego;
            relocationActivityDate.Value = date;
            relocationStartInput.Text = start;
            relocationEndInput.Text = end;
            relocationDistanceInput.Text = distance.ToString(); // Pass parameters to method
            relocationCostInput.Text = cost.ToString("N2");
        }

        public void EmptyFields()
        {
            relocationTitle.Text = "Relocation Activity - " + selectedVehicle.Rego;
            relocationActivityDate.Value = System.DateTime.Today;
            relocationStartInput.Text = "";
            relocationEndInput.Text = "";
            relocationDistanceInput.Text = "";
            relocationCostInput.Text = "";
        }
    }
}
