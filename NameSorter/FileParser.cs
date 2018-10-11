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
            return parser(filePath);
        }

        private List<String> parser(string filePath) {
            List<String> people = new List<String>();
            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(@filePath);

            while ((line = file.ReadLine()) != null) {
                people.Add(line);
            }

            file.Close();
            return people;
        }
    }
}
