using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_DataLayer
{
    public interface IPeopleRepository
    {
        List<Person> GetAllPeople();
        Person GetPersonById(int id);
        List<Person> FindPersonBySearch(string parameter);
        bool AddPerson(Person person);
        bool EditPerson(Person person);
        bool DeletePerson(Person person);
        bool DeletePerson(int id);
    }
}
