using Hotel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IPersonsRepository
    {
        List<Persons> GetUsers();

        Persons GetById(int id);

        Persons AddPerson(Persons person);

        Persons UpdatePerson(int id, Persons person);

        void DeletePerson(int id);
    }
}
