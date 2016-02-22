using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasktyCRM.Data;
using TasktyCRM.Data.Infrastructure;

namespace TasktyCRM.Service.CustomerService
{
    public interface ICustomerService:IEntityService<Customer>
    {
        Customer GetById(int Id);
    }
}
