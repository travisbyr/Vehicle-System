
namespace VehicleSystem
{
    partial class HiringActivityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HiringActivityForm));
            this.hiringTitle = new System.Windows.Forms.Label();
            this.hiringCloseButton = new System.Windows.Forms.Button();
            this.hiringSaveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.hiringCustomerInput = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hiringNameInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hiringStartDate = new System.Windows.Forms.DateTimePicker();
            this.hiringEndDate = new System.Windows.Forms.DateTimePicker();
            this.hiringDate = new System.Windows.Forms.DateTimePicker();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // hiringTitle
            // 
            this.hiringTitle.AutoSize = true;
            this.hiringTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.hiringTitle.Location = new System.Drawing.Point(290, 25);
            this.hiringTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hiringTitle.Name = "hiringTitle";
            this.hiringTitle.Size = new System.Drawing.Size(263, 29);
            this.hiringTitle.TabIndex = 41;
            this.hiringTitle.Text = "Hiring Activity - ABC123";
            this.hiringTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // hiringCloseButton
            // 
            this.hiringCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.hiringCloseButton.Location = new System.Drawing.Point(660, 337);
            this.hiringCloseButton.Margin = new System.Windows.Forms.Padding(2);
            this.hiringCloseButton.Name = "hiringCloseButton";
            this.hiringCloseButton.Size = new System.Drawing.Size(136, 39);
            this.hiringCloseButton.TabIndex = 40;
            this.hiringCloseButton.Text = "Close";
            this.hiringCloseButton.UseVisualStyleBackColor = true;
            this.hiringCloseButton.Click += new System.EventHandler(this.CloseFormButton_Click);
            // 
            // hiringSaveButton
            // 
            this.hiringSaveButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.hiringSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hiringSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.hiringSaveButton.Location = new System.Drawing.Point(489, 337);
            this.hiringSaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.hiringSaveButton.Name = "hiringSaveButton";
            this.hiringSaveButton.Size = new System.Drawing.Size(136, 39);
            this.hiringSaveButton.TabIndex = 39;
            this.hiringSaveButton.Text = "Save";
            this.hiringSaveButton.UseVisualStyleBackColor = false;
            this.hiringSaveButton.Click += new System.EventHandler(this.SaveActivityButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(38, 289);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "End Hire Date:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(32, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Start Hire Date:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.hiringCustomerInput);
            this.panel3.Location = new System.Drawing.Point(180, 181);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(618, 45);
            this.panel3.TabIndex = 34;
            // 
            // hiringCustomerInput
            // 
            this.hiringCustomerInput.BackColor = System.Drawing.Color.White;
            this.hiringCustomerInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hiringCustomerInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.hiringCustomerInput.Location = new System.Drawing.Point(7, 7);
            this.hiringCustomerInput.Margin = new System.Windows.Forms.Padding(2);
            this.hiringCustomerInput.Multiline = true;
            this.hiringCustomerInput.Name = "hiringCustomerInput";
            this.hiringCustomerInput.Size = new System.Drawing.Size(605, 27);
            this.hiringCustomerInput.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.hiringNameInput);
            this.panel2.Location = new System.Drawing.Point(180, 119);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(618, 45);
            this.panel2.TabIndex = 32;
            // 
            // hiringNameInput
            // 
            this.hiringNameInput.BackColor = System.Drawing.Color.White;
            this.hiringNameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hiringNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.hiringNameInput.Location = new System.Drawing.Point(7, 8);
            this.hiringNameInput.Margin = new System.Windows.Forms.Padding(2);
            this.hiringNameInput.Multiline = true;
            this.hiringNameInput.Name = "hiringNameInput";
            this.hiringNameInput.Size = new System.Drawing.Size(605, 27);
            this.hiringNameInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(17, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Customer Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(40, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Activity Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(118, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Date:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hiringStartDate
            // 
            this.hiringStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiringStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hiringStartDate.Location = new System.Drawing.Point(180, 243);
            this.hiringStartDate.Name = "hiringStartDate";
            this.hiringStartDate.Size = new System.Drawing.Size(318, 29);
            this.hiringStartDate.TabIndex = 43;
            this.hiringStartDate.Value = new System.DateTime(2021, 6, 8, 0, 0, 0, 0);
            // 
            // hiringEndDate
            // 
            this.hiringEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiringEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hiringEndDate.Location = new System.Drawing.Point(180, 287);
            this.hiringEndDate.Name = "hiringEndDate";
            this.hiringEndDate.Size = new System.Drawing.Size(318, 29);
            this.hiringEndDate.TabIndex = 44;
            this.hiringEndDate.Value = new System.DateTime(2021, 6, 8, 0, 0, 0, 0);
            // 
            // hiringDate
            // 
            this.hiringDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiringDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hiringDate.Location = new System.Drawing.Point(180, 75);
            this.hiringDate.Name = "hiringDate";
            this.hiringDate.Size = new System.Drawing.Size(318, 29);
            this.hiringDate.TabIndex = 45;
            this.hiringDate.Value = new System.DateTime(2021, 6, 8, 0, 0, 0, 0);
            // 
            // HiringActivityForm
            // 
            this.AcceptButton = this.hiringSaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 406);
            this.ControlBox = false;
            this.Controls.Add(this.hiringDate);
            this.Controls.Add(this.hiringEndDate);
            this.Controls.Add(this.hiringStartDate);
            this.Controls.Add(this.hiringTitle);
            this.Controls.Add(this.hiringCloseButton);
            this.Controls.Add(this.hiringSaveButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HiringActivityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle System - Hiring Activity";
            this.Load += new System.EventHandler(this.HiringActivityForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hiringTitle;
        public System.Windows.Forms.Button hiringCloseButton;
        public System.Windows.Forms.Button hiringSaveButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox hiringCustomerInput;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox hiringNameInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker hiringStartDate;
        private System.Windows.Forms.DateTimePicker hiringEndDate;
        private System.Windows.Forms.DateTimePicker hiringDate;
    }
}