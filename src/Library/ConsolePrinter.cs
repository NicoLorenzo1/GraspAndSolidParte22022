using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Consoleprinter
    {
        public static void PrintRecipe()
        {
            Console.WriteLine($"Receta de {Recipe.FinalProduct.Description}:");
            foreach (Step step in Recipe.Steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}