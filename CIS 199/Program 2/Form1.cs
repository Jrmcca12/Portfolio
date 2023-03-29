// Program 2
// CIS 199-01
// Due: 10/15/2020
// By: R2158

// This program prompts the user for their Weight, Distance, and Delivery,
// It returns the cost of each company and tells you who is the cheapest


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_2
{
    public partial class Form1 : Form
    {
        double DeliveryA, CostA;
        double WeightB, DeliveryB, CostB;
        double MilesC, DeliveryC, CostC;

        double DeliveryDay;
        double Weight, Miles;
        double Lowest;

       
        


        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            Weight = Convert.ToDouble(TXTWeight.Text);
            Miles = Convert.ToDouble(TXTDistance.Text);
            DeliveryDay = Convert.ToDouble(TXTDelivery.Text);

            //Company A Infromation
           if(DeliveryDay == 1)
            {
                DeliveryA = 20;
            }
            if (DeliveryDay == 2)
            {
                DeliveryA = 17;
            }
            if (DeliveryDay == 3)
            {
                DeliveryA = 15;
            }
            if (DeliveryDay >= 4 && DeliveryDay <=7)
            {
                DeliveryA = 10;
            }
            if (DeliveryDay > 7)
            {
                DeliveryA = 7;
            }

            //Company B Infromation
            if (Weight < 10)
            {
                WeightB = 3;
            }

            if (Weight >= 10 && Weight <50)
            {
                WeightB = 5;
            }

            if (Weight >= 50 && Weight < 100)
            {
                WeightB = 10;
            }

            if (Weight >= 100 && Weight < 200)
            {
                WeightB = 20;
            }

            if (Weight >200)
            {
                WeightB = .15 * Weight;
            }

            if (DeliveryDay >= 1 && DeliveryDay <= 4)
            {
                DeliveryB = 10;
            }

            if (DeliveryDay > 4)
            {
                DeliveryB = 7;
            }

            //Company C Information
            if (Miles < 200)
            {
                MilesC = 10;
            }
            if (Miles >= 200 && Miles < 500)
            {
                MilesC = 15;
            }
            if (Miles >= 500 && Miles < 750)
            {
                MilesC = 25;
            }
            if (Miles >= 750 && Miles < 1000)
            {
                MilesC = 35;
            }
            if (Miles >= 1000)
            {
                MilesC = 40;
            }

            int DeliveryC = 20;



            //Formulas
            CostA = (Weight * 1) + (Miles * .02) + DeliveryA;
            CostB = (WeightB) + (Miles * .1) + DeliveryB;
            CostC = (Weight * .25) + MilesC + DeliveryC;

            //Text Results Formulas
            if(CostA < CostB && CostA < CostC)
            {
                TxtLowest.Text = "The lowest cost company is: A";
            }
            if (CostB < CostA && CostB < CostC)
            {
                TxtLowest.Text = "The lowest cost company is: B";
            }
            if (CostC < CostB && CostC < CostA)
            {
                TxtLowest.Text = "The lowest cost company is: C";
            }

            //Display Results
            TXTComA.Text = CostA.ToString();
            TXTComB.Text = CostB.ToString();
            TXTComC.Text = CostC.ToString();

        }
    }
}
