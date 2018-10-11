using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class Person
    {
        private string forename;
        private string surname;

        public string Surname {
            get => surname;
            set => surname = value;
        }

        public string Forename {
            get => forename;
            set => forename = value;
        }
    }
}
