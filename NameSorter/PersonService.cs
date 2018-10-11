using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class PersonService
    {
        List<Person> people;

        public List<Person> People { get => people;}

        public PersonService() {
            people = new List<Person>();
        }

        public void sortPeopleByLastNameAndOutput(string filePath) {
            people = ExtractPeopleFromFileAsAList(filePath);
            people = SortPeopleLastNameDesc();

            OutputSortedPeople();
        }

        private void OutputSortedPeople() {
            foreach (Person p in people) {
                Console.WriteLine(p.Forename + p.Surname);
            }

            // I would pause the console window with "Console.ReadKey();" here, but it breaks the tests.
        }

        private List<Person> SortPeopleLastNameDesc() {
            return people.OrderBy(x => x.Surname).ThenBy(y => y.Forename).ToList();
        }

        public List<Person> ExtractPeopleFromFileAsAList(string filePath) {
            FileParser fileParser = new FileParser();
            
            foreach (string personAsString in fileParser.getPeople(filePath)) {
                string[] personAsArray = personAsString.Split(' ');
                if (personAsArray.Length > 4 ) {
                    // Skips element if too many names.
                } else { 
                    Person person = new Person();

                    person.Forename = ExtractForename(personAsArray);
                    person.Surname = extractSurname(personAsArray);
                    people.Add(person);
                }
            }
            return people;
        }

        private string ExtractForename(string[] asArray) {
            string forename = "";
            for (int i = 0; i < asArray.Length - 1; i++) {
                forename += asArray[i] + " ";
            }
            return forename;
        }

        private string extractSurname(string[] asArray) {
            return asArray[asArray.Length - 1];
        }
    }
}
