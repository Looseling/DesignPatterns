using DemoLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonModel> people = new();

        public DemoDataAccess()
        {
            people.Add(new PersonModel { ID = 1, FirstName = "Tim", LastName = "Corey" });
            people.Add(new PersonModel { ID = 2, FirstName = "LOL", LastName = "JOrry" });
            people.Add(new PersonModel { ID = 3, FirstName = "KEK", LastName = "Rorry" });
        }

        public List<PersonModel> GetPeople()
        {
            return people;
        }

        public PersonModel InsertPerson(string firstName, string lastName)
        {
            PersonModel p = new PersonModel
            {
                ID = people.Max(x => x.ID) + 1,
                FirstName = firstName,
                LastName = lastName
            };
            people.Add(p);
            return p;
        }

    }
}
