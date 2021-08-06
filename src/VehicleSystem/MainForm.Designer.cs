
namespace VehicleSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.vehicleRegistrationList = new System.Windows.Forms.ListBox();
            this.viewVehicleButton = new System.Windows.Forms.Button();
            this.removeVehicleButton = new System.Windows.Forms.Button();
            this.addVehicleButton = new System.Windows.Forms.Button();
            this.closeFormButton = new System.Windows.Forms.Button();
            this.vehicleDailyChargeTxt = new System.Windows.Forms.TextBox();
            this.vehicleMakeTxt = new System.Windows.Forms.TextBox();
            this.vehicleModelTxt = new System.Windows.Forms.TextBox();
            this.vehicleYearTxt = new System.Windows.Forms.TextBox();
            this.fleetCashFlowLabel = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(189, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Make";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(189, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(189, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(406, 168);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Daily Charge";
            // 
            // vehicleRegistrationList
            // 
            this.vehicleRegistrationList.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.vehicleRegistrationList.FormattingEnabled = true;
            this.vehicleRegistrationList.ItemHeight = 29;
            this.vehicleRegistrationList.Location = new System.Drawing.Point(30, 48);
            this.vehicleRegistrationList.Margin = new System.Windows.Forms.Padding(2);
            this.vehicleRegistrationList.Name = "vehicleRegistrationList";
            this.vehicleRegistrationList.Size = new System.Drawing.Size(128, 323);
            this.vehicleRegistrationList.Sorted = true;
            this.vehicleRegistrationList.TabIndex = 5;
            this.vehicleRegistrationList.SelectedIndexChanged += new System.EventHandler(this.RegistrationList_SelectedIndexChanged);
            this.vehicleRegistrationList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mainFormRego_MouseDoubleClick);
            // 
            // viewVehicleButton
            // 
            this.viewVehicleButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.viewVehicleButton.Enabled = false;
            this.viewVehicleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewVehicleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.viewVehicleButton.Location = new System.Drawing.Point(192, 330);
            this.viewVehicleButton.Margin = new System.Windows.Forms.Padding(2);
            this.viewVehicleButton.Name = "viewVehicleButton";
            this.viewVehicleButton.Size = new System.Drawing.Size(130, 42);
            this.viewVehicleButton.TabIndex = 10;
            this.viewVehicleButton.Text = "View Vehicle";
            this.viewVehicleButton.UseVisualStyleBackColor = false;
            this.viewVehicleButton.Click += new System.EventHandler(this.ViewVehicleButton_Click);
            // 
            // removeVehicleButton
            // 
            this.removeVehicleButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.removeVehicleButton.Enabled = false;
            this.removeVehicleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeVehicleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.removeVehicleButton.Location = new System.Drawing.Point(469, 329);
            this.removeVehicleButton.Margin = new System.Windows.Forms.Padding(2);
            this.removeVehicleButton.Name = "removeVehicleButton";
            this.removeVehicleButton.Size = new System.Drawing.Size(130, 42);
            this.removeVehicleButton.TabIndex = 11;
            this.removeVehicleButton.Text = "Remove";
            this.removeVehicleButton.UseVisualStyleBackColor = false;
            this.removeVehicleButton.Click += new System.EventHandler(this.RemoveVehicleButton_Click);
            // 
            // addVehicleButton
            // 
            this.addVehicleButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addVehicleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addVehicleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addVehicleButton.Location = new System.Drawing.Point(330, 330);
            this.addVehicleButton.Margin = new System.Windows.Forms.Padding(2);
            this.addVehicleButton.Name = "addVehicleButton";
            this.addVehicleButton.Size = new System.Drawing.Size(130, 42);
            this.addVehicleButton.TabIndex = 12;
            this.addVehicleButton.Text = "Add";
            this.addVehicleButton.UseVisualStyleBackColor = false;
            this.addVehicleButton.Click += new System.EventHandler(this.AddVehicleButton_Click);
            // 
            // closeFormButton
            // 
            this.closeFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.closeFormButton.Location = new System.Drawing.Point(607, 329);
            this.closeFormButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeFormButton.Name = "closeFormButton";
            this.closeFormButton.Size = new System.Drawing.Size(130, 42);
            this.closeFormButton.TabIndex = 13;
            this.closeFormButton.Text = "Close";
            this.closeFormButton.UseVisualStyleBackColor = true;
            this.closeFormButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // vehicleDailyChargeTxt
            // 
            this.vehicleDailyChargeTxt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.vehicleDailyChargeTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vehicleDailyChargeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.vehicleDailyChargeTxt.Location = new System.Drawing.Point(411, 196);
            this.vehicleDailyChargeTxt.Name = "vehicleDailyChargeTxt";
            this.vehicleDailyChargeTxt.ReadOnly = true;
            this.vehicleDailyChargeTxt.Size = new System.Drawing.Size(325, 32);
            this.vehicleDailyChargeTxt.TabIndex = 18;
            // 
            // vehicleMakeTxt
            // 
            this.vehicleMakeTxt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.vehicleMakeTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vehicleMakeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.vehicleMakeTxt.Location = new System.Drawing.Point(192, 47);
            this.vehicleMakeTxt.Name = "vehicleMakeTxt";
            this.vehicleMakeTxt.ReadOnly = true;
            this.vehicleMakeTxt.Size = new System.Drawing.Size(546, 32);
            this.vehicleMakeTxt.TabIndex = 19;
            // 
            // vehicleModelTxt
            // 
            this.vehicleModelTxt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.vehicleModelTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vehicleModelTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.vehicleModelTxt.Location = new System.Drawing.Point(192, 122);
            this.vehicleModelTxt.Name = "vehicleModelTxt";
            this.vehicleModelTxt.ReadOnly = true;
            this.vehicleModelTxt.Size = new System.Drawing.Size(546, 32);
            this.vehicleModelTxt.TabIndex = 20;
            // 
            // vehicleYearTxt
            // 
            this.vehicleYearTxt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.vehicleYearTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vehicleYearTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.vehicleYearTxt.Location = new System.Drawing.Point(192, 196);
            this.vehicleYearTxt.Name = "vehicleYearTxt";
            this.vehicleYearTxt.ReadOnly = true;
            this.vehicleYearTxt.Size = new System.Drawing.Size(195, 32);
            this.vehicleYearTxt.TabIndex = 21;
            // 
            // fleetCashFlowLabel
            // 
            this.fleetCashFlowLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fleetCashFlowLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fleetCashFlowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.fleetCashFlowLabel.Location = new System.Drawing.Point(0, 11);
            this.fleetCashFlowLabel.Margin = new System.Windows.Forms.Padding(2);
            this.fleetCashFlowLabel.Name = "fleetCashFlowLabel";
            this.fleetCashFlowLabel.ReadOnly = true;
            this.fleetCashFlowLabel.Size = new System.Drawing.Size(540, 22);
            this.fleetCashFlowLabel.TabIndex = 15;
            this.fleetCashFlowLabel.Text = "Fleet Cash-Flow: $1990";
            this.fleetCashFlowLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.fleetCashFlowLabel);
            this.panel1.ForeColor = System.Drawing.Color.Snow;
            this.panel1.Location = new System.Drawing.Point(192, 257);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(546, 49);
            this.panel1.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 398);
            this.ControlBox = false;
            this.Controls.Add(this.vehicleYearTxt);
            this.Controls.Add(this.vehicleModelTxt);
            this.Controls.Add(this.vehicleMakeTxt);
            this.Controls.Add(this.vehicleDailyChargeTxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.closeFormButton);
            this.Controls.Add(this.addVehicleButton);
            this.Controls.Add(this.removeVehicleButton);
            this.Controls.Add(this.viewVehicleButton);
            this.Controls.Add(this.vehicleRegistrationList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle System - MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button viewVehicleButton;
        private System.Windows.Forms.Button removeVehicleButton;
        private System.Windows.Forms.Button addVehicleButton;
        private System.Windows.Forms.Button closeFormButton;
        public System.Windows.Forms.ListBox vehicleRegistrationList;
        private System.Windows.Forms.TextBox vehicleDailyChargeTxt;
        private System.Windows.Forms.TextBox vehicleMakeTxt;
        private System.Windows.Forms.TextBox vehicleModelTxt;
        private System.Windows.Forms.TextBox vehicleYearTxt;
        private System.Windows.Forms.TextBox fleetCashFlowLabel;
        private System.Windows.Forms.Panel panel1;
    }
}

