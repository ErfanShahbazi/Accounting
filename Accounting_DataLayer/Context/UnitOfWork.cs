using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Accounting_DataLayer
{
    public class UnitOfWork : IDisposable
    {
       AccountingEntities context = new AccountingEntities();

        private IPeopleRepository _peopleRepository;

        public IPeopleRepository PeopleRepository { get
            {
                if (_peopleRepository == null)
                {
                    _peopleRepository = new PeopleRepository(context);
                }
                return _peopleRepository;
            }
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }

    }
}
