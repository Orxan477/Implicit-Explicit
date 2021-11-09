using System;
using System.Collections.Generic;
using System.Text;

namespace Implicit_explicit.Models
{
    class Celcius
    {
        public double CelciusC { get; set; }
        public Celcius(double celci)
        {
            CelciusC = celci;
        }
        /// <summary>
        /// Faranheyt calculated
        /// </summary>
        /// <param name="faranheyt">celci</param>
        public static implicit operator Faranheyt(Celcius celci)
        {
            return new Faranheyt(((celci.CelciusC * 9) / 5) + 32);
        }
    }
}
