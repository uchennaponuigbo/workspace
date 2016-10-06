using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public partial class PayrollForm : Form
    {
        private int _totalEmployeesProcessed;
        private decimal _totalGrossPay;
        private decimal _totalDeduction;
        private decimal _totalTaxes;
        private decimal _totalNetPay;

        private const decimal OvertimeRate = 1.5m;
        private const decimal DoubleOvertimeRate = 2.0m;
        private const decimal TaxRate = 0.25m;
        private const decimal MinimunWage = 9.25m;

        private List<string> _employeeSummaryInfo;

        public PayrollForm()
        {
            _employeeSummaryInfo = new List<string>();
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Clear out validation messages
            employeeNameValidLabel.Text = "";
            hourlyRateValidLabel.Text = "";
            hoursWorkedValidLabel.Text = "";

            bool formIsValid = true;

            employeeNameValidLabel.Text = "";
            string employeeName = employeeNameTextBox.Text;

            // Validate that the employee is filled in properly
            if (employeeNameTextBox.Text == "")
            {
                employeeNameValidLabel.Text = "Please enter an employee name";
                formIsValid = false;
            }

            // Validate that the hours are proper
            int hoursWorked;
            bool hoursWorkedIsValid = Int32.TryParse(hoursWorkedTextBox.Text, out hoursWorked);

            if (hoursWorkedTextBox.Text == "")
            {
                hoursWorkedValidLabel.Text = "Please enter the number of hours worked";
                formIsValid = false;
            }
            else if (!hoursWorkedIsValid)
            {
                hoursWorkedValidLabel.Text = "Please enter a valid number for number of hours worked.";
                formIsValid = false;
            }
            else if (hoursWorked > 70 || hoursWorked < 5)
            {
                hoursWorkedValidLabel.Text = "The hours must be between 5 and 70.";
                formIsValid = false;
            }

            // Validate that the hourly rate is proper
            decimal hourlyRate;
            bool hourlyRateIsValid = Decimal.TryParse(hourlyRateTextBox.Text, out hourlyRate);
            if (hourlyRateTextBox.Text == "")
            {
                hourlyRateValidLabel.Text = "Please enter the rate.";
                formIsValid = false;
            }
            else if (!hourlyRateIsValid)
            {
                hourlyRateValidLabel.Text = "Please enter a valid number for the rate.";
                formIsValid = false;
            }
            else if (hourlyRate < MinimunWage)
            {
                hourlyRateValidLabel.Text = "The rate must be greater than 9.25.";
                formIsValid = false;
            }

            // Do not process anything if the fields above are invalid
            if (!formIsValid)
            {
                return;
            }

            decimal deduction = calculateDeduction(deductionCodeTextBox.Text);
            if(deduction == 0m)
            {
                // If the user entered something invalid or blank, set the text box to show the correct value
                deductionCodeTextBox.Text = "D0";
            }

            decimal grossPay = calculateGrossPay(hoursWorked, hourlyRate);
            decimal taxes = (grossPay - deduction) * TaxRate;
            decimal netPay = grossPay - deduction - taxes;

            // Output all the calculated variables to the Form
            grossPayTextBox.Text = grossPay.ToString("N2");
            deductionTextBox.Text = deduction.ToString("N2");
            taxesTextBox.Text = taxes.ToString("N2");
            netPayTextBox.Text = netPay.ToString("N2");

            // Finally, update all the total values
            _totalEmployeesProcessed++;
            _totalGrossPay += grossPay;
            _totalDeduction += deduction;
            _totalTaxes += taxes;
            _totalNetPay += netPay;

            // Optional - update employee summary info
            _employeeSummaryInfo.Add(employeeName + ": ".PadRight(30 - employeeName.Length, ' ') + netPay.ToString("N2"));
        }

        private decimal calculateDeduction(string deductionCode)
        {
            // This is the default value, if the user enters anything not valid, or D0
            decimal deduction = 0m;
            if (deductionCodeTextBox.Text == "D1")
            {
                deduction = 10m;
            }
            else if (deductionCodeTextBox.Text == "D2")
            {
                deduction = 30m;
            }
            else if (deductionCodeTextBox.Text == "D3")
            {
                deduction = 60m;
            }
            else
            {
                // Any invalid input will default to 0, and we will display the proper deduction code
                deduction = 0m;
                deductionCodeTextBox.Text = "D0";
            }
            return deduction;

        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            employeeNameTextBox.Text = "";
            hoursWorkedTextBox.Text = "";
            hourlyRateTextBox.Text = "";
            deductionCodeTextBox.Text = "";

            employeeNameValidLabel.Text = "";
            hourlyRateValidLabel.Text = "";
            hoursWorkedValidLabel.Text = "";

            grossPayTextBox.Text = "";
            deductionTextBox.Text = "";
            taxesTextBox.Text = "";
            netPayTextBox.Text = "";

            _totalEmployeesProcessed = 0;
            _totalGrossPay = 0m;
            _totalDeduction = 0m;
            _totalTaxes = 0m;
            _totalNetPay = 0m;

            _employeeSummaryInfo.Clear();

        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void summaryButton_Click(object sender, EventArgs e)
        {
            var messageString = "";
            messageString += "# of Processed Employees: " + _totalEmployeesProcessed.ToString();
            messageString += "\nTotal Gross Pay: " + _totalGrossPay.ToString("N2");
            messageString += "\nTotal Deduction: " + _totalDeduction.ToString("N2");
            messageString += "\nTotal Taxes: " + _totalTaxes.ToString("N2");
            messageString += "\nTotal Net Pay: " + _totalNetPay.ToString("N2");
            messageString += "\n\n";

            for(int i = 0; i < _employeeSummaryInfo.Count; i++)
            {
                messageString += "\n" + _employeeSummaryInfo[i];
            }

            MessageBox.Show(messageString, "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private decimal calculateGrossPay(int hoursWorked, decimal hourlyRate)
        {
            int overTimeHours = hoursWorked - 40;
            if (overTimeHours < 0)
            {
                overTimeHours = 0;
            }

            int doubleOverTimeHours = hoursWorked - 60;
            if (doubleOverTimeHours < 0)
            {
                doubleOverTimeHours = 0;
            }

            // Make sure to only calculate a maximum of 40 hours worked            
            if(hoursWorked > 40)
            {
                hoursWorked = 40;
            }

            decimal regularHoursPay = hoursWorked * hourlyRate;
            decimal overTimePay = overTimeHours * hourlyRate * OvertimeRate;
            decimal doubleOverTimePay = doubleOverTimeHours * hourlyRate * DoubleOvertimeRate;

            decimal grossPay = regularHoursPay + overTimePay + doubleOverTimePay;

            return grossPay;
        }
    }
}
