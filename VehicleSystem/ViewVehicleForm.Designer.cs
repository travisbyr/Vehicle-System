
namespace VehicleSystem
{
    partial class ViewVehicleForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewVehicleForm));
            this.panel6 = new System.Windows.Forms.Panel();
            this.vehicleCashFlowLabel = new System.Windows.Forms.TextBox();
            this.activityDGV = new System.Windows.Forms.DataGridView();
            this.closeViewFormButton = new System.Windows.Forms.Button();
            this.deleteActivityButton = new System.Windows.Forms.Button();
            this.addActivityButton = new System.Windows.Forms.Button();
            this.viewActivityButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.activityComboBox = new System.Windows.Forms.ComboBox();
            this.dateSortButton = new System.Windows.Forms.Button();
            this.nameSortButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // saveFormButton
            // 
            this.saveFormButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.saveFormButton.Location = new System.Drawing.Point(142, 358);
            this.saveFormButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveFormButton.Visible = false;
            // 
            // closeFormButton
            // 
            this.closeFormButton.Location = new System.Drawing.Point(315, 358);
            this.closeFormButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeFormButton.Visible = false;
            // 
            // vehicleDailyChargeInput
            // 
            this.vehicleDailyChargeInput.Margin = new System.Windows.Forms.Padding(4);
            this.vehicleDailyChargeInput.Size = new System.Drawing.Size(265, 48);
            // 
            // vehicleYearInput
            // 
            this.vehicleYearInput.Margin = new System.Windows.Forms.Padding(4);
            this.vehicleYearInput.Size = new System.Drawing.Size(240, 29);
            // 
            // vehicleModelInput
            // 
            this.vehicleModelInput.Margin = new System.Windows.Forms.Padding(4);
            this.vehicleModelInput.Size = new System.Drawing.Size(605, 48);
            // 
            // vehicleMakeInput
            // 
            this.vehicleMakeInput.Margin = new System.Windows.Forms.Padding(4);
            this.vehicleMakeInput.Size = new System.Drawing.Size(605, 48);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.vehicleCashFlowLabel);
            this.panel6.ForeColor = System.Drawing.Color.Snow;
            this.panel6.Location = new System.Drawing.Point(549, 612);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.panel6.Size = new System.Drawing.Size(272, 40);
            this.panel6.TabIndex = 29;
            // 
            // vehicleCashFlowLabel
            // 
            this.vehicleCashFlowLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vehicleCashFlowLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vehicleCashFlowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.vehicleCashFlowLabel.Location = new System.Drawing.Point(-1, 7);
            this.vehicleCashFlowLabel.Margin = new System.Windows.Forms.Padding(2);
            this.vehicleCashFlowLabel.Multiline = true;
            this.vehicleCashFlowLabel.Name = "vehicleCashFlowLabel";
            this.vehicleCashFlowLabel.ReadOnly = true;
            this.vehicleCashFlowLabel.Size = new System.Drawing.Size(269, 24);
            this.vehicleCashFlowLabel.TabIndex = 15;
            this.vehicleCashFlowLabel.Text = "Vehicle Cash-Flow: $1990";
            this.vehicleCashFlowLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // activityDGV
            // 
            this.activityDGV.AllowUserToAddRows = false;
            this.activityDGV.AllowUserToDeleteRows = false;
            this.activityDGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.activityDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.activityDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.activityDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.activityDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.activityDGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.activityDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.activityDGV.ColumnHeadersHeight = 46;
            this.activityDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.activityDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.activityDGV.GridColor = System.Drawing.SystemColors.Control;
            this.activityDGV.Location = new System.Drawing.Point(27, 323);
            this.activityDGV.MultiSelect = false;
            this.activityDGV.Name = "activityDGV";
            this.activityDGV.ReadOnly = true;
            this.activityDGV.RowHeadersVisible = false;
            this.activityDGV.RowHeadersWidth = 82;
            this.activityDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.activityDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.activityDGV.Size = new System.Drawing.Size(794, 258);
            this.activityDGV.TabIndex = 28;
            this.activityDGV.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ActivityData_MouseDoubleClick);
            // 
            // closeViewFormButton
            // 
            this.closeViewFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.closeViewFormButton.Location = new System.Drawing.Point(649, 678);
            this.closeViewFormButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeViewFormButton.Name = "closeViewFormButton";
            this.closeViewFormButton.Size = new System.Drawing.Size(170, 40);
            this.closeViewFormButton.TabIndex = 27;
            this.closeViewFormButton.Text = "Save";
            this.closeViewFormButton.UseVisualStyleBackColor = true;
            this.closeViewFormButton.Click += new System.EventHandler(this.SaveFormButton_Click);
            // 
            // deleteActivityButton
            // 
            this.deleteActivityButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.deleteActivityButton.Enabled = false;
            this.deleteActivityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteActivityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deleteActivityButton.Location = new System.Drawing.Point(27, 613);
            this.deleteActivityButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteActivityButton.Name = "deleteActivityButton";
            this.deleteActivityButton.Size = new System.Drawing.Size(170, 40);
            this.deleteActivityButton.TabIndex = 26;
            this.deleteActivityButton.Text = "Delete Activity";
            this.deleteActivityButton.UseVisualStyleBackColor = false;
            this.deleteActivityButton.Click += new System.EventHandler(this.DeleteActivityButton_Click);
            // 
            // addActivityButton
            // 
            this.addActivityButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addActivityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addActivityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addActivityButton.Location = new System.Drawing.Point(27, 678);
            this.addActivityButton.Margin = new System.Windows.Forms.Padding(2);
            this.addActivityButton.Name = "addActivityButton";
            this.addActivityButton.Size = new System.Drawing.Size(170, 40);
            this.addActivityButton.TabIndex = 25;
            this.addActivityButton.Text = "Add Activity";
            this.addActivityButton.UseVisualStyleBackColor = false;
            this.addActivityButton.Click += new System.EventHandler(this.AddActivityButton_Click);
            // 
            // viewActivityButton
            // 
            this.viewActivityButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.viewActivityButton.Enabled = false;
            this.viewActivityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewActivityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.viewActivityButton.Location = new System.Drawing.Point(230, 613);
            this.viewActivityButton.Margin = new System.Windows.Forms.Padding(2);
            this.viewActivityButton.Name = "viewActivityButton";
            this.viewActivityButton.Size = new System.Drawing.Size(170, 40);
            this.viewActivityButton.TabIndex = 24;
            this.viewActivityButton.Text = "View Activity";
            this.viewActivityButton.UseVisualStyleBackColor = false;
            this.viewActivityButton.Click += new System.EventHandler(this.ViewActivityButton_Click);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(-2, 283);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(896, 1);
            this.label7.TabIndex = 23;
            // 
            // activityComboBox
            // 
            this.activityComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.activityComboBox.FormattingEnabled = true;
            this.activityComboBox.Items.AddRange(new object[] {
            "Hiring",
            "Service",
            "Relocation"});
            this.activityComboBox.Location = new System.Drawing.Point(230, 678);
            this.activityComboBox.Name = "activityComboBox";
            this.activityComboBox.Size = new System.Drawing.Size(170, 28);
            this.activityComboBox.TabIndex = 30;
            // 
            // dateSortButton
            // 
            this.dateSortButton.Location = new System.Drawing.Point(652, 292);
            this.dateSortButton.Name = "dateSortButton";
            this.dateSortButton.Size = new System.Drawing.Size(80, 23);
            this.dateSortButton.TabIndex = 31;
            this.dateSortButton.Text = "Sort By: Date";
            this.dateSortButton.UseVisualStyleBackColor = true;
            this.dateSortButton.Click += new System.EventHandler(this.DateSortButton_Click);
            // 
            // nameSortButton
            // 
            this.nameSortButton.Location = new System.Drawing.Point(738, 292);
            this.nameSortButton.Name = "nameSortButton";
            this.nameSortButton.Size = new System.Drawing.Size(83, 23);
            this.nameSortButton.TabIndex = 32;
            this.nameSortButton.Text = "Sort By: Name";
            this.nameSortButton.UseVisualStyleBackColor = true;
            this.nameSortButton.Click += new System.EventHandler(this.NameSortButton_Click);
            // 
            // ViewVehicleForm
            // 
            this.AcceptButton = this.closeViewFormButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(848, 744);
            this.Controls.Add(this.nameSortButton);
            this.Controls.Add(this.dateSortButton);
            this.Controls.Add(this.activityComboBox);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.activityDGV);
            this.Controls.Add(this.closeViewFormButton);
            this.Controls.Add(this.deleteActivityButton);
            this.Controls.Add(this.addActivityButton);
            this.Controls.Add(this.viewActivityButton);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ViewVehicleForm";
            this.Text = "Vehicle System - View Vehicle";
            this.Load += new System.EventHandler(this.ViewVehicleForm_Load);
            this.Controls.SetChildIndex(this.saveFormButton, 0);
            this.Controls.SetChildIndex(this.closeFormButton, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.viewActivityButton, 0);
            this.Controls.SetChildIndex(this.addActivityButton, 0);
            this.Controls.SetChildIndex(this.deleteActivityButton, 0);
            this.Controls.SetChildIndex(this.closeViewFormButton, 0);
            this.Controls.SetChildIndex(this.activityDGV, 0);
            this.Controls.SetChildIndex(this.panel6, 0);
            this.Controls.SetChildIndex(this.activityComboBox, 0);
            this.Controls.SetChildIndex(this.dateSortButton, 0);
            this.Controls.SetChildIndex(this.nameSortButton, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox vehicleCashFlowLabel;
        private System.Windows.Forms.Button closeViewFormButton;
        private System.Windows.Forms.Button deleteActivityButton;
        private System.Windows.Forms.Button addActivityButton;
        private System.Windows.Forms.Button viewActivityButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox activityComboBox;
        private System.Windows.Forms.Button dateSortButton;
        private System.Windows.Forms.Button nameSortButton;
        public System.Windows.Forms.DataGridView activityDGV;
    }
}
