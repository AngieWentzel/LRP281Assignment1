using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1LRP281
{
    class MySolver
    {
        private List<MyConstraints> constraints;

        private MyObjective objFun = new MyObjective();
        private double[] objValues = new double[2];

        TextFileHandler tFile = new TextFileHandler();

        private List<string> lines = new List<string>();

        public MySolver()
        {
            Constraints = new List<MyConstraints>();
        }

        public List<MyConstraints> Constraints { get => constraints; set => constraints = value; }
        public MyObjective ObjFun { get => objFun; set => objFun = value; }
        public List<string> Lines { get => lines; set => lines = value; }
        public double[] ObjValues { get => objValues; set => objValues = value; }

        public void Solve(string textfile)
        {
            try
            {
                Lines = tFile.ReadFromFile(textfile);


                string objFunLine = Lines[0];                   //first line will always be objective function
                string[] objFunData = objFunLine.Split(' ');    //split the line into usable data
                objFun.Type = objFunData[0];
                objFun.X1 = Convert.ToDouble(objFunData[1]);    //assign first numerical value as x1
                objFun.X2 = Convert.ToDouble(objFunData[2]);    //assign second numerical value as x2
                ObjValues[0] = objFun.X1;
                ObjValues[1] = ObjFun.X2;


                //get all of the constraints from the LP
                for (int i = 1; i < Lines.Count - 1; i++)
                {
                    MyConstraints constraint = new MyConstraints();

                    string line = Lines[i];
                    string[] lineData = line.Split(' ');            //split the line into usable data

                    constraint.X1 = Convert.ToDouble(lineData[0]);  //assign first numerical value to x1
                    constraint.X2 = Convert.ToDouble(lineData[1]);  //assign second numerical value to x2
                    constraint.Sign = lineData[2];
                    constraint.Rhs = Convert.ToDouble(lineData[3]);


                    Constraints.Add(constraint);
                }



                //calculate values for the constraints
                int k = 0;
                foreach (MyConstraints c in constraints)
                {
                    k++;

                    //set x1 = 0;
                    if (c.X1 != 0)
                    {
                        c.X1Value = c.Rhs / c.X1;
                    }
                    if (c.X2 != 0)
                    {
                        c.X2Value = c.Rhs / c.X2;
                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Error when solving");
                 
            }
          
            
        }
    }
}
