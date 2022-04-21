using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Se crea la clase ConsolePrinter con la finalidad de aplicar los patrones Expert Y SRP. La clase "Recipe" tenía asignada la funcion 
    /// de imprimir la receta, y no debía ser así ya que estaba haciendo dos funciones totalmente diferentes, por lo tanto se
    /// crea Esta clase la cual solamente se encarga de imprimir la receta por consola y conoce toda la informacón necesaria para cumplir su función.
    /// Por otro lado también es muy util ya que si en un futuro se quiere cambiar la forma de impresión o mostrar por consola se puede hacer facilmente modificando 
    /// solamente esta clase y no afectando al resto del codigo a grandes rasgos (aplicando SRP).
    /// </summary>
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