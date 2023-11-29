using Hotel.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class PersonsRepository:IPersonsRepository
    {
        private readonly DataContext _context;

        public PersonsRepository(DataContext context)
        {
            _context = context;
        }

        public Persons AddPerson(Persons person)
        {
            _context.allPersons.Add(person);
            return person;
        }

        public void DeletePerson(int id)
        {
            _context.allPersons.Remove(_context.allPersons.Find(p => p.idPerson == id));

        }

        public Persons GetById(int id)
        {
            return _context.allPersons.Find(p => p.idPerson == id);
        }

        public List<Persons> GetUsers()
        {
            return _context.allPersons;
        }

        public Persons UpdatePerson(int id, Persons person)
        {
            var updatePerson = _context.allPersons.Find(p => p.idPerson==id);
            if (updatePerson != null)
            {
                updatePerson.name = person.name;
                updatePerson.time = person.time;
                updatePerson.idPerson = id; 
                updatePerson.fName = person.fName;
                updatePerson.numPhone=person.numPhone;
                updatePerson.idroom = person.idroom;
                
                return updatePerson;
            }
            return null;
        }
    }
}
