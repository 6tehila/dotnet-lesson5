using Hotel.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    public class PersonsService : IPersonsService
    {
        private readonly IPersonsRepository _personService;
        public PersonsService(IPersonsRepository datesService)
        {
            _personService = datesService;
        }

        public Persons AddPerson(Persons person)
        {
            return _personService.AddPerson(person);
        }

        public void DeletePerson(int id )
        {
            _personService.DeletePerson(id);
        }

        public Persons GetById(int id)
        {
            return _personService.GetById(id);
        }

        public List<Persons> GetPersons()
        {
            return _personService.GetUsers();
        }

        public Persons UpdatePerson(int id, Persons person)
        {
           return  _personService.UpdatePerson(id, person);
        }
    }
}
