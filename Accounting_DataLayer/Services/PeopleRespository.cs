using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Accounting_DataLayer
{
    public class PeopleRespository : IPeopleRepository
    {

        private AccountingEntities accountingDB;

        public PeopleRespository(AccountingEntities db)
        {
            accountingDB = db;
        }

        public List<Person> GetAllPeople()
        {
            return accountingDB.Person.ToList();
        }

        public Person GetPersonById(int id)
        {
            try
            {
                return accountingDB.Person.Where(p => p.ID == id).SingleOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool AddPerson(Person person)
        {
            try
            {
                accountingDB.Person.Add(person);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool EditPerson(Person person)
        {
            try
            {
                accountingDB.Entry(person).State = EntityState.Modified;
                return true;
            }
            
            catch
            {
                return false;
            }
        }

        public bool DeletePerson(Person person)
        {
            try
            {
                accountingDB.Person.Remove(person);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeletePerson(int id)
        {
            try
            {
                Person personToDelete = accountingDB.Person.Where(p=> p.ID == id).SingleOrDefault();
                accountingDB.Person.Remove(personToDelete);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public void SaveChanges()
        {
            accountingDB.SaveChanges();
        }
    }
}
