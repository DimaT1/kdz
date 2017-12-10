namespace KDZ1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitButton = new System.Windows.Forms.Button();
            this.paramaUpDown = new System.Windows.Forms.NumericUpDown();
            this.aLabel = new System.Windows.Forms.Label();
            this.dxBox = new System.Windows.Forms.GroupBox();
            this.dxLabel1 = new System.Windows.Forms.Label();
            this.dxLabel3 = new System.Windows.Forms.Label();
            this.dxLabel2 = new System.Windows.Forms.Label();
            this.dxTrackBar2 = new System.Windows.Forms.TrackBar();
            this.dxTrackBar1 = new System.Windows.Forms.TrackBar();
            this.paramaBox = new System.Windows.Forms.GroupBox();
            this.defaultSetButton = new System.Windows.Forms.Button();
            this.colorBox = new System.Windows.Forms.GroupBox();
            this.colorButton3 = new System.Windows.Forms.Button();
            this.colorButton2 = new System.Windows.Forms.Button();
            this.colorButton1 = new System.Windows.Forms.Button();
            this.highlightButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paramaUpDown)).BeginInit();
            this.dxBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxTrackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxTrackBar1)).BeginInit();
            this.paramaBox.SuspendLayout();
            this.colorBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisX.Title = "X";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisY.Title = "Y";
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 25);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.EmptyPointStyle.Name = "Функция";
            series1.Legend = "Legend1";
            series1.LegendText = "Функция";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.LegendText = "Производная";
            series2.Name = "Series2";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(640, 420);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(658, 27);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(114, 31);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // paramaUpDown
            // 
            this.paramaUpDown.Location = new System.Drawing.Point(57, 27);
            this.paramaUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.paramaUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.paramaUpDown.Name = "paramaUpDown";
            this.paramaUpDown.Size = new System.Drawing.Size(50, 20);
            this.paramaUpDown.TabIndex = 3;
            this.paramaUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.paramaUpDown.ValueChanged += new System.EventHandler(this.paramaUpDown_ValueChanged);
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(38, 29);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(13, 13);
            this.aLabel.TabIndex = 4;
            this.aLabel.Text = "a";
            // 
            // dxBox
            // 
            this.dxBox.Controls.Add(this.dxLabel1);
            this.dxBox.Controls.Add(this.dxLabel3);
            this.dxBox.Controls.Add(this.dxLabel2);
            this.dxBox.Controls.Add(this.dxTrackBar2);
            this.dxBox.Controls.Add(this.dxTrackBar1);
            this.dxBox.Location = new System.Drawing.Point(12, 449);
            this.dxBox.Name = "dxBox";
            this.dxBox.Size = new System.Drawing.Size(238, 110);
            this.dxBox.TabIndex = 5;
            this.dxBox.TabStop = false;
            this.dxBox.Text = "Настройка Δx";
            // 
            // dxLabel1
            // 
            this.dxLabel1.AutoSize = true;
            this.dxLabel1.Location = new System.Drawing.Point(18, 51);
            this.dxLabel1.Name = "dxLabel1";
            this.dxLabel1.Size = new System.Drawing.Size(35, 13);
            this.dxLabel1.TabIndex = 4;
            this.dxLabel1.Text = "label4";
            // 
            // dxLabel3
            // 
            this.dxLabel3.AutoSize = true;
            this.dxLabel3.Location = new System.Drawing.Point(187, 70);
            this.dxLabel3.Name = "dxLabel3";
            this.dxLabel3.Size = new System.Drawing.Size(35, 13);
            this.dxLabel3.TabIndex = 3;
            this.dxLabel3.Text = "label3";
            // 
            // dxLabel2
            // 
            this.dxLabel2.AutoSize = true;
            this.dxLabel2.Location = new System.Drawing.Point(187, 34);
            this.dxLabel2.Name = "dxLabel2";
            this.dxLabel2.Size = new System.Drawing.Size(35, 13);
            this.dxLabel2.TabIndex = 2;
            this.dxLabel2.Text = "label2";
            // 
            // dxTrackBar2
            // 
            this.dxTrackBar2.Location = new System.Drawing.Point(77, 59);
            this.dxTrackBar2.Minimum = 1;
            this.dxTrackBar2.Name = "dxTrackBar2";
            this.dxTrackBar2.Size = new System.Drawing.Size(104, 45);
            this.dxTrackBar2.TabIndex = 1;
            this.dxTrackBar2.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.dxTrackBar2.Value = 1;
            this.dxTrackBar2.Scroll += new System.EventHandler(this.dxTrackBar2_Scroll);
            // 
            // dxTrackBar1
            // 
            this.dxTrackBar1.Location = new System.Drawing.Point(77, 19);
            this.dxTrackBar1.Maximum = 9;
            this.dxTrackBar1.Name = "dxTrackBar1";
            this.dxTrackBar1.Size = new System.Drawing.Size(104, 45);
            this.dxTrackBar1.TabIndex = 0;
            this.dxTrackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.dxTrackBar1.Scroll += new System.EventHandler(this.dxTrackBar1_Scroll);
            // 
            // paramaBox
            // 
            this.paramaBox.Controls.Add(this.paramaUpDown);
            this.paramaBox.Controls.Add(this.aLabel);
            this.paramaBox.Location = new System.Drawing.Point(256, 449);
            this.paramaBox.Name = "paramaBox";
            this.paramaBox.Size = new System.Drawing.Size(143, 64);
            this.paramaBox.TabIndex = 6;
            this.paramaBox.TabStop = false;
            this.paramaBox.Text = "Настройка параметра a";
            // 
            // defaultSetButton
            // 
            this.defaultSetButton.Location = new System.Drawing.Point(256, 519);
            this.defaultSetButton.Name = "defaultSetButton";
            this.defaultSetButton.Size = new System.Drawing.Size(143, 40);
            this.defaultSetButton.TabIndex = 7;
            this.defaultSetButton.Text = "По умолчанию";
            this.defaultSetButton.UseVisualStyleBackColor = true;
            this.defaultSetButton.Click += new System.EventHandler(this.defaultSetButton_Click);
            // 
            // colorBox
            // 
            this.colorBox.Controls.Add(this.colorButton3);
            this.colorBox.Controls.Add(this.colorButton2);
            this.colorBox.Controls.Add(this.colorButton1);
            this.colorBox.Location = new System.Drawing.Point(405, 449);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(247, 65);
            this.colorBox.TabIndex = 8;
            this.colorBox.TabStop = false;
            this.colorBox.Text = "Настройка цветов";
            // 
            // colorButton3
            // 
            this.colorButton3.Location = new System.Drawing.Point(166, 24);
            this.colorButton3.Name = "colorButton3";
            this.colorButton3.Size = new System.Drawing.Size(75, 23);
            this.colorButton3.TabIndex = 2;
            this.colorButton3.Text = "Цвет 3";
            this.colorButton3.UseVisualStyleBackColor = true;
            this.colorButton3.Click += new System.EventHandler(this.colorButton3_Click);
            // 
            // colorButton2
            // 
            this.colorButton2.Location = new System.Drawing.Point(87, 24);
            this.colorButton2.Name = "colorButton2";
            this.colorButton2.Size = new System.Drawing.Size(75, 23);
            this.colorButton2.TabIndex = 1;
            this.colorButton2.Text = "Цвет 2";
            this.colorButton2.UseVisualStyleBackColor = true;
            this.colorButton2.Click += new System.EventHandler(this.colorButton2_Click);
            // 
            // colorButton1
            // 
            this.colorButton1.Location = new System.Drawing.Point(6, 24);
            this.colorButton1.Name = "colorButton1";
            this.colorButton1.Size = new System.Drawing.Size(75, 23);
            this.colorButton1.TabIndex = 0;
            this.colorButton1.Text = "Цвет 1";
            this.colorButton1.UseVisualStyleBackColor = true;
            this.colorButton1.Click += new System.EventHandler(this.colorButton1_Click);
            // 
            // highlightButton
            // 
            this.highlightButton.Location = new System.Drawing.Point(405, 520);
            this.highlightButton.Name = "highlightButton";
            this.highlightButton.Size = new System.Drawing.Size(247, 39);
            this.highlightButton.TabIndex = 9;
            this.highlightButton.Text = "Выделить промежутки";
            this.highlightButton.UseVisualStyleBackColor = true;
            this.highlightButton.Click += new System.EventHandler(this.highlightButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.highlightButton);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.defaultSetButton);
            this.Controls.Add(this.paramaBox);
            this.Controls.Add(this.dxBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "График функции";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paramaUpDown)).EndInit();
            this.dxBox.ResumeLayout(false);
            this.dxBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxTrackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxTrackBar1)).EndInit();
            this.paramaBox.ResumeLayout(false);
            this.paramaBox.PerformLayout();
            this.colorBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.NumericUpDown paramaUpDown;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.GroupBox dxBox;
        private System.Windows.Forms.TrackBar dxTrackBar2;
        private System.Windows.Forms.TrackBar dxTrackBar1;
        private System.Windows.Forms.Label dxLabel1;
        private System.Windows.Forms.Label dxLabel3;
        private System.Windows.Forms.Label dxLabel2;
        private System.Windows.Forms.GroupBox paramaBox;
        private System.Windows.Forms.Button defaultSetButton;
        private System.Windows.Forms.GroupBox colorBox;
        private System.Windows.Forms.Button colorButton3;
        private System.Windows.Forms.Button colorButton2;
        private System.Windows.Forms.Button colorButton1;
        private System.Windows.Forms.Button highlightButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

