using StarbucksDemo.Abstract;
using StarbucksDemo.Adapters;
using StarbucksDemo.Concrete;
using StarbucksDemo.Entities;
using System;
namespace StarbucksDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth=new System.DateTime(1992,1,1),FirstName="Hakkı",LastName="Karakaş",NationalityId=46200200210});
            Console.ReadLine();

        }
    }
}
