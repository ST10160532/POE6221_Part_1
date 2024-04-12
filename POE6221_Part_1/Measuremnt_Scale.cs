using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE6221_Part_1
{
    internal class Measuremnt_Scale
    {
        private int numOfIngreds;
        private int menuOp;

        public int NumOfIngreds
        {
            get { return numOfIngreds; }
            set { numOfIngreds = value; }
        }

        public int MenuOp
        {
            get { return menuOp; }
            set { menuOp = value; }
        }

        public Measuremnt_Scale(int numOfIngreds, int menuOp)
        {
            this.numOfIngreds = numOfIngreds;
            this.menuOp = menuOp;
            

        }

        public static void ScaleMenu(int numOfIngreds)
        {
            //instantiation
            Measuremnt_Scale[] measurement_Scale = new Measuremnt_Scale[numOfIngreds];
            Ingredients[] ingredient = new Ingredients[numOfIngreds];
           

         
            for (int i = 0; i < numOfIngreds; i++)
            {
                //Scale menu
                Console.WriteLine("Options: " +
                  "\n 1. Add a scale factor to the recipe" +
                  "\n 2. Reset ingredient quantity" +
                  "\n 3. Clear all data");
                int menuOp = int.Parse(Console.ReadLine());
                measurement_Scale[i] = new Measuremnt_Scale(numOfIngreds, menuOp);


                Ingredients currentIngredient =new  Ingredients();
                //condition
                if (menuOp == 1)
                {

                    Console.WriteLine("Measurement scale for ingredient {: " +
                            "\n 1. 0.5" +
                            "\n 2. 2" +
                            "\n 3. 3" +
                            "\n 4. none");

                    double MeasuremntScale = double.Parse(Console.ReadLine());

                    switch (MeasuremntScale)
                    {

                        case 1:
                            MeasuremntScale = 0.5;

                            break;
                        case 2:
                            MeasuremntScale = 2;
                            break;
                        case 3:
                            MeasuremntScale = 3;
                            break;
                        default:
                            MeasuremntScale = 0;
                            break;


                    

                    }

                    currentIngredient.MeasuremntScale = MeasuremntScale;
                    ingredient[i] = currentIngredient;
                    currentIngredient.ScaleCalc();

                }
                else if (menuOp == 2)
                {
                    ;
                    ingredient[i] = currentIngredient;
                    currentIngredient.ResetScale();
                }

                else if (menuOp == 3)
                {
                   ingredient[i] = currentIngredient;
                    currentIngredient.ClearScale();
                }
            }
        }
    
    }
}

