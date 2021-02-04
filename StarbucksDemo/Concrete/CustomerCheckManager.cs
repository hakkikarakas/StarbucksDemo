using StarbucksDemo.Abstract;
using StarbucksDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarbucksDemo.Concrete
{
    class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
