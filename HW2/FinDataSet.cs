using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphing_Demo
{
    public class FinDataSet
    {
        List<FinDailyData> dataSet = new List<FinDailyData>();
        
        
        Pen pen = new Pen(Color.Black, .3f);
        Pen pen2 = new Pen(Color.Blue, .3f);
        Pen pen3 = new Pen(Color.Green, .3f);
        Pen pen4 = new Pen(Color.Red, .3f);
        Pen pen5 = new Pen(Color.Purple, .3f);
        Pen pen6 = new Pen(Color.Sienna, .3f);
        public FinDataSet()
        {
        }

        public void drawMovingAverage(Graphics g, float numDays2)
        {
            double average1 = 0;
            double average2 = 0;
            float[] dashValues = { 5, 2, 15, 4 };
            pen5.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            int i = 0;
            int numDays = (int)numDays2;
            if(i < dataSet.Count)
            {
                for (i = 0; i < dataSet.Count; i++)
                {
                    int j = 0;
                    average1 = 0;
                    average2 = 0;
                        
                   for (j = numDays + i; j > i ; j--)
                   {
                       if (j < dataSet.Count - 1)
                       {
                           average1 += dataSet[j].close;
                           average2 += dataSet[j + 1].close;
                       }
                   }
                    average1 = average1 / numDays;
                    average2 = average2 / numDays;
                    g.DrawLine(pen5, i, (float)average1, i + 1f, (float)average2);
                }
            }
            
        }

        public void drawMovingAverage2(Graphics g, float numDays2)
        {
            double average1 = 0;
            double average2 = 0;
            float[] dashValues = { 5, 2, 15, 4 };
            pen6.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            int i = 0;
            int numDays = (int)numDays2;
            if (i < dataSet.Count)
            {
                for (i = 0; i < dataSet.Count; i++)
                {
                    int j = 0;
                    average1 = 0;
                    average2 = 0;

                    for (j = numDays + i; j > i; j--)
                    {
                        if (j < dataSet.Count - 1)
                        {
                            average1 += dataSet[j].close;
                            average2 += dataSet[j + 1].close;
                        }
                    }
                    average1 = average1 / numDays;
                    average2 = average2 / numDays;
                    g.DrawLine(pen6, i, (float)average1, i + 1f, (float)average2);
                }
            }

        }
        public void drawClose(Graphics g)
        {
            for (int i = 0; i < dataSet.Count - 1; i++)
            {
                g.DrawLine(pen, i, (float)dataSet[i].close, i + 1f, (float)dataSet[i+1].close);
                
            }
        }

        public void drawOpen(Graphics g)
        {
            for (int i = 0; i < dataSet.Count - 1; i++)
            {
                g.DrawLine(pen2, i, (float)dataSet[i].open, i+ 1f, (float)dataSet[i + 1].open);

            }
        }

        public void drawHi(Graphics g)
        {
            for (int i = 0; i < dataSet.Count - 1; i++)
            {
                g.DrawLine(pen3, i, (float)dataSet[i].hi, i + 1f, (float)dataSet[i + 1].hi);

            }
        }

        public void drawLow(Graphics g)
        {
            for (int i = 0; i < dataSet.Count - 1; i++)
            {
                g.DrawLine(pen4, i, (float)dataSet[i].lo, i+1f, (float)dataSet[i + 1].lo);

            }
        }

        public void drawCandles(Graphics g)
        {
            for (int i = 0; i < dataSet.Count; i++)
            {
                dataSet[i].drawCandle(g, i);
            }
        }

        public void drawBars(Graphics g)
        {
            for (int i = 0; i < dataSet.Count; i++)
            {
                dataSet[i].drawbars(g, i);
            }
        }
        public void drawHiLowOpenClose(Graphics g)
        {
            drawClose(g);
            drawOpen(g);
            drawHi(g);
            drawLow(g);
            
        }


        public void readFromFile(string fileName)
        {
            string line;

            // Read the file and display it line by line.
            StreamReader file = new StreamReader(fileName);
            file.ReadLine(); 
            line = file.ReadLine();
            while (line != null)
            {
                // put what you are going do with each line
                FinDailyData fdd = new FinDailyData();
                fdd.getFromString(line);
                line = file.ReadLine();
                dataSet.Add(fdd);
            }
            dataSet.Reverse();
            file.Close();
        }

    }
}
