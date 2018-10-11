using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Tests
{
    [TestClass()]
    public class PersonServiceTests
    {
        [TestMethod()]
        public void sortPeopleByLastNameAndOutputTest_isEqualTo11()
        {
            PersonService personService = new PersonService();
            personService.sortPeopleByLastNameAndOutput("./unsorted-names-list.txt");
            List<Person> actual = personService.People;

            Assert.AreEqual(11, actual.Count);
        }

        [TestMethod()]
        public void sortPeopleByLastNameAndOutputTest_isInCorrectOrder()
        {
            PersonService personService = new PersonService();
            personService.sortPeopleByLastNameAndOutput("./unsorted-names-list.txt");
            List<Person> actual = personService.People;

            Assert.AreEqual(actual[0].Forename + actual[0].Surname, "Marin Alvarez");
            Assert.AreEqual(actual[1].Forename + actual[1].Surname, "Adonis Julius Archer");
            Assert.AreEqual(actual[2].Forename + actual[2].Surname, "Beau Tristan Bentley");
            Assert.AreEqual(actual[3].Forename + actual[3].Surname, "Hunter Uriah Mathew Clarke");
            Assert.AreEqual(actual[4].Forename + actual[4].Surname, "Leo Gardner");
            Assert.AreEqual(actual[5].Forename + actual[5].Surname, "Vaughn Lewis");
            Assert.AreEqual(actual[6].Forename + actual[6].Surname, "London Lindsey");
            Assert.AreEqual(actual[7].Forename + actual[7].Surname, "Mikayla Lopez");
            Assert.AreEqual(actual[8].Forename + actual[8].Surname, "Janet Parsons");
            Assert.AreEqual(actual[9].Forename + actual[9].Surname, "Frankie Conner Ritter");
            Assert.AreEqual(actual[10].Forename + actual[10].Surname, "Shelby Nathan Yoder");
        }
    }
}
