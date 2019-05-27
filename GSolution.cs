using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1LRP281
{
    public partial class GSolution : Form
    {
        public GSolution()
        {
            InitializeComponent();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            string fileName = txtPath.Text;
            MySolver solver = new MySolver();
            solver.Solve(fileName);
            MyConstraints myConstraint = new MyConstraints();
            List<MyConstraints> mConstraints = solver.Constraints;

            int count = 0;
           
            try
            {
                // List<Point> points = new List<Point>();
                chLine.Series.Add("ObjectFunction");
                chLine.Series["ObjectFunction"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                foreach (MyConstraints item in mConstraints)
                {
                    count++;
                    chLine.Series.Add(string.Format("Constraint{0}", count));
                    chLine.Series[string.Format("Constraint{0}", count)].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    chLine.Series[string.Format("Constraint{0}", count)].Points.AddXY(item.X1Value, 0);
                    chLine.Series[string.Format("Constraint{0}", count)].Points.AddXY(0, item.X2Value);
                }
                double[] objV = solver.ObjValues;
                chLine.Series["ObjectFunction"].Points.AddXY(objV[0], 0);
                chLine.Series["ObjectFunction"].Points.AddXY(0, objV[1]);
                for (int i = 0; i < mConstraints.Count-1; i++)
                {
                    chLine.Series.Add(string.Format("Point{0}", i + 1));
                    for (int x = 0; x < mConstraints.Count; x++)
                    {
                        chLine.Series[string.Format("Point{0}", i + 1)].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
                        mConstraints[i].GetIntersection(mConstraints[x]);
                        chLine.Series[string.Format("Point{0}", i + 1)].Points.AddXY(mConstraints[i].XIntersection, mConstraints[i].YIntersectiion);
                        chLine.Series[string.Format("Point{0}", i + 1)].Points.AddXY(0,mConstraints[i].X1Value);
                            // the points show the feasible area

                    }
                   
                
                }
            }
            catch (Exception )
            {

                MessageBox.Show("Error whene creating chart");
            }
          
        }
    }
}
