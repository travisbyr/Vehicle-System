using System;
using System.Drawing;
using System.Windows.Forms;

namespace VehicleSystem
{
    public partial class MainForm : Form
    {
        public static Vehicle selectedVehicle;

        private static readonly MainForm _instance = new MainForm();

        public static MainForm Form2 => _instance;

        static MainForm() { }

        public MainForm()
        {
            InitializeComponent();
            addVehicleButton.FlatAppearance.BorderColor = Color.Blue;
            viewVehicleButton.FlatAppearance.BorderColor = Color.Blue;
            removeVehicleButton.FlatAppearance.BorderColor = Color.Blue;
            Business.Retrieve();
        }

        private void RegistrationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedVehicle = (Vehicle)vehicleRegistrationList.SelectedItem; // Grab selected vehicle

            if (vehicleRegistrationList.SelectedItem != null)
            {
                viewVehicleButton.Enabled = true;
                removeVehicleButton.Enabled = true;
                UpdateMainFormFieldsDisplay();
            } else
            {
                viewVehicleButton.Enabled = false;
                removeVehicleButton.Enabled = false;
                vehicleMakeTxt.Text = "";
                vehicleModelTxt.Text = "";
                vehicleYearTxt.Text = "";
                vehicleDailyChargeTxt.Text = "";
            }
        }

        public void UpdateMainFormFieldsDisplay()
        {
            vehicleMakeTxt.Text = selectedVehicle.Make;
            vehicleModelTxt.Text = selectedVehicle.Model;
            vehicleYearTxt.Text = selectedVehicle.Year.ToString();
            vehicleDailyChargeTxt.Text = "$" + selectedVehicle.DailyCharge.ToString("N2");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateRegistrationList();
            UpdateFleetCashTotal();
        }

        public void UpdateRegistrationList()
        {
            vehicleRegistrationList.DataSource = null;
            vehicleRegistrationList.Items.Clear();
            vehicleRegistrationList.DataSource = new BindingSource(Business.VehicleList, ""); // Create new datasource using vehicle list data.
            vehicleRegistrationList.DisplayMember = "Rego";
        }

        private void RemoveVehicleButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you would like to delete this vehicle?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string selectedItem = vehicleRegistrationList.GetItemText(vehicleRegistrationList.SelectedItem);
                Business.RemoveVehicle(selectedItem);
                UpdateRegistrationList();
                UpdateFleetCashTotal();
            }
        }

        private void ViewVehicleButton_Click(object sender, EventArgs e)
        {
            ViewVehicleForm.Form.SelectedVehicle = selectedVehicle;
            ViewVehicleForm.Form.UpdateViewVehicle();
            ViewVehicleForm.Form.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Business.Save();
            System.Windows.Forms.Application.Exit();
        }

        private void AddVehicleButton_Click(object sender, EventArgs e)
        {
            AddVehicle.Instance.Show();
            AddVehicle.Instance.EmptyFields();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Business.Save();
        }

        public void UpdateFleetCashTotal()
        { // Calculate fleet cash total by adding all activities together, income - expenses
            decimal cost = 0;
            foreach (var vehicle in Business.VehicleList )
            {
                foreach (var activity in vehicle.ActivityList)
                {
                    cost = cost + activity.Cost;
                }
            }

            if (cost < 0)
            {
                decimal a = +System.Math.Abs(cost);
                fleetCashFlowLabel.Text = "Fleet Cash-Flow: -$" + a.ToString("#,##0.00");
                fleetCashFlowLabel.ForeColor = Color.Red;
            }
            else
            {
                fleetCashFlowLabel.Text = "Fleet Cash-Flow: $" + cost.ToString("#,##0.00");
                fleetCashFlowLabel.ForeColor = Color.Green;
            }
        }

        private void mainFormRego_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = vehicleRegistrationList.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches) // Get registration number from mouse click
            {
                ViewVehicleForm.Form.SelectedVehicle = selectedVehicle;
                ViewVehicleForm.Form.UpdateViewVehicle();
                ViewVehicleForm.Form.Show();
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
