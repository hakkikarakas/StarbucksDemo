using StarbucksDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarbucksDemo.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
