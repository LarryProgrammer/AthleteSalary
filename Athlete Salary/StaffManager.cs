using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Athlete_Salary
{
    public partial class StaffManager : Form
    {
        public StaffManager()
        {
            InitializeComponent();
        }

        //Decimal value for holding the athletes salary
        double AthleteSalary = 0;
        double totalSalaries = 0;
        int totalEmployees = 0;

        //Grabs the name and position that the user selected and instantiates a class, then inserts the data into the DB
        private void btnHire_Click(object sender, EventArgs e)
        {
            if (validateInput())
            {
                if (drpPosition.Text == "Lawyer") {
                    //Create Lawyer & Add to DB
                    Lawyer emp = new Lawyer(txtHireName.Text, AthleteSalary);
                    emp.AddData();
                } else if (drpPosition.Text == "Personal Assistant") {
                    //Create Assistant & Add to DB
                    Assistant emp = new Assistant(txtHireName.Text, AthleteSalary);
                    emp.AddData();
                } else if (drpPosition.Text == "Trainer") {
                    //Create Trainer & Add to DB
                    Trainer emp = new Trainer(txtHireName.Text, AthleteSalary);
                    emp.AddData();
                } else {
                    //Create Agent & Add to DB
                    Agent emp = new Agent(txtHireName.Text, AthleteSalary);
                    emp.AddData();
                }
            }

            //Set Focus
            txtHireName.Focus();

            //Refresh Displays & Reset Form
            displayEmployees();
            resetHiring();
        }

        //Validate Data from Input
        private bool validateInput() {
            bool validInput = true;
            char tempChar;

            //Check For Null Values
            if (txtHireName.Text == "" || drpPosition.Text == "")
            {
                validInput = false;
                MessageBox.Show("Please make sure Name & Position are not left blank.");
            }

            //Check For Punctuation
            for (int i = 0; i < txtHireName.Text.Length; i++)
            {
                tempChar = txtHireName.Text[i];
                if (tempChar == ',' || tempChar == '.')
                {
                    validInput = false;
                    MessageBox.Show("Invalid Input. Please avoid using commas in employee names.");
                }
            }
            return validInput;
        }

        //Adjust all Displays
        public void displayEmployees()
        {
            
            //Set Data Grid View Query (Specify Connection String, Specify Query, Create DataSet using Query)
            string query = "SELECT emp_id AS 'ID', emp_name AS 'Name', emp_position AS 'Position', emp_pay AS 'Salary' FROM Employees ORDER BY emp_id";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\StaffManager.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter dat = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dat.Fill(ds);
            dgvEmployees.ReadOnly = true;
            dgvEmployees.DataSource = ds.Tables[0];
            con.Close();

            //Display Quantities by Position
            calculatePositionSums();

            //Display Remaining & Spent Salary
            calculateSalaryRemaining();
        }

        //Reset Employee Input Boxes
        private void resetHiring()
        {
            //Reset Textbox
            txtHireName.Clear();
            //Reset Dropdown (Combo Box)
            drpPosition.SelectedIndex = -1;

            //Set Focus
            txtHireName.Focus();
        }

        // Event Listener for "Set Salary" Button
        private void btnSalary_Click(object sender, EventArgs e)
        {
            //Validate Salary Input
            if ((double.TryParse(txtSalary.Text, out AthleteSalary) && AthleteSalary >= 0) && txtEmpName.Text != "") //Valid Salary
            {
                //Create Athlete "ath"
                AthleteSalary = double.Parse(txtSalary.Text);
                Athlete ath = new Athlete(txtEmpName.Text, AthleteSalary);

                //Enable Form Controls
                ShowControls();

                //Set Salary Stats
                lblSpent.Text = "$0.00";
                lblRemaining.Text = "$" + AthleteSalary.ToString("###,###,###,###.00");
                lblRemaining.ForeColor = System.Drawing.Color.DarkGreen;

                //Format TextBox Data
                txtSalary.Text = AthleteSalary.ToString("###,###,###,###.00");
            }
            else //Invalid Salary
            {
                MessageBox.Show("Invalid Salary! Please enter a valid salary.");
                txtSalary.Clear();
                txtSalary.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e) //Clear Hire Form
        {
            resetHiring();
        }

        //Utilized to enable all controls once salary is set
        private void ShowControls()
        {
            txtHireName.Enabled = true;
            drpPosition.Enabled = true;
            btnHire.Enabled = true;
            btnClear.Enabled = true;
            txtSalary.Enabled = false;
            txtEmpName.Enabled = false;
            btnSalary.Enabled = false;
        }

        private void calculateSalaryRemaining() {
            if (totalEmployees > 0) {
                //Declare Data Reader
                SqlDataReader reader = null;

                //Declare SQL Connection String
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\StaffManager.mdf;Integrated Security=True");

                //SQL Query to Run - Reference Connection
                SqlCommand cmd = new SqlCommand("SELECT SUM(emp_pay) AS 'Total Pay' FROM Employees;", con);

                //Open DB Connection
                con.Open();

                //Assign "spent" to Sum
                totalSalaries = (double) cmd.ExecuteScalar();
            } else {
                totalSalaries = 0;
            }

            //Populate Labels
            lblSpent.Text = "$" + totalSalaries.ToString("###,###,###,###.00");
            lblRemaining.Text = "$" + (AthleteSalary - totalSalaries).ToString("###,###,###,##0.00");

            //Format Text Color
            if (AthleteSalary-totalSalaries < 0) {
                lblRemaining.ForeColor = System.Drawing.Color.DarkRed;
            } else if (AthleteSalary-totalSalaries >= 0) {
                lblRemaining.ForeColor = System.Drawing.Color.DarkGreen;
            }
        }

        private void calculatePositionSums() {
            //Display Values
            int lawyerCount, agentCount, assistantCount, trainerCount;
            
            //Declare Data Reader & Connection String
            SqlDataReader reader = null;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\StaffManager.mdf;Integrated Security=True");

            //SQL Commands
            SqlCommand lawyers = new SqlCommand("SELECT COUNT(*) FROM Employees WHERE emp_position='Lawyer'", con);
            SqlCommand agents = new SqlCommand("SELECT COUNT(*) FROM Employees WHERE emp_position='Agent'", con);
            SqlCommand assistant = new SqlCommand("SELECT COUNT(*) FROM Employees WHERE emp_position='Personal Assistant'", con);
            SqlCommand trainers = new SqlCommand("SELECT COUNT(*) FROM Employees WHERE emp_position='Trainer'", con);

            //Open DB Connection
            con.Open();

            //Assign Values
            lawyerCount = (int)lawyers.ExecuteScalar();
            agentCount = (int)agents.ExecuteScalar();
            assistantCount = (int)assistant.ExecuteScalar();
            trainerCount = (int)trainers.ExecuteScalar();

            //Update Total Employees
            totalEmployees = lawyerCount + agentCount + assistantCount + trainerCount;

            //Update Display
            lblHiredEmployees.Text = "Agents: " + agentCount.ToString() + "  |  Lawyers: " + lawyerCount.ToString() + "  |  Personal Assistants: " + assistantCount.ToString() + "  |  Trainers: " + trainerCount.ToString();

            //Update "Delete" Button
            if (totalEmployees < 1)
                DeletBtn.Enabled = false;
            else if (totalEmployees > 0)
                DeletBtn.Enabled = true;
        }

        private void StaffManager_Load(object sender, EventArgs e)
        {
            //Login loginForm = new Login();
            //loginForm.Close();
        }

        private void DeletBtn_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvEmployees.CurrentCell.RowIndex;
            int empID = int.Parse(dgvEmployees.Rows[rowIndex].Cells[0].Value.ToString());

            //Establish Connection
            SqlCommand cmd;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\StaffManager.mdf;Integrated Security=True");
            con.Open();

            //Build & Execute SQL Query With Paremeters
            cmd = new SqlCommand("DELETE FROM Employees WHERE emp_id=@empID", con);
            cmd.Parameters.AddWithValue("@empID", empID);
            cmd.ExecuteNonQuery();

            //Refresh Display
            displayEmployees();
        }

        private void StaffManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
