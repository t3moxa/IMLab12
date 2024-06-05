namespace IMLab12
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            label1 = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            button2 = new Button();
            NBox = new TextBox();
            StatisticsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(462, 465);
            button1.Name = "button1";
            button1.Size = new Size(159, 23);
            button1.TabIndex = 0;
            button1.Text = "Начать моделирование";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(690, 473);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 1;
            label1.Text = "Последнее состояние";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(159, 38);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Частота состояний";
            chart1.Series.Add(series1);
            chart1.Size = new Size(839, 398);
            chart1.TabIndex = 2;
            chart1.Text = "chart1";
            // 
            // button2
            // 
            button2.Location = new Point(104, 457);
            button2.Name = "button2";
            button2.Size = new Size(152, 39);
            button2.TabIndex = 3;
            button2.Text = "Собрать статистику для N переходов";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // NBox
            // 
            NBox.Location = new Point(278, 465);
            NBox.Name = "NBox";
            NBox.PlaceholderText = "N";
            NBox.Size = new Size(100, 23);
            NBox.TabIndex = 4;
            // 
            // StatisticsLabel
            // 
            StatisticsLabel.AutoSize = true;
            StatisticsLabel.Location = new Point(159, 521);
            StatisticsLabel.Name = "StatisticsLabel";
            StatisticsLabel.Size = new Size(12, 15);
            StatisticsLabel.TabIndex = 5;
            StatisticsLabel.Text = "-";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 624);
            Controls.Add(StatisticsLabel);
            Controls.Add(NBox);
            Controls.Add(button2);
            Controls.Add(chart1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "IMLab12";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button button2;
        private TextBox NBox;
        private Label StatisticsLabel;
    }
}
