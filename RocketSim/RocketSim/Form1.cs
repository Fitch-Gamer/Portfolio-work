using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RocketSim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Rocket Sim = new Rocket(double.Parse(StartVeltxt.Text), double.Parse(StartHeighttxt.Text), double.Parse(FuelMasstxt.Text), double.Parse(EmpMasstxt.Text), double.Parse(EjectVeltxt.Text), double.Parse(EjectMasstxt.Text),double.Parse(Dragtxt.Text), double.Parse(CrossSecttxt.Text));
            Planet Earth = new Planet(double.Parse(BodyMasstxt.Text), double.Parse(BodyRadtxt.Text), double.Parse(SurDenstxt.Text), double.Parse(SurTemptxt.Text), double.Parse(AtmosMolMasstxt.Text));
            Simulate(Sim, Earth);
        }

        private void Simulate(Rocket sim, Planet earth)
        {
            int time = 0;
            int ActualTime = int.Parse(TickPertxt.Text);
            double DeltaTime = (double) ActualTime/1000;
            int FinalTime = int.Parse(SimTimetxt.Text);

            while (time <= FinalTime)
            {
                try
                {
                    if (sim.CurFuelMass > 0)
                    {
                        sim.CurMomentum += sim.Impulse * DeltaTime;
                        sim.CurFuelMass += sim.DeltaFuelMass * DeltaTime;
                    }
                    sim.CurMomentum -= earth.GetGravStrength(sim.CurAltitude) * (sim.CurFuelMass + sim.BodyMass) * DeltaTime;
                    sim.CurMomentum -= sim.GetAirResistance(earth) * DeltaTime;

                    sim.CurVelocity = sim.CurMomentum / (sim.BodyMass + sim.CurFuelMass);

                    sim.CurAltitude += sim.CurVelocity * DeltaTime;

                    File.AppendAllLines(Nametxt.Text, new string[] { ((double)time / 1000).ToString() + "," + sim.CurAltitude.ToString() });

                    SimGraph.Series["Rocket"].Points.AddXY((double)time/1000, sim.CurAltitude);

                    time += ActualTime;
                }
                catch
                {
                    Console.WriteLine("Simulation failed at time" + ((double)time/1000));
                    break;
                }
            }
            MessageBox.Show("Simulation finished");
        }

        public class Rocket
        {
            //List<Stage> Stages;
            public double CurVelocity=0, CurAltitude=0, CurFuelMass, BodyMass,Impulse, DeltaFuelMass, CurMomentum = 0, DragCoeffecient,CrossSectionArea;
            public Rocket(double vel, double alt, double fuelmass,double bodymass, double ejectionvel, double ejectmass, double drag, double area)
            {
                CurFuelMass = fuelmass;
                CurAltitude = alt;
                CurVelocity = vel;
                BodyMass = bodymass;
                Impulse = ejectionvel*ejectmass;
                DeltaFuelMass = -ejectmass;
                DragCoeffecient = drag;
                CrossSectionArea = area;

            }
            public double GetAirResistance(Planet planet)
            {
                return (0.5) * planet.GetAirDensity(CurAltitude) * Math.Pow(CurVelocity, 2) * DragCoeffecient * CrossSectionArea;
            }
        }
        public class Stage
        {
            int DelayToNextStage;
        }
        public class Planet
        {
            double G = 6.673e-11, Mass, Radius, AirDensity, SurPress, R = 8.3144598, Temperature, MolarMass;
            public Planet(double mass, double radius, double density, double temp, double molmass)
            {
                Mass = mass;
                Radius = radius;
                AirDensity = density;
                Temperature = temp;
                MolarMass = molmass;
            }

            public double GetGravStrength(double height)
            {
                return (G * Mass) / Math.Pow(Radius + height, 2);
            }
            public double GetAirDensity(double radius)
            {
                return Math.Pow(AirDensity,(-GetGravStrength(radius)*MolarMass*radius)/(R*Temperature));
            }
        }
    }
}
