namespace RocketSim
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.EmpMasstxt = new System.Windows.Forms.TextBox();
            this.EmpMasslbl = new System.Windows.Forms.Label();
            this.FuelMasslbl = new System.Windows.Forms.Label();
            this.FuelMasstxt = new System.Windows.Forms.TextBox();
            this.EjectVellbl = new System.Windows.Forms.Label();
            this.EjectVeltxt = new System.Windows.Forms.TextBox();
            this.EjectMasslbl = new System.Windows.Forms.Label();
            this.EjectMasstxt = new System.Windows.Forms.TextBox();
            this.TickPerlbl = new System.Windows.Forms.Label();
            this.TickPertxt = new System.Windows.Forms.TextBox();
            this.SimTimelbl = new System.Windows.Forms.Label();
            this.SimTimetxt = new System.Windows.Forms.TextBox();
            this.BodyMasslbl = new System.Windows.Forms.Label();
            this.BodyMasstxt = new System.Windows.Forms.TextBox();
            this.BodyRadlbl = new System.Windows.Forms.Label();
            this.BodyRadtxt = new System.Windows.Forms.TextBox();
            this.SurTemplbl = new System.Windows.Forms.Label();
            this.SurTemptxt = new System.Windows.Forms.TextBox();
            this.SurDenslbl = new System.Windows.Forms.Label();
            this.SurDenstxt = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.Namelbl = new System.Windows.Forms.Label();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.StartVellbl = new System.Windows.Forms.Label();
            this.StartVeltxt = new System.Windows.Forms.TextBox();
            this.StartHeightlbl = new System.Windows.Forms.Label();
            this.StartHeighttxt = new System.Windows.Forms.TextBox();
            this.AtmosMolMasslbl = new System.Windows.Forms.Label();
            this.AtmosMolMasstxt = new System.Windows.Forms.TextBox();
            this.CrossSectlbl = new System.Windows.Forms.Label();
            this.CrossSecttxt = new System.Windows.Forms.TextBox();
            this.Draglbl = new System.Windows.Forms.Label();
            this.Dragtxt = new System.Windows.Forms.TextBox();
            this.SimGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.SimGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpMasstxt
            // 
            this.EmpMasstxt.Location = new System.Drawing.Point(12, 25);
            this.EmpMasstxt.Name = "EmpMasstxt";
            this.EmpMasstxt.Size = new System.Drawing.Size(100, 20);
            this.EmpMasstxt.TabIndex = 0;
            this.EmpMasstxt.Text = "90718.474";
            // 
            // EmpMasslbl
            // 
            this.EmpMasslbl.AutoSize = true;
            this.EmpMasslbl.Location = new System.Drawing.Point(9, 9);
            this.EmpMasslbl.Name = "EmpMasslbl";
            this.EmpMasslbl.Size = new System.Drawing.Size(78, 13);
            this.EmpMasslbl.TabIndex = 2;
            this.EmpMasslbl.Text = "Empty mass kg";
            // 
            // FuelMasslbl
            // 
            this.FuelMasslbl.AutoSize = true;
            this.FuelMasslbl.Location = new System.Drawing.Point(9, 48);
            this.FuelMasslbl.Name = "FuelMasslbl";
            this.FuelMasslbl.Size = new System.Drawing.Size(69, 13);
            this.FuelMasslbl.TabIndex = 4;
            this.FuelMasslbl.Text = "Fuel mass kg";
            // 
            // FuelMasstxt
            // 
            this.FuelMasstxt.Location = new System.Drawing.Point(12, 64);
            this.FuelMasstxt.Name = "FuelMasstxt";
            this.FuelMasstxt.Size = new System.Drawing.Size(100, 20);
            this.FuelMasstxt.TabIndex = 3;
            this.FuelMasstxt.Text = "498951.607";
            // 
            // EjectVellbl
            // 
            this.EjectVellbl.AutoSize = true;
            this.EjectVellbl.Location = new System.Drawing.Point(9, 86);
            this.EjectVellbl.Name = "EjectVellbl";
            this.EjectVellbl.Size = new System.Drawing.Size(105, 13);
            this.EjectVellbl.TabIndex = 6;
            this.EjectVellbl.Text = "Ejection velocity m/s";
            // 
            // EjectVeltxt
            // 
            this.EjectVeltxt.Location = new System.Drawing.Point(12, 102);
            this.EjectVeltxt.Name = "EjectVeltxt";
            this.EjectVeltxt.Size = new System.Drawing.Size(100, 20);
            this.EjectVeltxt.TabIndex = 5;
            this.EjectVeltxt.Text = "2571";
            // 
            // EjectMasslbl
            // 
            this.EjectMasslbl.AutoSize = true;
            this.EjectMasslbl.Location = new System.Drawing.Point(9, 128);
            this.EjectMasslbl.Name = "EjectMasslbl";
            this.EjectMasslbl.Size = new System.Drawing.Size(107, 13);
            this.EjectMasslbl.TabIndex = 8;
            this.EjectMasslbl.Text = "Ejection mass sec^-1";
            // 
            // EjectMasstxt
            // 
            this.EjectMasstxt.Location = new System.Drawing.Point(12, 144);
            this.EjectMasstxt.Name = "EjectMasstxt";
            this.EjectMasstxt.Size = new System.Drawing.Size(100, 20);
            this.EjectMasstxt.TabIndex = 7;
            this.EjectMasstxt.Text = "4989.5161";
            // 
            // TickPerlbl
            // 
            this.TickPerlbl.AutoSize = true;
            this.TickPerlbl.Location = new System.Drawing.Point(251, 8);
            this.TickPerlbl.Name = "TickPerlbl";
            this.TickPerlbl.Size = new System.Drawing.Size(76, 13);
            this.TickPerlbl.TabIndex = 10;
            this.TickPerlbl.Text = "Tick period ms";
            // 
            // TickPertxt
            // 
            this.TickPertxt.Location = new System.Drawing.Point(254, 24);
            this.TickPertxt.Name = "TickPertxt";
            this.TickPertxt.Size = new System.Drawing.Size(100, 20);
            this.TickPertxt.TabIndex = 9;
            this.TickPertxt.Text = "100";
            // 
            // SimTimelbl
            // 
            this.SimTimelbl.AutoSize = true;
            this.SimTimelbl.Location = new System.Drawing.Point(251, 48);
            this.SimTimelbl.Name = "SimTimelbl";
            this.SimTimelbl.Size = new System.Drawing.Size(93, 13);
            this.SimTimelbl.TabIndex = 12;
            this.SimTimelbl.Text = "Simulation time ms";
            // 
            // SimTimetxt
            // 
            this.SimTimetxt.Location = new System.Drawing.Point(254, 66);
            this.SimTimetxt.Name = "SimTimetxt";
            this.SimTimetxt.Size = new System.Drawing.Size(100, 20);
            this.SimTimetxt.TabIndex = 11;
            this.SimTimetxt.Text = "200000";
            // 
            // BodyMasslbl
            // 
            this.BodyMasslbl.AutoSize = true;
            this.BodyMasslbl.Location = new System.Drawing.Point(124, 9);
            this.BodyMasslbl.Name = "BodyMasslbl";
            this.BodyMasslbl.Size = new System.Drawing.Size(114, 13);
            this.BodyMasslbl.TabIndex = 14;
            this.BodyMasslbl.Text = "Celestial body mass kg";
            // 
            // BodyMasstxt
            // 
            this.BodyMasstxt.Location = new System.Drawing.Point(127, 25);
            this.BodyMasstxt.Name = "BodyMasstxt";
            this.BodyMasstxt.Size = new System.Drawing.Size(100, 20);
            this.BodyMasstxt.TabIndex = 13;
            this.BodyMasstxt.Text = "5.97e24";
            // 
            // BodyRadlbl
            // 
            this.BodyRadlbl.AutoSize = true;
            this.BodyRadlbl.Location = new System.Drawing.Point(124, 50);
            this.BodyRadlbl.Name = "BodyRadlbl";
            this.BodyRadlbl.Size = new System.Drawing.Size(114, 13);
            this.BodyRadlbl.TabIndex = 16;
            this.BodyRadlbl.Text = "Celestial body radius m";
            // 
            // BodyRadtxt
            // 
            this.BodyRadtxt.Location = new System.Drawing.Point(127, 66);
            this.BodyRadtxt.Name = "BodyRadtxt";
            this.BodyRadtxt.Size = new System.Drawing.Size(100, 20);
            this.BodyRadtxt.TabIndex = 15;
            this.BodyRadtxt.Text = "6.37e6";
            // 
            // SurTemplbl
            // 
            this.SurTemplbl.AutoSize = true;
            this.SurTemplbl.Location = new System.Drawing.Point(124, 89);
            this.SurTemplbl.Name = "SurTemplbl";
            this.SurTemplbl.Size = new System.Drawing.Size(113, 13);
            this.SurTemplbl.TabIndex = 18;
            this.SurTemplbl.Text = "Surface temperature K";
            // 
            // SurTemptxt
            // 
            this.SurTemptxt.Location = new System.Drawing.Point(127, 105);
            this.SurTemptxt.Name = "SurTemptxt";
            this.SurTemptxt.Size = new System.Drawing.Size(100, 20);
            this.SurTemptxt.TabIndex = 17;
            this.SurTemptxt.Text = "288";
            // 
            // SurDenslbl
            // 
            this.SurDenslbl.AutoSize = true;
            this.SurDenslbl.Location = new System.Drawing.Point(124, 126);
            this.SurDenslbl.Name = "SurDenslbl";
            this.SurDenslbl.Size = new System.Drawing.Size(139, 13);
            this.SurDenslbl.TabIndex = 22;
            this.SurDenslbl.Text = "Atmosphere density kg/m^3";
            // 
            // SurDenstxt
            // 
            this.SurDenstxt.Location = new System.Drawing.Point(127, 144);
            this.SurDenstxt.Name = "SurDenstxt";
            this.SurDenstxt.Size = new System.Drawing.Size(100, 20);
            this.SurDenstxt.TabIndex = 21;
            this.SurDenstxt.Text = "1.225";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(12, 345);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(139, 23);
            this.Start.TabIndex = 23;
            this.Start.Text = "Start simulation";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Location = new System.Drawing.Point(9, 301);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(35, 13);
            this.Namelbl.TabIndex = 25;
            this.Namelbl.Text = "Name";
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(12, 319);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(100, 20);
            this.Nametxt.TabIndex = 24;
            // 
            // StartVellbl
            // 
            this.StartVellbl.AutoSize = true;
            this.StartVellbl.Location = new System.Drawing.Point(377, 6);
            this.StartVellbl.Name = "StartVellbl";
            this.StartVellbl.Size = new System.Drawing.Size(89, 13);
            this.StartVellbl.TabIndex = 27;
            this.StartVellbl.Text = "Start velocity m/s";
            // 
            // StartVeltxt
            // 
            this.StartVeltxt.Location = new System.Drawing.Point(380, 24);
            this.StartVeltxt.Name = "StartVeltxt";
            this.StartVeltxt.Size = new System.Drawing.Size(100, 20);
            this.StartVeltxt.TabIndex = 26;
            this.StartVeltxt.Text = "0";
            // 
            // StartHeightlbl
            // 
            this.StartHeightlbl.AutoSize = true;
            this.StartHeightlbl.Location = new System.Drawing.Point(377, 46);
            this.StartHeightlbl.Name = "StartHeightlbl";
            this.StartHeightlbl.Size = new System.Drawing.Size(72, 13);
            this.StartHeightlbl.TabIndex = 29;
            this.StartHeightlbl.Text = "Start height m";
            // 
            // StartHeighttxt
            // 
            this.StartHeighttxt.Location = new System.Drawing.Point(380, 64);
            this.StartHeighttxt.Name = "StartHeighttxt";
            this.StartHeighttxt.Size = new System.Drawing.Size(100, 20);
            this.StartHeighttxt.TabIndex = 28;
            this.StartHeighttxt.Text = "0";
            // 
            // AtmosMolMasslbl
            // 
            this.AtmosMolMasslbl.AutoSize = true;
            this.AtmosMolMasslbl.Location = new System.Drawing.Point(124, 170);
            this.AtmosMolMasslbl.Name = "AtmosMolMasslbl";
            this.AtmosMolMasslbl.Size = new System.Drawing.Size(154, 13);
            this.AtmosMolMasslbl.TabIndex = 31;
            this.AtmosMolMasslbl.Text = "Atmosphere molar mass kg/mol";
            // 
            // AtmosMolMasstxt
            // 
            this.AtmosMolMasstxt.Location = new System.Drawing.Point(127, 188);
            this.AtmosMolMasstxt.Name = "AtmosMolMasstxt";
            this.AtmosMolMasstxt.Size = new System.Drawing.Size(100, 20);
            this.AtmosMolMasstxt.TabIndex = 30;
            this.AtmosMolMasstxt.Text = "0.0289644";
            // 
            // CrossSectlbl
            // 
            this.CrossSectlbl.AutoSize = true;
            this.CrossSectlbl.Location = new System.Drawing.Point(9, 170);
            this.CrossSectlbl.Name = "CrossSectlbl";
            this.CrossSectlbl.Size = new System.Drawing.Size(117, 13);
            this.CrossSectlbl.TabIndex = 33;
            this.CrossSectlbl.Text = "Cross section area m^2";
            // 
            // CrossSecttxt
            // 
            this.CrossSecttxt.Location = new System.Drawing.Point(12, 188);
            this.CrossSecttxt.Name = "CrossSecttxt";
            this.CrossSecttxt.Size = new System.Drawing.Size(100, 20);
            this.CrossSecttxt.TabIndex = 32;
            this.CrossSecttxt.Text = "43.2412";
            // 
            // Draglbl
            // 
            this.Draglbl.AutoSize = true;
            this.Draglbl.Location = new System.Drawing.Point(9, 213);
            this.Draglbl.Name = "Draglbl";
            this.Draglbl.Size = new System.Drawing.Size(86, 13);
            this.Draglbl.TabIndex = 35;
            this.Draglbl.Text = "Drag coeffecient";
            // 
            // Dragtxt
            // 
            this.Dragtxt.Location = new System.Drawing.Point(12, 231);
            this.Dragtxt.Name = "Dragtxt";
            this.Dragtxt.Size = new System.Drawing.Size(100, 20);
            this.Dragtxt.TabIndex = 34;
            this.Dragtxt.Text = "0";
            // 
            // SimGraph
            // 
            chartArea1.Name = "ChartArea1";
            this.SimGraph.ChartAreas.Add(chartArea1);
            this.SimGraph.DataSource = this.SimGraph.Images;
            legend1.Name = "Legend1";
            this.SimGraph.Legends.Add(legend1);
            this.SimGraph.Location = new System.Drawing.Point(515, 46);
            this.SimGraph.Name = "SimGraph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Rocket";
            this.SimGraph.Series.Add(series1);
            this.SimGraph.Size = new System.Drawing.Size(640, 467);
            this.SimGraph.TabIndex = 36;
            this.SimGraph.Text = "SimGraph";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 511);
            this.Controls.Add(this.SimGraph);
            this.Controls.Add(this.Draglbl);
            this.Controls.Add(this.Dragtxt);
            this.Controls.Add(this.CrossSectlbl);
            this.Controls.Add(this.CrossSecttxt);
            this.Controls.Add(this.AtmosMolMasslbl);
            this.Controls.Add(this.AtmosMolMasstxt);
            this.Controls.Add(this.StartHeightlbl);
            this.Controls.Add(this.StartHeighttxt);
            this.Controls.Add(this.StartVellbl);
            this.Controls.Add(this.StartVeltxt);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.SurDenslbl);
            this.Controls.Add(this.SurDenstxt);
            this.Controls.Add(this.SurTemplbl);
            this.Controls.Add(this.SurTemptxt);
            this.Controls.Add(this.BodyRadlbl);
            this.Controls.Add(this.BodyRadtxt);
            this.Controls.Add(this.BodyMasslbl);
            this.Controls.Add(this.BodyMasstxt);
            this.Controls.Add(this.SimTimelbl);
            this.Controls.Add(this.SimTimetxt);
            this.Controls.Add(this.TickPerlbl);
            this.Controls.Add(this.TickPertxt);
            this.Controls.Add(this.EjectMasslbl);
            this.Controls.Add(this.EjectMasstxt);
            this.Controls.Add(this.EjectVellbl);
            this.Controls.Add(this.EjectVeltxt);
            this.Controls.Add(this.FuelMasslbl);
            this.Controls.Add(this.FuelMasstxt);
            this.Controls.Add(this.EmpMasslbl);
            this.Controls.Add(this.EmpMasstxt);
            this.Name = "Form1";
            this.Text = "Rocket Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.SimGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmpMasstxt;
        private System.Windows.Forms.Label EmpMasslbl;
        private System.Windows.Forms.Label FuelMasslbl;
        private System.Windows.Forms.TextBox FuelMasstxt;
        private System.Windows.Forms.Label EjectVellbl;
        private System.Windows.Forms.TextBox EjectVeltxt;
        private System.Windows.Forms.Label EjectMasslbl;
        private System.Windows.Forms.TextBox EjectMasstxt;
        private System.Windows.Forms.Label TickPerlbl;
        private System.Windows.Forms.TextBox TickPertxt;
        private System.Windows.Forms.Label SimTimelbl;
        private System.Windows.Forms.TextBox SimTimetxt;
        private System.Windows.Forms.Label BodyMasslbl;
        private System.Windows.Forms.TextBox BodyMasstxt;
        private System.Windows.Forms.Label BodyRadlbl;
        private System.Windows.Forms.TextBox BodyRadtxt;
        private System.Windows.Forms.Label SurTemplbl;
        private System.Windows.Forms.TextBox SurTemptxt;
        private System.Windows.Forms.Label SurDenslbl;
        private System.Windows.Forms.TextBox SurDenstxt;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.Label StartVellbl;
        private System.Windows.Forms.TextBox StartVeltxt;
        private System.Windows.Forms.Label StartHeightlbl;
        private System.Windows.Forms.TextBox StartHeighttxt;
        private System.Windows.Forms.Label AtmosMolMasslbl;
        private System.Windows.Forms.TextBox AtmosMolMasstxt;
        private System.Windows.Forms.Label CrossSectlbl;
        private System.Windows.Forms.TextBox CrossSecttxt;
        private System.Windows.Forms.Label Draglbl;
        private System.Windows.Forms.TextBox Dragtxt;
        private System.Windows.Forms.DataVisualization.Charting.Chart SimGraph;
    }
}

