//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private static ArrayList steps = new ArrayList();
        public static Product FinalProduct { get; set; }
        
        /// <summary>
        /// Método get publico para obtener los steps
        /// </summary>
        /// <value></value>
        public static ArrayList Steps
        {
            get
            {
                return steps;
            }
        }
        
        public void AddStep(Step step)
        {
            steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            steps.Remove(step);
        }

    }
}