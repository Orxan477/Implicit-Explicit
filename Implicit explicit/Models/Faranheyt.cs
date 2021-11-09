using System;
using System.Collections.Generic;
using System.Text;

namespace Implicit_explicit.Models
{
    class Faranheyt
    {
        
        public double FaranheytF { get; set; }
        public Faranheyt(double faranheyt)
        {
            FaranheytF = faranheyt;
        }
        /// <summary>
        /// Celci calculated
        /// </summary>
        /// <param name="faranheyt">faranheyt</param>
        public static implicit operator Celcius(Faranheyt faranheyt)
        {
            return new Celcius(((faranheyt.FaranheytF - 32) *5)/9);
        }
    }
}
