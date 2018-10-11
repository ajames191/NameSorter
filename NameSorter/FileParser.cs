using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class FileParser
    {
        public List<String> getPeople(string filePath) {
            // Call the parser function to read the file at the specified file path
            return parser(filePath);
        }

        private List<String> parser(string filePath) {
            List<String> people = new List<String>();
            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(@filePath);

            // While there are lines to read in the text file, add them to the "people" ArrayList
            while ((line = file.ReadLine()) != null) {
                people.Add(line);
            }

            file.Close();
            return people;
        }
    }
}
