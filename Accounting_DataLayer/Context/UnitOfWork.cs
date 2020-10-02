using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_DataLayer
{
    public class UnitOfWork : IDisposable
    {
        AccountingEntities db = new AccountingEntities();

        private IPeopleRepository _peopleRepository;

        public IPeopleRepository PeopleRepository
        {
            get
            {
                if (_peopleRepository == null)
                {
                    _peopleRepository = new PeopleRespository(db);
                }
                return _peopleRepository;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
