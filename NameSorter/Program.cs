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

            PersonService personService = new PersonService();

            personService.sortPeopleByLastNameAndOutput(args[0]);
        }
    }
}
