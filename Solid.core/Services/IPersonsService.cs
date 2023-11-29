using Hotel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IPersonsService
    {
        List<Persons> GetPersons();       
        Persons GetById(int id);
        Persons AddPerson( Persons person);
        Persons UpdatePerson(int id,Persons person);
        void DeletePerson(int id);

    }
}
