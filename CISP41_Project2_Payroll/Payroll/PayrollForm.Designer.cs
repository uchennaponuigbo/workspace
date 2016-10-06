namespace Payroll
{
    partial class PayrollForm
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
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.hoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.hourlyRateTextBox = new System.Windows.Forms.TextBox();
            this.deductionCodeTextBox = new System.Windows.Forms.TextBox();
            this.grossPayTextBox = new System.Windows.Forms.TextBox();
            this.taxesTextBox = new System.Windows.Forms.TextBox();
            this.deductionTextBox = new System.Windows.Forms.TextBox();
            this.netPayTextBox = new System.Windows.Forms.TextBox();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.hoursWorkedLabel = new System.Windows.Forms.Label();
            this.hourlyRateLabel = new System.Windows.Forms.Label();
            this.deductionCodeLabel = new System.Windows.Forms.Label();
            this.grossPayLabel = new System.Windows.Forms.Label();
            this.taxesLabel = new System.Windows.Forms.Label();
            this.deductionLabel = new System.Windows.Forms.Label();
            this.netPayLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.summaryButton = new System.Windows.Forms.Button();
            this.employeeNameValidLabel = new System.Windows.Forms.Label();
            this.hoursWorkedValidLabel = new System.Windows.Forms.Label();
            this.hourlyRateValidLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(46, 111);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(186, 22);
            this.employeeNameTextBox.TabIndex = 2;
            // 
            // hoursWorkedTextBox
            // 
            this.hoursWorkedTextBox.Location = new System.Drawing.Point(46, 202);
            this.hoursWorkedTextBox.MaximumSize = new System.Drawing.Size(200, 40);
            this.hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            this.hoursWorkedTextBox.Size = new System.Drawing.Size(186, 22);
            this.hoursWorkedTextBox.TabIndex = 3;
            // 
            // hourlyRateTextBox
            // 
            this.hourlyRateTextBox.Location = new System.Drawing.Point(46, 303);
            this.hourlyRateTextBox.Name = "hourlyRateTextBox";
            this.hourlyRateTextBox.Size = new System.Drawing.Size(186, 22);
            this.hourlyRateTextBox.TabIndex = 4;
            // 
            // deductionCodeTextBox
            // 
            this.deductionCodeTextBox.Location = new System.Drawing.Point(46, 403);
            this.deductionCodeTextBox.Name = "deductionCodeTextBox";
            this.deductionCodeTextBox.Size = new System.Drawing.Size(186, 22);
            this.deductionCodeTextBox.TabIndex = 5;
            // 
            // grossPayTextBox
            // 
            this.grossPayTextBox.Location = new System.Drawing.Point(399, 111);
            this.grossPayTextBox.Name = "grossPayTextBox";
            this.grossPayTextBox.ReadOnly = true;
            this.grossPayTextBox.Size = new System.Drawing.Size(186, 22);
            this.grossPayTextBox.TabIndex = 6;
            // 
            // taxesTextBox
            // 
            this.taxesTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.taxesTextBox.Location = new System.Drawing.Point(399, 202);
            this.taxesTextBox.Name = "taxesTextBox";
            this.taxesTextBox.ReadOnly = true;
            this.taxesTextBox.Size = new System.Drawing.Size(186, 22);
            this.taxesTextBox.TabIndex = 7;
            // 
            // deductionTextBox
            // 
            this.deductionTextBox.Location = new System.Drawing.Point(399, 303);
            this.deductionTextBox.Name = "deductionTextBox";
            this.deductionTextBox.ReadOnly = true;
            this.deductionTextBox.Size = new System.Drawing.Size(186, 22);
            this.deductionTextBox.TabIndex = 8;
            // 
            // netPayTextBox
            // 
            this.netPayTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.netPayTextBox.ForeColor = System.Drawing.Color.Green;
            this.netPayTextBox.Location = new System.Drawing.Point(399, 403);
            this.netPayTextBox.Name = "netPayTextBox";
            this.netPayTextBox.ReadOnly = true;
            this.netPayTextBox.Size = new System.Drawing.Size(186, 22);
            this.netPayTextBox.TabIndex = 9;
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Location = new System.Drawing.Point(43, 90);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(111, 17);
            this.employeeNameLabel.TabIndex = 10;
            this.employeeNameLabel.Text = "Employee Name";
            // 
            // hoursWorkedLabel
            // 
            this.hoursWorkedLabel.AutoSize = true;
            this.hoursWorkedLabel.Location = new System.Drawing.Point(43, 182);
            this.hoursWorkedLabel.Name = "hoursWorkedLabel";
            this.hoursWorkedLabel.Size = new System.Drawing.Size(99, 17);
            this.hoursWorkedLabel.TabIndex = 12;
            this.hoursWorkedLabel.Text = "Hours Worked";
            // 
            // hourlyRateLabel
            // 
            this.hourlyRateLabel.AutoSize = true;
            this.hourlyRateLabel.Location = new System.Drawing.Point(43, 283);
            this.hourlyRateLabel.Name = "hourlyRateLabel";
            this.hourlyRateLabel.Size = new System.Drawing.Size(83, 17);
            this.hourlyRateLabel.TabIndex = 14;
            this.hourlyRateLabel.Text = "Hourly Rate";
            // 
            // deductionCodeLabel
            // 
            this.deductionCodeLabel.AutoSize = true;
            this.deductionCodeLabel.Location = new System.Drawing.Point(45, 383);
            this.deductionCodeLabel.Name = "deductionCodeLabel";
            this.deductionCodeLabel.Size = new System.Drawing.Size(109, 17);
            this.deductionCodeLabel.TabIndex = 16;
            this.deductionCodeLabel.Text = "Deduction Code";
            // 
            // grossPayLabel
            // 
            this.grossPayLabel.AutoSize = true;
            this.grossPayLabel.Location = new System.Drawing.Point(396, 90);
            this.grossPayLabel.Name = "grossPayLabel";
            this.grossPayLabel.Size = new System.Drawing.Size(74, 17);
            this.grossPayLabel.TabIndex = 18;
            this.grossPayLabel.Text = "Gross Pay";
            // 
            // taxesLabel
            // 
            this.taxesLabel.AutoSize = true;
            this.taxesLabel.Location = new System.Drawing.Point(396, 182);
            this.taxesLabel.Name = "taxesLabel";
            this.taxesLabel.Size = new System.Drawing.Size(46, 17);
            this.taxesLabel.TabIndex = 20;
            this.taxesLabel.Text = "Taxes";
            // 
            // deductionLabel
            // 
            this.deductionLabel.AutoSize = true;
            this.deductionLabel.Location = new System.Drawing.Point(396, 283);
            this.deductionLabel.Name = "deductionLabel";
            this.deductionLabel.Size = new System.Drawing.Size(72, 17);
            this.deductionLabel.TabIndex = 22;
            this.deductionLabel.Text = "Deduction";
            // 
            // netPayLabel
            // 
            this.netPayLabel.AutoSize = true;
            this.netPayLabel.Location = new System.Drawing.Point(396, 383);
            this.netPayLabel.Name = "netPayLabel";
            this.netPayLabel.Size = new System.Drawing.Size(58, 17);
            this.netPayLabel.TabIndex = 24;
            this.netPayLabel.Text = "Net Pay";
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.calculateButton.FlatAppearance.BorderSize = 0;
            this.calculateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.calculateButton.ForeColor = System.Drawing.Color.White;
            this.calculateButton.Location = new System.Drawing.Point(46, 466);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(0);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(124, 28);
            this.calculateButton.TabIndex = 25;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(188, 466);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(124, 28);
            this.clearButton.TabIndex = 26;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(522, 466);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(124, 28);
            this.exitButton.TabIndex = 27;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // summaryButton
            // 
            this.summaryButton.Location = new System.Drawing.Point(379, 466);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(124, 28);
            this.summaryButton.TabIndex = 28;
            this.summaryButton.Text = "Summary";
            this.summaryButton.UseVisualStyleBackColor = true;
            this.summaryButton.Click += new System.EventHandler(this.summaryButton_Click);
            // 
            // employeeNameValidLabel
            // 
            this.employeeNameValidLabel.AutoSize = true;
            this.employeeNameValidLabel.ForeColor = System.Drawing.Color.Red;
            this.employeeNameValidLabel.Location = new System.Drawing.Point(43, 136);
            this.employeeNameValidLabel.Name = "employeeNameValidLabel";
            this.employeeNameValidLabel.Size = new System.Drawing.Size(0, 17);
            this.employeeNameValidLabel.TabIndex = 29;
            // 
            // hoursWorkedValidLabel
            // 
            this.hoursWorkedValidLabel.AutoSize = true;
            this.hoursWorkedValidLabel.ForeColor = System.Drawing.Color.Red;
            this.hoursWorkedValidLabel.Location = new System.Drawing.Point(45, 227);
            this.hoursWorkedValidLabel.MaximumSize = new System.Drawing.Size(250, 44);
            this.hoursWorkedValidLabel.Name = "hoursWorkedValidLabel";
            this.hoursWorkedValidLabel.Size = new System.Drawing.Size(0, 17);
            this.hoursWorkedValidLabel.TabIndex = 30;
            // 
            // hourlyRateValidLabel
            // 
            this.hourlyRateValidLabel.AutoSize = true;
            this.hourlyRateValidLabel.ForeColor = System.Drawing.Color.Red;
            this.hourlyRateValidLabel.Location = new System.Drawing.Point(45, 328);
            this.hourlyRateValidLabel.Name = "hourlyRateValidLabel";
            this.hourlyRateValidLabel.Size = new System.Drawing.Size(0, 17);
            this.hourlyRateValidLabel.TabIndex = 31;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(45, 32);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(494, 25);
            this.titleLabel.TabIndex = 32;
            this.titleLabel.Text = "Enter the values below to calculate the employee\'s pay. ";
            // 
            // PayrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 527);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.hourlyRateValidLabel);
            this.Controls.Add(this.hoursWorkedValidLabel);
            this.Controls.Add(this.employeeNameValidLabel);
            this.Controls.Add(this.summaryButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.netPayLabel);
            this.Controls.Add(this.deductionLabel);
            this.Controls.Add(this.taxesLabel);
            this.Controls.Add(this.grossPayLabel);
            this.Controls.Add(this.deductionCodeLabel);
            this.Controls.Add(this.hourlyRateLabel);
            this.Controls.Add(this.hoursWorkedLabel);
            this.Controls.Add(this.employeeNameLabel);
            this.Controls.Add(this.netPayTextBox);
            this.Controls.Add(this.deductionTextBox);
            this.Controls.Add(this.taxesTextBox);
            this.Controls.Add(this.grossPayTextBox);
            this.Controls.Add(this.deductionCodeTextBox);
            this.Controls.Add(this.hourlyRateTextBox);
            this.Controls.Add(this.hoursWorkedTextBox);
            this.Controls.Add(this.employeeNameTextBox);
            this.Name = "PayrollForm";
            this.Text = "Payroll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.TextBox hoursWorkedTextBox;
        private System.Windows.Forms.TextBox hourlyRateTextBox;
        private System.Windows.Forms.TextBox deductionCodeTextBox;
        private System.Windows.Forms.TextBox grossPayTextBox;
        private System.Windows.Forms.TextBox taxesTextBox;
        private System.Windows.Forms.TextBox deductionTextBox;
        private System.Windows.Forms.TextBox netPayTextBox;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Label hoursWorkedLabel;
        private System.Windows.Forms.Label hourlyRateLabel;
        private System.Windows.Forms.Label deductionCodeLabel;
        private System.Windows.Forms.Label grossPayLabel;
        private System.Windows.Forms.Label taxesLabel;
        private System.Windows.Forms.Label deductionLabel;
        private System.Windows.Forms.Label netPayLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button summaryButton;
        private System.Windows.Forms.Label employeeNameValidLabel;
        private System.Windows.Forms.Label hoursWorkedValidLabel;
        private System.Windows.Forms.Label hourlyRateValidLabel;
        private System.Windows.Forms.Label titleLabel;
    }
}

