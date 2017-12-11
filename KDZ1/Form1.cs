using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace KDZ1
{
    public partial class Form1 : Form
    {
        MyFunction f;
        Plot plot;

        private static double TrackBarValuesToDouble(decimal a, decimal b)
        {
            return 0.1 * (double)a + 0.01 * (double)b;
        }

        private static void ResetTrackBarLabels(decimal track1, decimal track2,
                                                Label label1, Label label2, Label label3)
        {
            label2.Text = $"{track1} * 0.1";
            label3.Text = $"{track2} * 0.01";
            label1.Text = $"Δx = {TrackBarValuesToDouble(track1, track2)}";
        }

        private static void SaveToFile(SaveFileDialog saveFileDialog1, Chart chart)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                string filename = saveFileDialog1.FileName;
                chart.SaveImage(filename, System.Drawing.Imaging.ImageFormat.Gif);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            colorDialog1.FullOpen = true;
            f = new MyFunction(1, 0.01);
            plot = new Plot();
            ResetTrackBarLabels(dxTrackBar1.Value, dxTrackBar2.Value, dxLabel1, dxLabel2, dxLabel3);
            f.DeltaX = TrackBarValuesToDouble(dxTrackBar1.Value, dxTrackBar2.Value);
            plot.Clear(chart);
            saveFileDialog1.Filter = "Image Files(*.gif)|*.gif|All files(*.*)|*.*"; 
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void paramaUpDown_ValueChanged(object sender, EventArgs e)
        {
            f.A = (int)paramaUpDown.Value;
            plot.Print(chart, f);
        }

        private void dxTrackBar1_Scroll(object sender, EventArgs e)
        {
            ResetTrackBarLabels(dxTrackBar1.Value, dxTrackBar2.Value, dxLabel1, dxLabel2, dxLabel3);
            f.DeltaX = TrackBarValuesToDouble(dxTrackBar1.Value, dxTrackBar2.Value);
            plot.Print(chart, f);
        }

        private void dxTrackBar2_Scroll(object sender, EventArgs e)
        {
            ResetTrackBarLabels(dxTrackBar1.Value, dxTrackBar2.Value, dxLabel1, dxLabel2, dxLabel3);
            f.DeltaX = TrackBarValuesToDouble(dxTrackBar1.Value, dxTrackBar2.Value);
            plot.Print(chart, f);
        }

        private void colorButton1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
                plot.Color1 = colorDialog1.Color;
            plot.Print(chart, f);
        }

        private void colorButton2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
                plot.Color2 = colorDialog1.Color;
            plot.Print(chart, f);
        }

        private void colorButton3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
                plot.Color3 = colorDialog1.Color;
            plot.Print(chart, f);
        }

        private void highlightButton_Click(object sender, EventArgs e)
        {
            plot.Print(chart, f, highlight: true);
        }

        private void defaultSetButton_Click(object sender, EventArgs e)
        {
            f = new MyFunction(1, 0.01);
            plot = new Plot();
            paramaUpDown.Value = 1;
            dxTrackBar1.Value = dxTrackBar1.Minimum;
            dxTrackBar2.Value = dxTrackBar2.Minimum;
            ResetTrackBarLabels(dxTrackBar1.Value, dxTrackBar2.Value, dxLabel1, dxLabel2, dxLabel3);
            f.DeltaX = TrackBarValuesToDouble(dxTrackBar1.Value, dxTrackBar2.Value);
            plot.Clear(chart);
        }

        private void нарисоватьГрафикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            plot.Print(chart, f);
        }

        private void выделитьПромежуткиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            plot.Print(chart, f, highlight: true);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            plot.Print(chart, f);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            plot.Print(chart, f, highlight: true);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            SaveToFile(saveFileDialog1, chart);
        }

        private void экспортВGifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveToFile(saveFileDialog1, chart);
        }
    }
}
