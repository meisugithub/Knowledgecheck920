using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toyota
{
    public class Sedan:Type
    {
        public bool Hybrid { get; set; }
        public string Model { get; set; }

        public override string ToString()
        {
            return Name + " " + Description + " " + Price + " " + Quantity + " " + Hybrid + " " + Model;
        }

    }
}
