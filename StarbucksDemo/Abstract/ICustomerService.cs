using StarbucksDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarbucksDemo.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
