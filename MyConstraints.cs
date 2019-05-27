using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1LRP281
{
    class MyConstraints
    {
        private double x1;          //value in front of the x1
        private double x1Value;     //calculated value of x1
        private double x2;          //value in front of the x2
        private double x2Value;     //calculated value of x2
        private string sign;        //sign of the equation (= <= >=)
        private double rhs;         //the rhs value
        double xIntersection;
        double yIntersectiion;

        public double X1Value { get => x1Value; set => x1Value = value; }
        public double X2Value { get => x2Value; set => x2Value = value; }
        public double Rhs { get => rhs; set => rhs = value; }
        public double X1 { get => x1; set => x1 = value; }
        public double X2 { get => x2; set => x2 = value; }
        public string Sign { get => sign; set => sign = value; }
        public double XIntersection { get => xIntersection; set => xIntersection = value; }
        public double YIntersectiion { get => yIntersectiion; set => yIntersectiion = value; }

        public MyConstraints()
        {

        }
    


        public override string ToString()
        {
            return string.Format("{0}x1 {1}x2 {2} {3}", x1, x2, sign, rhs);
        }

        public void GetIntersection(object otherConstraint)
        {
            MyConstraints constraint = (MyConstraints)otherConstraint;
            double a = this.x1 - constraint.x1;
            double b = (this.x2) - (constraint.x2);
            

            try
            {
                //double c = (a * this.x1 + (b*this.x2));
                if (a == 1 && b == 0)
                {
                    xIntersection = this.rhs - constraint.rhs;
                    yIntersectiion = constraint.rhs - xIntersection;
                    
                }
                else if (b == 1 && a == 0)
                {
                    xIntersection = float.Parse(this.rhs.ToString()) - float.Parse(constraint.rhs.ToString());
                    yIntersectiion = float.Parse(constraint.rhs.ToString()) - xIntersection;
                    
                }
                else
                if (a < 0 && b < 0 || a >= 1 && b >= 1)
                {

                    a = (this.x1 * constraint.x1) - (constraint.x1 * this.x1);
                    b = (this.x2 * constraint.x1) - (constraint.x2 * this.x1);
                    xIntersection = (this.rhs * constraint.x1) - (constraint.rhs * this.x1);
                    yIntersectiion = (constraint.rhs * this.x1) - xIntersection;

                }
                else
                {
                    xIntersection = 0;
                    yIntersectiion = 0;
                }
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);

            }
        }
    }
}
