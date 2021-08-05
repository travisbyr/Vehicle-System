
namespace VehicleSystem
{
    partial class RelocationActivityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelocationActivityForm));
            this.panel5 = new System.Windows.Forms.Panel();
            this.relocationDistanceInput = new System.Windows.Forms.TextBox();
            this.relocationTitle = new System.Windows.Forms.Label();
            this.closeFormButton = new System.Windows.Forms.Button();
            this.saveFormButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.relocationEndInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.relocationStartInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.relocationCostInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.relocationActivityDate = new System.Windows.Forms.DateTimePicker();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.relocationDistanceInput);
            this.panel5.Location = new System.Drawing.Point(159, 249);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(618, 45);
            this.panel5.TabIndex = 55;
            // 
            // relocationDistanceInput
            // 
            this.relocationDistanceInput.BackColor = System.Drawing.Color.White;
            this.relocationDistanceInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.relocationDistanceInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.relocationDistanceInput.Location = new System.Drawing.Point(7, 7);
            this.relocationDistanceInput.Margin = new System.Windows.Forms.Padding(2);
            this.relocationDistanceInput.Multiline = true;
            this.relocationDistanceInput.Name = "relocationDistanceInput";
            this.relocationDistanceInput.Size = new System.Drawing.Size(605, 27);
            this.relocationDistanceInput.TabIndex = 5;
            // 
            // relocationTitle
            // 
            this.relocationTitle.AutoSize = true;
            this.relocationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.relocationTitle.Location = new System.Drawing.Point(254, 25);
            this.relocationTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.relocationTitle.Name = "relocationTitle";
            this.relocationTitle.Size = new System.Drawing.Size(314, 29);
            this.relocationTitle.TabIndex = 54;
            this.relocationTitle.Text = "Relocation Activity - ABC123";
            this.relocationTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // closeFormButton
            // 
            this.closeFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.closeFormButton.Location = new System.Drawing.Point(641, 375);
            this.closeFormButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeFormButton.Name = "closeFormButton";
            this.closeFormButton.Size = new System.Drawing.Size(136, 39);
            this.closeFormButton.TabIndex = 8;
            this.closeFormButton.TabStop = false;
            this.closeFormButton.Text = "Close";
            this.closeFormButton.UseVisualStyleBackColor = true;
            this.closeFormButton.Click += new System.EventHandler(this.CloseFormButton_Click);
            // 
            // saveFormButton
            // 
            this.saveFormButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.saveFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.saveFormButton.Location = new System.Drawing.Point(470, 375);
            this.saveFormButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveFormButton.Name = "saveFormButton";
            this.saveFormButton.Size = new System.Drawing.Size(136, 39);
            this.saveFormButton.TabIndex = 7;
            this.saveFormButton.TabStop = false;
            this.saveFormButton.Text = "Save";
            this.saveFormButton.UseVisualStyleBackColor = false;
            this.saveFormButton.Click += new System.EventHandler(this.SaveActivityButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(17, 259);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 51;
            this.label5.Text = "Distance (km):";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.relocationEndInput);
            this.panel4.Location = new System.Drawing.Point(159, 186);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(618, 45);
            this.panel4.TabIndex = 50;
            // 
            // relocationEndInput
            // 
            this.relocationEndInput.BackColor = System.Drawing.Color.White;
            this.relocationEndInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.relocationEndInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.relocationEndInput.Location = new System.Drawing.Point(7, 7);
            this.relocationEndInput.Margin = new System.Windows.Forms.Padding(2);
            this.relocationEndInput.Multiline = true;
            this.relocationEndInput.Name = "relocationEndInput";
            this.relocationEndInput.Size = new System.Drawing.Size(605, 27);
            this.relocationEndInput.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(24, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 49;
            this.label4.Text = "End Location:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.relocationStartInput);
            this.panel3.Location = new System.Drawing.Point(159, 120);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(618, 45);
            this.panel3.TabIndex = 48;
            // 
            // relocationStartInput
            // 
            this.relocationStartInput.BackColor = System.Drawing.Color.White;
            this.relocationStartInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.relocationStartInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.relocationStartInput.Location = new System.Drawing.Point(7, 7);
            this.relocationStartInput.Margin = new System.Windows.Forms.Padding(2);
            this.relocationStartInput.Multiline = true;
            this.relocationStartInput.Name = "relocationStartInput";
            this.relocationStartInput.Size = new System.Drawing.Size(605, 27);
            this.relocationStartInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(18, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 47;
            this.label3.Text = "Start Location:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(97, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "Date:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.relocationCostInput);
            this.panel6.Location = new System.Drawing.Point(159, 309);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(618, 45);
            this.panel6.TabIndex = 57;
            // 
            // relocationCostInput
            // 
            this.relocationCostInput.BackColor = System.Drawing.Color.White;
            this.relocationCostInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.relocationCostInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.relocationCostInput.Location = new System.Drawing.Point(7, 7);
            this.relocationCostInput.Margin = new System.Windows.Forms.Padding(2);
            this.relocationCostInput.Multiline = true;
            this.relocationCostInput.Name = "relocationCostInput";
            this.relocationCostInput.Size = new System.Drawing.Size(605, 27);
            this.relocationCostInput.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(81, 319);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 56;
            this.label6.Text = "Cost: $";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // relocationActivityDate
            // 
            this.relocationActivityDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.relocationActivityDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.relocationActivityDate.Location = new System.Drawing.Point(159, 75);
            this.relocationActivityDate.Name = "relocationActivityDate";
            this.relocationActivityDate.Size = new System.Drawing.Size(318, 29);
            this.relocationActivityDate.TabIndex = 1;
            this.relocationActivityDate.Value = new System.DateTime(2021, 6, 8, 0, 0, 0, 0);
            // 
            // RelocationActivityForm
            // 
            this.AcceptButton = this.saveFormButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 438);
            this.ControlBox = false;
            this.Controls.Add(this.relocationActivityDate);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.relocationTitle);
            this.Controls.Add(this.closeFormButton);
            this.Controls.Add(this.saveFormButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RelocationActivityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle System - Relocation Activity";
            this.Load += new System.EventHandler(this.RelocationActivityForm_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox relocationDistanceInput;
        private System.Windows.Forms.Label relocationTitle;
        public System.Windows.Forms.Button closeFormButton;
        public System.Windows.Forms.Button saveFormButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox relocationEndInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox relocationStartInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox relocationCostInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker relocationActivityDate;
    }
}