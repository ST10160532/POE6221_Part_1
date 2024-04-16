using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace POE6221_Part_1
{
    internal class Ingredients
    {
        private string ingredName;
        private int ingredQuantity;
        private string ingredMeasurement;
        private double measurement;
        private double clear;
        private double reset;
        private double measuremntScale;
        private Formula[] formula;

        public string IngredName
        {
            get { return ingredName; }
            set { ingredName = value; }
        }
       


        public int IngredQuantity
        {
            get { return ingredQuantity; }
            set { ingredQuantity = value; }
        }

        public string IngredMeasurement
        {
            get { return ingredMeasurement; }
            set { ingredMeasurement = value; }
        }
        public double MeasuremntScale
        {
            get { return measuremntScale; }
            set { measuremntScale = value; }
        }

        public Formula[] Formula
        {
            get { return formula; }
            set { formula = value; }
        }
        public double Measurement
        {
            get { return measurement; }
            set { measurement = value; }
        }
        public double Reset
        {
            get { return reset; }
            set { reset = value; }
        }

        public double Clear
        {
            get { return clear; }
            set { clear = value; }
        }
        public Ingredients(Formula[] formula, string ingredMeasurement, int ingredQuantity, string ingredName)
        {
            this.formula = formula; 
            //this.measurement = measurement;
            this.ingredMeasurement = ingredMeasurement;
            this.ingredQuantity = ingredQuantity;   
            this.ingredName = ingredName;
        }
        public Ingredients(double measuremntScale)
        {
            this.measuremntScale = measuremntScale;
        }

        public Ingredients() { }

        public void ScaleCalc()
        {
            measurement = measuremntScale * ingredQuantity;

            Console.WriteLine();
            Console.WriteLine(measurement + " " + ingredMeasurement + " of " + ingredName);

            Console.WriteLine();
           
            Console.WriteLine();

        }
        //reset method
        public void ResetScale()
        {

            reset = measuremntScale;
            Console.WriteLine();
            Console.WriteLine(reset + " " + ingredMeasurement + " of " + ingredName);

            Console.WriteLine();
            
           
            Console.WriteLine();


        }
        //clear method
        public void ClearScale()
        {
             clear = 0;
            ingredMeasurement = "";
            ingredName = "";
            Console.WriteLine();
            Console.WriteLine(clear + " " + ingredMeasurement + " of " + ingredName);

            Console.WriteLine();
           
            Console.WriteLine();

        }




        //display method
        public void Display()
        {
            
           

            Console.WriteLine() ;
            Console.WriteLine(ingredQuantity + " " + ingredMeasurement + " of " + ingredName);
           
                Console.WriteLine();
                Console.WriteLine("Steps: ");
                foreach (var steps in formula)
                {
                    Console.WriteLine(steps.IngredInstruction);
               

                }
                Console.WriteLine();
            


        }


    }
}
