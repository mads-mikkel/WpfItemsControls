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
            Persons = new ObservableCollection<Person>();
            LoadPersons();
        }

        public ObservableCollection<Person> Persons { get; set; }

        public void LoadPersons()
        {
            Repository repository = new Repository();
            List<Person> people = repository.GetAllPersons();
            Persons.Clear();
            foreach(Person p in people)
            {
                Persons.Add(p);
            }
        }
    }
}
