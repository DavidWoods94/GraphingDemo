using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphing_Demo
{
    public class FinDailyData
    {
        public double hi { get; set; }
        public double lo { get; set; }
        public double open { get; set; }
        public double close { get; set; }
        public DateTime date { get; set; }
        public PointF hiPoint;
        public PointF loPoint;
        public PointF openPoint;
        public PointF closePoint;
        



        public void drawCandle(Graphics g,float dayIndex)
        {
            Pen pen = new Pen(Color.Black,0.2f);
            g.DrawLine(pen, dayIndex, (float)hi, dayIndex, (float)lo);
            if (open < close)
            {
                g.FillRectangle(Brushes.Blue, dayIndex - 0.3f, (float)open, 0.6f, (float)(close - open));
            }
            else
            {
                g.FillRectangle(Brushes.Black, dayIndex - 0.3f, (float)close, 0.6f, (float)(open - close));
            }
        }

        public void drawbars(Graphics g, float dayIndex)
        {
            Pen pen = new Pen(Color.Black, 0.2f);
            Pen openPen = new Pen(Color.Blue, 0.2f);
            Pen closePen = new Pen(Color.Red, 0.2f);
            g.DrawLine(pen, dayIndex, (float)hi, dayIndex, (float)lo);
            g.DrawLine(openPen, dayIndex, (float)open, dayIndex - 0.5f, (float)open);
            g.DrawLine(closePen, dayIndex, (float)close, dayIndex + 0.5f, (float) close);
        }
        //public void drawOpen(Graphics g, float dayIndex)
        //{
        //    g.FillEllipse(Brushes.Blue, dayIndex - 0.3f, (float)open, .5f, .5f);
        //}
        //public void drawHi(Graphics g, float dayIndex)
        //{
        //    g.FillEllipse(Brushes.Green, dayIndex - 0.3f, (float)hi, .5f, .5f);
        //}
        //public void drawLow(Graphics g, float dayIndex)
        //{
        //    g.FillEllipse(Brushes.Red, dayIndex - 0.3f, (float)lo, .5f, .5f);
        //}

        internal void getFromString(string line)
        {
            String[] x = line.Split(',');
            date = Convert.ToDateTime(x[0]);
            open = Convert.ToDouble(x[1]);
            hi = Convert.ToDouble(x[2]);
            lo = Convert.ToDouble(x[3]);
            close = Convert.ToDouble(x[4]);
        }
    }
}
