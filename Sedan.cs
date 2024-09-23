using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toyota
{
    public class Sedan:Vehicle
    {
        public bool Hybrid { get; set; }
        public string Model { get; set; }

        public override string ToString()
        {
            string output = base.ToString();
            output += $"Hybrid: {Hybrid}{newLine}";
            output += $"Model: {Model}{newLine}";
            return output ; 
        }

    }
}
