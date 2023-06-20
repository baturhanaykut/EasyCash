using EasyCash.DataAccessLayer.Abstract;
using EasyCash.DataAccessLayer.Repositories;
using EasyCash.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCash.DataAccessLayer.EntityFramework
{
    public class EfCustomerAccountProcessDal : GenericRepository<CustomerAccountProcess>,ICustomerAccountProcessDal
    {
    }
}
