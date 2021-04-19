using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Athlete_Salary
{
    class Athlete //Base Class
    {
        //Define Backing Fields
        private string _name;
        private double _pay;

        //Define the Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double Pay
        {
            get { return _pay; }
            set { _pay = value; }
        }

        //Define Parameterized Constructor
        public Athlete(string n, double p)
        {
            _name = n; _pay = p;
        }

    }
}
