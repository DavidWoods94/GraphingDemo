using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphing_Demo
{
    public partial class GraphControlForm : Form
    {
        public bool showGrid
        {
            get { return checkBoxGridLines.Checked; }
        }
        public bool showAxes
        {
            get { return checkBoxDrawAxes.Checked; }
        }
        public bool aspectRatio
        {
            get { return checkBoxKeepAspectRatio.Checked; }
        }

        public float minX
        {
            get { return Convert.ToSingle(textBoxMinX.Text); }
        }
        public float maxX
        {
            get { return Convert.ToSingle(textBoxMaxX.Text); }
        }
        public float minY
        {
            get { return (float)Convert.ToDouble(textBoxMinY.Text); }
        }
        public float maxY
        {
            get { return (float)Convert.ToDouble(textBoxMaxY.Text); }
        }

        public float graphPenWidth
        {
            get { return (float).3f; }
        }
        public float movingAverage2
        {
            get { return (float)Convert.ToDouble(MovingAverage2.Text); }
        }
        public bool closed
        {
            get { return Close.Checked;}
        }
        public bool candles
        {
            get { return RCandles.Checked; }
        }
        public bool hiLowOpenClose
        {
            get { return HiLow.Checked; }
        }
        public bool barChart
        {
            get { return BarChart.Checked; }
        }
        public float maDays;

        public RectangleF worldRectF
        {
            
            get 
            {
                return new RectangleF(minX,minY,maxX-minX,maxY-minY); 
            }
        }




        public GraphForm graphForm
        {
            set { _graphForm = value; }
            get { return _graphForm; }
        }

        GraphForm _graphForm;

        public GraphControlForm()
        {
            InitializeComponent();
        }

        public bool alreadyClosing = false;

        private void GraphControlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            alreadyClosing = true;
            if (!graphForm.alreadyClosing)
            {
                graphForm.Close();
            }
        }

        private void invalidaateGraphForm(object sender, EventArgs e)
        {
            graphForm.Invalidate();
        }

        private void buttonGetFile_Click(object sender, EventArgs e)
        {
            FileDialog fd = new OpenFileDialog();
            fd.DefaultExt = "csv";
            fd.Filter = "(*.csv)|*.csv|All files (*.*)|*.*";
            DialogResult dr = fd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                graphForm.finDataSet.readFromFile(fd.FileName);
            }
            graphForm.Invalidate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FileDialog fd = new OpenFileDialog();
            fd.DefaultExt = "csv";
            fd.Filter = "(*.csv)|*.csv|All files (*.*)|*.*";
            DialogResult dr = fd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                graphForm.finDataSet.readFromFile(fd.FileName);
            }
            graphForm.Invalidate();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            graphForm.Invalidate();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void minXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graphForm.Invalidate();
        }

        private void Close_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RCandles_CheckedChanged(object sender, EventArgs e)
        {
            graphForm.Invalidate();
        }

        private void HiLow_CheckedChanged(object sender, EventArgs e)
        {
            graphForm.Invalidate();
        }

        private void HiLow_Click(object sender, EventArgs e)
        {
            graphForm.Invalidate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            maDays = 10;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            maDays = 20;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            maDays = 30;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            maDays = 40;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            maDays = 50;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            maDays = 100;
        }

        private void BarChart_CheckedChanged(object sender, EventArgs e)
        {
            graphForm.Invalidate();
        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maDays = 0;
        }

        private void labelMinY_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



    }
}
