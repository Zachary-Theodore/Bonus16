using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus16
{
    class Used : Car
    {
        private int miles;

        public int Miles
        {
            set { miles = value; }
            get { return miles; }
        }

        public Used(string mk, string md, string yr, double pr, int mi)
            : base(mk, md, yr, pr)
        {

            Miles = mi;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine( $"Mileage {Miles}");
        }


    }
}
