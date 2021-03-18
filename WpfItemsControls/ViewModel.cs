using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfItemsControls
{
    class ViewModel
    {        
        public ViewModel()
        {
            Persons = new ObservableCollection<Person>(GetPersons());
        }

        public ObservableCollection<Person> Persons { get; set; }
        public Person SelectedPerson { get; set; }


        public List<Person> GetPersons()
        {
            List<Person> people = new List<Person>()
            {
                new Person() {FirstName = "Mads", LastName = "Rasmussen", Email = "mara@aspit.dk", PhoneNumber = "123"},
                new Person() {FirstName = "Brian", LastName = "Jørgensen", Email = "brjo@aspit.dk", PhoneNumber = "456"}
            };
            return people;
        }
    }
}
