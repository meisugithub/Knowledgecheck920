using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toyota
{
    public class Vehicle
    {
        protected string newLine = Environment.NewLine;  
        public string Name { get; set; }
        public string Description { get; set; } 
        public decimal Price { get; set; }
        public int Quantity {get; set; }

        public override string ToString()
        {
            string output = string.Empty;
            output += $"Name: {Name}{newLine}";
            output += $"Description: {Description}{newLine}";
            output += $"Price: {Price}{newLine}";
            output += $"Quantity: {Quantity}{newLine}";
            return output;

        }
    }
     

}
