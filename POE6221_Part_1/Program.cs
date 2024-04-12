using POE6221_Part_1;
using System.Diagnostics.Metrics;
using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        

        //start up value/input
        Console.Write("Enter number of ingridients for your recipe: ");
       int NumOfIngreds = int.Parse(Console.ReadLine());

        //instantiation :ingredients Array
        Ingredients[] ingredient = new Ingredients[NumOfIngreds];
       

        for (int i = 0; i < NumOfIngreds; i++)
        {
            string ingredName;


            //input
            //number of ingredients to enter
            if (NumOfIngreds <= 1)
            {
                Console.Write("Enter ingredient name: ");
                ingredName = Console.ReadLine();
            }
            else
            {
                Console.Write($"Enter ingredient name {i + 1}: ");
               ingredName = Console.ReadLine();

            }

            //input
            Console.Write("Ingredient quantity: ");
            int ingredQuantity = int.Parse(Console.ReadLine());

            Console.Write("Ingredient in measurement: ");
            string ingredMeasurement = Console.ReadLine();


            //steps
            int numOfSteps;

            Console.Write("Enter number of steps for the recipe: ");
            numOfSteps = int.Parse(Console.ReadLine());

            //instatntiation : Steps Array
            Formula[] formula = new Formula[numOfSteps];

            for (int j = 0; j < numOfSteps; j++)
            {
                formula[j] = new Formula();
                Console.Write($"Step {j + 1} : ");
                formula[j].IngredInstruction = Console.ReadLine();
                Console.WriteLine();

            }
            
            ingredient[i] = new Ingredients(formula, ingredMeasurement,  ingredQuantity, ingredName);
        }

        //ScaleMenu Method
        

        //instantiation
        Measuremnt_Scale[] Opt = new Measuremnt_Scale[ingredient.Length];
        for (int i = 0; i < ingredient.Length; i++) 
        {
               
            Console.WriteLine("================================");
            Console.WriteLine($"Instruction {i + 1}: ");
            ingredient[i].Display();
            Console.WriteLine();
            Console.WriteLine();
        }
        Measuremnt_Scale.ScaleMenu(NumOfIngreds);



    }
}