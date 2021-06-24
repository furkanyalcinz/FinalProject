using Core.DataAccess;
using Entities.Concerete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICustomerDal: IEntityRepository<Customer>
    {
    }
}
