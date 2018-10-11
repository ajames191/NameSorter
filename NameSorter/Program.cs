using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide a file to sort.");
                Console.ReadKey();
                return;
            }

            // Person service is a class that is used to manipulate the data for us, so it aids parsing, extracting and sorting the data
            PersonService personService = new PersonService();

            // Sort the text file at the specified directory
            personService.sortPeopleByLastNameAndOutput(args[0]);
        }
    }
}
