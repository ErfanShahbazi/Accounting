using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting_DataLayer;



namespace TestReops
{
    class Program
    {
        static void Main(string[] args)
        {

            UnitOfWork Context = new UnitOfWork();

            var x = Context.PeopleRepository.GetAllPeople();

            Context.Dispose();

        }
    }
}
