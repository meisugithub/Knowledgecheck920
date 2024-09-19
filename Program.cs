
using System.Transactions;
using Toyota;
using System.Text.Json;
using System;


namespace Toyota
{
   
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many Toyota sedan records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());
            Console.WriteLine();

            var recordList = new List<Sedan>();
            for (int i = 0; i<numberOfRecords; i++)
            {
	        // In this loop, populate the object's properties using Console.ReadLine()
	         var sedan = new Sedan();

            Console.WriteLine("Enter Sedan Type Name:");
            sedan.Name = Console.ReadLine();

            Console.WriteLine("Enter Description:");
            sedan.Description = Console.ReadLine();

            Console.WriteLine("Enter Price: xx.xx");
            sedan.Price = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter Quantity:");
            sedan.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("If the car is Hybrid, please enter true.  Otherwise enter false.");
            sedan.Hybrid = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Enter Model: ");
	        sedan.Model = Console.ReadLine();

             Console.WriteLine();

	         recordList.Add(sedan);
         }

            // Print out the list of records using Console.WriteLine()

            Console.WriteLine("Print out the list of added cars\n");


            foreach (var car in recordList)
            {
                Console.WriteLine(car);
            }

     }
  }
}

