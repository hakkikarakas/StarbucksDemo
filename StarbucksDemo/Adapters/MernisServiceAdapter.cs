using StarbucksDemo.Abstract;
using StarbucksDemo.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;




namespace StarbucksDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(customer.NationalityId, customer.FirstName, customer.LastName, customer.DateOfBirth.Year).Result;
            return result.Body.TCKimlikNoDogrulaResult;

        }
    }
}
