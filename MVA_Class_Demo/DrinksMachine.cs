using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVA_Class_Demo
{
    class DrinksMachine
    {
        public DrinksMachine(string loc, string make, string model)
        {
            this.Location = loc;
            this.Make = make;
            this.Model = model;
        }
        //the following statements declare private member variables
        private string _location;
        public string Location { get => _location; set => _location = value; }

        private string _make;
        public string Make { get => _make; set => _make = value; }

        private string _model;
        public string Model { get => _model; set => _model = value; }

        //the following statements declare public methods

        public void MakeCappuccino()
        {
            Console.WriteLine("Cappucino is made.");
        }

        public void MakeExpresso()
        {
            //Method logic goes here
        }
    }
}
