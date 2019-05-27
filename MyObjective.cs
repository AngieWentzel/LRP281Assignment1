using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment1LRP281
{
    class MyObjective
    {
        //fields used to store data about the objective function
        private string type;        //states what type of function it is MIN/MAX
        private double x1;          //stores the value in front of the x1
        private double x1Value;     //stores the calculated x1 value
        private double x2;          //stores the value in front of the x2
        private double x2Value;     //stores the calculated x2 value
        private double z;


        public string Type { get => type; set => type = value; }
        public double X1 { get => x1; set => x1 = value; }
        public double X2 { get => x2; set => x2 = value; }
        public double Z { get => z; set => z = value; }
        public double X1Value { get => x1Value; set => x1Value = value; }
        public double X2Value { get => x2Value; set => x2Value = value; }

        public MyObjective()
        {

        }

        public override string ToString()
        {
            return string.Format("{0} Z = {1}x1 + {2}x2", Type, X1, X2);
        }
    }
}
