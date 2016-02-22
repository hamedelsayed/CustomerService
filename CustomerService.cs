using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasktyCRM.Data;
using TasktyCRM.Data.Infrastructure;

namespace TasktyCRM.Service.CustomerService
{
    public class CustomerService:EntityService<Customer>, ICustomerService
    {
        readonly TasktyCRM.Data.TasktyCRM _context;
        public CustomerService(TasktyCRM.Data.TasktyCRM context)
            : base(context)
        {
            _context = context;
            Dbset = _context.Set<Customer>();
        }
        public override IEnumerable<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }


        public Customer GetById(int Id)
        {
            return _context.Customers.FirstOrDefault(x => x.Id == Id);
        }

    }
}
