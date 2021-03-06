using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Athlete_Salary
{

    class Employee //Base Class
    {
        //Define Backing Fields
        private string _name;

        //Define the Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //Define Parameterized Constructor
        public Employee(string n)
        {
            _name = n;
        }
    }

    class Lawyer : Employee //Derived Class
    {
        //Define Backing Fields
        private double _pay;
        private string _position = "Lawyer";

        //Define the Properties
        double Pay
        {
            get { return _pay; }
            set { _pay = value * .1; }
        }
        string Position
        {
            get { return _position; }
        }

        //Define Parameterized Constructor
        public Lawyer(string n, double p) : base(n)
        {
            _pay = p * .1; //10% payment
        }
        //Push Data to DB
        public void AddData() {
            //Establish Connection
            SqlCommand cmd;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\StaffManager.mdf;Integrated Security=True");
            con.Open();

            //Build & Execute SQL Query With Paremeters
            cmd = new SqlCommand("INSERT INTO Employees (emp_name, emp_position, emp_pay) VALUES (@name, @pos, @pay)", con);
            cmd.Parameters.AddWithValue("@name", this.Name);
            cmd.Parameters.AddWithValue("@pos", this.Position);
            cmd.Parameters.AddWithValue("@pay", this.Pay);
            cmd.ExecuteNonQuery();
        }
    }

    class Agent : Employee //Derived Class
    {
        //Define Backing Fields
        private double _pay;
        private string _position = "Agent";

        //Define the Properties
        double Pay
        {
            get { return _pay; }
            set { _pay = value * .07; }
        }
        string Position
        {
            get { return _position; }
        }

        //Define Parameterized Constructor
        public Agent(string n, double p) : base(n)
        {
            _pay = p * .07; // 70% payment
        }
        //Push Data to DB
        public void AddData()
        {
            //Establish Connection
            SqlCommand cmd;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\StaffManager.mdf;Integrated Security=True");
            con.Open();

            //Build & Execute SQL Query With Paremeters
            cmd = new SqlCommand("INSERT INTO Employees (emp_name, emp_position, emp_pay) VALUES (@name, @pos, @pay)", con);
            cmd.Parameters.AddWithValue("@name", this.Name);
            cmd.Parameters.AddWithValue("@pos", this.Position);
            cmd.Parameters.AddWithValue("@pay", this.Pay);
            cmd.ExecuteNonQuery();
        }
    }

    class Trainer : Employee //Derived Class
    {
        //Define Backing Fields
        private double _pay;
        private string _position = "Trainer";

        //Define the Properties
        double Pay
        {
            get { return _pay; }
            set { _pay = value * .05; }
        }
        string Position
        {
            get { return _position; }
        }

        //Define Parameterized Constructor
        public Trainer(string n, double p) : base(n)
        {
            _pay = p * .05;// 50% payment
        }
        //Push Data to DB
        public void AddData()
        {
            //Establish Connection
            SqlCommand cmd;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\StaffManager.mdf;Integrated Security=True");
            con.Open();

            //Build & Execute SQL Query With Paremeters
            cmd = new SqlCommand("INSERT INTO Employees (emp_name, emp_position, emp_pay) VALUES (@name, @pos, @pay)", con);
            cmd.Parameters.AddWithValue("@name", this.Name);
            cmd.Parameters.AddWithValue("@pos", this.Position);
            cmd.Parameters.AddWithValue("@pay", this.Pay);
            cmd.ExecuteNonQuery();
        }
    }

    class Assistant : Employee //Derived Class
    {
        //Define Backing Fields
        private double _pay;
        private string _position = "Personal Assistant";

        //Define the Properties
        double Pay
        {
            get { return _pay; }
            set { _pay = value * .03; }
        }
        string Position
        {
            get { return _position; }
        }

        //Define Parameterized Constructor
        public Assistant(string n, double p) : base(n)
        {
            _pay = p * .03;// 30% payment
        }
        //Push Data to DB
        public void AddData()
        {
            //Establish Connection
            SqlCommand cmd;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\StaffManager.mdf;Integrated Security=True");
            con.Open();

            //Build & Execute SQL Query With Paremeters
            cmd = new SqlCommand("INSERT INTO Employees (emp_name, emp_position, emp_pay) VALUES (@name, @pos, @pay)", con);
            cmd.Parameters.AddWithValue("@name", this.Name);
            cmd.Parameters.AddWithValue("@pos", this.Position);
            cmd.Parameters.AddWithValue("@pay", this.Pay);
            cmd.ExecuteNonQuery();
        }
    }
}
