namespace SPM
{
    partial class statics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonLecture = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStudent = new System.Windows.Forms.Button();
            this.button1Room = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.topicLable = new System.Windows.Forms.Label();
            this.label2Pie = new System.Windows.Forms.Label();
            this.label3Bar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea9.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chart1.Legends.Add(legend9);
            this.chart1.Location = new System.Drawing.Point(40, 136);
            this.chart1.Name = "chart1";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series9.Legend = "Legend1";
            series9.Name = "Total";
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(325, 302);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // buttonLecture
            // 
            this.buttonLecture.BackColor = System.Drawing.Color.Lime;
            this.buttonLecture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLecture.Location = new System.Drawing.Point(40, 35);
            this.buttonLecture.Name = "buttonLecture";
            this.buttonLecture.Size = new System.Drawing.Size(125, 46);
            this.buttonLecture.TabIndex = 1;
            this.buttonLecture.Text = "LECTURE [RANK]";
            this.buttonLecture.UseVisualStyleBackColor = false;
            this.buttonLecture.Click += new System.EventHandler(this.buttonLecture_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "STATICS";
            // 
            // buttonStudent
            // 
            this.buttonStudent.BackColor = System.Drawing.Color.Aqua;
            this.buttonStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudent.Location = new System.Drawing.Point(354, 35);
            this.buttonStudent.Name = "buttonStudent";
            this.buttonStudent.Size = new System.Drawing.Size(155, 46);
            this.buttonStudent.TabIndex = 3;
            this.buttonStudent.Text = "SUBJECT [OFFERED YEAR]";
            this.buttonStudent.UseVisualStyleBackColor = false;
            this.buttonStudent.Click += new System.EventHandler(this.buttonStudent_Click);
            // 
            // button1Room
            // 
            this.button1Room.BackColor = System.Drawing.Color.Fuchsia;
            this.button1Room.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Room.Location = new System.Drawing.Point(640, 35);
            this.button1Room.Name = "button1Room";
            this.button1Room.Size = new System.Drawing.Size(125, 46);
            this.button1Room.TabIndex = 4;
            this.button1Room.Text = "ROOM [CAPACITY]";
            this.button1Room.UseVisualStyleBackColor = false;
            this.button1Room.Click += new System.EventHandler(this.button1Room_Click);
            // 
            // chart2
            // 
            chartArea10.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chart2.Legends.Add(legend10);
            this.chart2.Location = new System.Drawing.Point(465, 138);
            this.chart2.Name = "chart2";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Total";
            this.chart2.Series.Add(series10);
            this.chart2.Size = new System.Drawing.Size(300, 300);
            this.chart2.TabIndex = 5;
            this.chart2.Text = "chart2";
            // 
            // topicLable
            // 
            this.topicLable.AutoSize = true;
            this.topicLable.BackColor = System.Drawing.SystemColors.Control;
            this.topicLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topicLable.ForeColor = System.Drawing.Color.Red;
            this.topicLable.Location = new System.Drawing.Point(275, 107);
            this.topicLable.Name = "topicLable";
            this.topicLable.Size = new System.Drawing.Size(16, 16);
            this.topicLable.TabIndex = 6;
            this.topicLable.Text = "y";
            // 
            // label2Pie
            // 
            this.label2Pie.AutoSize = true;
            this.label2Pie.BackColor = System.Drawing.Color.White;
            this.label2Pie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2Pie.Location = new System.Drawing.Point(73, 441);
            this.label2Pie.Name = "label2Pie";
            this.label2Pie.Size = new System.Drawing.Size(11, 15);
            this.label2Pie.TabIndex = 7;
            this.label2Pie.Text = "l";
            // 
            // label3Bar
            // 
            this.label3Bar.AutoSize = true;
            this.label3Bar.BackColor = System.Drawing.Color.White;
            this.label3Bar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3Bar.Location = new System.Drawing.Point(471, 441);
            this.label3Bar.Name = "label3Bar";
            this.label3Bar.Size = new System.Drawing.Size(11, 15);
            this.label3Bar.TabIndex = 8;
            this.label3Bar.Text = "l";
            // 
            // statics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 501);
            this.Controls.Add(this.label3Bar);
            this.Controls.Add(this.label2Pie);
            this.Controls.Add(this.topicLable);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.button1Room);
            this.Controls.Add(this.buttonStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLecture);
            this.Controls.Add(this.chart1);
            this.Name = "statics";
            this.Text = "statics";
            this.Load += new System.EventHandler(this.statics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonLecture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStudent;
        private System.Windows.Forms.Button button1Room;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label topicLable;
        private System.Windows.Forms.Label label2Pie;
        private System.Windows.Forms.Label label3Bar;
    }
}