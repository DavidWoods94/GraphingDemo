namespace Graphing_Demo
{
    partial class GraphControlForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphControlForm));
            this.labelMinX = new System.Windows.Forms.Label();
            this.textBoxMinX = new System.Windows.Forms.TextBox();
            this.textBoxMaxX = new System.Windows.Forms.TextBox();
            this.labelMaxX = new System.Windows.Forms.Label();
            this.textBoxMaxY = new System.Windows.Forms.TextBox();
            this.labelMaxY = new System.Windows.Forms.Label();
            this.textBoxMinY = new System.Windows.Forms.TextBox();
            this.labelMinY = new System.Windows.Forms.Label();
            this.checkBoxGridLines = new System.Windows.Forms.CheckBox();
            this.checkBoxDrawAxes = new System.Windows.Forms.CheckBox();
            this.checkBoxKeepAspectRatio = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.movingAverage1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.MovingAverage2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Close = new System.Windows.Forms.RadioButton();
            this.RCandles = new System.Windows.Forms.RadioButton();
            this.HiLow = new System.Windows.Forms.RadioButton();
            this.BarChart = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMinX
            // 
            this.labelMinX.AutoSize = true;
            this.labelMinX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinX.Location = new System.Drawing.Point(11, 49);
            this.labelMinX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinX.Name = "labelMinX";
            this.labelMinX.Size = new System.Drawing.Size(76, 20);
            this.labelMinX.TabIndex = 1;
            this.labelMinX.Text = "Start Day";
            // 
            // textBoxMinX
            // 
            this.textBoxMinX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMinX.Location = new System.Drawing.Point(91, 46);
            this.textBoxMinX.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMinX.Name = "textBoxMinX";
            this.textBoxMinX.Size = new System.Drawing.Size(76, 26);
            this.textBoxMinX.TabIndex = 2;
            this.textBoxMinX.Text = "60";
            this.textBoxMinX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMaxX
            // 
            this.textBoxMaxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaxX.Location = new System.Drawing.Point(254, 46);
            this.textBoxMaxX.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMaxX.Name = "textBoxMaxX";
            this.textBoxMaxX.Size = new System.Drawing.Size(76, 26);
            this.textBoxMaxX.TabIndex = 4;
            this.textBoxMaxX.Text = "120";
            this.textBoxMaxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelMaxX
            // 
            this.labelMaxX.AutoSize = true;
            this.labelMaxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxX.Location = new System.Drawing.Point(178, 49);
            this.labelMaxX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaxX.Name = "labelMaxX";
            this.labelMaxX.Size = new System.Drawing.Size(72, 20);
            this.labelMaxX.TabIndex = 3;
            this.labelMaxX.Text = "Last Day";
            // 
            // textBoxMaxY
            // 
            this.textBoxMaxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaxY.Location = new System.Drawing.Point(254, 89);
            this.textBoxMaxY.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMaxY.Name = "textBoxMaxY";
            this.textBoxMaxY.Size = new System.Drawing.Size(76, 26);
            this.textBoxMaxY.TabIndex = 6;
            this.textBoxMaxY.Text = "370";
            this.textBoxMaxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelMaxY
            // 
            this.labelMaxY.AutoSize = true;
            this.labelMaxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxY.Location = new System.Drawing.Point(171, 92);
            this.labelMaxY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaxY.Name = "labelMaxY";
            this.labelMaxY.Size = new System.Drawing.Size(77, 20);
            this.labelMaxY.TabIndex = 5;
            this.labelMaxY.Text = "Max Price";
            // 
            // textBoxMinY
            // 
            this.textBoxMinY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMinY.Location = new System.Drawing.Point(91, 89);
            this.textBoxMinY.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMinY.Name = "textBoxMinY";
            this.textBoxMinY.Size = new System.Drawing.Size(76, 26);
            this.textBoxMinY.TabIndex = 8;
            this.textBoxMinY.Text = "310";
            this.textBoxMinY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelMinY
            // 
            this.labelMinY.AutoSize = true;
            this.labelMinY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinY.Location = new System.Drawing.Point(14, 92);
            this.labelMinY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinY.Name = "labelMinY";
            this.labelMinY.Size = new System.Drawing.Size(73, 20);
            this.labelMinY.TabIndex = 7;
            this.labelMinY.Text = "Min Price";
            this.labelMinY.Click += new System.EventHandler(this.labelMinY_Click);
            // 
            // checkBoxGridLines
            // 
            this.checkBoxGridLines.AutoSize = true;
            this.checkBoxGridLines.Checked = true;
            this.checkBoxGridLines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGridLines.Location = new System.Drawing.Point(215, 187);
            this.checkBoxGridLines.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxGridLines.Name = "checkBoxGridLines";
            this.checkBoxGridLines.Size = new System.Drawing.Size(73, 17);
            this.checkBoxGridLines.TabIndex = 9;
            this.checkBoxGridLines.Text = "Grid Lines";
            this.checkBoxGridLines.UseVisualStyleBackColor = true;
            this.checkBoxGridLines.CheckedChanged += new System.EventHandler(this.invalidaateGraphForm);
            // 
            // checkBoxDrawAxes
            // 
            this.checkBoxDrawAxes.AutoSize = true;
            this.checkBoxDrawAxes.Checked = true;
            this.checkBoxDrawAxes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDrawAxes.Location = new System.Drawing.Point(215, 206);
            this.checkBoxDrawAxes.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxDrawAxes.Name = "checkBoxDrawAxes";
            this.checkBoxDrawAxes.Size = new System.Drawing.Size(49, 17);
            this.checkBoxDrawAxes.TabIndex = 10;
            this.checkBoxDrawAxes.Text = "Axes";
            this.checkBoxDrawAxes.UseVisualStyleBackColor = true;
            this.checkBoxDrawAxes.CheckedChanged += new System.EventHandler(this.invalidaateGraphForm);
            // 
            // checkBoxKeepAspectRatio
            // 
            this.checkBoxKeepAspectRatio.AutoSize = true;
            this.checkBoxKeepAspectRatio.Location = new System.Drawing.Point(215, 223);
            this.checkBoxKeepAspectRatio.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxKeepAspectRatio.Name = "checkBoxKeepAspectRatio";
            this.checkBoxKeepAspectRatio.Size = new System.Drawing.Size(87, 17);
            this.checkBoxKeepAspectRatio.TabIndex = 11;
            this.checkBoxKeepAspectRatio.Text = "Aspect Ratio";
            this.checkBoxKeepAspectRatio.UseVisualStyleBackColor = true;
            this.checkBoxKeepAspectRatio.CheckedChanged += new System.EventHandler(this.invalidaateGraphForm);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.movingAverage1,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.MovingAverage2,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(448, 25);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // movingAverage1
            // 
            this.movingAverage1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.movingAverage1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.noneToolStripMenuItem});
            this.movingAverage1.Image = ((System.Drawing.Image)(resources.GetObject("movingAverage1.Image")));
            this.movingAverage1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.movingAverage1.Name = "movingAverage1";
            this.movingAverage1.Size = new System.Drawing.Size(107, 22);
            this.movingAverage1.Text = "Moving Average";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem2.Text = "10";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem3.Text = "20";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem4.Text = "30";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem5.Text = "40";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem6.Text = "50";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem7.Text = "100";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.noneToolStripMenuItem.Text = "None";
            this.noneToolStripMenuItem.Click += new System.EventHandler(this.noneToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel1.Text = "Moving Average2";
            // 
            // MovingAverage2
            // 
            this.MovingAverage2.Name = "MovingAverage2";
            this.MovingAverage2.Size = new System.Drawing.Size(100, 25);
            this.MovingAverage2.Text = "0";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.Checked = true;
            this.Close.Location = new System.Drawing.Point(15, 151);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(51, 17);
            this.Close.TabIndex = 18;
            this.Close.TabStop = true;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.CheckedChanged += new System.EventHandler(this.Close_CheckedChanged);
            // 
            // RCandles
            // 
            this.RCandles.AutoSize = true;
            this.RCandles.Location = new System.Drawing.Point(15, 175);
            this.RCandles.Name = "RCandles";
            this.RCandles.Size = new System.Drawing.Size(63, 17);
            this.RCandles.TabIndex = 19;
            this.RCandles.Text = "Candles";
            this.RCandles.UseVisualStyleBackColor = true;
            this.RCandles.CheckedChanged += new System.EventHandler(this.RCandles_CheckedChanged);
            // 
            // HiLow
            // 
            this.HiLow.AutoSize = true;
            this.HiLow.Location = new System.Drawing.Point(15, 199);
            this.HiLow.Name = "HiLow";
            this.HiLow.Size = new System.Drawing.Size(122, 17);
            this.HiLow.TabIndex = 20;
            this.HiLow.TabStop = true;
            this.HiLow.Text = "Hi/Low/Open/Close";
            this.HiLow.UseVisualStyleBackColor = true;
            this.HiLow.CheckedChanged += new System.EventHandler(this.HiLow_CheckedChanged);
            this.HiLow.Click += new System.EventHandler(this.HiLow_Click);
            // 
            // BarChart
            // 
            this.BarChart.AutoSize = true;
            this.BarChart.Location = new System.Drawing.Point(15, 223);
            this.BarChart.Name = "BarChart";
            this.BarChart.Size = new System.Drawing.Size(66, 17);
            this.BarChart.TabIndex = 21;
            this.BarChart.TabStop = true;
            this.BarChart.Text = "BarChart";
            this.BarChart.UseVisualStyleBackColor = true;
            this.BarChart.CheckedChanged += new System.EventHandler(this.BarChart_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Key:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(362, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "High";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(362, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Low";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(362, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Open";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Close";
            // 
            // GraphControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 260);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BarChart);
            this.Controls.Add(this.HiLow);
            this.Controls.Add(this.RCandles);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.checkBoxKeepAspectRatio);
            this.Controls.Add(this.checkBoxDrawAxes);
            this.Controls.Add(this.checkBoxGridLines);
            this.Controls.Add(this.textBoxMinY);
            this.Controls.Add(this.labelMinY);
            this.Controls.Add(this.textBoxMaxY);
            this.Controls.Add(this.labelMaxY);
            this.Controls.Add(this.textBoxMaxX);
            this.Controls.Add(this.labelMaxX);
            this.Controls.Add(this.textBoxMinX);
            this.Controls.Add(this.labelMinX);
            this.Location = new System.Drawing.Point(750, 0);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GraphControlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GraphControlForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GraphControlForm_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMinX;
        private System.Windows.Forms.TextBox textBoxMinX;
        private System.Windows.Forms.TextBox textBoxMaxX;
        private System.Windows.Forms.Label labelMaxX;
        private System.Windows.Forms.TextBox textBoxMaxY;
        private System.Windows.Forms.Label labelMaxY;
        private System.Windows.Forms.TextBox textBoxMinY;
        private System.Windows.Forms.Label labelMinY;
        private System.Windows.Forms.CheckBox checkBoxGridLines;
        private System.Windows.Forms.CheckBox checkBoxDrawAxes;
        private System.Windows.Forms.CheckBox checkBoxKeepAspectRatio;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.RadioButton Close;
        private System.Windows.Forms.RadioButton RCandles;
        private System.Windows.Forms.RadioButton HiLow;
        private System.Windows.Forms.ToolStripDropDownButton movingAverage1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.RadioButton BarChart;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox MovingAverage2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

    }
}