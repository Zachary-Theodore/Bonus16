using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bonus16
{
    class Car
    {
        private string make;
        private string model;
        private string year;
        private double price;

        public string Make
        {
            set { make = value; }
            get { return make; }
        }

        public string Model
        {
            set { model = value; }
            get { return model; }
        }

        public string Year
        {
            set
            {
                if (!Regex.IsMatch(value, @"^[0-9]{4}$"))
                {
                    throw new Exception("Year Not a Valid Number Input");
                }
                else
                {

                    year = value;
                }
            }

            get { return year; }
        }

        public double Price
        {
            set { price = value; }
            get { return price; }
        }
    }
}
